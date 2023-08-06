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

namespace AdoDelete
{
    public partial class Form1 : Form
    {
        DBHelper northwindDb = null;
        DataSet ds = null;

        int startPage = 1;
        int currentPage = 1;
        int endPage = 0;
        int currentRowIndex = 0;
        int pageSize = 5;
        int totalCount = 0;
        int[] pages = new int[] { };
        string tableName = "Customers";

        public Form1()
        {
            InitializeComponent();
            northwindDb = new DBHelper();
            totalCount = Convert.ToInt32(northwindDb.GetScalarValue($"select count(*) from {tableName}"));
            if (totalCount % pageSize > 0)
            {
                endPage = (totalCount / pageSize) + 1;
            }
            else
            {
                endPage = (totalCount / pageSize);
            }
            pagination();
        }

        private void pagination()
        {
            int[] pages = new int[endPage];
            for (int i = 0; i < endPage; i++)
            {
                pages[i] = i + 1;
                //pages.Append(i);
            }

            if (currentPage > 3)
            {
                label1.Text = String.Join(",", pages.Skip(currentPage - 3).Take(5).ToArray());
            }
            else
            {
                label1.Text = String.Join(",", pages.Skip(currentPage - 1).Take(5).ToArray());
            }

        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (ds != null && ds.Tables[tableName] != null && ds.Tables[tableName].Rows.Count > 0)
            {
                ds.Tables[tableName].Clear();
            }
            //string tableName = "Customers";
            string queryString = $"select * from {tableName} order by CustomerID offset {currentRowIndex} rows fetch next {pageSize} rows only";
            ds = northwindDb.SelectData(queryString, tableName);
            dataGridView1.DataSource = ds.Tables[tableName];
        }
        private void insertBtn_Click(object sender, EventArgs e)
        {

            string sqlStr = $"insert into Customers " +
                $"(CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) " +
                $"values (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax) ";
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("@CustomerID", "JAOK");
            data.Add("@CompanyName", "Affect");
            data.Add("@ContactName", "jfdskcc");
            data.Add("@ContactTitle", "ifdsjk");
            data.Add("@Address", "tcxzdas");
            data.Add("@City", "dfkai");
            data.Add("@Region", "Affect2");
            data.Add("@PostalCode", "13564");
            data.Add("@Country", "13564");
            data.Add("@Phone", "01-1111-5398");
            data.Add("@Fax", "01-5462-5698");

            int affectedRow = northwindDb.InsertData(sqlStr, data);
            MessageBox.Show(affectedRow.ToString());
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string sqlStr = "update Customers set CustomerID=@NewCustomerID where CustomerID=@CustomerID";

            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("@NewCustomerID", "XAZI");
            data.Add("@CustomerID", "JAOK");

            int affectedRow = northwindDb.UpdateData(sqlStr, data);
            MessageBox.Show(affectedRow.ToString());
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string sqlStr = "delete from Customers where CustomerID=@CustomerID";
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("@CustomerID", "XAZI");

            int affectedRow = northwindDb.DeleteData(sqlStr, data);
            MessageBox.Show(affectedRow.ToString());
        }

        private void deleteThroughDs_Click(object sender, EventArgs e)
        {
            string sqlStr = "delete from Customers where CustomerID=@CustomerID";
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("@CustomerID", "XAZI");

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int affectedRow = northwindDb.DeleteDataThroughDs(sqlStr, data, rowIndex);
            MessageBox.Show(affectedRow.ToString());
        }


        private void prevBtn_Click(object sender, EventArgs e)
        {
            currentRowIndex -= pageSize;
            selectBtn_Click(sender, e);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            currentRowIndex += pageSize;
            selectBtn_Click(sender, e);
        }


        private void next5page_Click(object sender, EventArgs e)
        {
            currentRowIndex += pageSize * 5;
            selectBtn_Click(sender, e);
        }

        private void prev5page_Click(object sender, EventArgs e)
        {
            currentRowIndex -= pageSize * 5;
            selectBtn_Click(sender, e);
        }

    }
}
