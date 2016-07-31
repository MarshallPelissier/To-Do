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
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomFormat();
            txt_Date.Text = mnc_Date.TodayDate.ToString("MM/dd/yyyy");
            Write_Tree(trv_Daily_Events);
            Write_List(lsv_Due_Dates);
        }
        
        private void CustomFormat()
        {
        //dtp_Day.Format = DateTimePickerFormat.Custom;
        //dtp_Day.CustomFormat = "MM/dd/yyyy";
        //dtp_Due_Date.Format = DateTimePickerFormat.Custom;
        //dtp_Due_Date.CustomFormat = "MM/dd/yyyy - hh:00 tt";

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_Date.Text = mnc_Date.SelectionRange.Start.ToString("MM/dd/yyyy");
            this.Visible = false;
            this.Visible = true;
            //dtp_Day.Value = mnc_Date.SelectionRange.Start;
        }

        private void btn_Add_Event_Click(object sender, EventArgs e)
        {
            if (trv_Daily_Events.SelectedNode != null)
            {
                Show_Add_Event(mnc_Date.SelectionRange.Start,trv_Daily_Events.SelectedNode.Text);
            }
            Show_Add_Event(mnc_Date.SelectionRange.Start);
        }

        private void btn_Edit_Event_Click(object sender, EventArgs e)
        {
            Find_Tree_Event(trv_Daily_Events, mnc_Date);
            /*
            if (trv_Daily_Events.Nodes.Count == 0)
            {
                return;
            }
            string n = trv_Daily_Events.SelectedNode.Text;
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
            else
            {               
                Show_Add_Event(mnc_Date.SelectionRange.Start);
            }  
        */
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lsv_Due_Dates.Items.Clear();
            trv_Daily_Events.Nodes.Clear();
            Write_Tree(trv_Daily_Events);
            Write_List(lsv_Due_Dates);
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

        private void lsv_Due_Dates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected override void Open_File()
        {
            base.Open_File();
            Write_List(lsv_Due_Dates);
            this.Visible = false;
            this.Visible = true;

            if (SaveFile != "")
            {
                Text = "To Do   -   " + SaveFile;
            }
            else
            {
                Text = "To Do";
            }
        }   

        public void Write_Tree(TreeView Tree_View)
        {

            foreach (Event e in file.All_Events)
            {
                if (mnc_Date.SelectionRange.Start >e.Completed && e.Done)
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
            Tree_View.Refresh();
            Tree_View.SelectedNode = null;
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
                node.Tag = node.BackColor;
                node.Text = ev.Title;
                node.Tag = node.BackColor;
                node.Name = "trn_" + ev.Title;
                
                if (mnc_Date.SelectionRange.Start > ev.Completed && ev.Done)
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
                Write_Node(Tree_View, ev);
                if (ev.Child_Events.Count != 0)
                    Tree_View.SelectedNode = Tree_View.SelectedNode.Parent;
            }
        }

        private void btn_Delete_Event_Click(object sender, EventArgs e)
        {
            string ename;
            Event delete_event = null;
            if (trv_Daily_Events.SelectedNode != null)
            {
                ename = trv_Daily_Events.SelectedNode.Text;
                foreach (Event eve in file.All_Events)
                {
                    delete_event = Find_Event(eve, ename);
                    if (delete_event != null)
                    {
                        break;
                    }
                }
            }

            if (delete_event != null)
            {
                if (delete_event != null)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete Event \""+trv_Daily_Events.SelectedNode.Text + "\"" , "Delete Event?", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        foreach(Event eve in file.All_Events)
                        {
                            eve.Child_Events.Remove(delete_event);
                        }
                        file.All_Events.Remove(delete_event);
                        this.Visible = false;
                        this.Visible = true;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            data_changed();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (change == true)
            {
                Closing_Dialog(e);
            }
        }

        private void Closing_Dialog(FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Save changes?", "To Do", MessageBoxButtons.YesNoCancel);

            if (dlg == DialogResult.Yes)
            {
                Save_File();
                if (SaveFile == "")
                {
                    Closing_Dialog(e);
                }
                e.Cancel = false;
            }
            if (dlg == DialogResult.No)
            {
                e.Cancel = false;
            }

            if (dlg == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }        

        private void trv_Daily_Events_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            //Use a recrusion to clear the previos selection 
            TreeNode current = trv_Daily_Events.Nodes[0];
            while (current != null)
            {
                if (current != e.Node)
                {
                    current.BackColor = (Color)current.Tag;
                    current.ForeColor = trv_Daily_Events.ForeColor;
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
            if (trv_Daily_Events.SelectedNode != null && trv_Daily_Events.SelectedNode == e.Node)
            {
                e.Node.BackColor = ColorTranslator.FromHtml("#3399FF");
                e.Node.ForeColor = Color.White;
            }
            //cancle the selecting 
            //e.Cancel = true;
            //trv_Daily_Events.SelectedNode = e.Node;
            if (trv_Daily_Events.SelectedNode != null)
            {
                txt_selected.Text = trv_Daily_Events.SelectedNode.Text;
            }
            else
            {
                txt_selected.Text = "No Event Selected";
            }
        }

        private void trv_Daily_Events_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }

        private void trv_Daily_Events_DoubleClick(object sender, EventArgs e)
        {
            trv_Daily_Events.SelectedNode = null;
            if (trv_Daily_Events.SelectedNode != null)
            {
                txt_selected.Text = trv_Daily_Events.SelectedNode.Text;
            }
            else
            {
                txt_selected.Text = "No Event Selected";
            }
        }
        
        private void btn_Up_Click(object sender, EventArgs e)
        {
            string ename;
            Event selected_event= null;
            if (trv_Daily_Events.SelectedNode != null)
            {
                string nodeName = trv_Daily_Events.SelectedNode.Name;
                ename = trv_Daily_Events.SelectedNode.Text;
                foreach (Event eve in file.All_Events)
                {
                    selected_event = Find_Event(eve, ename);
                    if (selected_event != null)
                    {
                        break;
                    }
                }
                Move_Event(selected_event, true);
                trv_Daily_Events.Nodes.Clear();
                Write_Tree(trv_Daily_Events);
                trv_Daily_Events.SelectedNode = trv_Daily_Events.Nodes.Find(nodeName, true)[0];
                trv_Daily_Events.SelectedNode.BackColor = ColorTranslator.FromHtml("#3399FF");
                trv_Daily_Events.SelectedNode.ForeColor = Color.White;
            }
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            string ename;
            Event selected_event = null;
            if (trv_Daily_Events.SelectedNode != null)
            {
                string nodeName = trv_Daily_Events.SelectedNode.Name;
                TreeNode temp = trv_Daily_Events.SelectedNode;
                ename = trv_Daily_Events.SelectedNode.Text;
                foreach (Event eve in file.All_Events)
                {
                    selected_event = Find_Event(eve, ename);
                    if (selected_event != null)
                    {
                        break;
                    }
                }
                Move_Event(selected_event, false);
                trv_Daily_Events.Nodes.Clear();
                Write_Tree(trv_Daily_Events);
                trv_Daily_Events.SelectedNode = trv_Daily_Events.Nodes.Find(nodeName, true)[0];
                trv_Daily_Events.SelectedNode.BackColor = ColorTranslator.FromHtml("#3399FF");
                trv_Daily_Events.SelectedNode.ForeColor = Color.White;
            }
        }

        private void trv_Daily_Events_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (trv_Daily_Events.SelectedNode != null)
            {
                txt_selected.Text = trv_Daily_Events.SelectedNode.Text;
            }
            else
            {
                txt_selected.Text = "No Event Selected";
            }
        }
        

    }
}

