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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomFormat();
        }
        
        private void CustomFormat()
        {
        dtp_Day.Format = DateTimePickerFormat.Custom;
        dtp_Day.CustomFormat = "MM/dd/yyyy";
        //dtp_Due_Date.Format = DateTimePickerFormat.Custom;
        //dtp_Due_Date.CustomFormat = "MM/dd/yyyy - hh:00 tt";

        }
        private void btn_Add_Node_Click(object sender, EventArgs e)
        {
            trv_Daily_Events.Nodes.Add("project1");
            trv_Daily_Events.Nodes.Add("project2");
            trv_Daily_Events.Nodes[0].Nodes.Add("sub");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txt_Date.Text = dtp_Day.Value.ToString("MM/dd/yyyy");
            monthCalendar1.SetDate(dtp_Day.Value);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_Date.Text = monthCalendar1.SelectionRange.Start.ToString("MM/dd/yyyy");
            dtp_Day.Value = monthCalendar1.SelectionRange.Start;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
