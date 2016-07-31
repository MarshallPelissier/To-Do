using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_App
{
    public partial class Add_Event : BaseForm
    {
        public Add_Event()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public Add_Event(DateTime day,string parent = "")
        {
            InitializeComponent();
            dtp_Day.Value = day;
            dtp_Complete_Date.Value = day;
            Day = day;
            Write_Tree(trv_All_Events);
            //need to write to treeview
            if (parent != "")
            {
                chk_Project.Checked = true;
                txt_Project.Text = parent;
            }
        }
        public Add_Event(Event new_event)
        {
            InitializeComponent();
            done = new_event.Done;
            due_date = new_event.Due_Date;
            Day = new_event.Created;
            dtp_Complete_Date.Value = new_event.Completed;
            dtp_Day.Value = new_event.Due;
            txt_Title.Text = new_event.Title;
            rtb_Description.Text = new_event.Description;
            edit_event = new_event;
            Parent_Event = new_event.Parent_Event;
            Write_Tree(trv_All_Events);
            editing = true;
            //need to write to treeview
            //and select parent event and check checkbox
            if (new_event.Parent_Event != null)
            {
                chk_Project.Checked = true;
                txt_Project.Text = new_event.Parent_Event.Title;
            }
            
        }

        private void rad_zero_CheckedChanged(object sender, EventArgs e)
        {
            done = false;
            dtp_Complete_Date.Enabled = false;
            Completion = 0;
        }
        private void rad_4th_CheckedChanged(object sender, EventArgs e)
        {

            done = false;
            dtp_Complete_Date.Enabled = false;
            Completion = 0.25f;
        }

        private void rad_half_CheckedChanged(object sender, EventArgs e)
        {

            done = false;
            dtp_Complete_Date.Enabled = false;
            Completion = 0.50f;
        }

        private void rad_3_4ths_CheckedChanged(object sender, EventArgs e)
        {

            done = false;
            dtp_Complete_Date.Enabled = false;
            Completion = 0.75f;
        }

        private void rad_done_CheckedChanged(object sender, EventArgs e)
        {

            done = true;
            dtp_Complete_Date.Enabled = true;
            Completion = 1;
        }
        
        private void Events_Load(object sender, EventArgs e)
        {
            CustomFormat();
        }

        private void CustomFormat()
        {
            dtp_Day.Format = DateTimePickerFormat.Custom;
            dtp_Day.CustomFormat = "MM/dd/yyyy - hh:00 tt";
        }     

        private void btn_Save_Event_Click(object sender, EventArgs e)
        {
            if (txt_Title.Text == "")
            {
                MessageBox.Show("Event Title is blank","Title ERROR");
                return;
            }
            Event parent_event = null;
            string pname;
            

            bool duplicate = false;

            if (editing)
            {
                duplicate = true;
            }
            else
            {
                foreach (Event test_event in file.All_Events)
                {
                    duplicate = Check_Duplicate(test_event, txt_Title.Text);
                    if (duplicate == true)
                    {
                        break;
                    }
                }
            }

            if (trv_All_Events.SelectedNode != null && chk_Project.Checked)
            {
                pname = txt_Project.Text;

                if (pname == txt_Title.Text)
                {
                    MessageBox.Show("Event has parent's name", "Title ERROR");
                    return;
                }

                foreach (Event eve in file.All_Events)
                {
                    parent_event = Find_Event(eve, pname);
                    if (parent_event != null)
                    {
                        break;
                    }
                }
            }

            if (duplicate)
            {
                DialogResult dr = MessageBox.Show("Overwrite Event?", "Event Title is not unique", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {                    
                    //edit_event = new Event(done, due_date, Day, dtp_Complete_Date.Value, dtp_Day.Value, txt_Title.Text, rtb_Description.Text, Completion, parent_event);
                    if (edit_event.Parent_Event != null)
                    {
                        edit_event.Parent_Event.Child_Events.Remove(edit_event);
                    }
                    else
                    {
                        file.All_Events.Remove(edit_event);
                    }
                    edit_event.Done = done;
                    edit_event.Due_Date = due_date;
                    edit_event.Created = Day;
                    edit_event.Completed = dtp_Complete_Date.Value;
                    edit_event.Due = dtp_Day.Value;
                    edit_event.Title = txt_Title.Text;
                    edit_event.Description = rtb_Description.Text;
                    edit_event.Completion = Completion;
                    if (edit_event == parent_event)
                    {
                        parent_event = null;
                    }
                    edit_event.Parent_Event = parent_event;
                    if (parent_event != null)
                    {
                        edit_event.Parent_Event.Child_Events.Add(edit_event);
                    }
                    else
                    {
                        file.All_Events.Add(edit_event);
                    }
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                Event ev = new Event(done, due_date, Day, dtp_Complete_Date.Value, dtp_Day.Value, txt_Title.Text, rtb_Description.Text, Completion, parent_event);
                Save_Event(ev);
                this.Close();
            }
            data_changed();
        }

        private bool Check_Duplicate(Event some_event, string name)
        {
            if (some_event.Title == name)
            {
                edit_event = some_event;
                return (true);
            }
            else
            {
                foreach (Event eve in some_event.Child_Events)
                {
                    if (Check_Duplicate(eve, name))
                    {
                        return (true);
                    }
                }
            }
            return (false);
        }

        private void btn_Del_Event_Click(object sender, EventArgs e)
        {
            if (edit_event != null)
            {
                if (edit_event != null)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this Event?", "Delete Event?", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        if (edit_event.Parent_Event != null)
                        {
                            edit_event.Parent_Event.Child_Events.Remove(edit_event);
                        }
                        else
                        {
                            file.All_Events.Remove(edit_event);
                        }
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void chk_Deadline_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Deadline.Checked == true)
            {
                dtp_Day.Enabled = true;
                due_date = true;
            }
            else
            {
                dtp_Day.Enabled = false;
                due_date = false;
            }
        }
       
        //private Project Selected_Project;
        private DateTime Day;
        float Completion;
        bool due_date;
        bool done = false;
        bool editing = false;
        Event edit_event;
        Event Parent_Event = null;

        

        public void Write_Tree(TreeView Tree_View)
        {

            foreach (Event e in file.All_Events)
            {
                if (Day > e.Completed && e.Done)
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
                    Write_Node(Tree_View, e);
                }
            }
            Tree_View.ExpandAll();
        }

        public void Write_Node(TreeView Tree_View, Event write_event)
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
                if (Day > ev.Completed && ev.Done)
                {
                }
                else
                {
                    Tree_View.SelectedNode.Nodes.Add(node);
                    if (ev.Child_Events.Count != 0)
                    {
                        Tree_View.SelectedNode = node;
                    }
                }
                Write_Node(Tree_View, ev);
            }
        }        

        private void trv_All_Events_DoubleClick(object sender, EventArgs e)
        {
            trv_All_Events.SelectedNode = null;
        }

        private void trv_All_Events_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            //Use a recrusion to clear the previos selection 
            TreeNode current = trv_All_Events.Nodes[0];
            while (current != null)
            {
                if (current != e.Node)
                {
                    current.BackColor = (Color)current.Tag;
                    current.ForeColor = trv_All_Events.ForeColor;
                }
                if (current.Nodes.Count > 0)
                    current = current.Nodes[0];
                else if (current.NextNode != null)
                    current = current.NextNode;
                else if (current.Parent != null)
                    current = current.Parent.NextNode;
                else
                    current = null;
            }
            //Set the back color of the selected node
            if (trv_All_Events.SelectedNode != null && trv_All_Events.SelectedNode == e.Node)
            {
                e.Node.BackColor = ColorTranslator.FromHtml("#3399FF");
                e.Node.ForeColor = Color.White;
            }
        }

        private void trv_All_Events_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(trv_All_Events.SelectedNode != null)
            {
                txt_Project.Text = trv_All_Events.SelectedNode.Text;
            }
            else
            {
                txt_Project.Text = "";
            }
        }
    }
}
