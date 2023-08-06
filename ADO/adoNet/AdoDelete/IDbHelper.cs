using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDelete
{
    internal interface IDbHelper
    {
        DataSet SelectData(string sqlStr, string dsName);
        int InsertData(string sqlStr, Dictionary<string,string> data);
        int UpdateData(string sqlStr, Dictionary<string,string> data);
        int DeleteData(string sqlStr, Dictionary<string,string> data);
    }
}
