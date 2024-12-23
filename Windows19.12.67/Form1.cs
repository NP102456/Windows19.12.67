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
using System.Data;
using System.Data.SqlClient;

namespace Windows19._12._67
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Form2.ConnectNorthwind();
           
            // string server = "LAPTOP-IQ8TJ0SI\\SQLEXPRESS";
            // string db = "Northwind";
            //ประกาศตัวแปล string conStr
            // string conStr = string.Format(@"Data Source={0}; Initial catalog={1}; Integrated Security=True; Encrypt=False;", server, db);

            // SqlConnection conn = new SqlConnection(conStr);
            // conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Connected to Northwind database  Successfully!");
            }
            conn.Close();   
        }
    }
}
