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
    public partial class frmOrders : Form
    {
        DataTable table = new DataTable();
        int sum = 0;
        public frmOrders()
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
                gvKhachhang.DataSource = ds.Tables[0];


                Con.Close();

            }
            catch
            {

            }
        }
        void populateproduct()
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
        void fillcategory()
        {
            string query = "select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Tên loại sản phẩm", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                //cbProduct.ValueMember = "Tên loại sản phẩm";
                //cbProduct.DataSource = dt;
                cbChon.ValueMember = "Tên loại sản phẩm";
                cbChon.DataSource = dt;
                Con.Close();

            }
            catch
            {

            }
        }
        void updateproduct()
        {
            if (gvProduct.SelectedRows.Count > 0)
            {
                Con.Open();
                int id = Convert.ToInt32(gvProduct.SelectedRows[0].Cells[0].Value.ToString());
                int newQty = stock - Convert.ToInt32(txtQuantity.Text);
                string query = "update ProductTbl set [Số lượng]= " + newQty + " where [ID Sản phẩm] = " + id + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populateproduct();
            }
            else
            {
                
            }
        }

        int so = 0;
        int uprice, totprice, qty;
        string product;
        private void frmOrders_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Số", typeof(int));
            table.Columns.Add("Sản phẩm", typeof(string));
            table.Columns.Add("Số lượng", typeof(int));
            table.Columns.Add("Giá", typeof(int));
            table.Columns.Add("Tổng tiền", typeof(int));

            gvorder.DataSource = table;

            populate();
            populateproduct();
            fillcategory();
            populate();
            populateproduct();
            fillcategory();
            gvProduct.CellClick += new DataGridViewCellEventHandler(gvProduct_CellClick);


        }

        private void txtOrderid_TextChanged(object sender, EventArgs e)
        {

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

        private void cbChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl where[Loại]='" + cbChon.SelectedValue.ToString() + "'";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Nhập số lượng");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Chọn sản phẩm");
            }
            else if(Convert.ToInt32(txtQuantity.Text) > stock)
            {
                MessageBox.Show("Không đủ số lượng vui lòng chọn lại");
            }
            else
            {
                so = so + 1;
                qty = Convert.ToInt32(txtQuantity.Text);
                totprice = qty * uprice;
                table.Rows.Add(so, product, qty, uprice, totprice); 
                gvorder.DataSource = table;

             
                int totalAmount = 0;
                foreach (DataRow row in table.Rows)
                {
                    totalAmount += Convert.ToInt32(row["Tổng tiền"]);
                }


                flag = 0;
            }
            sum += totprice;
           txtVND.Text =sum.ToString()+ "VNĐ";
            updateproduct();
            
        }


        private void gvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = gvKhachhang.Rows[e.RowIndex];
                    txtIdKhachhang.Text = row.Cells[0].Value.ToString();
                    txtTenkhachhang.Text = row.Cells[1].Value.ToString();
                }
                else if (e.RowIndex == -1 && gvKhachhang.Rows.Count > 0)
                {
                    DataGridViewRow firstRow = gvKhachhang.Rows[0];
                    txtIdKhachhang.Text = firstRow.Cells[0].Value.ToString();

                }
            }
        }
        int flag=0;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtOrderid.Text == "" || txtIdKhachhang.Text == "" || txtTenkhachhang.Text == "" || lblTong.Text == "")
            {
                MessageBox.Show("Fill the data Correctly");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO OrderTbl ([Id_mua_hang], [ID_khach_hang], [Ten_khach_hang], [Ngay_mua_hang], [Tong]) VALUES ('" + txtOrderid.Text + "', '" + txtIdKhachhang.Text + "', '" + txtTenkhachhang.Text + "', '" + dtpOrder.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " + sum.ToString() + ")", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Them thanh cong");
                Con.Close();
                //populate();
            }
            try
            {
            }
            catch
            {
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
             frmViewOrder view = new frmViewOrder();
            view.Show();
        }

        private void lblTong_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        
    }

        int stock;
        private void gvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvProduct.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                product = row.Cells[1].Value.ToString();
                stock = Convert.ToInt32(row.Cells[2].Value);
                uprice = Convert.ToInt32(row.Cells[3].Value);
                flag = 1;
                MessageBox.Show($"ID: {id}, Sản phẩm: {product}, Số lượng: {stock}, Giá: {uprice}, Flag: {flag}");
            }
            else if (e.RowIndex == -1 && gvProduct.Rows.Count > 0)
            {
                DataGridViewRow firstRow = gvProduct.Rows[0];
                product = firstRow.Cells[1].Value.ToString();
                uprice = Convert.ToInt32(firstRow.Cells[3].Value);
                flag = 1;
            }
        }



    }
}





