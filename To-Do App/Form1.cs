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
            foreach (Project p in file.All_Projects)
            {
                foreach (Event ev in p.All_Events)
                {
                    if (ev.Title == n)
                    {
                        edit_event = ev;
                    }
                }
            }
            foreach (Event ev in file.Loose_Events)
            {
                if (ev.Title == n)
                {
                    edit_event = ev;
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
        private void btn_Add_Project_Click(object sender, EventArgs e)
        {
            Show_Add_Project(mnc_Date.SelectionRange.Start);
        }

        private void btn_Edit_Project_Click(object sender, EventArgs e)
        {
            if (trv_Daily_Events.Nodes.Count == 0)
            {
                return;
            }
            string n = trv_Daily_Events.SelectedNode.Tag.ToString();
            Project edit_project = null;
            foreach (Project p in file.All_Projects)
            {
                if (p.Title == n)
                {
                    edit_project = p;
                }
            }
            
            if (edit_project != null)
            {
                Show_Add_Project(edit_project);
            }
            else
            {
                Show_Add_Project(mnc_Date.SelectionRange.Start);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lsv_Due_Dates.Items.Clear();
            trv_Daily_Events.Nodes.Clear();
            Write_Tree(trv_Daily_Events);
            Write_List(lsv_Due_Dates);
        }

        public void Write_List(ListView List_View)
        {
            
            foreach (Project p in file.All_Projects)
            {
                foreach (Event ev in p.All_Events)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = ev.Title;
                    item.Name = "lsi_" + ev.Title;
                    if(ev.Due_Date == true)
                        item.SubItems.Add(ev.Completed.ToString("MM/dd/yyyy - hh:00 tt"));
                    List_View.Items.Add(item);
                }
            }

            foreach (Event ev in file.Loose_Events)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ev.Title;
                item.Name = "lsi_" + ev.Title;
                if (ev.Due_Date == true)
                    item.SubItems.Add(ev.Completed.ToString("MM/dd/yyyy - hh:00 tt"));
                List_View.Items.Add(item);
            }
        }

        private void lsv_Due_Dates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected override void Open_File()
        {
            base.Open_File();
            Write_List(lsv_Due_Dates);
            // treeview is stupid :(
            this.Visible = false;
            this.Visible = true;
        }   

    }
}
