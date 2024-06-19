using Project_DoAn.DAO;
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
    public partial class frmLuaChonQL : Form
    {
        public frmLuaChonQL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmManager().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmTable().ShowDialog();
        }
    }
}
