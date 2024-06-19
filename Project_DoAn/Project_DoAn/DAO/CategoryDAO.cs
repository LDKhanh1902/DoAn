using Project_DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DoAn.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> lstCategory = new List<Category>();
            DataTable data = DataProvider.Instance.ExecuteQuery("GetListCategory");
            foreach (DataRow row in data.Rows)
            {
                Category item = new Category(row);
                lstCategory.Add(item);
            }
            return lstCategory;
        }
        public Category GetCategoryByID(int categoryname)
        {
            Category category = null;

            string query = "select * from FOOD_CATEGORY where CATEGORY_ID = " + categoryname;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }
    }
}
