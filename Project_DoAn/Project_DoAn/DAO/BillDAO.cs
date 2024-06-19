using Project_DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DoAn.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        // Singleton pattern để đảm bảo chỉ có một thể hiện của BillDAO trong ứng dụng
        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public BillDAO() { }

        // Lấy ID hóa đơn dựa trên ID bàn
        public int GetBillID(int idtable)
        {
            int id = (int)DataProvider.Instance.ExecuteScalar("GetBillIdByTable @idtable", new object[] { idtable });

            return id;
        }

        public int GetDiscount(int billid)
        {
            int discount = (int)DataProvider.Instance.ExecuteScalar("GetDisCountBill @billid", new object[] { billid });
            return discount;
        }

        public void UpdateDiscount(int discount,int billid)
        {
            DataProvider.Instance.ExecuteQuery("UpdateDiscountBillById @discount , @billid",new object[] { discount,billid});
        }

        // Lấy thông tin hóa đơn dựa trên ID bàn
        public Bill GetBillByTable(int tableid)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("GetBillByTable @tableid", new object[] { tableid });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new Bill(row);
            }

            return null;
        }

        // Kiểm tra xem bàn đã có hóa đơn chưa
        public int CheckIsBill(int tableid)
        {
            Bill bill = GetBillByTable(tableid);
            if (bill != null)
            {
                return 1; // Trả về 1 nếu có hóa đơn
            }
            else
            {
                return 0; // Trả về 0 nếu chưa có hóa đơn
            }
        }

        // Lấy ID hóa đơn chưa thanh toán dựa trên ID bàn
        public int GetUnCheckBillIdByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill where TABLE_ID = " + id + " and STATUS = 1");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.BillId;
            }
            return -1;
        }

        // Thêm hóa đơn mới với ID nhân viên và ID bàn
        public int InsertBill(int employeeid, int tableid)
        {
            int id = (int)DataProvider.Instance.ExecuteScalar("InsertBill @employeeid , @tableid", new object[] { employeeid, tableid });
            return id;
        }

        public int PayTableBill(int tableid)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("PayTableBill @tableid", new object[] { tableid });
            return result;
        }

        public List<Bill> GetListBill()
        {
            List<Bill> lst = new List<Bill>();
            DataTable tb = DataProvider.Instance.ExecuteQuery("GetListBill");
            foreach(DataRow row in tb.Rows)
            {
                Bill b = new Bill(row);
                lst.Add(b);
            }
            return lst;
        }

        public DataTable GetListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
    }
}
