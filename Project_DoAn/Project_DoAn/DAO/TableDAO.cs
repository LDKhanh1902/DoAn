using Project_DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Project_DoAn.DAO
{
    // Lớp TableDAO quản lý các thao tác liên quan đến đối tượng Table trong cơ sở dữ liệu
    public class TableDAO
    {
        // Biến instance dùng cho mô hình Singleton, giúp đảm bảo chỉ có một đối tượng TableDAO được tạo trong suốt quá trình chạy
        private static TableDAO instance;

        // Phương thức getter và setter cho instance
        public static TableDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDAO();
                return instance;
            }
            private set { instance = value; }
        }

        // Constructor riêng tư để ngăn chặn việc tạo đối tượng trực tiếp từ bên ngoài lớp
        private TableDAO() { }

        // Phương thức GetLoadListTable trả về danh sách các bàn từ cơ sở dữ liệu
        public List<Table> GetLoadListTable()
        {
            List<Table> lstTable = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TABLE_LIST");

            foreach (DataRow item in data.Rows)
            {
                Table tb = new Table(item);
                lstTable.Add(tb);
            }
            return lstTable;
        }

        public int UpdateTableStatus(int tableid,int status)
        {
            int check = DataProvider.Instance.ExecuteNonQuery("UpdateTableStatusByID @tableid , @status", new object[] { tableid,status });
            return check;
        }

        // Phương thức GetTableStatus trả về trạng thái của một bàn dựa trên tên bàn
        public int GetTableStatus(string tablename)
        {
            int status = (int)DataProvider.Instance.ExecuteScalar("GetTableStatus @tablename", new object[] { tablename });
            return status;
        }

        public int GetTableId(string tablename)
        {
            int id = (int)DataProvider.Instance.ExecuteScalar("GetTableId @tablename", new object[] { tablename });
            return id;
        }

        // Phương thức SwitchTableWhenOccupied thực hiện việc chuyển bàn khi bàn đích đã có khách
        public int SwitchTableWhenOccupied(int oldId, int newId,int employeeid)
        {
            int result = (int)DataProvider.Instance.ExecuteNonQuery("SwitchTableWhenOccupied @oldid , @newid , @employeeid", new object[] { oldId, newId ,employeeid});
            return result;
        }

        // Phương thức SwitchTableWhenEmpty thực hiện việc chuyển bàn khi bàn đích trống
        public int SwitchTableWhenEmpty(int oldId, int newId, int employeeid)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SwitchTableWhenEmpty @oldid , @newid , @employeeid", new object[] { oldId, newId, employeeid });
            return result;
        }
    }
}
