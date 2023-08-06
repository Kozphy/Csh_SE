using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0523_MyDBHelper
{
    public partial class Select_insert : Form
    {
        DbHelper adVentureDb;
        DbHelper northwindDb;
        public Select_insert()
        {
            InitializeComponent();
            adVentureDb = new DbHelper();
            northwindDb = new DbHelper(Properties.Settings.Default.northwind);
        }

        private DataTable select(DbHelper dbhelper,string tableName) { 
            string queryString = $"select * from {tableName}";
            string dsName = "DimCurrency";
            DataTable dt = dbhelper.getData(queryString, dsName);
            return dt;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataTable dt = select(adVentureDb, "DimCurrency");
            dataGridView1.DataSource = dt;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 解決 SqlAdapter.SelectCommand Property need to be initialized
            // method 1 填入 selectCommand
            //select(adVentureDb, "DimCurrency");


            // 使用 sqlCommandBuilder
            //int totalInsert = adVentureDb.insertData(txtCurrencyAlternateKey.Text.ToString(), txtCurrencyName.Text.ToString());

            // method 2 without SqlCommandBuilder，自己寫 SQL
            string queryString = "insert into DimCurrency " +
                "(CurrencyAlternateKey, CurrencyName) values " +
                "(@CurrencyAlternateKey, @CurrencyName)";
            //int totalInsert2 = adVentureDb.insertDataV2(queryString, txtCurrencyAlternateKey.Text.ToString(), txtCurrencyName.Text.ToString());

            // 優化
            DataTable dt = select(adVentureDb, "DimCurrency");
            Dictionary<string, string> userData = new Dictionary<string, string>(){};
            userData.Add("@CurrencyAlternateKey", txtCurrencyAlternateKey.Text.ToString());
            userData.Add("@CurrencyName",  txtCurrencyName.Text.ToString());

            int totalInsert2 = adVentureDb.insertDataV3(queryString, userData);

            Debug.WriteLine($"insert {totalInsert2}");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateStr = "update DimCurrency " +
                "set CurrencyAlternateKey=@NewCurrencyAlternateKey ,CurrencyName=@NewCurrencyName " +
                "where CurrencyKey=@CurrencyKey and CurrencyAlternateKey=@CurrencyAlternateKey and CurrencyName=@CurrencyName ";

            Dictionary<string, string> data = new Dictionary<string, string>();
            // value
            data.Add("@NewCurrencyAlternateKey", txtCurrencyAlternateKey.Text.ToString());
            data.Add("@NewCurrencyName", txtCurrencyName.Text.ToString());
            // where clause
            data.Add("@CurrencyKey", "1");
            data.Add("@CurrencyAlternateKey", "CIS");
            data.Add("@CurrencyName", "12345");

            adVentureDb.updateData(updateStr, data);
        }


        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            string queryString = "select * from ProductsJoin order by ProductsJoin.ProductName ASC";
            string dsName = "northwindProducts";
            DataTable dt = northwindDb.getData(queryString, dsName);
            dataGridView1.DataSource = dt;
        }

        private void ProductsV2_Click(object sender, EventArgs e)
        {
            string queryString = "select * from ProductsJoin order by ProductsJoin.ProductName ASC";
            DataTable dt = null;
            int totalRow = northwindDb.getDataV2(queryString, out dt);
            Debug.WriteLine($"totalRow: {totalRow}");
            dataGridView1.DataSource = dt;
        }

        private void intoNWRegion_Click(object sender, EventArgs e)
        {
            string selectStr = "select * from region";
            string insertStr = "insert into Region(RegionID, RegionDescription) values(@RegionID, @RegionDescription)";
            Dictionary<string,string> data = new Dictionary<string,string>();
            data.Add("@RegionID", textBox1.Text);
            data.Add("@RegionDescription", textBox2.Text);
            northwindDb.insertDataV3(insertStr, data);
        }
    }
}
