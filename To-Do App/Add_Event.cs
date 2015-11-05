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

        public Add_Event(DateTime day)
        {
            InitializeComponent();
            dtp_Day.Value = day;
            dtp_Complete_Date.Value = day;
            Day = day;
            Write_List(lsv_Projects);
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
            Write_List(lsv_Projects);
            edit_event = new_event;
            if (new_event.Assigned_Project != null)
            {
                foreach (ListViewItem p in lsv_Projects.Items)
                {
                    if (p.Text == new_event.Assigned_Project.Title)
                    {
                        lsv_Projects.Items[p.Index].Focused = true;
                        lsv_Projects.Items[p.Index].Selected = true;
                    }
                }
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
            //dtp_Due_Date.Format = DateTimePickerFormat.Custom;
            //dtp_Due_Date.CustomFormat = "MM/dd/yyyy - hh:00 tt";

        }

        private void txt_Deadline_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtp_Day_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Show_Add_Project(DateTime.Today);
        }

        private void btn_Save_Event_Click(object sender, EventArgs e)
        {
            if (txt_Title.Text == "")
            {
                MessageBox.Show("Event Title is blank","Title ERROR");
                return;
            }
            Project project = null;
            string pname;
            if (lsv_Projects.SelectedItems.Count != 0 && chk_Project.Checked)
            {
                pname = lsv_Projects.SelectedItems[0].Text;
                foreach (Project p in file.All_Projects)
                {
                    if (p.Title == pname)
                    {
                        project = p;
                    }
                }
            }
            Event edit_event;
            bool duplicate = false;
            foreach (Project p in file.All_Projects)
            {
                if (p.Title == txt_Title.Text)
                {
                    duplicate = true;
                    MessageBox.Show("Event Title has same name as a Project", "Title ERROR");
                    return;
                }
                foreach (Event ev in p.All_Events)
                {
                    if (ev.Title == txt_Title.Text)
                    {
                        edit_event = ev;
                        duplicate = true;
                    }
                }
            }
            foreach (Event ev in file.Loose_Events)
            {
                if (ev.Title == txt_Title.Text)
                {
                    edit_event = ev;
                    duplicate = true;
                }
            }

            if (duplicate)
            {
                DialogResult dr = MessageBox.Show("Overwrite Event?", "Event Title is not unique", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    edit_event = new Event(done, due_date, Day, dtp_Complete_Date.Value, dtp_Day.Value, txt_Title.Text, rtb_Description.Text, Completion, project);
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else
            {
                Event ev = new Event(done, due_date, Day, dtp_Complete_Date.Value, dtp_Day.Value, txt_Title.Text, rtb_Description.Text, Completion, project);
                Save_Event(ev);
                this.Close();
            }
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
                        if (edit_event.Assigned_Project != null)
                        {
                            edit_event.Assigned_Project.All_Events.Remove(edit_event);
                        }
                        else
                        {
                            file.Loose_Events.Remove(edit_event);
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
        bool due_date;
        bool done = false;
        Event edit_event;

        private void lsv_Projects_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lsv_Projects.SelectedItems.Count != 0)
            {
                txt_Project.Text = lsv_Projects.SelectedItems[0].Text;
            }
        }

        
    }
}
