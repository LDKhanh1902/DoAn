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

namespace Project_DoAn
{
    public partial class frmLogin : Form
    {
        private int checkout = 1;

        public frmLogin()
        {
            InitializeComponent();            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnLogin.Focus();
            txtUsername_Leave(sender, e);
            txtPassword_Leave(sender, e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.Login(txtUsername.Text, txtPassword.Text) == 1)
            {
                int checkPosition = (int)DataProvider.Instance.ExecuteScalar("select POSITION_ID from EMPLOYEE where EMPLOYEE_ID = " + AccountDAO.Instance.GetEmployeeID);
                if (checkPosition == 1)
                {
                    this.Hide();
                    new frmLuaChonQL().ShowDialog();                    
                }
                else
                {
                    this.Hide();
                    new frmTable().ShowDialog();                   
                }                   
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!!!"+Environment.NewLine+"vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.ForeColor = Color.Black;
            if (txtUsername.Text == "Nhập tên đăng nhập")
                txtUsername.Text = "";
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.ForeColor = Color.FromArgb(125, 137, 149);
                txtUsername.Text = "Nhập tên đăng nhập";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            if (txtPassword.Text == "Nhập mật khẩu")
                txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = default;
            if (txtPassword.Text == "")
            {
                txtPassword.ForeColor = Color.FromArgb(125, 137, 149);
                txtPassword.Text = "Nhập mật khẩu";
            }
            else
            {
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';
            }
        }
    }
}