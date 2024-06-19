using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DoAn.DTO
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        public Employee(DataRow row)
        {
            this.EmployeeId = (int)row["EMPLOYEE_ID"];
            this.EmployeeName = row["EMPLOYEE_NAME"].ToString();
            this.BirthDate = Convert.ToDateTime(row["BIRTH_DATE"].ToString());
            this.Gender = row["GENDER"].ToString();
            this.Position = row["POSITION_NAME"].ToString();
            this.Address = row["ADDRESS"].ToString();
            this.PhoneNumber = row["PHONE_NUMBER"].ToString();   
            this.Salary = (int)row["SALARY"];
        }

        public Employee() { }  
    }
}
