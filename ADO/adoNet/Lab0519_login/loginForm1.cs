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

namespace Lab0519_login
{
    public partial class loginForm1 : Form
    {

        DataSet ds = null;
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;

        private string account = null;
        private string password = null;
        private string connStr = Properties.Settings.Default.LabAccount;

        public loginForm1()
        {
            InitializeComponent();
        }

        private void loginForm1_Load(object sender, EventArgs e)
        {
            this.conn = new SqlConnection(this.connStr);
            this.adapter = new SqlDataAdapter();
            this.ds = new DataSet();
        }

       private void loginBtn_Click(object sender, EventArgs e)
        {
            string dataSetName = "account";
            account = accountTextBox.Text;
            password = passwordTextBox.Text;
            string queryString = "select * from Account where Account = @accountText and Password = @passwordText";
            SqlCommand cmd = new SqlCommand(queryString, this.conn);
            cmd.Parameters.AddWithValue("@accountText", this.account);
            cmd.Parameters.AddWithValue("@passwordText", this.password);
            adapter.SelectCommand = cmd;
            int success = adapter.Fill(ds, dataSetName);
            foundLabel.Text = success > 0 ? ds.Tables[dataSetName].Rows[0].ItemArray[1].ToString() : "fail login";

            //if (success > 0) { 
            //    foundLabel.Text = ds.Tables["account"].Rows[0].ItemArray[1].ToString();
            //}
            //else { 
            //    foundLabel.Text = "fail login";
            //}
        }

    }
}
