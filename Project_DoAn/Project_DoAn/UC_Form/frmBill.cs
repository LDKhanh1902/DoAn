using Project_DoAn.DAO;
using Menu = Project_DoAn.DTO.Menu;
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

namespace Project_DoAn.UC_Form
{
    public partial class frmBill : Form
    {
        private int billId = 0;
        private string tableName = "";
        private float discount = 0;

        public frmBill()
        {
            InitializeComponent();
            LoadListBill();
            
        }
        void LoadListBill()
        {
            dgvBill.DataSource = BillDAO.Instance.GetListBill();
            CalculateTotal();
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            dgvBill.DataSource = BillDAO.Instance.GetListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            CalculateTotal();
        }
        private void CalculateTotal()
        {
            double totalPrice = 0;
            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                if (row.IsNewRow)
                    continue;

                double totalPerBill = Convert.ToDouble(row.Cells[dgvBill.Columns.Count - 1].Value);
                totalPrice += totalPerBill;
            }

            txtTotalPrice.Text = totalPrice.ToString();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {

        }

        private void PrintBill_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font font = new System.Drawing.Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            string text = "Hóa đơn bàn " + tableName;
            SizeF textSize = e.Graphics.MeasureString(text, font);

            float x = (e.PageBounds.Width - textSize.Width) / 2;

            e.Graphics.DrawString(text, font, Brushes.Black, x, 100);

            System.Drawing.Font tableFont = new System.Drawing.Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Point);
            Pen blackPen = new Pen(System.Drawing.Color.Black, 1); // Độ dày 1 cho gạch ngang
            string currentDate = DateTime.Now.ToString("dd/MM/yyyy");
            System.Drawing.Font dateAndIdFont = new System.Drawing.Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Point);
            // Mã hóa đơn
            string BillId = "Mã hóa đơn: " + billId.ToString();

            // Vẽ ngày tháng năm và mã hóa đơn
            e.Graphics.DrawString(currentDate, dateAndIdFont, Brushes.Black, 0, 50); // Vẽ ngày tháng năm ở bên trái
            e.Graphics.DrawString(BillId, dateAndIdFont, Brushes.Black, e.PageBounds.Width - e.Graphics.MeasureString(BillId, dateAndIdFont).Width, 50); // Vẽ mã hóa đơn ở bên phải
            int startY = 200;
            int columnWidth = e.PageBounds.Width / 5;

            // Vẽ đường kẻ ngang ngay dưới tiêu đề cột
            e.Graphics.DrawLine(blackPen, 0, startY, e.PageBounds.Width, startY);

            string[] headers = { "Tên món", "Số lượng", "Giá", "Tổng giá" };
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(headers[i], tableFont, Brushes.Black, (i) * columnWidth + 150, startY);
            }
            e.Graphics.DrawLine(blackPen, 0, startY + 35, e.PageBounds.Width, startY + 35);
            List<Menu> lstBillDetails = MenuDAO.Instance.GetListMenuByBill(billId);

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

            float discountedPrice = totalprice - (totalprice * (discount / 100.0f));

            e.Graphics.DrawString("Tổng tiền  : " + totalprice.ToString(), tableFont, Brushes.Black, 2 * columnWidth + 150, startY + y * 35);
            y++;
            e.Graphics.DrawString(string.Format("Giảm giá   : {0} %", discount.ToString()), tableFont, Brushes.Black, 2 * columnWidth + 150, startY + y * 35);
            y++;
            e.Graphics.DrawString("Thành tiền : " + discountedPrice.ToString(), tableFont, Brushes.Black, 2 * columnWidth + 150, startY + y * 35);

        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            printPreviewBill.Document = PrintBill;
            printPreviewBill.ShowDialog();
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBill.Rows[e.RowIndex];
                billId = (int)row.Cells[0].Value;
                tableName = row.Cells[3].Value.ToString();
                discount = (float)Convert.ToDouble(row.Cells[4].Value.ToString());
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewBill.Document = printDoanhThu;
            printPreviewBill.ShowDialog();
        }

        private void printDoanhThu_PrintPage(object sender, PrintPageEventArgs e)
        {
                // Tạo font và brush
                Font font = new Font("Arial", 20);
                SolidBrush brush = new SolidBrush(Color.Black);

                // Tạo vị trí cho các dòng
                float lineHeight = font.GetHeight();
                float y = 0;

                // Dòng đầu tiên
                string line1 = "Báo cáo doanh thu tháng "+dtpkFromDate.Value.Month;
                float x = (e.PageBounds.Width - e.Graphics.MeasureString(line1, font).Width) / 2;
                e.Graphics.DrawString(line1, font, brush, x, y);
                y += lineHeight;

                // Dòng thứ hai
                string line2 = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                x = (e.PageBounds.Width - e.Graphics.MeasureString(line2, font).Width) / 2;
                e.Graphics.DrawString(line2, font, brush, x, y);
                y += lineHeight;

                // Dòng thứ ba
                string line3 = "Tổng doanh thu tháng "+dtpkFromDate.Value.Month+":"+txtTotalPrice.Text+" (Nghìn đồng)";
                x = (e.PageBounds.Width - e.Graphics.MeasureString(line3, font).Width) / 2;
                e.Graphics.DrawString(line3, font, brush, x, y);
            
        }
    }
}
