
namespace Project_DoAn.UC_Form
{
    partial class frmEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsvEmployee = new System.Windows.Forms.ListView();
            this.MaNhanVien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Luong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoDienThoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpkBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbMen = new System.Windows.Forms.RadioButton();
            this.rdbGirl = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.cbxPosition = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.ptbImageEmployee = new System.Windows.Forms.PictureBox();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvEmployee
            // 
            this.lsvEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNhanVien,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.ChucVu,
            this.Luong,
            this.DiaChi,
            this.SoDienThoai});
            this.lsvEmployee.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lsvEmployee.FullRowSelect = true;
            this.lsvEmployee.GridLines = true;
            this.lsvEmployee.HideSelection = false;
            this.lsvEmployee.Location = new System.Drawing.Point(10, 285);
            this.lsvEmployee.Name = "lsvEmployee";
            this.lsvEmployee.Size = new System.Drawing.Size(978, 303);
            this.lsvEmployee.TabIndex = 6;
            this.lsvEmployee.UseCompatibleStateImageBehavior = false;
            this.lsvEmployee.View = System.Windows.Forms.View.Details;
            this.lsvEmployee.SelectedIndexChanged += new System.EventHandler(this.lsvEmployee_SelectedIndexChanged);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Text = "Mã nhân viên";
            this.MaNhanVien.Width = 105;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ tên nhân viên";
            this.HoTen.Width = 150;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Text = "Ngày sinh";
            this.NgaySinh.Width = 133;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Text = "Giới tính";
            this.GioiTinh.Width = 97;
            // 
            // ChucVu
            // 
            this.ChucVu.Text = "Chức vụ";
            this.ChucVu.Width = 140;
            // 
            // Luong
            // 
            this.Luong.DisplayIndex = 7;
            this.Luong.Text = "Lương";
            this.Luong.Width = 116;
            // 
            // DiaChi
            // 
            this.DiaChi.DisplayIndex = 5;
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Width = 112;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DisplayIndex = 6;
            this.SoDienThoai.Text = "Số điện thoại";
            this.SoDienThoai.Width = 119;
            // 
            // dtpkBirthday
            // 
            this.dtpkBirthday.CustomFormat = "dd/MM/yyyy";
            this.dtpkBirthday.Font = new System.Drawing.Font("Tahoma", 16F);
            this.dtpkBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkBirthday.Location = new System.Drawing.Point(27, 208);
            this.dtpkBirthday.Name = "dtpkBirthday";
            this.dtpkBirthday.Size = new System.Drawing.Size(199, 33);
            this.dtpkBirthday.TabIndex = 11;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtEmployeeName.Location = new System.Drawing.Point(27, 62);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(281, 33);
            this.txtEmployeeName.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(345, 62);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(281, 33);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtAddress.Location = new System.Drawing.Point(345, 136);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(281, 33);
            this.txtAddress.TabIndex = 10;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.InitialDirectory = "C:\\Users\\Khanh\\OneDrive\\Documents\\Image_Employee";
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnChooseImage.Location = new System.Drawing.Point(57, 225);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(96, 45);
            this.btnChooseImage.TabIndex = 5;
            this.btnChooseImage.Text = "Đổi ảnh";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnAdd.Location = new System.Drawing.Point(865, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 57);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnEdit.Location = new System.Drawing.Point(865, 87);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 57);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnDelete.Location = new System.Drawing.Point(865, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 57);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnFind.Location = new System.Drawing.Point(865, 213);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(123, 57);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.Location = new System.Drawing.Point(28, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.Location = new System.Drawing.Point(348, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label4.Location = new System.Drawing.Point(348, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label5.Location = new System.Drawing.Point(28, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chức vụ";
            // 
            // rdbMen
            // 
            this.rdbMen.AutoSize = true;
            this.rdbMen.BackColor = System.Drawing.Color.White;
            this.rdbMen.Font = new System.Drawing.Font("Tahoma", 16F);
            this.rdbMen.Location = new System.Drawing.Point(257, 210);
            this.rdbMen.Name = "rdbMen";
            this.rdbMen.Size = new System.Drawing.Size(75, 31);
            this.rdbMen.TabIndex = 12;
            this.rdbMen.TabStop = true;
            this.rdbMen.Text = "Nam";
            this.rdbMen.UseVisualStyleBackColor = false;
            // 
            // rdbGirl
            // 
            this.rdbGirl.AutoSize = true;
            this.rdbGirl.BackColor = System.Drawing.Color.White;
            this.rdbGirl.Font = new System.Drawing.Font("Tahoma", 16F);
            this.rdbGirl.Location = new System.Drawing.Point(329, 210);
            this.rdbGirl.Name = "rdbGirl";
            this.rdbGirl.Size = new System.Drawing.Size(58, 31);
            this.rdbGirl.TabIndex = 13;
            this.rdbGirl.TabStop = true;
            this.rdbGirl.Text = "Nữ";
            this.rdbGirl.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label6.Location = new System.Drawing.Point(252, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giới tính";
            // 
            // gb
            // 
            this.gb.BackColor = System.Drawing.Color.White;
            this.gb.Controls.Add(this.cbxPosition);
            this.gb.Controls.Add(this.rdbGirl);
            this.gb.Controls.Add(this.rdbMen);
            this.gb.Controls.Add(this.label4);
            this.gb.Controls.Add(this.label5);
            this.gb.Controls.Add(this.label6);
            this.gb.Controls.Add(this.label7);
            this.gb.Controls.Add(this.label3);
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.label1);
            this.gb.Controls.Add(this.txtSalary);
            this.gb.Controls.Add(this.txtAddress);
            this.gb.Controls.Add(this.txtPhoneNumber);
            this.gb.Controls.Add(this.txtEmployeeName);
            this.gb.Controls.Add(this.dtpkBirthday);
            this.gb.Font = new System.Drawing.Font("Tahoma", 16F);
            this.gb.Location = new System.Drawing.Point(214, 12);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(645, 258);
            this.gb.TabIndex = 0;
            this.gb.TabStop = false;
            this.gb.Text = "Thông tin nhân viên";
            // 
            // cbxPosition
            // 
            this.cbxPosition.FormattingEnabled = true;
            this.cbxPosition.Location = new System.Drawing.Point(27, 136);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(281, 33);
            this.cbxPosition.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label7.Location = new System.Drawing.Point(425, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lương";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtSalary.Location = new System.Drawing.Point(422, 210);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(204, 33);
            this.txtSalary.TabIndex = 14;
            // 
            // ptbImageEmployee
            // 
            this.ptbImageEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.ptbImageEmployee.Location = new System.Drawing.Point(29, 13);
            this.ptbImageEmployee.Name = "ptbImageEmployee";
            this.ptbImageEmployee.Size = new System.Drawing.Size(158, 207);
            this.ptbImageEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImageEmployee.TabIndex = 4;
            this.ptbImageEmployee.TabStop = false;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ptbImageEmployee);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.lsvEmployee);
            this.Controls.Add(this.gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvEmployee;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader GioiTinh;
        private System.Windows.Forms.ColumnHeader MaNhanVien;
        private System.Windows.Forms.DateTimePicker dtpkBirthday;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.PictureBox ptbImageEmployee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader ChucVu;
        private System.Windows.Forms.ColumnHeader DiaChi;
        private System.Windows.Forms.ColumnHeader SoDienThoai;
        private System.Windows.Forms.RadioButton rdbMen;
        private System.Windows.Forms.RadioButton rdbGirl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.ColumnHeader Luong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.ComboBox cbxPosition;
    }
}