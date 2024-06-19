using Project_DoAn.DAO;
using Project_DoAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DoAn.UC_Form
{
    public partial class frmEmployee : Form
    {
        private int employeeId;
        private string Image = "";

        public frmEmployee()
        {
            InitializeComponent();
            LoadListEmployee();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\Users\\Khanh\\OneDrive\\Documents\\Image_Employee"; // Thay đổi đường dẫn này thành đường dẫn của thư mục bạn muốn mở
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của hình ảnh
                Image = openFileDialog.FileName;

                // Hiển thị hình ảnh lên PictureBox
                ptbImageEmployee.Image = new Bitmap(Image);
            }
        }
        public void LoadListEmployee()
        {
            lsvEmployee.Items.Clear();
            List<Employee> list = EmployeeDAO.Instance.GetListEmployee();
            foreach(Employee emp in list)
            {
                ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
                item.SubItems.Add(emp.EmployeeName);
                item.SubItems.Add(emp.BirthDate.ToShortDateString());
                item.SubItems.Add(emp.Gender);
                item.SubItems.Add(emp.Position);
                item.SubItems.Add(emp.Salary.ToString());
                item.SubItems.Add(emp.Address);
                item.SubItems.Add(emp.PhoneNumber);
                
                lsvEmployee.Items.Add(item);
            }

        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            cbxPosition.DataSource = DataProvider.Instance.ExecuteQuery("select * from POSITION");
            cbxPosition.DisplayMember = "POSITION_NAME";
        }

        private void lsvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvEmployee.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvEmployee.SelectedItems[0];
                employeeId = Convert.ToInt32(item.Text);
                txtEmployeeName.Text = item.SubItems[1].Text;
                dtpkBirthday.Value = Convert.ToDateTime(item.SubItems[2].Text);
                if (item.SubItems[3].Text == "Nam")
                {
                    rdbMen.Checked = true;
                }
                else
                {
                    rdbGirl.Checked = true;
                }
                cbxPosition.Text = item.SubItems[4].Text;
                txtSalary.Text = item.SubItems[5].Text;
                txtAddress.Text = item.SubItems[6].Text;
                txtPhoneNumber.Text = item.SubItems[7].Text;
                ptbImageEmployee.ImageLocation = EmployeeDAO.Instance.GetEmployeeImage(employeeId);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {           
                string gender = "";
                int positionId = (int)DataProvider.Instance.ExecuteScalar("GetPositionIdByName @name",new object[] { cbxPosition.Text});
                if (rdbMen.Checked == true)
                    gender = rdbMen.Text;
                else
                    gender = rdbGirl.Text;
            
                EmployeeDAO.Instance.InsertEmployee(txtEmployeeName.Text,dtpkBirthday.Value,txtAddress.Text,txtPhoneNumber.Text,gender,positionId,Image);
                LoadListEmployee();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi!!!Vui lòng thử lại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Giả sử bạn có một control (ví dụ: một TextBox hoặc Label) có tên txtEmployeeId
                // chứa ID của nhân viên cần xóa
                int employeeId = EmployeeDAO.Instance.GetEmployeeId(txtEmployeeName.Text);

                EmployeeDAO.Instance.DeleteEmployee(employeeId);
                LoadListEmployee();
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!!! Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {   
                MessageBox.Show(ptbImageEmployee.ImageLocation);
                string gender = "";
                int positionId = (int)DataProvider.Instance.ExecuteScalar("GetPositionIdByName @name", new object[] { cbxPosition.Text });
                if (rdbMen.Checked == true)
                    gender = rdbMen.Text;
                else
                    gender = rdbGirl.Text;

                // Giả sử bạn có một control (ví dụ: một TextBox hoặc Label) có tên txtEmployeeId
                // chứa ID của nhân viên cần chỉnh sửa

                EmployeeDAO.Instance.UpdateEmployee(employeeId, txtEmployeeName.Text, dtpkBirthday.Value, txtAddress.Text, txtPhoneNumber.Text, gender, positionId, Image);
                LoadListEmployee();
                MessageBox.Show("Sửa thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi!!! Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lsvEmployee.Items.Clear();
            List<Employee> list = EmployeeDAO.Instance.SearchEmployee(txtEmployeeName.Text);
            foreach (Employee emp in list)
            {
                ListViewItem item = new ListViewItem(emp.EmployeeId.ToString());
                item.SubItems.Add(emp.EmployeeName);
                item.SubItems.Add(emp.BirthDate.ToShortDateString());
                item.SubItems.Add(emp.Gender);
                item.SubItems.Add(emp.Position);
                item.SubItems.Add(emp.Salary.ToString());
                item.SubItems.Add(emp.Address);
                item.SubItems.Add(emp.PhoneNumber);

                lsvEmployee.Items.Add(item);
            }
        }
    }
}
