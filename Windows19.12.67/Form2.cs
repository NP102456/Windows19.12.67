using Microsoft.Identity.Client;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

       
        
           public static SqlConnection ConnectNorthwind() 
            {
                string server = "LAPTOP-IQ8TJ0SI\\SQLEXPRESS";
                string db = "Northwind";
                //ประกาศตัวแปล string conStr
                string conStr = string.Format(@"Data Source={0}; Initial catalog={1}; Integrated Security=True; Encrypt=False;", server, db);

                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();

            return conn;
            }
        
    }
}
