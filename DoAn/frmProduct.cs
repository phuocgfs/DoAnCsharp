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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-BJ79796\SQLEXPRESS;Initial Catalog=QLBHDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        void fillcategory()
        {
            string query = "select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Tên loại sản phẩm", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                cbProduct.ValueMember = "Tên loại sản phẩm";
                cbProduct.DataSource = dt;
                cbChon.ValueMember = "Tên loại sản phẩm";
                cbChon.DataSource = dt;
                Con.Close();
            } 
            catch { 
            
            }
        }
        void fillSearchcombobox()
        {
            string query = "select * from CategoryTbl where [Tên loại sản phẩm]='"+cbChon.SelectedValue.ToString()+"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Tên loại sản phẩm", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                cbProduct.ValueMember = "Tên loại sản phẩm";
                cbProduct.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
        }
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gvProduct.DataSource = ds.Tables[0];


                Con.Close();

            }
            catch
            {

            }
        }
        void fillterCategory()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl where[Loại]='"+cbChon.SelectedValue.ToString()+"'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gvProduct.DataSource = ds.Tables[0];


                Con.Close();

            }
            catch
            {

            }
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values('" + txtProductid.Text + "', '" + txtProductName.Text + "', '" + txtProductSL.Text + "', '" + txtProductGia.Text + "', '" + txtProductMota.Text + "', '" + cbProduct.SelectedValue.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them thanh cong");
                Con.Close();
                populate();

            }
            catch
            {

            }
        }

        private void txtProductMota_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtProductid.Text == "")
            {
                MessageBox.Show("Nhap id");
            }
            else
            {
                Con.Open();
                string myquery = "delete from ProductTbl where [ID Sản phẩm]='" + txtProductid.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoa thanh cong");
                txtProductid.Text = "";
                txtProductName.Text = "";
                txtProductSL.Text = "";
                txtProductGia.Text = "";
                txtProductMota.Text = "";
                Con.Close();
                populate();
            }
        }

        private void gvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = gvProduct.Rows[e.RowIndex];
                    txtProductid.Text = row.Cells[0].Value.ToString();
                    txtProductName.Text = row.Cells[1].Value.ToString();
                    txtProductSL.Text = row.Cells[2].Value.ToString();
                    txtProductGia.Text = row.Cells[3].Value.ToString();
                   txtProductMota.Text = row.Cells[4].Value.ToString();
                    cbProduct.SelectedValue = row.Cells[5].Value.ToString();
                }
                else if (e.RowIndex == -1 && gvProduct.Rows.Count > 0)
                {
                    DataGridViewRow firstRow = gvProduct.Rows[0];
                    txtProductid.Text = firstRow.Cells[0].Value.ToString();
                    txtProductName.Text = firstRow.Cells[1].Value.ToString();
                    txtProductSL.Text = firstRow.Cells[2].Value.ToString();
                    txtProductGia.Text = firstRow.Cells[3].Value.ToString();
                    txtProductMota.Text = firstRow.Cells[4].Value.ToString();
                    cbProduct.SelectedValue = firstRow.Cells[5].Value.ToString();

                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string myquery = "UPDATE ProductTbl SET [Tên sản phẩm] = '" + txtProductName.Text + "', [Số lượng] = '" + txtProductSL.Text + "', [Giá] = '" + txtProductGia.Text + "', [Mô tả] = '" + txtProductMota.Text + "', [Loại] = '" + cbProduct.SelectedValue + "' WHERE [ID Sản phẩm] = '" + txtProductid.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công");
                txtProductid.Text = "";
                txtProductName.Text = "";
                txtProductSL.Text = "";
                txtProductGia.Text = "";
                txtProductMota.Text = "";
                cbProduct.SelectedValue = "";
                Con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cbChon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            fillterCategory();
        
        }

        private void txtLamoi_Click(object sender, EventArgs e)
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
