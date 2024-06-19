using Project_DoAn.DAO;
using Project_DoAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = Project_DoAn.DTO.Menu;

namespace Project_DoAn
{
    public partial class frmTable : Form
    {
        // Định nghĩa kích thước và ID của bàn
        private int tableWidth = 170;
        private int tableHeight = 170;
        private int tableId;

        // Hàm khởi tạo
        public frmTable()
        {
            InitializeComponent();
        }
        #region Method
        // Sự kiện khi form được tải
        private void frmTable_Load(object sender, EventArgs e)
        {
            loadTable(); // Tải bàn
            // Đặt nguồn dữ liệu và hiển thị thành viên cho hộp combo danh mục thực phẩm
            cbbFoodCategory.DataSource = CategoryDAO.Instance.GetListCategory();
            cbbFoodCategory.DisplayMember = "CategoryName";

            cbbListTable.DataSource = TableDAO.Instance.GetLoadListTable();
            cbbListTable.DisplayMember = "TableName";
        }

        // Xử lý sự kiện thay đổi lựa chọn danh mục thực phẩm
        private void cbbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Đặt nguồn dữ liệu và hiển thị thành viên cho hộp combo tên thực phẩm
            cbbFoodName.DataSource = FoodDAO.Instance.GetListFoodByCategory(cbbFoodCategory.Text);
            cbbFoodName.DisplayMember = "FOOD_NAME";
        }

