using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            {
                {
                    {
                        DialogResult result = MessageBox.Show(
                            "Bạn muốn thoát?",
                            "Thông báo",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                            );
                        if (result == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();
            product.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmUser user = new frmUser();
            user.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           frmCategories cte = new frmCategories();
            cte.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmCustomer cus = new frmCustomer();
            cus.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmOrders ord = new frmOrders();
            ord.Show();
            this.Hide();
        }

        private void btnDãnguat_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
