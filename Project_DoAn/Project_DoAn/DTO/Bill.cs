using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DoAn.DTO
{
    public class Bill
    {
        public int BillId { get; set; }
        public DateTime DateCreated { get; set; }
        public string EmployeeName { get; set; }
        public string TableName { get; set; }
        public int Discount { get; set; }
        public int TotalPriceWithDiscount { get; set; }

        public Bill(DataRow row)
        {
            BillId = (int)row["BILL_ID"];
            DateCreated = Convert.ToDateTime(row["DATE_CREATED"]);
            EmployeeName = row["EMPLOYEE_NAME"].ToString();
            TableName = row["TABLE_NAME"].ToString();
            Discount = (int)row["DISCOUNT"];
            TotalPriceWithDiscount = (int)row["TOTAL_PRICE_WITH_DISCOUNT"];
        }
    }

}
