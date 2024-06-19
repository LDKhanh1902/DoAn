using Project_DoAn.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = Project_DoAn.DTO.Menu;

namespace Project_DoAn
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {

        }

        private void previewButton_Click(object sender, EventArgs e)
        {

        }


        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            System.Drawing.Font font = new System.Drawing.Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Point);
            string text = "Hóa đơn bàn ";
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
            e.Graphics.DrawLine(blackPen, 0, startY + 35, e.PageBounds.Width, startY + 35);
            List<Menu> lstBillDetails = MenuDAO.Instance.GetListMenuByTable(1);

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
            float discount = (float)BillDAO.Instance.GetDiscount(BillDAO.Instance.GetBillID(1));
            float discountedPrice = totalprice - (totalprice * (discount / 100.0f));

            e.Graphics.DrawString("Tổng tiền  : " + totalprice.ToString(), tableFont, Brushes.Black, 2 * columnWidth + 150, startY + y * 35);
            y++;
            e.Graphics.DrawString(string.Format("Giảm giá   : {0} %", discount.ToString()), tableFont, Brushes.Black, 2 * columnWidth + 150, startY + y * 35);
            y++;
            e.Graphics.DrawString("Thành tiền : " + discountedPrice.ToString(), tableFont, Brushes.Black, 2 * columnWidth + 150, startY + y * 35);

        }



        private void Button1_Click(object sender, EventArgs e)
        {
                PrintDialog printDialog = new PrintDialog();
                PrintPreviewDialog printPreview = new PrintPreviewDialog();
                printPreview.Document = printDocument1;
                printPreview.ShowDialog();
        }

    }
}
