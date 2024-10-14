namespace KTra
{
    partial class Form1
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
            this.btnTim = new System.Windows.Forms.Button();
            this.clLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimesv = new System.Windows.Forms.DateTimePicker();
            this.cblLop = new System.Windows.Forms.Label();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblMsv = new System.Windows.Forms.Label();
            this.clMsv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMsv = new System.Windows.Forms.TextBox();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.btnKhongluu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.grb1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grb2.SuspendLayout();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(352, 184);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 52);
            this.btnTim.TabIndex = 18;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // clLop
            // 
            this.clLop.HeaderText = "Lớp";
            this.clLop.MinimumWidth = 6;
            this.clLop.Name = "clLop";
            this.clLop.ReadOnly = true;
            this.clLop.Width = 175;
            // 
            // clNgay
            // 
            this.clNgay.HeaderText = "Ngày Sinh";
            this.clNgay.MinimumWidth = 6;
            this.clNgay.Name = "clNgay";
            this.clNgay.ReadOnly = true;
            this.clNgay.Width = 200;
            // 
            // clTen
            // 
            this.clTen.HeaderText = "Họ Tên";
            this.clTen.MinimumWidth = 6;
            this.clTen.Name = "clTen";
            this.clTen.ReadOnly = true;
            this.clTen.Width = 200;
            // 
            // datetimesv
            // 
            this.datetimesv.Location = new System.Drawing.Point(162, 96);
            this.datetimesv.Name = "datetimesv";
            this.datetimesv.Size = new System.Drawing.Size(200, 22);
            this.datetimesv.TabIndex = 7;
            // 
            // cblLop
            // 
            this.cblLop.AutoSize = true;
            this.cblLop.Location = new System.Drawing.Point(550, 100);
            this.cblLop.Name = "cblLop";
            this.cblLop.Size = new System.Drawing.Size(33, 16);
            this.cblLop.TabIndex = 10;
            this.cblLop.Text = "Lớp:";
            // 
            // cmbLop
            // 
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(603, 92);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(177, 24);
            this.cmbLop.TabIndex = 9;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(539, 45);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(55, 16);
            this.lblTen.TabIndex = 8;
            this.lblTen.Text = "Họ Tên:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(603, 42);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(261, 22);
            this.txtTen.TabIndex = 7;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(57, 101);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(72, 16);
            this.lblNgay.TabIndex = 6;
            this.lblNgay.Text = "Ngày Sinh:";
            // 
            // lblMsv
            // 
            this.lblMsv.AutoSize = true;
            this.lblMsv.Location = new System.Drawing.Point(57, 48);
            this.lblMsv.Name = "lblMsv";
            this.lblMsv.Size = new System.Drawing.Size(88, 16);
            this.lblMsv.TabIndex = 4;
            this.lblMsv.Text = "Mã Sinh Viên:";
            // 
            // clMsv
            // 
            this.clMsv.HeaderText = "Mã Sinh Viên";
            this.clMsv.MinimumWidth = 6;
            this.clMsv.Name = "clMsv";
            this.clMsv.ReadOnly = true;
            this.clMsv.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMsv,
            this.clTen,
            this.clNgay,
            this.clLop});
            this.dataGridView1.Location = new System.Drawing.Point(254, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 224);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(266, 21);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 42);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // txtMsv
            // 
            this.txtMsv.Location = new System.Drawing.Point(151, 39);
            this.txtMsv.Name = "txtMsv";
            this.txtMsv.Size = new System.Drawing.Size(255, 22);
            this.txtMsv.TabIndex = 3;
            // 
            // grb2
            // 
            this.grb2.Controls.Add(this.btnKhongluu);
            this.grb2.Controls.Add(this.btnLuu);
            this.grb2.Controls.Add(this.btnThoat);
            this.grb2.Controls.Add(this.btnThem);
            this.grb2.Controls.Add(this.btnSua);
            this.grb2.Controls.Add(this.btnXoa);
            this.grb2.Location = new System.Drawing.Point(530, 168);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(705, 95);
            this.grb2.TabIndex = 15;
            this.grb2.TabStop = false;
            // 
            // btnKhongluu
            // 
            this.btnKhongluu.Location = new System.Drawing.Point(376, 21);
            this.btnKhongluu.Name = "btnKhongluu";
            this.btnKhongluu.Size = new System.Drawing.Size(75, 42);
            this.btnKhongluu.TabIndex = 11;
            this.btnKhongluu.Text = "K.Lưu";
            this.btnKhongluu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(601, 21);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 42);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(49, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 42);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(154, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 42);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(493, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 42);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(162, 199);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(158, 22);
            this.txtTim.TabIndex = 17;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.datetimesv);
            this.grb1.Controls.Add(this.cblLop);
            this.grb1.Controls.Add(this.cmbLop);
            this.grb1.Controls.Add(this.lblTen);
            this.grb1.Controls.Add(this.txtTen);
            this.grb1.Controls.Add(this.lblNgay);
            this.grb1.Controls.Add(this.lblMsv);
            this.grb1.Controls.Add(this.txtMsv);
            this.grb1.Location = new System.Drawing.Point(342, 9);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(893, 153);
            this.grb1.TabIndex = 14;
            this.grb1.TabStop = false;
            this.grb1.Text = "Thông tin chi tiết";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 526);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.grb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grb2.ResumeLayout(false);
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DateTimePicker datetimesv;
        private System.Windows.Forms.Label cblLop;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblMsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMsv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMsv;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.Button btnKhongluu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.GroupBox grb1;
    }
}

