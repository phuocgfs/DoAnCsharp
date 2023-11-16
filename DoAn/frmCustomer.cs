using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DoAn
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-BJ79796\SQLEXPRESS;Initial Catalog=QLBHDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gvCustomer.DataSource = ds.Tables[0];


                Con.Close();

            }
            catch
            {

            }
        }
        private void lblThoat_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show(
                    "Ban muon thoat",
                    "Thong bao",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                if (!IsValidPhoneNumber(txtCustomerphone.Text))
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số và không có ký tự đặc biệt.");
                    Con.Close();
                    return;
                }

                if (!IsValidName(txtCustomername.Text))
                {
                    MessageBox.Show("Tên không được chứa ký tự đặc biệt.");
                    Con.Close();
                    return;
                }

                SqlCommand cmd = new SqlCommand("insert into CustomerTbl values('" + txtCustomerid.Text + "', '" + txtCustomername.Text + "', '" + txtCustomerphone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length == 10;
        }

        private bool IsValidName(string name)
        {
            return name.All(char.IsLetterOrDigit) && !name.Any(char.IsPunctuation);
        }


        private void frmCustomer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "UPDATE CustomerTbl SET [TEN KHACH HANG] = '" + txtCustomername.Text + "', [SDT KHACH HANG] = '" + txtCustomerphone.Text + "' WHERE IDKH = '" + txtCustomerid.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                txtCustomerid.Text = "";
                txtCustomername.Text = "";
                txtCustomerphone.Text = "";
                Con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtCustomerid.Text == "")
            {
                MessageBox.Show("Nhap id");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CustomerTbl where IDKH='" + txtCustomerid.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoa thanh cong");
                txtCustomerid.Text = "";
                txtCustomername.Text = "";
                txtCustomerphone.Text = "";
                Con.Close();
                populate();
            }
        }

        private void gvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = gvCustomer.Rows[e.RowIndex];
                    txtCustomerid.Text = row.Cells[0].Value.ToString();
                    txtCustomername.Text = row.Cells[1].Value.ToString();
                    txtCustomerphone.Text = row.Cells[2].Value.ToString();

                    Con.Open();

                    // Sửa lỗi dấu ngoặc vuông và thêm tham số
                    SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from OrderTbl where [ID_khach_hang] = @IdKhachHang", Con);
                    sda.SelectCommand.Parameters.AddWithValue("@IdKhachHang", txtCustomerid.Text);

                    SqlDataAdapter sda1 = new SqlDataAdapter("select Sum([Tong]) from OrderTbl where [ID_khach_hang] = @IdKhachHang", Con);
                    sda1.SelectCommand.Parameters.AddWithValue("@IdKhachHang", txtCustomerid.Text);

                    SqlDataAdapter sda2 = new SqlDataAdapter("select Max([Ngay_mua_hang]) from OrderTbl where [ID_khach_hang] = @IdKhachHang", Con);
                    sda2.SelectCommand.Parameters.AddWithValue("@IdKhachHang", txtCustomerid.Text);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    lblOrder.Text = dt.Rows[0][0].ToString();

                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    lblAmount.Text = dt1.Rows[0][0].ToString();

                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                    lblNgaymua.Text = dt2.Rows[0][0].ToString();
                }
                else if (e.RowIndex == -1 && gvCustomer.Rows.Count > 0)
                {
                    DataGridViewRow firstRow = gvCustomer.Rows[0];
                    txtCustomerid.Text = firstRow.Cells[0].Value.ToString();
                    txtCustomername.Text = firstRow.Cells[1].Value.ToString();
                    txtCustomerphone.Text = firstRow.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOrder_Click(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblNgaymua_Click(object sender, EventArgs e)
        {

        }
    }
}
