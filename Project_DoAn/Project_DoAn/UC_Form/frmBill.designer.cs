
namespace Project_DoAn.UC_Form
{
    partial class frmBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill));
            this.btnViewBill = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintBill = new System.Drawing.Printing.PrintDocument();
            this.printPreviewBill = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.printDoanhThu = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewBill
            // 
            this.btnViewBill.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnViewBill.Location = new System.Drawing.Point(773, 12);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(215, 46);
            this.btnViewBill.TabIndex = 5;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            this.btnViewBill.Click += new System.EventHandler(this.btnViewBill_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 25F);
            this.btnPrint.Location = new System.Drawing.Point(637, 511);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(351, 77);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "In thống kê";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Tahoma", 25F);
            this.txtTotalPrice.Location = new System.Drawing.Point(320, 526);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(308, 48);
            this.txtTotalPrice.TabIndex = 7;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 28F);
            this.label2.Location = new System.Drawing.Point(9, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng doanh thu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 28F);
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Từ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28F);
            this.label1.Location = new System.Drawing.Point(294, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "đến";
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkToDate.Font = new System.Drawing.Font("Tahoma", 25F);
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkToDate.Location = new System.Drawing.Point(375, 11);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(220, 48);
            this.dtpkToDate.TabIndex = 3;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkFromDate.Font = new System.Drawing.Font("Tahoma", 25F);
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkFromDate.Location = new System.Drawing.Point(74, 11);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(223, 48);
            this.dtpkFromDate.TabIndex = 2;
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvBill.Location = new System.Drawing.Point(10, 71);
            this.dgvBill.Name = "dgvBill";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.Size = new System.Drawing.Size(978, 434);
            this.dgvBill.TabIndex = 9;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BillId";
            this.Column1.FillWeight = 97.18029F;
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DateCreated";
            this.Column7.FillWeight = 121.8274F;
            this.Column7.HeaderText = "Ngày tạo hóa đơn";
            this.Column7.Name = "Column7";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "EmployeeName";
            this.Column2.FillWeight = 112.5951F;
            this.Column2.HeaderText = "Người tạo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TableName";
            this.Column3.FillWeight = 68.8362F;
            this.Column3.HeaderText = "Bàn";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Discount";
            this.Column4.FillWeight = 86.96578F;
            this.Column4.HeaderText = "Giảm giá(%)";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TotalPriceWithDiscount";
            this.Column5.FillWeight = 112.5951F;
            this.Column5.HeaderText = "Tổng tiền";
            this.Column5.Name = "Column5";
            // 
            // PrintBill
            // 
            this.PrintBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintBill_PrintPage);
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
            // btnPrintBill
            // 
            this.btnPrintBill.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnPrintBill.Location = new System.Drawing.Point(601, 12);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(166, 46);
            this.btnPrintBill.TabIndex = 4;
            this.btnPrintBill.Text = "In hóa đơn";
            this.btnPrintBill.UseVisualStyleBackColor = true;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // printDoanhThu
            // 
            this.printDoanhThu.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoanhThu_PrintPage);
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewBill);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.dtpkToDate);
            this.Controls.Add(this.dtpkFromDate);
            this.Controls.Add(this.txtTotalPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBill";
            this.Text = "frmBill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewBill;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Drawing.Printing.PrintDocument PrintBill;
        private System.Windows.Forms.PrintPreviewDialog printPreviewBill;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Drawing.Printing.PrintDocument printDoanhThu;
    }
}