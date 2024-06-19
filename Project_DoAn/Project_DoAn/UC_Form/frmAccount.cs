using Project_DoAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_DoAn.UC_Form
{
    public partial class frmAccount : Form
    {
        

        public frmAccount()
        {
            InitializeComponent();
            LoadAccount();
        }
        void LoadAccount()
        {
            dgvAccount.DataSource = AccountDAO.Instance.GetAccount();
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAccount.Rows[e.RowIndex];
                txtEmployeeName.Text = row.Cells[0].Value.ToString();
                txtUserName.Text = row.Cells[1].Value.ToString();
                txtPassword.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEmployeeName.Text != "")
                {
                    int EMPLOYEE_ID = EmployeeDAO.Instance.GetEmployeeId(txtEmployeeName.Text);
                    string USERNAME = txtUserName.Text;
                    string PASSWORD = txtPassword.Text;

                    if (AccountDAO.Instance.InsertAccount(EMPLOYEE_ID, USERNAME, PASSWORD))
                    {
                        MessageBox.Show("Thêm tài khoản thành công", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                     
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!!!Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadAccount();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int EMPLOYEE_ID = EmployeeDAO.Instance.GetEmployeeId(txtEmployeeName.Text);
                string USERNAME = txtUserName.Text;
                string PASSWORD = txtPassword.Text;
                if (AccountDAO.Instance.UpdateAccount(EMPLOYEE_ID, USERNAME, PASSWORD))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadAccount();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi!!!Vui lòng thử lại"+ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int EMPLOYEE_ID = EmployeeDAO.Instance.GetEmployeeId(txtEmployeeName.Text);
                if (AccountDAO.Instance.DeleteAccount(EMPLOYEE_ID))
                {
                    MessageBox.Show("Xóa tài khoản thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadAccount();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!!!Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {

        }

    }
}
