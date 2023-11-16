using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frmViewOrder : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-BJ79796\SQLEXPRESS;Initial Catalog=QLBHDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public frmViewOrder()
        {
            InitializeComponent();
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
        }

        void updateOrder()
        {
            try
            {
                Con.Open();
                string query = "select * from OrderTbl";
                SqlDataAdapter cmd = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(cmd);
                var ds = new DataSet();
                cmd.Fill(ds);
                gvVieworder.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void frmViewOrder_Load(object sender, EventArgs e)
        {
            updateOrder();
        }

        private void btnXemdonhang_Click(object sender, EventArgs e)
        {
            frmOrders or = new frmOrders();
            or.Show();
            this.Hide();
        }

        private void lblThoat_Click(object sender, EventArgs e)
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

        private void gvVieworder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bạn có thể thêm xử lý nếu cần thiết
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Gọi sự kiện in
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                if (gvVieworder.SelectedRows.Count > 0)
                {
                    e.Graphics.DrawString("Id_mua_hang: " + gvVieworder.SelectedRows[0].Cells["Id_mua_hang"].Value?.ToString(), new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new PointF(10, 10));
                    e.Graphics.DrawString("ID_khach_hang: " + gvVieworder.SelectedRows[0].Cells["ID_khach_hang"].Value?.ToString(), new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new PointF(10, 30));
                    e.Graphics.DrawString("Ten_khach_hang: " + gvVieworder.SelectedRows[0].Cells["Ten_khach_hang"].Value?.ToString(), new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new PointF(10, 50));
                    e.Graphics.DrawString("Ngay_mua_hang: " + gvVieworder.SelectedRows[0].Cells["Ngay_mua_hang"].Value?.ToString(), new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new PointF(10, 70));
                    e.Graphics.DrawString("Tong: " + gvVieworder.SelectedRows[0].Cells["Tong"].Value?.ToString(), new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new PointF(10, 90));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in: " + ex.Message);
            }
        }
    }
}
