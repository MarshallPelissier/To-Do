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
            Show_Add_Event(mnc_Date.SelectionRange.Start);
        }

        private void btn_Edit_Event_Click(object sender, EventArgs e)
        {
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
        }

        private Event Find_Event(Event some_event, string name)
        {
            if (some_event.Title == name)
            {
                return(some_event);
            }
            foreach (Event ev in some_event.Child_Events)
            {
                if(Find_Event(ev,name) != null)
                {
                    return(ev);
                }
            }
            return (null);
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
                node.Tag = ev.Title;
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
                }
                Write_Node(Tree_View, ev);
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
                    delete_event = Find_parent(eve, ename);
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
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this Event?", "Delete Event?", MessageBoxButtons.OKCancel);
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
        }

        private Event Find_parent(Event some_event, string name)
        {
            if (some_event.Title == name)
            {
                return (some_event);
            }
            else
            {
                foreach (Event eve in some_event.Child_Events)
                {
                    return (Find_parent(eve, name));
                }
            }
            return (null);
        }
    }
}

