
namespace Project_DoAn.UC_Form
{
    partial class frmMenu
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
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtFoodPrice = new System.Windows.Forms.TextBox();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblFoodType = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.cbxFoodType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMenu
            // 
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvMenu.Location = new System.Drawing.Point(0, 0);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.Size = new System.Drawing.Size(650, 580);
            this.dgvMenu.TabIndex = 0;
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FoodId";
            this.Column1.HeaderText = "Mã món";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FoodName";
            this.Column2.HeaderText = "Tên món";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CategoryName";
            this.Column3.HeaderText = "Loại món";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Price";
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.Name = "Column4";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnAdd.Location = new System.Drawing.Point(689, 415);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 79);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnEdit.Location = new System.Drawing.Point(833, 415);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 79);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnDelete.Location = new System.Drawing.Point(689, 501);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 79);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnFind.Location = new System.Drawing.Point(833, 501);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(126, 79);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFoodID
            // 
            this.txtFoodID.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtFoodID.Location = new System.Drawing.Point(25, 68);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(270, 33);
            this.txtFoodID.TabIndex = 4;
            this.txtFoodID.TextChanged += new System.EventHandler(this.txtFoodID_TextChanged);
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtFoodName.Location = new System.Drawing.Point(25, 151);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(270, 33);
            this.txtFoodName.TabIndex = 5;
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtFoodPrice.Location = new System.Drawing.Point(25, 324);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(270, 33);
            this.txtFoodPrice.TabIndex = 7;
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblFoodName.Location = new System.Drawing.Point(28, 38);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(90, 27);
            this.lblFoodName.TabIndex = 0;
            this.lblFoodName.Text = "Mã món";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbl.Location = new System.Drawing.Point(28, 121);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(129, 27);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Tên món ăn";
            // 
            // lblFoodType
            // 
            this.lblFoodType.AutoSize = true;
            this.lblFoodType.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblFoodType.Location = new System.Drawing.Point(28, 209);
            this.lblFoodType.Name = "lblFoodType";
            this.lblFoodType.Size = new System.Drawing.Size(101, 27);
            this.lblFoodType.TabIndex = 2;
            this.lblFoodType.Text = "Loại món";
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblFoodPrice.Location = new System.Drawing.Point(28, 294);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(87, 27);
            this.lblFoodPrice.TabIndex = 3;
            this.lblFoodPrice.Text = "Đơn giá";
            // 
            // cbxFoodType
            // 
            this.cbxFoodType.Font = new System.Drawing.Font("Tahoma", 16F);
            this.cbxFoodType.FormattingEnabled = true;
            this.cbxFoodType.Location = new System.Drawing.Point(25, 239);
            this.cbxFoodType.Name = "cbxFoodType";
            this.cbxFoodType.Size = new System.Drawing.Size(270, 33);
            this.cbxFoodType.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbxFoodType);
            this.groupBox1.Controls.Add(this.lblFoodPrice);
            this.groupBox1.Controls.Add(this.lblFoodType);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.lblFoodName);
            this.groupBox1.Controls.Add(this.txtFoodPrice);
            this.groupBox1.Controls.Add(this.txtFoodName);
            this.groupBox1.Controls.Add(this.txtFoodID);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.groupBox1.Location = new System.Drawing.Point(664, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvMenu);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.Text = "frmMune";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtFoodPrice;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblFoodType;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.ComboBox cbxFoodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}