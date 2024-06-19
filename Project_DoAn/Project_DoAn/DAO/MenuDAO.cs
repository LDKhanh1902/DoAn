using Project_DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Project_DoAn.DAO
{
    // Lớp MenuDAO quản lý các thao tác liên quan đến đối tượng Menu trong cơ sở dữ liệu
    public class MenuDAO
    {
        // Biến instance dùng cho mô hình Singleton, giúp đảm bảo chỉ có một đối tượng MenuDAO được tạo trong suốt quá trình chạy
        private static MenuDAO instance;

        // Phương thức getter và setter cho instance
        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MenuDAO();
                return instance;
            }
            private set { instance = value; }
        }

        // Constructor riêng tư để ngăn chặn việc tạo đối tượng trực tiếp từ bên ngoài lớp
        private MenuDAO() { }

        // Phương thức GetListMenuByTable trả về danh sách các menu thuộc một bàn nhất định
        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = string.Format("GetBillDetails @id");
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }

        public List<Menu> GetListMenuByBill(int billid)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = string.Format("GetBillDetailsByBill @billid");
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { billid });

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
