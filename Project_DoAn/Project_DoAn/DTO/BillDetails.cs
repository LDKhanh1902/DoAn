using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DoAn.DTO
{
    public class BillDetails
    {
        public int BillId { get; set; }
        public int FoodId { get; set; }
        public int Quantity { get; set; }

        public BillDetails() { }

        public BillDetails(DataRow row)
        {
            this.BillId = (int)row["BILL_ID"];
            this.FoodId = (int)row["FOOD_ID"];
            this.Quantity = (int)row["QUANTITY"];
        }
    }
}
