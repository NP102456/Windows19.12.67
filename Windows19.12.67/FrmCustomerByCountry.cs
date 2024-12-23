using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows19._12._67
{
    public partial class FrmCustomerByCountry : Form
    {
        public FrmCustomerByCountry()
        {
            InitializeComponent();
        }
        public void showCountry()
        {
            SqlConnection conn = Form2.ConnectNorthwind();

            string query = "Select Distinct From Customers By Country ASC";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboCountry.DataSource = dt;
            cboCountry.DisplayMember = "Country";
            cboCountry.ValueMember = "Country";

            conn.Close();
        }
    }
}
