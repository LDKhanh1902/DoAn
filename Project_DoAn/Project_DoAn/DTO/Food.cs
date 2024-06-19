using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DoAn.DTO
{
    public class Food
    {
        public int FoodId { set; get; }
        public string FoodName { set; get; }
        public string CategoryName { set; get; }
        public int Price { set; get; }

        public Food() { }

        public Food(DataRow row)
        {
            this.FoodId = (int)row["FOOD_ID"];
            this.FoodName = row["FOOD_NAME"].ToString();
            this.CategoryName = row["CATEGORY_NAME"].ToString();
            this.Price = (int)row["PRICE"];
        }
    }
}
