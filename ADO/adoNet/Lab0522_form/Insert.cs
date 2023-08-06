using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0522_form
{
    public partial class Insert : Form
    {
        #region
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        string connStr = Properties.Settings.Default.AdventureWork2022;
        string dataSetName = "DimCurrency";


        #endregion

        public Insert()
        {
            InitializeComponent();
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            adapter = new SqlDataAdapter();
            ds = new DataSet();
        }

        private void getData()
        {
            string queryString = "select * from DimCurrency";
            SqlCommand cmd = new SqlCommand(queryString, conn);
            adapter.SelectCommand = cmd;
            adapter.Fill(this.ds, dataSetName);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ds.Clear();
            getData();
            dataGridView1.DataSource = ds.Tables[dataSetName];
        }

        private void insertV1_Click(object sender, EventArgs e)
        {
            // 使用者在 dataGridView 新增
            // 整個 Table 更新回資料庫
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            SqlCommand cmd = cmdBuilder.GetInsertCommand(true);
            adapter.InsertCommand = cmd;
            Debug.WriteLine(cmd.CommandText);
            int i = adapter.Update(ds.Tables[dataSetName]);
            textBox1.Text = "Insert row: " + i.ToString();
        }

        private void insertV2_Click(object sender, EventArgs e)
        {
            // SqlCommand Builder 給 SQL 指令
            // 自己填入參數 
            // INSERT INTO [DimCurrency] ([CurrencyAlternateKey], [CurrencyName]) VALUES (@CurrencyAlternateKey, @CurrencyName)
            conn.Open();
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
            SqlCommand cmd = cmdBuilder.GetInsertCommand(true);
            cmd.Parameters["@CurrencyAlternateKey"].Value = txtCurrencyAlternateKey.ToString();
            cmd.Parameters["@CurrencyName"].Value = txtCurrencyName.ToString();
            adapter.InsertCommand = cmd;
            int i = adapter.InsertCommand.ExecuteNonQuery();
            textBox1.Text = "Insert row: " + i.ToString();
            conn.Close();
        }
    }
}
