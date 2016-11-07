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
            //CustomFormat();
            txt_Date.Text = mnc_Date.TodayDate.ToString("MM/dd/yyyy");
            Write_Tree(trv_Daily_Events, mnc_Date.SelectionRange.Start);
            Write_List(lsv_Due_Dates);
        }
        
        private void CustomFormat()
        {
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_Date.Text = mnc_Date.SelectionRange.Start.ToString("MM/dd/yyyy");
            this.Visible = false;
            this.Visible = true;
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
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lsv_Due_Dates.Items.Clear();
            trv_Daily_Events.Nodes.Clear();
            Write_Tree(trv_Daily_Events, mnc_Date.SelectionRange.Start);
            Write_List(lsv_Due_Dates);
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
            Highlight_Node(e.Node);
        }

        public void Highlight_Node(TreeNode nod, string color = "#3399FF")
        {
            //Use a recrusion to clear the previous selection 
            TreeNode current = trv_Daily_Events.Nodes[0];
            while (current != null)
            {
                if (current != nod)
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
            if (trv_Daily_Events.SelectedNode != null && trv_Daily_Events.SelectedNode == nod)
            {
                nod.BackColor = ColorTranslator.FromHtml(color);
                nod.ForeColor = Color.White;
            }
        }

        private void trv_Daily_Events_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }

        private void trv_Daily_Events_DoubleClick(object sender, EventArgs e)
        {
            trv_Daily_Events.SelectedNode = null;            
        }
        
        private void btn_Up_Click(object sender, EventArgs e)
        {
            Button_Click(true);
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            Button_Click(false);
        } 
        
        public void Button_Click(bool up)
        {
            string ename;
            Event selected_event = null;
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
                Move_Event(selected_event, up);
                trv_Daily_Events.Nodes.Clear();
                Write_Tree(trv_Daily_Events, mnc_Date.SelectionRange.Start);
                trv_Daily_Events.SelectedNode = trv_Daily_Events.Nodes.Find(nodeName, true)[0];
                Highlight_Node(trv_Daily_Events.Nodes.Find(nodeName, true)[0], "#28b3c9");
            }
        }
    }
}

