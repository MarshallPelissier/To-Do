using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace To_Do_App
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public void Show_Events()
        {
            Form e = Application.OpenForms["Events"];
            var new_Events = new Events();
            if (e == null)
            {
                new_Events.Show();
            }
            else
            {
                e.Activate();
            }
        }

        public void Show_Add_Event(DateTime day, string par = "")
        {
            Form ae = Application.OpenForms["Add_Event"];
            var new_Add_Event = new Add_Event(day, par);
            if (ae == null)
            {
                new_Add_Event.Show();
            }
            else
            {
                ae.Activate();
            }
        }

        public void Show_Edit_Event(Event new_event)
        {
            Form ae = Application.OpenForms["Add_Event"];
            var new_Add_Event = new Add_Event(new_event);
            if (ae == null)
            {
                new_Add_Event.Show();
            }
            else
            {
                ae.Activate();
            }
        }

        public void Find_Tree_Event(TreeView Tree_View,MonthCalendar Month_Calendar = null)
        {
            if (Tree_View.Nodes.Count == 0)
            {
                return;
            }
            if (Tree_View.SelectedNode == null)
            {
                return;
            }
            string n = Tree_View.SelectedNode.Text;
            Event edit_event = null;
            foreach (Event ev in file.All_Events)
            {
                edit_event = Find_Event(ev, n);
                if (edit_event != null)
                {
                    break;
                }
            }

            if (edit_event != null)
            {
                Show_Edit_Event(edit_event);
            }
            else if (Month_Calendar != null)
            {
                Show_Add_Event(Month_Calendar.SelectionRange.Start);
            }
            else
            {
                Show_Add_Event(DateTime.Today);
            }
        }

        public Event Find_Selected_List_Event(ListView List_View)
        {
            Event re;
            foreach (Event list_event in file.All_Events)
            {
                if (list_event.Title == List_View.SelectedItems[0].Text)
                {
                    return (list_event);
                }
                re = Find_Child_Event(list_event, List_View.SelectedItems[0].Text);
                if (re != null)
                {
                    return (re);
                }
            }
            return (null);
        }

        public Event Find_Child_Event(Event parent_event,string Child_Name)
        {
            foreach (Event child_event in parent_event.Child_Events)
            {
                if (child_event.Title == Child_Name)
                {
                    return (child_event);
                }
            }
            return (null);
        }

        public Event Find_Event(Event some_event, string name)
        {
            if (some_event.Title == name)
            {
                return (some_event);
            }
            else
            {
                foreach (Event eve in some_event.Child_Events)
                {
                    Event temp = Find_Event(eve, name);
                    if (temp != null)
                    {
                        return temp;
                    }
                }
            }
            return (null);
        }

        private void newEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Add_Event(DateTime.Today);
        }

        private void eventListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Events();
        }        

        public void Save_Event(Event new_event)
        {
            if (new_event.Parent_Event == null)
            {
                file.All_Events.Add(new_event);
            }
            else
            {
                new_event.Parent_Event.Child_Events.Add(new_event);
                int i = 0;
                float j = 0;
                foreach (Event e in new_event.Parent_Event.Child_Events)
                {
                    j += e.Completion;
                    i++;
                }
                new_event.Parent_Event.Completion_Children = (j / i);
            }
        }
        
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        static public To_Do_File file = new To_Do_File();
        //static public Event file = new Event();
        static public string SaveFile = "";
        static public bool change = false;

        public void data_changed()
        {
            change = true;
        }

        protected virtual void Open_File() 
        {           
            ofd.Filter = "TDF|*.tdf";
            ofd.Title = "Select File to Open";
            string De_Serial;

            var _jsonSettings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                ObjectCreationHandling = ObjectCreationHandling.Auto
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader input = new System.IO.StreamReader(ofd.FileName);
                De_Serial = input.ReadToEnd();          
                input.Close();
                file = JsonConvert.DeserializeObject<To_Do_File>(De_Serial, _jsonSettings);
                SaveFile = ofd.FileName;

            }
        }

        protected virtual void Save_File()
        {            
            var _jsonSettings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                ObjectCreationHandling = ObjectCreationHandling.Auto
            };

            if (SaveFile != "")
            {
                string Serial;
                Serial = JsonConvert.SerializeObject(file, Formatting.Indented, _jsonSettings);
                System.IO.StreamWriter output = new System.IO.StreamWriter(SaveFile);
                output.Write(Serial);
                output.Close();
            }
            else
            {
                Save_As_File();
            }
        }

        protected virtual void Save_As_File()
        {
            sfd.Filter = "TDF|*.tdf";
            sfd.Title = "Select Location to Save";
            string Serial;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Serial = JsonConvert.SerializeObject(file, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
                System.IO.StreamWriter output = new System.IO.StreamWriter(sfd.FileName);
                output.Write(Serial);
                output.Close();
                SaveFile = sfd.FileName;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_File();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save_File();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save_As_File();
        }

        public void Move_Event(Event ev, bool Up)
        {
            List<Event> current_list;
            int index;
            if (ev.Parent_Event != null)
            {
                current_list = ev.Parent_Event.Child_Events;
            }
            else
            {
                current_list = file.All_Events;
            }
            index = current_list.IndexOf(ev);
            int len = current_list.Count();
            if (Up && index != 0)
            {
                Event old = current_list[index - 1];
                current_list[index - 1] = current_list[index];
                current_list[index] = old;
            }
            else if (!Up && index < len-1)
            {
                Event old = current_list[index + 1];
                current_list[index + 1] = current_list[index];
                current_list[index] = old;
            }
        }

        public void Write_List(ListView List_View, Event selected_event = null)
        {
            if (selected_event == null)
            {
                foreach (Event e in file.All_Events)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = e.Title;
                    item.Name = "lsi_" + e.Title;
                    if (e.Due_Date == true)
                        item.SubItems.Add(e.Completed.ToString("MM/dd/yyyy - hh:00 tt"));
                    List_View.Items.Add(item);

                }
            }
            else
            {
                foreach (Event ev in selected_event.Child_Events)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = ev.Title;
                    item.Name = "lsi_" + ev.Title;
                    if (ev.Due_Date == true)
                        item.SubItems.Add(ev.Completed.ToString("MM/dd/yyyy - hh:00 tt"));
                    List_View.Items.Add(item);
                }
            }
        }

        public void Write_Tree(TreeView Tree_View, DateTime Date)
        {

            foreach (Event e in file.All_Events)
            {
                if (Date > e.Completed && e.Done)
                {

                }
                else
                {
                    TreeNode nod = new TreeNode();
                    if (e.Done == true)
                    {
                        nod.BackColor = Color.LightGray;
                    }
                    else if (e.Due_Date)
                    {
                        nod.BackColor = Color.LightCoral;
                    }
                    else if (e.Completion != 0)
                    {
                        nod.BackColor = Color.LightBlue;
                    }
                    else
                    {
                        nod.BackColor = Color.LightGreen;
                    }

                    nod.Tag = nod.BackColor;
                    nod.Text = e.Title;
                    nod.Name = "trn_" + e.Title;
                    Tree_View.Nodes.Add(nod);
                    Tree_View.SelectedNode = nod;
                    Write_Node(Tree_View, e, Date);
                }
            }
            Tree_View.ExpandAll();
            Tree_View.Refresh();
            Tree_View.SelectedNode = null;
        }

        public void Write_Node(TreeView Tree_View, Event write_event, DateTime Dat)
        {
            foreach (Event ev in write_event.Child_Events)
            {

                TreeNode node = new TreeNode();
                if (ev.Done == true)
                {
                    node.BackColor = Color.LightGray;
                }
                else if (ev.Due_Date)
                {
                    node.BackColor = Color.LightCoral;
                }
                else if (ev.Completion != 0)
                {
                    node.BackColor = Color.LightBlue;
                }
                else
                {
                    node.BackColor = Color.LightGreen;
                }

                node.Text = ev.Title;
                node.Tag = node.BackColor;
                node.Name = "trn_" + ev.Title;

                if (Dat > ev.Completed && ev.Done)
                {
                }
                else
                {
                    Tree_View.SelectedNode.Nodes.Add(node);
                    if (ev.Child_Events.Count != 0)
                    {
                        Tree_View.SelectedNode = node;
                    }
                    else
                    {

                    }
                }
                Write_Node(Tree_View, ev, Dat);
                if (ev.Child_Events.Count != 0)
                    Tree_View.SelectedNode = Tree_View.SelectedNode.Parent;
            }
        }
    }
}
