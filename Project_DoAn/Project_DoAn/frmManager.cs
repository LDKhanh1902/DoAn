using Project_DoAn.UC_Form;
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
    public partial class frmManager : Form
    {

        public frmManager()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            btnShowMenu_Click(sender,e);
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMenu());
        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBill());
        }

        private void btnShowEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEmployee());
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAccount());
        }

        private void frmManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
