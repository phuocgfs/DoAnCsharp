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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-BJ79796\SQLEXPRESS;Initial Catalog=QLBHDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CategoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gvCategories.DataSource = ds.Tables[0];


                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-BJ79796\SQLEXPRESS;Initial Catalog=QLBHDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    Con.Open();

        
                    string checkQuery = "SELECT Id FROM CategoryTbl WHERE Id = @Id";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, Con))
                    {
                        checkCmd.Parameters.AddWithValue("@Id", txtCategoriesid.Text);
                        object result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                        
                            MessageBox.Show("ID đã tồn tại .");
                        }
                        else
                        {
                          
                            checkCmd.Dispose(); // Giải phóng tài nguyên Command
                            SqlCommand insertCmd = new SqlCommand("INSERT INTO CategoryTbl (Id, [Tên loại sản phẩm]) VALUES (@Id, @CategoryName)", Con);
                            insertCmd.Parameters.AddWithValue("@Id", txtCategoriesid.Text);
                            insertCmd.Parameters.AddWithValue("@CategoryName", txtCategoriesname.Text);
                            insertCmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm thành công");
                            txtCategoriesid.Text = "";
                            txtCategoriesname.Text = "";
                            populate();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void gvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvCategories.Rows[e.RowIndex];
                txtCategoriesid.Text = row.Cells[0].Value.ToString();
                txtCategoriesname.Text = row.Cells[1].Value.ToString();
                
            }
            else if (e.RowIndex == -1 && gvCategories.Rows.Count > 0)
            {
                DataGridViewRow firstRow = gvCategories.Rows[0];
                txtCategoriesid.Text = firstRow.Cells[0].Value.ToString();
                txtCategoriesname.Text = firstRow.Cells[1].Value.ToString();
                
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtCategoriesid.Text == "")
            {
                MessageBox.Show("Nhap id");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CategoryTbl where Id='" + txtCategoriesid.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoa thanh cong");
                txtCategoriesid.Text = "";
               txtCategoriesname.Text = "";
              
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "UPDATE CategoryTbl SET [Tên loại sản phẩm] = '" + txtCategoriesname.Text + "'WHERE Id = '" + txtCategoriesid.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                txtCategoriesid.Text = "";
                txtCategoriesname.Text = "";
                Con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }
    }
}
