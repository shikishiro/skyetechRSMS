using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace skyetechRSMS
{
    public partial class formptvrequest : Form
    {
        //Test Database
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\rdmsdata.accdb");

        //Main Database
        //OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\rdmsdata.accdb");

        //String Declaration
        string contactperson = "63";
        string referrerno = "63";
        public formptvrequest()
        {
            InitializeComponent();
            input_otherdetail.TextChanged += new EventHandler(input_otherdetail_TextChanged);
            input_remarks.TextChanged += new EventHandler(input_remarks_TextChanged);
        }

        private void input_otherdetail_TextChanged(object sender, EventArgs e)
        {
            lbl_charcount.Text = "Characters Remaining: " + (5000 - input_otherdetail.Text.Length);
        }

        private void input_remarks_TextChanged(object sender, EventArgs e)
        {
            lbl_charcount_remarks.Text = "Character Remaining: " + (1000 - input_remarks.Text.Length);
        }

        public void dateformat()
        {
            calendar_date.Format = DateTimePickerFormat.Custom;
            calendar_date.CustomFormat = "MM/dd/yyyy";
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //Check for any not filled forms
            DateTime dt = calendar_date.Value;

            if (string.IsNullOrWhiteSpace(input_patientcase.Text) ||
                (string.IsNullOrWhiteSpace(input_patientname.Text) ||
                (string.IsNullOrWhiteSpace(input_patientage.Text) ||
                (string.IsNullOrWhiteSpace(input_contactperson.Text) ||
                (string.IsNullOrWhiteSpace(input_relation.Text) ||
                (string.IsNullOrWhiteSpace(input_contactno.Text) ||
                (string.IsNullOrWhiteSpace(input_origin.Text) ||
                (string.IsNullOrWhiteSpace(input_destination.Text) ||
                (string.IsNullOrWhiteSpace(drop_driver.Text) ||
                (string.IsNullOrWhiteSpace(input_referrer.Text) ||
                (string.IsNullOrWhiteSpace(input_referrercontact.Text) ||
                (string.IsNullOrWhiteSpace(input_otherdetail.Text) ||
                (string.IsNullOrWhiteSpace(drop_dispatcher.Text))))))))))))))
            {
                MessageBox.Show("Fields cannot be empty.", "Skyetech: RDMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                //establish connection
                conn.Close();
                conn.Open();

                //string query

                string strcmd = "INSERT INTO tbl_ptv ([Date Documented], [Patient Case], [Patient Name], [Patient Age], [Origin], [Destination], [Contact Person], [Relation to Patient], [Contact Number], [Referred by], [Referrer Contact], [Assigned Transport], [Other Details], [Remarks], [Dispatched By]) VALUES" +
                    " (#" +dt.ToString("MM/dd/yyyy")+ "#, '" +input_patientcase.Text+ "', '" +input_patientname.Text+ "', '" +input_patientage.Text+ "', '" +input_origin.Text+ "', '" +input_destination.Text+ "', '" +input_contactperson.Text+ "', '" +input_relation.Text+ "', '" +contactperson+input_contactno.Text+ "', '"+input_referrer.Text+"', '"+referrerno+input_referrercontact.Text+"', '" +drop_driver.Text+ "', '" +input_otherdetail.Text+ "', '" +input_remarks.Text+ "', '"+drop_dispatcher.Text+"')";

                OleDbCommand cmd = new OleDbCommand(strcmd, conn);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Patient Transfer Request Recorded", "Skyetech: RDMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }
    }
}
