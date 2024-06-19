using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DoAn.DTO
{
    public class Account
    {
        public string EmployeeName { set; get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PositionName { get; set; }

        public Account(){}

        public Account(DataRow row)
        {
            this.EmployeeName = row["EMPLOYEE_NAME"].ToString();
            this.Username = row["USERNAME"].ToString();
            this.Password = row["PASSWORD"].ToString();
            this.PositionName = row["POSITION_NAME"].ToString();
        }
    }

}
