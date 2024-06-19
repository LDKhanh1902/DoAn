using Project_DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_DoAn.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public int GetEmployeeID { set; get; }

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            set { instance = value; }
        }

        private AccountDAO()
        {
            // Constructor
        }

        public int Login(string username, string password)
        {
            object[] parameter = new[] { username, password };
            DataTable data = DataProvider.Instance.ExecuteQuery("GetLogin @username , @password", parameter);
            if (data.Rows.Count > 0)
            {
                this.GetEmployeeID = (int)data.Rows[0]["EMPLOYEE_ID"];
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public List<Account> GetAccount()
        {
            List<Account> lst = new List<Account>();
            DataTable tb = DataProvider.Instance.ExecuteQuery("GetAccount");
            foreach (DataRow item in tb.Rows)
            {
                Account a = new Account(item);
                lst.Add(a);
            }
            return lst;
        }

        public bool InsertAccount(int EMPLOYEE_ID, string USERNAME, string PASSWORD)
        {
            string query = string.Format("INSERT dbo.ACCOUNT ( EMPLOYEE_ID, USERNAME, PASSWORD )VALUES  ( {0}, N'{1}', N'{2}')", EMPLOYEE_ID, USERNAME, PASSWORD);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(int EMPLOYEE_ID, string USERNAME, string PASSWORD)
        {
            string query = string.Format("UPDATE dbo.ACCOUNT SET USERNAME = '{1}', PASSWORD = {2} WHERE EMPLOYEE_ID = {0}", EMPLOYEE_ID, USERNAME, PASSWORD);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(int EMPLOYEE_ID)
        {
            string query = string.Format("Delete ACCOUNT where EMPLOYEE_ID = {0}", EMPLOYEE_ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


    }
}
