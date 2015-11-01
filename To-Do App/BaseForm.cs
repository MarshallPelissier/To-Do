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
        private void newEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Add_Event();
        }

        private void eventListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Events();
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Add_Project();
        }

        private void projectListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Projects();
        }
    }
}
