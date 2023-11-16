namespace DoAn
{
    partial class frmViewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThoat = new System.Windows.Forms.Label();
            this.gvSanpham = new System.Windows.Forms.Label();
            this.gvVieworder = new System.Windows.Forms.DataGridView();
            this.btnXemdonhang = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVieworder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblThoat);
            this.panel1.Controls.Add(this.gvSanpham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoat.ForeColor = System.Drawing.Color.White;
            this.lblThoat.Location = new System.Drawing.Point(983, 9);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(46, 49);
            this.lblThoat.TabIndex = 57;
            this.lblThoat.Text = "X";
            this.lblThoat.Click += new System.EventHandler(this.lblThoat_Click);
            // 
            // gvSanpham
            // 
            this.gvSanpham.AutoSize = true;
            this.gvSanpham.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSanpham.ForeColor = System.Drawing.Color.White;
            this.gvSanpham.Location = new System.Drawing.Point(401, 23);
            this.gvSanpham.Name = "gvSanpham";
            this.gvSanpham.Size = new System.Drawing.Size(245, 49);
            this.gvSanpham.TabIndex = 1;
            this.gvSanpham.Text = "ĐƠN HÀNG";
            // 
            // gvVieworder
            // 
            this.gvVieworder.BackgroundColor = System.Drawing.Color.LightGray;
            this.gvVieworder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVieworder.Location = new System.Drawing.Point(164, 106);
            this.gvVieworder.Name = "gvVieworder";
            this.gvVieworder.RowHeadersWidth = 51;
            this.gvVieworder.RowTemplate.Height = 24;
            this.gvVieworder.Size = new System.Drawing.Size(758, 397);
            this.gvVieworder.TabIndex = 52;
            this.gvVieworder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvVieworder_CellContentClick);
            // 
            // btnXemdonhang
            // 
            this.btnXemdonhang.BackColor = System.Drawing.Color.Crimson;
            this.btnXemdonhang.FlatAppearance.BorderSize = 0;
            this.btnXemdonhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemdonhang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemdonhang.ForeColor = System.Drawing.Color.White;
            this.btnXemdonhang.Location = new System.Drawing.Point(486, 509);
            this.btnXemdonhang.Name = "btnXemdonhang";
            this.btnXemdonhang.Size = new System.Drawing.Size(174, 42);
            this.btnXemdonhang.TabIndex = 56;
            this.btnXemdonhang.Text = "Xem đơn hàng";
            this.btnXemdonhang.UseVisualStyleBackColor = false;
            this.btnXemdonhang.Click += new System.EventHandler(this.btnXemdonhang_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Crimson;
            this.btnIn.FlatAppearance.BorderSize = 0;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Location = new System.Drawing.Point(76, 509);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(174, 42);
            this.btnIn.TabIndex = 57;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 563);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXemdonhang);
            this.Controls.Add(this.gvVieworder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewOrder";
            this.Text = "frmViewOrder";
            this.Load += new System.EventHandler(this.frmViewOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVieworder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label gvSanpham;
        private System.Windows.Forms.DataGridView gvVieworder;
        private System.Windows.Forms.Button btnXemdonhang;
        private System.Windows.Forms.Label lblThoat;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnIn;
    }
}