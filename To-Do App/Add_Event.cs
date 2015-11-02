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
        }

        public Add_Event(DateTime day,bool new_event)
        {
            InitializeComponent();
            dtp_Day.Value = day;
            dtp_Complete_Date.Value = day;
            Day = day;
            New_Event = new_event;
            Write_List(lsv_Projects);
        }

        private void rad_zero_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Events_Load(object sender, EventArgs e)
        {
            CustomFormat();
        }

        private void CustomFormat()
        {
            dtp_Day.Format = DateTimePickerFormat.Custom;
            dtp_Day.CustomFormat = "MM/dd/yyyy - hh:00 tt";
            //dtp_Due_Date.Format = DateTimePickerFormat.Custom;
            //dtp_Due_Date.CustomFormat = "MM/dd/yyyy - hh:00 tt";

        }

        private void txt_Deadline_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtp_Day_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnu_Main_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Show_Add_Project(DateTime.Today,true);
        }

        private void btn_Save_Event_Click(object sender, EventArgs e)
        {
            if (txt_Title.Text != "")
            {
                Project project = null;
                int pint;
                if (lsv_Projects.SelectedItems.Count != 0)
                {
                    pint = lsv_Projects.SelectedItems.IndexOf(lsv_Projects.SelectedItems[0]);
                    project = file.All_Projects[pint];
                }

                Event ev = new Event(Day, dtp_Complete_Date.Value, dtp_Day.Value, txt_Title.Text, rtb_Description.Text, Completion, project);
                Save_Event(ev);
            }

            this.Close();
        }

        private void chk_Deadline_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Deadline.Checked == true)
            {
                due_date = true;
            }
            else
            {
                due_date = false;
            }
        }

        public void Write_List(ListView List_View)
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
        //private Project Selected_Project;
        private DateTime Day;
        float Completion;
        bool New_Event = true;
        bool due_date;
        bool complete_date;
        
    }
}
