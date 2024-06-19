using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DoAn.DTO
{
    public class Menu
    {
        public string FoodName { set; get; }
        public int Quantity { set; get; }
        public int Price { set; get; }
        public int TotalPrice { set; get; }

        public Menu() { }

        public Menu(DataRow row)
        {
            this.FoodName = row["FOOD_NAME"].ToString();
            this.Quantity = (int)row["QUANTITY"];
            this.Price = (int)row["PRICE"];
            this.TotalPrice = (int)row["TOTALPRICE"];
        }
    }
}
