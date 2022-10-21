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
    public partial class formemergency : Form
    {
        //Test Database
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\rdmsdata.accdb");

        //Main Database
        //OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\rdmsdata.accdb");

        //String Declaration
        string va; //Vehicular Accidet
        string rp; //Responding Group
        string collision; //Collission yes or no

        public formemergency()
        {
            InitializeComponent();
            //Character Remaining Initialization
            input_otherdetail.TextChanged += new EventHandler(input_otherdetail_TextChanged);
            input_remarks.TextChanged += new EventHandler(input_remarks_TextChanged);
        }

        public void dateformat()
        {
            calendar_dateofincident.Format = DateTimePickerFormat.Custom;
            calendar_dateofincident.CustomFormat = "MM/dd/yyyy";
        }

        private void input_timeofincident_Enter(object sender, EventArgs e)
        {
            if (input_timeofincident.Text == "Use 24Hour Format: 0600-0700H")
            {
                input_timeofincident.Text = "";
                input_timeofincident.ForeColor = Color.Black;
            }
        }

        private void input_timeofincident_Leave(object sender, EventArgs e)
        {
            if (input_timeofincident.Text == "")
            {
                input_timeofincident.Text = "Use 24Hour Format: 0600-0700H";
                input_timeofincident.ForeColor = Color.Gray;
            }
        }

        private void formemergency_Load(object sender, EventArgs e)
        {
            input_timeofincident.Text = "Use 24Hour Format: 0600-0700H";
            input_timeofincident.ForeColor = Color.Gray;
        }

        private void input_otherdetail_TextChanged(object sender, EventArgs e)
        {
            lbl_charcount.Text = "Characters Remaining: " + (5000 - input_otherdetail.Text.Length);
        }

        private void radio_va_yes_CheckedChanged(object sender, EventArgs e)
        {
            grp_vehicularaccident.Visible = true;
        }

        private void radio_va_no_CheckedChanged(object sender, EventArgs e)
        {
            grp_vehicularaccident.Visible = false;
        }

        private void input_remarks_TextChanged(object sender, EventArgs e)
        {
            lbl_charcount_remarks.Text = "Characters Remaining: " + (1000 - input_remarks.Text.Length);
        }

        public void collisionyesno()
        {
            if (radio_va_yes.Checked == true)
            {
                collision = "Yes";
            }
            else if (radio_va_no.Checked == true)
            {
                collision = "No";
            }
        }

        public void vehicleinvolvedconditionalbranches()
        {
            if (checkbox_car.Checked)
            {
                va = checkbox_car.Text;
            }
            if (checkbox_van.Checked)
            {
                va += " " + checkbox_van.Text;
            }
            if (checkbox_bus.Checked)
            {
                va += " " + checkbox_bus.Text;
            }
            if (checkbox_motorcycle.Checked)
            {
                va += " " + checkbox_motorcycle.Text;
            }
            if (checkbox_tricycle.Checked)
            {
                va += " " + checkbox_tricycle.Text;
            }
            if (checkbox_bicycle.Checked)
            {
                va += " " + checkbox_bicycle.Text;
            }

        }

        public void repondersconditionalbranches()
        {
            if (checkbox_mdrrmo.Checked)
            {
                rp = checkbox_mdrrmo.Text;
            }
            if (checkbox_mdrrmovolunteer.Checked)
            {
                rp += " " + checkbox_mdrrmovolunteer.Text;
            }
            if (checkbox_bfp.Checked)
            {
                rp += " " + checkbox_bfp.Text;
            }
            if (checkbox_pnp.Checked)
            {
                rp += " " + checkbox_pnp.Text;
            }
            if (checkbox_bdrrmc.Checked)
            {
                rp += " " + checkbox_bdrrmc.Text;
            }
            if (checkbox_vmo.Checked)
            {
                rp += " " + checkbox_vmo.Text;
            }
            if (checkbox_ptv.Checked)
            {
                rp += " " + checkbox_ptv.Text;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //Check for any not filled forms
            DateTime dt = calendar_dateofincident.Value;

            if (string.IsNullOrWhiteSpace(input_timeofincident.Text) ||
                (string.IsNullOrWhiteSpace(drop_natureofincident.Text) ||
                (string.IsNullOrWhiteSpace(drop_placeofincident.Text) ||
                (string.IsNullOrWhiteSpace(drop_placeofincident.Text) ||
                (string.IsNullOrWhiteSpace(input_numberofvictims.Text) ||
                (string.IsNullOrWhiteSpace(drop_hospital.Text)))))))
            {
                MessageBox.Show("Fields cannot be empty.", "Skyetech: RDMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                //This submits the record to the database
                vehicleinvolvedconditionalbranches();
                repondersconditionalbranches();
                collisionyesno();

                //Establish connections
                conn.Close();
                conn.Open();

                string strcmd = "INSERT INTO tbl_ir ([Date of Incident], [Time of Incident], [Nature of Incident], [Place of Incident], [No of Victims], [Endorsed to which Hospital], [Is it a Collision], [Vehicle Involved], [Responded by], [Other details], [Remarks]) VALUES" +
                " (#" + dt.ToString("MM/dd/yyyy") + "#, '" + input_timeofincident.Text + "', '" + drop_natureofincident.Text + "', '" + drop_placeofincident.Text + "', '" + input_numberofvictims.Text + "', '" + drop_hospital.Text + "', '" + collision + "', '" + va + "', '" + rp + "', '" + input_otherdetail.Text + "', '" + input_remarks.Text + "')";

                OleDbCommand cmd = new OleDbCommand(strcmd, conn);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Incident reported", "Skyetech: RDMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }
    }
}
