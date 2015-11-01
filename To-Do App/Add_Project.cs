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
        public Add_Project(DateTime day)
        {
            InitializeComponent();
            dtp_Day.Value = day;
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
    }
}
