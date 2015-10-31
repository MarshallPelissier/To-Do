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
            txt_Date.Text = mnc_Date.TodayDate.ToString("MM/dd/yyyy");
        }
        
        private void CustomFormat()
        {
        //dtp_Day.Format = DateTimePickerFormat.Custom;
        //dtp_Day.CustomFormat = "MM/dd/yyyy";
        //dtp_Due_Date.Format = DateTimePickerFormat.Custom;
        //dtp_Due_Date.CustomFormat = "MM/dd/yyyy - hh:00 tt";

        }
        private void btn_Add_Node_Click(object sender, EventArgs e)
        {
            trv_Daily_Events.Nodes.Add("project1");
            trv_Daily_Events.Nodes.Add("project2");
            trv_Daily_Events.Nodes[0].Nodes.Add("sub");
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_Date.Text = mnc_Date.SelectionRange.Start.ToString("MM/dd/yyyy");
            //dtp_Day.Value = mnc_Date.SelectionRange.Start;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newEvents = new Events();
            newEvents.Show();

        }

        private void newEventToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Show_Add_Event();
        }

        private void btn_Add_Event_Click(object sender, EventArgs e)
        {
            Show_Add_Event();
        }

        private void eventListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Events();
        }

        private void Show_Events()
        {
            Form e = Application.OpenForms["Events"];
            if (e == null)
            {
                var newEvents = new Events();
                newEvents.Show();
            }
        }

        private void Show_Add_Event()
        {
            Form ae = Application.OpenForms["Add_Event"];
            if (ae == null)
            {
                var newEvent = new Add_Event();
                newEvent.Show();
            }
        }

    }
}
