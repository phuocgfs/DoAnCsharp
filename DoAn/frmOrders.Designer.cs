namespace DoAn
{
    partial class frmOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThoat = new System.Windows.Forms.Label();
            this.gvSanpham = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gvKhachhang = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdKhachhang = new System.Windows.Forms.TextBox();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbChon = new System.Windows.Forms.ComboBox();
            this.gvProduct = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenkhachhang = new System.Windows.Forms.TextBox();
            this.gvorder = new System.Windows.Forms.DataGridView();
            this.lblTong = new System.Windows.Forms.Label();
            this.txtVND = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnXemdonhang = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvorder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.lblThoat);
            this.panel1.Controls.Add(this.gvSanpham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 100);
            this.panel1.TabIndex = 3;
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoat.ForeColor = System.Drawing.Color.White;
            this.lblThoat.Location = new System.Drawing.Point(1195, 9);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(46, 49);
            this.lblThoat.TabIndex = 1;
            this.lblThoat.Text = "X";
            this.lblThoat.Click += new System.EventHandler(this.lblThoat_Click);
            // 
            // gvSanpham
            // 
            this.gvSanpham.AutoSize = true;
            this.gvSanpham.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSanpham.ForeColor = System.Drawing.Color.White;
            this.gvSanpham.Location = new System.Drawing.Point(410, 29);
            this.gvSanpham.Name = "gvSanpham";
            this.gvSanpham.Size = new System.Drawing.Size(409, 49);
            this.gvSanpham.TabIndex = 0;
            this.gvSanpham.Text = "QUẢN LÝ ĐẶT HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Crimson;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 27);
            this.label2.TabIndex = 35;
            this.label2.Text = "Danh sách khách hàng";
            // 
            // gvKhachhang
            // 
            this.gvKhachhang.BackgroundColor = System.Drawing.Color.LightGray;
            this.gvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKhachhang.Location = new System.Drawing.Point(12, 149);
            this.gvKhachhang.Name = "gvKhachhang";
            this.gvKhachhang.RowHeadersWidth = 51;
            this.gvKhachhang.RowTemplate.Height = 24;
            this.gvKhachhang.Size = new System.Drawing.Size(468, 183);
            this.gvKhachhang.TabIndex = 36;
            this.gvKhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvKhachhang_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Thistle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "ID đặt hàng";
            // 
            // txtOrderid
            // 
            this.txtOrderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderid.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtOrderid.Location = new System.Drawing.Point(76, 415);
            this.txtOrderid.Multiline = true;
            this.txtOrderid.Name = "txtOrderid";
            this.txtOrderid.Size = new System.Drawing.Size(199, 38);
            this.txtOrderid.TabIndex = 37;
            this.txtOrderid.TextChanged += new System.EventHandler(this.txtOrderid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "ID khách hàng";
            // 
            // txtIdKhachhang
            // 
            this.txtIdKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdKhachhang.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtIdKhachhang.Location = new System.Drawing.Point(76, 479);
            this.txtIdKhachhang.Multiline = true;
            this.txtIdKhachhang.Name = "txtIdKhachhang";
            this.txtIdKhachhang.Size = new System.Drawing.Size(199, 38);
            this.txtIdKhachhang.TabIndex = 39;
            // 
            // dtpOrder
            // 
            this.dtpOrder.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpOrder.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
            this.dtpOrder.Location = new System.Drawing.Point(216, 364);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(250, 22);
            this.dtpOrder.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Crimson;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "Ngày đặt hàng";
            // 
            // cbChon
            // 
            this.cbChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbChon.FormattingEnabled = true;
            this.cbChon.Location = new System.Drawing.Point(642, 118);
            this.cbChon.Name = "cbChon";
            this.cbChon.Size = new System.Drawing.Size(197, 28);
            this.cbChon.TabIndex = 44;
            this.cbChon.Text = "Chọn danh mục";
            this.cbChon.SelectedIndexChanged += new System.EventHandler(this.cbChon_SelectedIndexChanged);
            this.cbChon.SelectionChangeCommitted += new System.EventHandler(this.cbChon_SelectedIndexChanged);
            // 
            // gvProduct
            // 
            this.gvProduct.BackgroundColor = System.Drawing.Color.LightGray;
            this.gvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProduct.Location = new System.Drawing.Point(587, 149);
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.RowHeadersWidth = 51;
            this.gvProduct.RowTemplate.Height = 24;
            this.gvProduct.Size = new System.Drawing.Size(655, 183);
            this.gvProduct.TabIndex = 43;
            this.gvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProduct_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Thistle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(593, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Số lượng";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtQuantity.Location = new System.Drawing.Point(597, 359);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(199, 38);
            this.txtQuantity.TabIndex = 45;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Crimson;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(823, 355);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(174, 42);
            this.btnThem.TabIndex = 47;
            this.btnThem.Text = "Thành tiền";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Thistle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Tên khách hàng";
            // 
            // txtTenkhachhang
            // 
            this.txtTenkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenkhachhang.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtTenkhachhang.Location = new System.Drawing.Point(76, 543);
            this.txtTenkhachhang.Multiline = true;
            this.txtTenkhachhang.Name = "txtTenkhachhang";
            this.txtTenkhachhang.Size = new System.Drawing.Size(199, 38);
            this.txtTenkhachhang.TabIndex = 49;
            // 
            // gvorder
            // 
            this.gvorder.BackgroundColor = System.Drawing.Color.LightGray;
            this.gvorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvorder.Location = new System.Drawing.Point(586, 403);
            this.gvorder.Name = "gvorder";
            this.gvorder.RowHeadersWidth = 51;
            this.gvorder.RowTemplate.Height = 24;
            this.gvorder.Size = new System.Drawing.Size(655, 124);
            this.gvorder.TabIndex = 51;
            this.gvorder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.BackColor = System.Drawing.Color.Crimson;
            this.lblTong.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTong.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.Color.White;
            this.lblTong.Location = new System.Drawing.Point(542, 543);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(57, 27);
            this.lblTong.TabIndex = 52;
            this.lblTong.Text = "Tổng";
            this.lblTong.Click += new System.EventHandler(this.lblTong_Click);
            // 
            // txtVND
            // 
            this.txtVND.AutoSize = true;
            this.txtVND.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtVND.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVND.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVND.ForeColor = System.Drawing.Color.White;
            this.txtVND.Location = new System.Drawing.Point(675, 543);
            this.txtVND.Name = "txtVND";
            this.txtVND.Size = new System.Drawing.Size(0, 27);
            this.txtVND.TabIndex = 53;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Crimson;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(4, 587);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(174, 42);
            this.btnInsert.TabIndex = 54;
            this.btnInsert.Text = "Đặt hàng";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnXemdonhang
            // 
            this.btnXemdonhang.BackColor = System.Drawing.Color.Crimson;
            this.btnXemdonhang.FlatAppearance.BorderSize = 0;
            this.btnXemdonhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemdonhang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemdonhang.ForeColor = System.Drawing.Color.White;
            this.btnXemdonhang.Location = new System.Drawing.Point(200, 587);
            this.btnXemdonhang.Name = "btnXemdonhang";
            this.btnXemdonhang.Size = new System.Drawing.Size(174, 42);
            this.btnXemdonhang.TabIndex = 55;
            this.btnXemdonhang.Text = "Xem đơn hàng";
            this.btnXemdonhang.UseVisualStyleBackColor = false;
            this.btnXemdonhang.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(419, 587);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 42);
            this.button3.TabIndex = 56;
            this.button3.Text = "Trang chủ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 657);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnXemdonhang);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtVND);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.gvorder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenkhachhang);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cbChon);
            this.Controls.Add(this.gvProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdKhachhang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrderid);
            this.Controls.Add(this.gvKhachhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblThoat;
        private System.Windows.Forms.Label gvSanpham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvKhachhang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdKhachhang;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbChon;
        private System.Windows.Forms.DataGridView gvProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridView gvorder;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label txtVND;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnXemdonhang;
        private System.Windows.Forms.Button button3;
    }
}