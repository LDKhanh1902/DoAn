
namespace Project_DoAn
{
    partial class frmManager
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnShowEmployee = new System.Windows.Forms.Button();
            this.btnShowBill = new System.Windows.Forms.Button();
            this.btnShowMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlBody.Location = new System.Drawing.Point(183, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1000, 600);
            this.pnlBody.TabIndex = 1;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.BackgroundImage = global::Project_DoAn.Properties.Resources.QLTK;
            this.btnShowAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowAccount.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnShowAccount.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnShowAccount.Location = new System.Drawing.Point(2, 462);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(175, 138);
            this.btnShowAccount.TabIndex = 1;
            this.btnShowAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnShowEmployee
            // 
            this.btnShowEmployee.BackgroundImage = global::Project_DoAn.Properties.Resources.QLNV;
            this.btnShowEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowEmployee.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnShowEmployee.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnShowEmployee.Location = new System.Drawing.Point(2, 308);
            this.btnShowEmployee.Name = "btnShowEmployee";
            this.btnShowEmployee.Size = new System.Drawing.Size(175, 148);
            this.btnShowEmployee.TabIndex = 1;
            this.btnShowEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowEmployee.UseVisualStyleBackColor = true;
            this.btnShowEmployee.Click += new System.EventHandler(this.btnShowEmployee_Click);
            // 
            // btnShowBill
            // 
            this.btnShowBill.BackgroundImage = global::Project_DoAn.Properties.Resources.QLBill;
            this.btnShowBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowBill.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnShowBill.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnShowBill.Location = new System.Drawing.Point(2, 154);
            this.btnShowBill.Name = "btnShowBill";
            this.btnShowBill.Size = new System.Drawing.Size(175, 148);
            this.btnShowBill.TabIndex = 1;
            this.btnShowBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowBill.UseVisualStyleBackColor = true;
            this.btnShowBill.Click += new System.EventHandler(this.btnShowBill_Click);
            // 
            // btnShowMenu
            // 
            this.btnShowMenu.BackgroundImage = global::Project_DoAn.Properties.Resources.QLMenu;
            this.btnShowMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowMenu.Font = new System.Drawing.Font("Tahoma", 20F);
            this.btnShowMenu.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnShowMenu.Location = new System.Drawing.Point(2, 0);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.Size = new System.Drawing.Size(175, 148);
            this.btnShowMenu.TabIndex = 1;
            this.btnShowMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowMenu.UseVisualStyleBackColor = true;
            this.btnShowMenu.Click += new System.EventHandler(this.btnShowMenu_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 601);
            this.Controls.Add(this.btnShowAccount);
            this.Controls.Add(this.btnShowEmployee);
            this.Controls.Add(this.btnShowBill);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.btnShowMenu);
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManager_FormClosing);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnShowMenu;
        private System.Windows.Forms.Button btnShowBill;
        private System.Windows.Forms.Button btnShowEmployee;
    }
}