        // Xử lý sự kiện thay đổi lựa chọn tên thực phẩm
        private void cbbFoodName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy danh sách thực phẩm theo danh mục
            DataTable dt = FoodDAO.Instance.GetListFoodByCategory(cbbFoodCategory.Text);
            foreach (DataRow row in dt.Rows)
            {
                if (row["FOOD_NAME"].ToString() == cbbFoodName.Text)
                {
                    txtPrice.Text = row["PRICE"].ToString();
                    break;
                }
            }
        }

        // Xử lý sự kiện thay đổi lựa chọn hóa đơn
        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvBill.SelectedItems[0];

                cbbFoodName.Text = item.Text;
                numQuantity.Value = int.Parse(item.SubItems[1].Text);
            }
        }

        // Phương thức để tải bàn
        public void loadTable()
        {
            flpTableList.Controls.Clear(); // Xóa tất cả các điều khiển hiện tại
                                           // Lấy danh sách bàn từ cơ sở dữ liệu
            List<Table> tableList = TableDAO.Instance.GetLoadListTable();
            if (tableList == null) return; // Kiểm tra xem danh sách bàn có null không
                                           // Duyệt qua từng bàn
            foreach (Table item in tableList)
            {
                // Tạo một nút mới
                Button btn = new Button()
                {
                    Width = tableWidth, // Đặt chiều rộng
                    Height = tableHeight, // Đặt chiều cao
                    Text = item.TableName, // Đặt văn bản hiển thị
                    Tag = item // Đặt thẻ
                };
                btn.Click += btn_Click; // Thêm sự kiện nhấp
                                        // Đặt màu nền tương ứng với trạng thái
                switch (item.Status)
                {
                    case 1:
                        btn.BackColor = Color.Aqua;
                        break;
                    case -1:
                        btn.BackColor = Color.Red;
                        break;
                    default:
                        btn.BackColor = Color.Yellow;
                        break;
                }
                flpTableList.Controls.Add(btn); // Thêm nút vào bảng điều khiển
            }
        }

        public void UpdateTable(FlowLayoutPanel flpnl)
        {
            // Lấy danh sách bàn từ cơ sở dữ liệu
            List<Table> tableList = TableDAO.Instance.GetLoadListTable();
            if (tableList == null) return; // Kiểm tra xem danh sách bàn có null không

            // Duyệt qua từng nút trong FlowLayoutPanel
            foreach (Control control in flpnl.Controls)
            {
                Button btn = control as Button;
                if (btn != null)
                {
                    foreach (Table table in tableList)
                    {
                        // Kiểm tra xem nút hiện tại có tương ứng với bàn nào trong danh sách không
                        if (btn.Text == table.TableName)
                        {
                            // Cập nhật màu nền của nút tương ứng với trạng thái của bàn
                            switch (table.Status)
                            {
                                case 1:
                                    btn.BackColor = Color.Aqua;
                                    break;
                                case -1:
                                    btn.BackColor = Color.Red;
                                    break;
                                default:
                                    btn.BackColor = Color.Yellow;
                                    break;
                            }

                            // Thoát khỏi vòng lặp sau khi đã tìm thấy và cập nhật nút
                            break;
                        }
                    }
                }
            }
        }

        // Phương thức để hiển thị hóa đơn
        private void ShowBill(int id)
        {
            // Lấy danh sách menu theo bàn
            List<Menu> lstBill = MenuDAO.Instance.GetListMenuByTable(id);

            int totalPrice = 0; // Tổng giá
            lsvBill.Items.Clear(); // Xóa tất cả các mục trong danh sách xem hóa đơn

            // Duyệt qua từng mục menu
            foreach (Menu menu in lstBill)
            {
                // Tạo một mục mới cho danh sách xem
                ListViewItem lsvItem = new ListViewItem(menu.FoodName);
                lsvItem.SubItems.Add(menu.Quantity.ToString()); // Thêm số lượng
                lsvItem.SubItems.Add(menu.Price.ToString()); // Thêm giá
                lsvItem.SubItems.Add(menu.TotalPrice.ToString()); // Thêm tổng giá

                lsvBill.Items.Add(lsvItem); // Thêm mục vào danh sách xem
                totalPrice += int.Parse(menu.TotalPrice.ToString()); // Cộng dồn tổng giá
            }
            CultureInfo culture = new CultureInfo("vi-VN"); // Tạo một đối tượng văn hóa mới
            txtTotalPrice.Text = totalPrice.ToString();
        }

        public void PrintDetails(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font font = new System.Drawing.Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            string text = "Hóa đơn bàn " + tableId.ToString();
            SizeF textSize = e.Graphics.MeasureString(text, font);

            float x = (e.PageBounds.Width - textSize.Width) / 2;

            e.Graphics.DrawString(text, font, Brushes.Black, x, 100);

            System.Drawing.Font tableFont = new System.Drawing.Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Point);
            Pen blackPen = new Pen(System.Drawing.Color.Black, 1); // Độ dày 1 cho gạch ngang

            int startY = 200;
            int columnWidth = e.PageBounds.Width / 5;

            // Vẽ đường kẻ ngang ngay dưới tiêu đề cột
            e.Graphics.DrawLine(blackPen, 0, startY, e.PageBounds.Width, startY);

            string[] headers = { "Tên món", "Số lượng", "Giá", "Tổng giá" };
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], tableFont, Brushes.Black, (i) * columnWidth + 150, startY);
            }

            List<Menu> lstBillDetails = MenuDAO.Instance.GetListMenuByTable(10);

            int totalprice = 0;
            int y = 1;

            foreach (Menu item in lstBillDetails)
            {
                e.Graphics.DrawString(item.FoodName, tableFont, Brushes.Black, 0 * columnWidth + 150, startY + y * 35);
                e.Graphics.DrawString(item.Quantity.ToString(), tableFont, Brushes.Black, 1 * columnWidth + 150, startY + y * 35);
                e.Graphics.DrawString(item.Price.ToString(), tableFont, Brushes.Black, 2 * columnWidth + 150, startY + y * 36);
                e.Graphics.DrawString(item.TotalPrice.ToString(), tableFont, Brushes.Black, 3 * columnWidth + 150, startY + y * 35);
                y++;
                totalprice += item.TotalPrice;
            }

            // Vẽ đường kẻ ngang ngay dưới tổng tiền
            e.Graphics.DrawLine(blackPen, 0, startY + y * 35, e.PageBounds.Width, startY + y * 35);
            y++;

            // Vẽ dòng ngăn cách giữa tiêu đề và dữ liệu
            e.Graphics.DrawLine(blackPen, 0, startY + y * 35, e.PageBounds.Width, startY + y * 35);
            y++;

            e.Graphics.DrawString("Tổng tiền  : " + totalprice.ToString(), tableFont, Brushes.Black, 2 * columnWidth + 150, startY + y * 35);
            y++;
            e.Graphics.DrawString("Giảm giá   : " + totalprice.ToString(), tableFont, Brushes.Black, 2 * columnWidth + 150, startY + y * 35);
            y++;
            e.Graphics.DrawString("Thành tiền : " + totalprice.ToString(), tableFont, Brushes.Black, 2 * columnWidth + 150, startY + y * 35);
        }
        #endregion

        #region Event

        // Xử lý sự kiện nhấp chuột vào nút
        private void btn_Click(object sender, EventArgs e)
        {
            // Lấy ID bàn từ thẻ của nút
            int tableID = ((sender as Button).Tag as Table).TableId;
            ShowBill(tableID); // Hiển thị hóa đơn của bàn
            tableId = tableID; // Lưu ID bàn
            lblBillTaleName.Text = string.Format("Bàn {0}",tableId);
        }

        // Xử lý sự kiện nhấp vào nút thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {                   
                // Nếu số lượng là 0, không làm gì cả
                if (numQuantity.Value == 0)
                {
                    MessageBox.Show("Vui lòng chọn số lượng món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Lấy ID nhân viên
                    int employeeId = AccountDAO.Instance.GetEmployeeID;
                    int billId;
                    // Lấy ID thực phẩm từ tên thực phẩm
                    int foodId = FoodDAO.Instance.GetFoodId(cbbFoodName.Text);

                    // Kiểm tra xem bàn có hóa đơn chưa
                    if (BillDAO.Instance.CheckIsBill(tableId) == 1)
                    {
                        // Lấy ID hóa đơn của bàn
                        billId = BillDAO.Instance.GetBillID(tableId);

                        // Kiểm tra xem hóa đơn đã có chi tiết hóa đơn với thực phẩm này chưa
                        if (BillDetailsDAO.Instance.CheckIsBillDetails(billId, foodId) == 1)
                        {
                            // Lấy số lượng thực phẩm hiện tại trong chi tiết hóa đơn
                            int quantity = BillDetailsDAO.Instance.GetQuantity(billId, foodId);
                            // Cập nhật số lượng thực phẩm trong chi tiết hóa đơn
                            BillDetailsDAO.Instance.UpdateQuantityFoodInBillDetails(billId, foodId, (int)numQuantity.Value + quantity);
                        }
                        else
                        {
                            // Thêm chi tiết hóa đơn mới với thực phẩm và số lượng
                            BillDetailsDAO.Instance.InsertBillDetails(billId, foodId, (int)numQuantity.Value);
                        }
                    }
                    else
                    {
                        // Tạo hóa đơn mới cho bàn
                        billId = BillDAO.Instance.InsertBill(employeeId, tableId);
                        // Thêm chi tiết hóa đơn mới với thực phẩm và số lượng
                        BillDetailsDAO.Instance.InsertBillDetails(billId, foodId, (int)numQuantity.Value);
                        if (TableDAO.Instance.UpdateTableStatus(tableId, 1) == 0)
                        {
                            MessageBox.Show("Thêm món ăn không thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    // Hiển thị lại hóa đơn
                    UpdateTable(flpTableList);
                    ShowBill(tableId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi vui lòng kiểm tra lại thông tin món");
            }

        }

        // Xử lý sự kiện nhấp vào nút xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy ID hóa đơn của bàn
                int billId = BillDAO.Instance.GetBillID(tableId);
                // Lấy ID thực phẩm từ tên thực phẩm
                int foodId = FoodDAO.Instance.GetFoodId(cbbFoodName.Text);
                // Lấy số lượng thực phẩm hiện tại trong chi tiết hóa đơn
                int quantity = BillDetailsDAO.Instance.GetQuantity(billId, foodId);
                if(quantity != 0)
                {
                    // Nếu số lượng sau khi trừ đi là 0 hoặc nhỏ hơn
                    if (quantity - (int)numQuantity.Value <= 0)
                    {
                        // Xóa thực phẩm khỏi chi tiết hóa đơn
                        BillDetailsDAO.Instance.DeleteFoodInBillDetails(billId, foodId);
                    }
                    else
                    {
                        // Cập nhật số lượng thực phẩm trong chi tiết hóa đơn
                        BillDetailsDAO.Instance.UpdateQuantityFoodInBillDetails(billId, foodId, quantity - (int)numQuantity.Value);
                    }
                }
                else
                    MessageBox.Show("Vui lòng chọn món ăn cần xóa","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Hiển thị lại hóa đơn
                ShowBill(tableId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa ","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            int tableNewId = TableDAO.Instance.GetTableId(cbbListTable.Text);
            int employeeId = AccountDAO.Instance.GetEmployeeID;

            if(tableNewId == tableId)
            {
                MessageBox.Show("Vui lòng chọn bàn mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int result = 0;

            // Kiểm tra trạng thái của bàn mới
            int newTableStatus = TableDAO.Instance.GetTableStatus(cbbListTable.Text);
            if (newTableStatus == 1)
            {
                // Chuyển bàn khi bàn mới đã có người
                result = TableDAO.Instance.SwitchTableWhenOccupied(tableId, tableNewId, employeeId);
            }
            else
            {
                // Chuyển bàn khi bàn mới trống
                result = TableDAO.Instance.SwitchTableWhenEmpty(tableId, tableNewId, employeeId);
            }
            if(result > 0)
            {
                // Cập nhật trạng thái của bàn cũ thành trống
                TableDAO.Instance.UpdateTableStatus(tableId, 0);
                // Cập nhật trạng thái của bàn mới thành có người
                TableDAO.Instance.UpdateTableStatus(tableNewId, 1);
                // Cập nhật lại danh sách bàn và hiển thị hóa đơn cho bàn mới
                UpdateTable(flpTableList);
                ShowBill(tableNewId);

                // Cập nhật ID bàn hiện tại
                tableId = tableNewId;
                lblBillTaleName.Text = string.Format("Bàn {0}", tableId);
            }
            else
            {
                MessageBox.Show("Vui lòng thực hiện lại!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            
        }

        private void btnPayTableBill_Click(object sender, EventArgs e)
        {
            if (lsvBill.Items.Count>0)
            {
                int billid = BillDAO.Instance.GetBillID(tableId);
                BillDAO.Instance.UpdateDiscount((int)numDisscount.Value, billid);
                DialogResult result = MessageBox.Show(string.Format("Bạn có muốn thanh toán bàn {0}",tableId),"Thông bán",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                if(result == DialogResult.Yes) 
                {
                    PrintPreviewDialog printPreview = new PrintPreviewDialog();
                    printPreview.Document = PrintBill;
                    printPreview.ShowDialog();

                    if (BillDAO.Instance.PayTableBill(tableId) > 0)
                    {
                        MessageBox.Show(string.Format("Thanh toán bàn {0} thành công!",tableId),"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Cập nhật trạng thái của bàn thành trống
                    TableDAO.Instance.UpdateTableStatus(tableId, 0);
                    UpdateTable(flpTableList);
                    ShowBill(tableId);
                }    
            }
            else
                MessageBox.Show("Vui lòng kiểm tra lại bàn muốn thanh toán", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

        }

        private void PrintBill_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font font = new System.Drawing.Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            string text = "Hóa đơn bàn " + tableId.ToString();
            SizeF textSize = e.Graphics.MeasureString(text, font);

            float x = (e.PageBounds.Width - textSize.Width) / 2;

            e.Graphics.DrawString(text, font, Brushes.Black, x, 100);

            System.Drawing.Font tableFont = new System.Drawing.Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Point);
            Pen blackPen = new Pen(System.Drawing.Color.Black, 1); // Độ dày 1 cho gạch ngang

            int startY = 200;
            int columnWidth = e.PageBounds.Width / 5;

            // Vẽ đường kẻ ngang ngay dưới tiêu đề cột
            e.Graphics.DrawLine(blackPen, 0, startY, e.PageBounds.Width, startY);

            string[] headers = { "Tên món", "Số lượng", "Giá", "Tổng giá" };
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], tableFont, Brushes.Black, (i) * columnWidth + 150, startY);
            }
            e.Graphics.DrawLine(blackPen, 0, startY+35, e.PageBounds.Width, startY+35);
            List<Menu> lstBillDetails = MenuDAO.Instance.GetListMenuByTable(tableId);

            int totalprice = 0;
            int y = 1;

            foreach (Menu item in lstBillDetails)
            {
                e.Graphics.DrawString(item.FoodName, tableFont, Brushes.Black, 0 * columnWidth + 150, startY + y * 35);
                e.Graphics.DrawString(item.Quantity.ToString(), tableFont, Brushes.Black, 1 * columnWidth + 150, startY + y * 35);
                e.Graphics.DrawString(item.Price.ToString(), tableFont, Brushes.Black, 2 * columnWidth + 150, startY + y * 36);
                e.Graphics.DrawString(item.TotalPrice.ToString(), tableFont, Brushes.Black, 3 * columnWidth + 150, startY + y * 35);
                y++;
                totalprice += item.TotalPrice;
            }

            // Vẽ đường kẻ ngang ngay dưới tổng tiền
            e.Graphics.DrawLine(blackPen, 0, startY + y * 35, e.PageBounds.Width, startY + y * 35);
            y++;

            // Vẽ dòng ngăn cách giữa tiêu đề và dữ liệu
            
            y++;
            float discount = (float)BillDAO.Instance.GetDiscount(BillDAO.Instance.GetBillID(tableId));
            float discountedPrice = totalprice - (totalprice * (discount / 100.0f));

            e.Graphics.DrawString("Tổng tiền  : " + totalprice.ToString(), tableFont, Brushes.Black, 2 * columnWidth + 150, startY + y * 35);
            y++;
            e.Graphics.DrawString(string.Format("Giảm giá   : {0} %",discount.ToString()), tableFont, Brushes.Black, 2 * columnWidth + 150, startY + y * 35);
            y++;
            e.Graphics.DrawString("Thành tiền : " + discountedPrice.ToString(), tableFont, Brushes.Black, 2 * columnWidth + 150, startY + y * 35);
            
        }

        private void numDisscount_ValueChanged(object sender, EventArgs e)
        {
            double total = 0;
            for (int i = 0; i < lsvBill.Items.Count; i++)
            {
                total += double.Parse(lsvBill.Items[i].SubItems[3].Text);
            }
            txtTotalPrice.Text = ((int)total - (int)total *(int)numDisscount.Value* 1 / 100).ToString();
        }

        private void frmTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        
    }
}
