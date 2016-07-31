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
    public partial class Events : BaseForm
    {
        public Events()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            CustomFormat();
        }

        private void CustomFormat()
        {
            //dtp_Day.Format = DateTimePickerFormat.Custom;
            //dtp_Day.CustomFormat = "MM/dd/yyyy - hh:00 tt";
            //dtp_Due_Date.Format = DateTimePickerFormat.Custom;
            //dtp_Due_Date.CustomFormat = "MM/dd/yyyy - hh:00 tt";

        }

        private void btn_Add_Event_Click(object sender, EventArgs e)
        {
            Show_Add_Event(DateTime.Today);
        }       

        private void btn_Edit_Event_Click(object sender, EventArgs e)
        {
            Show_Edit_Event(Find_Selected_List_Event(lsv_Events));
        }
    }
}
