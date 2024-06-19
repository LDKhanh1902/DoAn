using Project_DoAn.DAO;
using Project_DoAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DoAn.UC_Form
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();           
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            LoadListFood();
            LoadCategoryIntoCombobox(cbxFoodType);
        }

        void LoadListFood()
        {
            dgvMenu.DataSource = FoodDAO.Instance.GetListFood();
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "CATEGORYNAME";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try 
            { 
                string FOOD_NAME = txtFoodName.Text;
                int CATEGORY_ID = (cbxFoodType.SelectedItem as Category).CategoryId;
                string PRICE = txtFoodPrice.Text;

                if (FoodDAO.Instance.InsertFood(FOOD_NAME, CATEGORY_ID, PRICE))
                {
                    MessageBox.Show("Thêm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListFood();
                }
                else
                {
                    MessageBox.Show("Thêm món không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin món ăn!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string FOOD_NAME = txtFoodName.Text;
                int CATEGORY_ID = (cbxFoodType.SelectedItem as Category).CategoryId;
                string PRICE = txtFoodPrice.Text;
                int FOOD_ID = Convert.ToInt32(txtFoodID.Text);

                if (FoodDAO.Instance.UpdateFood(FOOD_ID, FOOD_NAME, CATEGORY_ID, PRICE))
                {
                    MessageBox.Show("Sửa món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListFood();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa thức ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int FOOD_ID = Convert.ToInt32(txtFoodID.Text);

                if (FoodDAO.Instance.DeleteFood(FOOD_ID))
                {
                    MessageBox.Show("Xóa món thành công" ,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListFood();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa thức ăn" ,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn!!!"+Environment.NewLine+ "Kiểm tra lại món ăn" ,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvMenu.SelectedCells.Count > 0)
                {
                    int id = (int)dgvMenu.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cbxFoodType.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbxFoodType.Items)
                    {
                        if (item.CategoryId == cateogory.CategoryId)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbxFoodType.SelectedIndex = index;
                }
            }
            catch { }

        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvMenu.Rows[e.RowIndex];
                txtFoodID.Text = row.Cells[0].Value.ToString();
                txtFoodName.Text = row.Cells[1].Value.ToString();
                cbxFoodType.Text = row.Cells[2].Value.ToString();
                txtFoodPrice.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvMenu.DataSource = FoodDAO.Instance.SearchFood(txtFoodName.Text);
        }
    }
}
