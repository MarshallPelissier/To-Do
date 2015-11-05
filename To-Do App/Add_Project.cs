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
    public partial class Add_Project : BaseForm
    {
        public Add_Project()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public Add_Project(Project new_project)
        {
            InitializeComponent();
            done = new_project.Done;
            due_date = new_project.Due_Date;
            Day = new_project.Created;
            dtp_Complete_Date.Value = new_project.Completed;
            dtp_Day.Value = new_project.Due;
            txt_Title_Value.Text = new_project.Title;
            rtb_Description.Text = new_project.Description;
            Write_List(lsv_Events);
            edit_project = new_project;
            float c = 0;
            int i = 0;
            foreach (Event eve in edit_project.All_Events)
            {
                c += eve.Completion;
                i++;
            }
            txt_Completion_Value.Text = (c / i).ToString();
        }

        public Add_Project(DateTime day, Project project = null)
        {
            InitializeComponent();
            dtp_Day.Value = day;
            dtp_Complete_Date.Value = day;
            Write_List(lsv_Events);
        }

        private void Add_Project_Load(object sender, EventArgs e)
        {

        }

        private void chk_done_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_done.Checked)
            {
                dtp_Complete_Date.Enabled = true;
                done = true;
            }
            else
            {
                dtp_Complete_Date.Enabled = false;
                done = false;
            }
        }
        private void chk_Deadline_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Deadline.Checked)
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
        private void btn_Add_Event_Click(object sender, EventArgs e)
        {
            Show_Add_Event(DateTime.Today);
        }

        public void Write_List(ListView List_View)
        {
            if (edit_project != null)
            {
                foreach (Event ev in edit_project.All_Events)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = ev.Title;
                    item.Name = "lsi_" + ev.Title;
                    item.SubItems.Add(ev.Completed.ToString());
                    List_View.Items.Add(item);
                }
            }
        }

        private void btn_Save_Project_Click(object sender, EventArgs e)
        {
            if (txt_Title_Value.Text == "")
            {
                MessageBox.Show("Project Title is blank", "Title ERROR");
                return;
            }
            bool duplicate = false;
            foreach (Project p in file.All_Projects)
            {
                if (p.Title == txt_Title_Value.Text)
                {
                    DialogResult dr = MessageBox.Show("Overwrite Event?", "Event Title is not unique", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        edit_project = new Project(done, due_date, Day, dtp_Complete_Date.Value, dtp_Day.Value, txt_Title_Value.Text, rtb_Description.Text);
                        this.Close();
                    }
                    else
                    {
                        return;
                    }
                }
                foreach (Event ev in p.All_Events)
                {
                    if (ev.Title == txt_Title_Value.Text)
                    {
                        duplicate = true;
                    }
                }
            }
            foreach (Event ev in file.Loose_Events)
            {
                if (ev.Title == txt_Title_Value.Text)
                {
                    duplicate = true;
                }
            }

            if (duplicate)
            {

                MessageBox.Show("Project Title has same name as a Event", "Title ERROR");
                return;
            }
            else
            {
                Project p = new Project(done, due_date, Day, dtp_Complete_Date.Value, dtp_Day.Value, txt_Title_Value.Text, rtb_Description.Text);
                Save_Project(p);
                this.Close();
            }
        }
        
        private void btn_Delete_Project_Click(object sender, EventArgs e)
        {
            if (edit_project != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this Project?", "Delete Project?", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    file.All_Projects.Remove(edit_project);
                    this.Close();
                }
                else
                {
                    return;
                }
            }
        }   
        DateTime Day = DateTime.Today;
        bool done = false;
        bool due_date = false;
        Project edit_project = null;

          
    }
}
