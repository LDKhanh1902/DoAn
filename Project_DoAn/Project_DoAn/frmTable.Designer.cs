
namespace Project_DoAn
{
    partial class frmTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTable));
            this.flpTableList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbFoodName = new System.Windows.Forms.ComboBox();
            this.cbbFoodCategory = new System.Windows.Forms.ComboBox();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBillTaleName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.numDisscount = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnPayTableBill = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.cbbListTable = new System.Windows.Forms.ComboBox();
            this.printPreviewBill = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintBill = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDisscount)).BeginInit();
            this.SuspendLayout();
            // 
            // flpTableList
            // 
            this.flpTableList.AutoScroll = true;
            this.flpTableList.BackColor = System.Drawing.Color.White;
            this.flpTableList.Font = new System.Drawing.Font("Tahoma", 10F);
            this.flpTableList.Location = new System.Drawing.Point(2, 4);
            this.flpTableList.Name = "flpTableList";
            this.flpTableList.Size = new System.Drawing.Size(555, 441);
            this.flpTableList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbbFoodName);
            this.panel1.Controls.Add(this.cbbFoodCategory);
            this.panel1.Controls.Add(this.lsvBill);
            this.panel1.Controls.Add(this.numQuantity);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblBillTaleName);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.panel1.Location = new System.Drawing.Point(560, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 441);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label6.Location = new System.Drawing.Point(316, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label4.Location = new System.Drawing.Point(2, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên món";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label5.Location = new System.Drawing.Point(317, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại món";
            // 
            // cbbFoodName
            // 
            this.cbbFoodName.Font = new System.Drawing.Font("Tahoma", 16F);
            this.cbbFoodName.FormattingEnabled = true;
            this.cbbFoodName.Location = new System.Drawing.Point(1, 137);
            this.cbbFoodName.Name = "cbbFoodName";
            this.cbbFoodName.Size = new System.Drawing.Size(281, 33);
            this.cbbFoodName.TabIndex = 7;
            this.cbbFoodName.SelectedIndexChanged += new System.EventHandler(this.cbbFoodName_SelectedIndexChanged);
            // 
            // cbbFoodCategory
            // 
            this.cbbFoodCategory.Font = new System.Drawing.Font("Tahoma", 16F);
            this.cbbFoodCategory.FormattingEnabled = true;
            this.cbbFoodCategory.Location = new System.Drawing.Point(2, 49);
            this.cbbFoodCategory.Name = "cbbFoodCategory";
            this.cbbFoodCategory.Size = new System.Drawing.Size(281, 33);
            this.cbbFoodCategory.TabIndex = 5;
            this.cbbFoodCategory.SelectedIndexChanged += new System.EventHandler(this.cbbFoodCategory_SelectedIndexChanged);
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 232);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(709, 209);
            this.lsvBill.TabIndex = 9;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món ăn";
            this.columnHeader1.Width = 209;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá món";
            this.columnHeader3.Width = 198;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng giá";
            this.columnHeader4.Width = 201;
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Tahoma", 16F);
            this.numQuantity.Location = new System.Drawing.Point(316, 50);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(203, 33);
            this.numQuantity.TabIndex = 6;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnEdit.Location = new System.Drawing.Point(552, 101);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(160, 76);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Xóa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnAdd.Location = new System.Drawing.Point(552, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 76);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm món";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBillTaleName
            // 
            this.lblBillTaleName.AutoSize = true;
            this.lblBillTaleName.BackColor = System.Drawing.Color.Cornsilk;
            this.lblBillTaleName.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblBillTaleName.Location = new System.Drawing.Point(3, 196);
            this.lblBillTaleName.Name = "lblBillTaleName";
            this.lblBillTaleName.Size = new System.Drawing.Size(60, 33);
            this.lblBillTaleName.TabIndex = 4;
            this.lblBillTaleName.Text = "Bàn";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtPrice.Location = new System.Drawing.Point(315, 137);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(204, 33);
            this.txtPrice.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSwitchTable);
            this.panel2.Controls.Add(this.numDisscount);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.btnPayTableBill);
            this.panel2.Controls.Add(this.txtTotalPrice);
            this.panel2.Controls.Add(this.cbbListTable);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.panel2.Location = new System.Drawing.Point(2, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1281, 160);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.Location = new System.Drawing.Point(10, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chuyển bàn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label7.Location = new System.Drawing.Point(347, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 39);
            this.label7.TabIndex = 3;
            this.label7.Text = "Giảm giá (%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label1.Location = new System.Drawing.Point(347, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng  tiền :";
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnSwitchTable.Location = new System.Drawing.Point(10, 75);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(156, 75);
            this.btnSwitchTable.TabIndex = 2;
            this.btnSwitchTable.Text = "chuyển";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // numDisscount
            // 
            this.numDisscount.Font = new System.Drawing.Font("Tahoma", 20F);
            this.numDisscount.Location = new System.Drawing.Point(563, 28);
            this.numDisscount.Name = "numDisscount";
            this.numDisscount.Size = new System.Drawing.Size(121, 40);
            this.numDisscount.TabIndex = 4;
            this.numDisscount.ValueChanged += new System.EventHandler(this.numDisscount_ValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(-471, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // btnPayTableBill
            // 
            this.btnPayTableBill.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnPayTableBill.Location = new System.Drawing.Point(1067, 13);
            this.btnPayTableBill.Name = "btnPayTableBill";
            this.btnPayTableBill.Size = new System.Drawing.Size(203, 135);
            this.btnPayTableBill.TabIndex = 7;
            this.btnPayTableBill.Text = "Thanh toán";
            this.btnPayTableBill.UseVisualStyleBackColor = true;
            this.btnPayTableBill.Click += new System.EventHandler(this.btnPayTableBill_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtTotalPrice.Location = new System.Drawing.Point(529, 85);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(397, 40);
            this.txtTotalPrice.TabIndex = 6;
            // 
            // cbbListTable
            // 
            this.cbbListTable.DropDownHeight = 80;
            this.cbbListTable.Font = new System.Drawing.Font("Tahoma", 16F);
            this.cbbListTable.FormattingEnabled = true;
            this.cbbListTable.IntegralHeight = false;
            this.cbbListTable.Location = new System.Drawing.Point(9, 36);
            this.cbbListTable.Name = "cbbListTable";
            this.cbbListTable.Size = new System.Drawing.Size(157, 33);
            this.cbbListTable.TabIndex = 1;
            // 
            // printPreviewBill
            // 
            this.printPreviewBill.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewBill.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewBill.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewBill.Enabled = true;
            this.printPreviewBill.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewBill.Icon")));
            this.printPreviewBill.Name = "printPreviewBill";
            this.printPreviewBill.Visible = false;
            // 
            // PrintBill
            // 
            this.PrintBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintBill_PrintPage);
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTableList);
            this.Name = "frmTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bàn ăn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTable_FormClosing);
            this.Load += new System.EventHandler(this.frmTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDisscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTableList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbbListTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPayTableBill;
        private System.Windows.Forms.ComboBox cbbFoodName;
        private System.Windows.Forms.ComboBox cbbFoodCategory;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.NumericUpDown numDisscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblBillTaleName;
        private System.Windows.Forms.PrintPreviewDialog printPreviewBill;
        private System.Drawing.Printing.PrintDocument PrintBill;
    }
}