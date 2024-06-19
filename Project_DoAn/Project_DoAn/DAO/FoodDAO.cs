using Project_DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Project_DoAn.DAO
{
    // Lớp FoodDAO quản lý các thao tác liên quan đến đối tượng Food trong cơ sở dữ liệu
    public class FoodDAO
    {
        // Biến instance dùng cho mô hình Singleton, giúp đảm bảo chỉ có một đối tượng FoodDAO được tạo trong suốt quá trình chạy
        private static FoodDAO instance;

        // Phương thức getter và setter cho instance
        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new FoodDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public FoodDAO() { }

        public List<Food> GetListFood()
        {
            List<Food> lst = new List<Food>();
            DataTable tb = DataProvider.Instance.ExecuteQuery("GetListFood");
            foreach(DataRow item in tb.Rows)
            {
                Food f = new Food(item);
                lst.Add(f);
            }
            return lst;
        }

        // Phương thức GetListFoodByCategory trả về danh sách các món ăn thuộc một danh mục nhất định
        public DataTable GetListFoodByCategory(string CategoryName)
        {
            object[] parameter = new[] { CategoryName };
            DataTable data = DataProvider.Instance.ExecuteQuery("GetFoodByCategory @categoryname", parameter);

            return data;
        }

        // Phương thức GetFoodId trả về ID của một món ăn dựa trên tên món ăn
        public int GetFoodId(string foodname)
        {
            int id = (int)DataProvider.Instance.ExecuteScalar("GetFoodIdByFoodName @foodname", new object[] { foodname });

            return id;
        }

        public bool InsertFood(string FOOD_NAME, int CATEGORY_ID, string PRICE)
        {
            string query = string.Format("INSERT dbo.Menu(FOOD_NAME, CATEGORY_ID, PRICE) VALUES( N'{0}', {1},{2})", FOOD_NAME, CATEGORY_ID, PRICE);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateFood(int FOOD_ID, string FOOD_NAME, int CATEGORY_ID, string PRICE)
        {
            string query = string.Format("UPDATE dbo.MENU SET FOOD_NAME = N'{0}', CATEGORY_ID = {1}, PRICE = {2} WHERE FOOD_ID = {3}", FOOD_NAME, CATEGORY_ID, PRICE, FOOD_ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteFood(int FOOD_ID)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.BILL_DETAILS WHERE FOOD_ID = " + FOOD_ID);
            string query = string.Format("Delete MENU where FOOD_ID = {0}", FOOD_ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<Food> SearchFood(string foodname)
        {
            List<Food> lst = new List<Food>();
            DataTable tb = DataProvider.Instance.ExecuteQuery("SearchFoodByName @foodname", new object[] { foodname });
            foreach (DataRow item in tb.Rows)
            {
                Food f = new Food(item);
                lst.Add(f);
            }
            return lst;
        }
    }
}
