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

        public void Show_Add_Event(DateTime day)
        {
            Form ae = Application.OpenForms["Add_Event"];
            var new_Add_Event = new Add_Event(day);
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
        public void Show_Projects()
        {
            Form p = Application.OpenForms["Projects"];
            var new_Projects = new Projects();
            if (p == null)
            {
                new_Projects.Show();
            }
            else
            {
                p.Activate();
            }

        }

        public void Show_Add_Project(DateTime day)
        {
            Form ap = Application.OpenForms["Add_Project"];
            var new_Add_Project = new Add_Project(day);
            if (ap == null)
            {
                new_Add_Project.Show();
            }
            else
            {
                ap.Activate();
            }
        }

        public void Show_Add_Project(Project new_project)
        {
            Form ap = Application.OpenForms["Add_Project"];
            var new_Add_Project = new Add_Project(new_project);
            if (ap == null)
            {
                new_Add_Project.Show();
            }
            else
            {
                ap.Activate();
            }
        }

        private void newEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Add_Event(DateTime.Today);
        }

        private void eventListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Events();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Add_Project(DateTime.Today);
        }

        private void projectListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Projects();
        }

        public void Save_Event(Event new_event)
        {
            if (new_event.Assigned_Project == null)
            {
                file.Loose_Events.Add(new_event);
            }
            else
            {
                new_event.Assigned_Project.All_Events.Add(new_event);
                int i = 0;
                float j = 0;
                foreach (Event e in new_event.Assigned_Project.All_Events)
                {
                    j += e.Completion;
                    i++;
                }
                new_event.Assigned_Project.Completion = (j / i);
            }
        }

        public void Save_Project(Project new_project)
        {
            file.All_Projects.Add(new_project);
        }


        public void Write_Tree(TreeView Tree_View)
        {
            
            foreach (Project p in file.All_Projects)
            {
                TreeNode nod = new TreeNode();
                if (p.Done == true)
                {
                    nod.BackColor = Color.LightGray;
                }
                else if (p.Due_Date)
                {
                    nod.BackColor = Color.LightCoral;
                }
                else if (p.Completion != 0)
                {
                    nod.BackColor = Color.LightBlue;
                }
                else 
                { 
                    nod.BackColor = Color.LightGreen;
                }
                nod.Text = p.Title;
                nod.Name = "trn_" + p.Title;
                nod.Tag = p.Title;
                int j = nod.Text.Length/3 + 1;
                for (int i = 0; i < (j); i++)
                {
                    nod.Text += " ";
                }
                Tree_View.Nodes.Add(nod);
                Tree_View.SelectedNode = nod;
                Tree_View.SelectedNode.NodeFont = new Font(Tree_View.Font, FontStyle.Bold);
                foreach (Event e in p.All_Events)
                {                  
                    TreeNode node = new TreeNode();
                    if (e.Done == true)
                    {
                        node.BackColor = Color.LightGray;
                    }
                    else if (e.Due_Date)
                    {
                        node.BackColor = Color.LightCoral;
                    }
                    else if (e.Completion != 0)
                    {
                        node.BackColor = Color.LightBlue;
                    }
                    else
                    {
                        node.BackColor = Color.LightGreen;
                    }
                    node.Text = e.Title;
                    node.Tag = e.Title;
                    node.Name = "trn_" + e.Title;
                    Tree_View.SelectedNode.Nodes.Add(node);
                }
            }
            foreach (Event e in file.Loose_Events)
            {
                TreeNode node = new TreeNode();
                if (e.Done == true)
                {
                    node.BackColor = Color.LightGray;
                }
                else if (e.Due_Date)
                {
                    node.BackColor = Color.LightCoral;
                }
                else if (e.Completion != 0)
                {
                    node.BackColor = Color.LightBlue;
                }
                else
                {
                    node.BackColor = Color.LightGreen;
                }
                node.Text = e.Title;
                node.Tag = e.Title;
                node.Name = "trn_" + e.Title;
                Tree_View.Nodes.Add(node);
                Tree_View.SelectedNode = node;
            }
            Tree_View.ExpandAll();
            
        }
        /*
        public void Write_List(ListView List_View, bool proj, Project project = null)
        {
            if (proj == true)
            {
                foreach (Project p in file.All_Projects)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = p.Title;
                    item.Name = "lsi_" + p.Title;
                    item.SubItems.Add(p.Completed.ToString());
                    List_View.Items.Add(item);
                }
            }
            else
            {
                if (project == null)
                {
                    foreach (Event ev in file.Loose_Events)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = ev.Title;
                        item.Name = "lsi_" + ev.Title;
                        item.SubItems.Add(ev.Completed.ToString());
                        List_View.Items.Add(item);
                    }
                }
                else
                {
                    foreach (Event ev in project.All_Events)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = ev.Title;
                        item.Name = "lsi_" + ev.Title;
                        item.SubItems.Add(ev.Completed.ToString());
                        List_View.Items.Add(item);
                    }
                }
            }
        }
        */
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        static public To_Do_File file = new To_Do_File();

        protected virtual void Open_File() 
        {
            ofd.Filter = "TDF|*.tdf";
            ofd.Title = "Select File to Open";
            string De_Serial = JsonConvert.SerializeObject(file);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader input = new System.IO.StreamReader(ofd.FileName);
                De_Serial = input.ReadToEnd();
                input.Close();
                file = JsonConvert.DeserializeObject<To_Do_File>(De_Serial);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_File();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.Filter = "TDF|*.tdf";
            sfd.Title = "Select Location to Save";
            string Serial;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Serial = JsonConvert.SerializeObject(file, Formatting.Indented,new JsonSerializerSettings{PreserveReferencesHandling = PreserveReferencesHandling.Objects});
                System.IO.StreamWriter output = new System.IO.StreamWriter(sfd.FileName);
                output.Write(Serial);
                output.Close();
            }
        }
    }
}
