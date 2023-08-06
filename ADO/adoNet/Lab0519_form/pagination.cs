using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0519_form
{
    public partial class pagination : Form
    {
        #region
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        SqlConnection conn = null;
        int currentIndex = 0;
        int pageSize = 5;
        string dataSetCurrencyName = "currency";
        string connStr = Properties.Settings.Default.advantureWorksDW2022;
        string totalCount = null;
        #endregion

        public pagination()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conn = new SqlConnection(connStr);
            this.adapter = new SqlDataAdapter();
            this.ds = new DataSet();
            getDatabaseTotalCount();
            if (this.ds.Tables[dataSetCurrencyName] == null) { 
                btnNext.Enabled = false;
                btnPrv.Enabled = false;
            }
            //getDatabaseTotalCountWithAdapter();
        }
        private void getDatabaseTotalCount()
        {
            this.conn.Open();
            string queryString = $"select count(*) AS countCurrency from DimCurrency";
            SqlCommand cmd = new SqlCommand(queryString, this.conn);
            this.totalCount = Convert.ToString(cmd.ExecuteScalar());
            this.conn.Close();
        }

        //private void getDatabaseTotalCountWithAdapter()
        //{
        //    string queryString = $"select count(*) AS countCurrency from DimCurrency";
        //    SqlCommand cmd = new SqlCommand(queryString, this.conn);
        //    this.adapter.SelectCommand = cmd;
        //    adapter.Fill(this.ds, "countTotal");
        //    cmd.Cancel();
        //    this.totalCount = this.ds.Tables["countTotal"].Rows[0].ItemArray[0].ToString();
        //}

        private void FillDataSet(SqlCommand cmd)
        {
            ds.Clear();
            this.adapter.SelectCommand = cmd;
            this.adapter.Fill(this.ds, dataSetCurrencyName);
            cmd.Cancel();
        }
        private void GetPartialData() { 
            string queryString = $"select * from DimCurrency ORDER BY CurrencyAlternateKey ASC OFFSET @currentIndex ROWS FETCH FIRST @pageSize ROWS ONLY";
            SqlCommand cmd = new SqlCommand(queryString, this.conn);
            cmd.Parameters.AddWithValue("@currentIndex", this.currentIndex);
            cmd.Parameters.AddWithValue("@pageSize", this.pageSize);
            FillDataSet(cmd);
            this.dataGridView1.DataSource = this.ds.Tables[dataSetCurrencyName];
            label1.Text = $"第 {this.currentIndex + 1} 筆 - 第 {this.currentIndex + this.pageSize} 筆，共 {this.totalCount} 筆";

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            GetPartialData();
            btnGetData.Enabled = false;
            btnNext.Enabled = true;
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            this.currentIndex = this.currentIndex - 50;
            if(this.currentIndex <= 0) { 
               this.currentIndex = 0; 
            }
            btnPrv.Enabled = (this.currentIndex != 0);
            btnNext.Enabled = true;
            GetPartialData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.currentIndex = this.currentIndex + 50;
            if (this.currentIndex >= Convert.ToInt32(this.totalCount))
            {
                this.currentIndex = Convert.ToInt32(this.totalCount) - pageSize;
                btnNext.Enabled = false;
            }
            GetPartialData();
            btnPrv.Enabled = true;
        }
    }
}
