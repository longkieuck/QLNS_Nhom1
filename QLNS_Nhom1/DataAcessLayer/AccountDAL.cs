using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_Nhom1.DataAcessLayer
{
    public class AccountDAL
    {
        private static AccountDAL instance;

        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set { instance = value; }
        }

        private AccountDAL() { }

        public bool Login(string userName, string pass)
        {
            string query = "QLNS_Login @username , @pass";

            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] { userName,pass});

            return result.Rows.Count > 0;
        }
    }
}
