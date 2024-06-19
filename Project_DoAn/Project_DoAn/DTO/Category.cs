using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DoAn.DTO
{
    public class Category
    {
        public int CategoryId { set; get; }
        public string CategoryName { set; get; }

        public Category() { }

        public Category(DataRow row)
        {
            this.CategoryId = (int)row["CATEGORY_ID"];
            this.CategoryName = row["CATEGORY_NAME"].ToString();
        }
    }
}
