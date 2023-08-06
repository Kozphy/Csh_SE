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

namespace CRUD_ADO_NET
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        public Form1()
        {
            InitializeComponent();
            string connStr = Properties.Settings.Default.northwind;
            conn = new SqlConnection(connStr);
        }

        void Reset()
        { 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
            string query = "select max(DeptId) from Categories";
            //cmd = new SqlCommand(command, conn);
        }
    }
}
