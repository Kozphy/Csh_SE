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

namespace Lab0518_form
{
    public partial class getData : Form
    {
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        public getData()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.adapter = new SqlDataAdapter();
            this.ds = new DataSet();
        }


        private void getDataSet(string database, string dataSetName, SqlCommand cmd) {
            //ds.Clear();
            //if (this.ds.Tables[dataSetName] != null) { 
            //    this.ds.Tables[dataSetName].Clear();
            //}
            if (this.ds.Tables[dataSetName] != null && this.ds.Tables[dataSetName].Rows.Count > 0) {
                this.ds.Tables[dataSetName].Clear(); 
            }
            string str = $"Data Source=DESKTOP-BO1NJFV;Initial Catalog={database};User ID=zixsa;Password=0270453";
            using (SqlConnection conn = new SqlConnection(str)) { 
                cmd.Connection = conn;
                this.adapter.SelectCommand = cmd;
                this.adapter.Fill(this.ds, dataSetName);
                cmd.Cancel();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string database = "northwind";
            string dataSetName = "Categories";
            string queryString = "select * from Categories;";
            SqlCommand cmd = new SqlCommand(queryString);
            getDataSet(database, dataSetName, cmd);
            this.dataGridView1.DataSource = this.ds.Tables[dataSetName];
            SetDataGridViewData();
        }

        private void btnwhere_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            string database = "advantureWorksDW2022";
            string dataSetName = "dimCurrency";
            string queryString = $"select * from DimCurrency where CurrencyAlternateKey='@abrCurrency'";
            SqlCommand cmd = new SqlCommand(queryString);
            cmd.Parameters.AddWithValue("@abrCurrency", userInput);
            //cmd.Parameters.Add("@abrCurrency", SqlDbType.NChar, 6);
            //cmd.Parameters["@abrCurrency"].Value = userInput;
            getDataSet(database, dataSetName, cmd);

            if (this.ds.Tables[dataSetName].Rows.Count == 0) { 
                MessageBox.Show("can't get item in database.");
                return;
            }

            this.dataGridView1.DataSource = this.ds.Tables[dataSetName];
            SetDataGridViewData();
        }
        
        public void SetDataGridViewData()
        {
            this.dataGridView1.Columns[0].HeaderText = "貨幣編號";
            this.dataGridView1.Columns[1].HeaderText = "貨幣縮寫";
            this.dataGridView1.Columns[2].HeaderText = "貨幣全名";
        }

    }
}
