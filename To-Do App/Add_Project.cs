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
        }
        public Add_Project(DateTime day, Project project = null)
        {
            InitializeComponent();
            dtp_Day.Value = day;
            dtp_Complete_Date.Value = day;
            Write_List(lsv_Events, project);
        }

        private void Add_Project_Load(object sender, EventArgs e)
        {

        }

        private void chk_done_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_done.Checked)
            {
                dtp_Complete_Date.Enabled = true;
            }
            else
            {
                dtp_Complete_Date.Enabled = false;
            }
        }

        private void btn_Add_Event_Click(object sender, EventArgs e)
        {
            Show_Add_Event(DateTime.Today,true);
        }

        public void Write_List(ListView List_View, Project project)
        {
            if (project != null)
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

        private void btn_Save_Project_Click(object sender, EventArgs e)
        {
            if (txt_Title.Text != "")
            {
                Project p = new Project(DateTime.Today, dtp_Complete_Date.Value, dtp_Day.Value ,txt_Title.Text, rtb_Description.Text, done, due_date);
                Save_Project(p);
            }

            this.Close();
        }
        bool done = false;
        bool due_date = false;
    }
}
