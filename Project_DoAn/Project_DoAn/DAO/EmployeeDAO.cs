using Project_DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DoAn.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;

        // Singleton pattern
        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public EmployeeDAO() { }

        public int GetEmployeeId(string employeename)
        {
            int id = (int)DataProvider.Instance.ExecuteScalar("GetEmployeeId @name",new object[] { employeename});
            return id;
        }

        public List<Employee> GetListEmployee()
        {
            List<Employee> list = new List<Employee>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("GetListEmployee");
            foreach (DataRow row in dt.Rows)
            {
                Employee employee = new Employee(row);
                list.Add(employee);
            }
            return list;
        }

        public int InsertEmployee(string employeeName, DateTime birthDate, string address, string phoneNumber, string gender, int positionId, string employeeImage = null)
        {
            string query = "EXEC InsertEmployee @EMPLOYEE_NAME , @BIRTH_DATE , @ADDRESS , @PHONE_NUMBER , @GENDER , @POSITION_ID , @EMPLOYEE_IMAGE";
            object[] parameters = new object[] { employeeName, birthDate, address, phoneNumber, gender, positionId, employeeImage };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result;
        }

        public int UpdateEmployee(int employeeId, string employeeName, DateTime birthDate, string address, string phoneNumber, string gender, int positionId, string employeeImage = null)
        {
            string query = "EXEC UpdateEmployee @EMPLOYEE_ID , @EMPLOYEE_NAME , @BIRTH_DATE , @ADDRESS , @PHONE_NUMBER , @GENDER , @POSITION_ID , @EMPLOYEE_IMAGE";
            object[] parameters = new object[] { employeeId, employeeName, birthDate, address, phoneNumber, gender, positionId, employeeImage };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result;
        }

        public string GetEmployeeImage(int id)
        {
            string img = (string)DataProvider.Instance.ExecuteScalar("GetEmployeeImageById @id",new object[] { id });
            return img;
        }

        public int DeleteEmployee(int employeeId)
        {
            string query = "EXEC DeleteEmployee @EMPLOYEE_ID";
            object[] parameters = new object[] { employeeId };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result;
        }

        public List<Employee> SearchEmployee(string employeeName)
        {
            List<Employee> list = new List<Employee>();
            string query = "EXEC SearchEmployeeByName @EMPLOYEE_NAME";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { employeeName });

            foreach (DataRow item in data.Rows)
            {
                Employee employee = new Employee(item);
                list.Add(employee);
            }

            return list;
        }

    }
}
