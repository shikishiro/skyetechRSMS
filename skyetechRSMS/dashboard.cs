using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skyetechRSMS
{
    public partial class dashboard : Form
    {
        formemergency emergency = new formemergency();
        dashboardreports dashreport = new dashboardreports();
        formemergencyreports emerreport = new formemergencyreports();
        formptvrequest ptvreq = new formptvrequest();
        public dashboard()
        {
            InitializeComponent();
            timer_timeanddate.Start();
            dashreport.TopLevel = false;
            panel_mainpanel.Controls.Add(dashreport);
            dashreport.BringToFront();
            dashreport.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            //emerreport.Hide();
            //emergency.Hide();
            dashreport.TopLevel = false;
            panel_mainpanel.Controls.Add(dashreport);
            dashreport.BringToFront();
            dashreport.Show();
        }


        private void btn_emergency_Click(object sender, EventArgs e)
        {
            emergency.TopLevel = false;
            panel_mainpanel.Controls.Add(emergency);
            emergency.BringToFront();
            emergency.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using RDMS, System Logging out.", "Skyetech: RDMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new login().Show();
            this.Close();
        }

        private void timer_timeanddate_Tick(object sender, EventArgs e)
        {
            lbl_datetime.Text = DateTime.Now.ToString("ddd - MM/dd/yyyy HH:mm:ss");
        }

        private void btn_dispatchreport_Click(object sender, EventArgs e)
        {
            emerreport.TopLevel = false;
            panel_mainpanel.Controls.Add(emerreport);
            emerreport.BringToFront();
            emerreport.Show();
        }

        private void btn_ptvrequest_Click(object sender, EventArgs e)
        {
            ptvreq.TopLevel = false;
            panel_mainpanel.Controls.Add(ptvreq);
            ptvreq.BringToFront();
            ptvreq.Show();
        }
    }
}
