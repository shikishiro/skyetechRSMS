using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skyetechRSMS
{
    public partial class dashboardreports : Form
    {
        //Test Database
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\rdmsdata.accdb");

        //Main Database
        //OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\rdmsdata.accdb");
        public dashboardreports()
        {
            InitializeComponent();
            chartIR();
            chartPTV();
        }

        public void chartIR()
        {
            conn.Close();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT COUNT ([Case Number]) AS COUNTCASE, [Nature of Incident] FROM tbl_ir GROUP BY [Nature of Incident]", conn);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                chart_ir.Series["Series1"].Points.AddXY(reader["Nature of Incident"].ToString(), reader["COUNTCASE"].ToString());
            }
            conn.Close();
        }

        public void chartPTV()
        {
            conn.Close();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT COUNT ([Case Number]) AS COUNTCASE, [Date Documented] FROM tbl_ptv GROUP BY [Date Documented]", conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                chart_ptv.Series["Series1"].Points.AddXY(Convert.ToDateTime(reader["Date Documented"]).ToString("MM/dd/yyyy"), reader["COUNTCASE"].ToString());
            }
            conn.Close();
        }
    }
}
