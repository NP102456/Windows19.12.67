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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Form2.ConnectNorthwind();

            string startPrice = txtStart.Text;
            string endPrice = txtEnd.Text;

            string query = string.Format("select * Form Products Where UniPrice" +
                " Between{0} And {1}", startPrice, endPrice);

            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvResult.DataSource = dt;

            conn.Close();
        }
    }
}
