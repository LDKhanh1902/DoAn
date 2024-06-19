using Project_DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DoAn.DAO
{
    public class BillDetailsDAO
    {
        private static BillDetailsDAO instance;

        // Singleton pattern
        public static BillDetailsDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDetailsDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public BillDetailsDAO() { }

        // Lấy số lượng món ăn trong chi tiết hóa đơn
        public int GetQuantity(int billid, int foodid)
        {
            object result = DataProvider.Instance.ExecuteScalar("GetQuantityByFoodIdAndBillId @billid , @foodid", new object[] { billid, foodid });
            int quantity = (result != null) ? Convert.ToInt32(result) : 0;
            return quantity;
        }

        // Lấy thông tin chi tiết hóa đơn theo ID món ăn và ID hóa đơn
        public BillDetails GetBillDetailsByFoodID(int billID, int foodID)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("GetBillDetailsByFoodAndBill @billid , @foodid", new object[] { billID, foodID });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new BillDetails(row);
            }

            return null;
        }

        // Kiểm tra xem món ăn đã có trong chi tiết hóa đơn chưa
        public int CheckIsBillDetails(int billID, int foodID)
        {
            BillDetails billdetails = GetBillDetailsByFoodID(billID, foodID);
            if (billdetails != null)
            {
                return 1; // Trả về 1 nếu món ăn đã có trong hóa đơn
            }
            else
            {
                return 0; // Trả về 0 nếu món ăn chưa có trong hóa đơn
            }
        }

        // Thêm một mục mới vào chi tiết hóa đơn với ID hóa đơn, ID món ăn và số lượng
        public void InsertBillDetails(int billid, int foodid, int quantity)
        {
            object[] parameter = new object[] { billid, foodid, quantity };
            DataProvider.Instance.ExecuteScalar("InsertBillDetails @billid , @foodid , @quantity", parameter);
        }

        // Cập nhật số lượng món ăn trong chi tiết hóa đơn
        public void UpdateQuantityFoodInBillDetails(int billid, int foodid, int quantity)
        {
            object[] parameter = new object[] { billid, foodid, quantity };
            DataProvider.Instance.ExecuteQuery("UpdateQuantityFoodInBillDetails @billid , @foodid , @quantity", parameter);
        }

        // Xóa món ăn khỏi chi tiết hóa đơn
        public void DeleteFoodInBillDetails(int billid, int foodid)
        {
            object[] parameter = new object[] { billid, foodid };
            DataProvider.Instance.ExecuteQuery("DeleteFoodInBillDetails @billid , @foodid", parameter);
        }
    }
}
