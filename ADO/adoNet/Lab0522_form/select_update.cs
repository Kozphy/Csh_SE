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
    public partial class select_update : Form
    {
        #region
        //SqlConnection conn = null;
        //SqlDataAdapter adapter = null;
        //DataSet ds = null;

        //string dataSetName = "DimCurrency";
        //string connStr = Properties.Settings.Default.AdventureWork2022;
        reuseDBInit db = null;
        DataSet ds = null;

        string dataSetName = "DimCurrency";
        string selectFromTableStr = "select * from DimCurrency";

        #endregion


        public select_update()
        {
            InitializeComponent();
            db = new reuseDBInit();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //   conn = new SqlConnection(connStr);
        //   adapter = new SqlDataAdapter();
        //   ds = new DataSet();
        //}


        private void btnSelect_Click(object sender, EventArgs e)
        {

            ds = db.getData(selectFromTableStr, dataSetName);
            dataGridView1.DataSource = ds.Tables[dataSetName];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
            foreach (DataRow row in ds.Tables[dataSetName].Rows)
            {
                txtResult.Text += string.Join(",", row.ItemArray) + " --> " + row.RowState.ToString() + "\r\n";
            }

            // method 1: SqlDataAdapter + DataTable
            int i = db.adapter.Update(ds.Tables[dataSetName]);
            Debug.WriteLine(i);
        }

        enum TableColumn { 
            CurrencyKey = 0,
            CurrencyAlternateKey = 1,
            CurrencyName = 2
        }

        //Dictionary<TableColumn, int> TableColumnMap = new Dictionary<TableColumn, int>(){ 
        //    { TableColumn.CurrencyKey , "CurrencyKey" },
        //};

        private StringBuilder GetModifiedData() { 
            StringBuilder modifiedData  = new StringBuilder();
            foreach(DataRow row in ds.Tables[dataSetName].Rows)
            {
                if(row.RowState == DataRowState.Modified) { 
                    modifiedData.Append(String.Join(",", row.ItemArray) + "\r\n");
                }
            }
            return modifiedData;
        }
        private void btnUpdateV2_Click(object sender, EventArgs e)
        {
            // method 2 SqlCommandBuilder
            SqlCommandBuilder sqlb = new SqlCommandBuilder(db.adapter);
            db.adapter.UpdateCommand = sqlb.GetUpdateCommand(); 
            int i = db.adapter.Update(ds.Tables[dataSetName]);
            txtResult.Text = "update " + i + " rows";
        }

        private void btnUpdateV3_Click(object sender, EventArgs e)
        {
            db.conn.Open();
            // method 3 SqlCommandBuilder + @
            SqlCommandBuilder sqlb = new SqlCommandBuilder(db.adapter);

            // setting sql where clause only use PK to filter
            // sqlb.ConflictOption = ConflictOption.OverwriteChanges;

            // autoCreate sqlcmd with default column name
            SqlCommand cmd = sqlb.GetUpdateCommand(true);
            db.adapter.UpdateCommand = cmd;

            //Debug.WriteLine(cmd.CommandText);
            // UPDATE [DimCurrency] SET [CurrencyAlternateKey] = @CurrencyAlternateKey, [CurrencyName] = @CurrencyName WHERE (([CurrencyKey] = @Original_CurrencyKey) AND ([CurrencyAlternateKey] = @Original_CurrencyAlternateKey) AND ([CurrencyName] = @Original_CurrencyName))
            db.adapter.UpdateCommand.Parameters["@CurrencyAlternateKey"].Value = "CIS";
            db.adapter.UpdateCommand.Parameters["@CurrencyName"].Value = "1234";
            db.adapter.UpdateCommand.Parameters["@Original_CurrencyKey"].Value = "1";
            db.adapter.UpdateCommand.Parameters["@Original_CurrencyAlternateKey"].Value = "ZZ";
            db.adapter.UpdateCommand.Parameters["@Original_CurrencyName"].Value = "ZOOO";
            int i = db.adapter.UpdateCommand.ExecuteNonQuery();
            Debug.WriteLine(i);
            db.conn.Close();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StringBuilder modifiedData = GetModifiedData(); 

            if(modifiedData.Length == 0) { 
                return;
            }

            DialogResult userChoose = DialogResult.None;

            userChoose = MessageBox.Show(modifiedData.ToString(), "Do you want to save Modified?", MessageBoxButtons.OKCancel);
            Debug.WriteLine(modifiedData.Length);

            if (userChoose == DialogResult.OK && modifiedData.Length > 0)
            {
                btnUpdate_Click(sender, e);
            }
            else { 
                e.Cancel = true;
            }
        }

    }
}
