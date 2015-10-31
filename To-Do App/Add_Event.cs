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
    public partial class Add_Event : Form
    {
        public Add_Event()
        {
            InitializeComponent();
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
    }
}
