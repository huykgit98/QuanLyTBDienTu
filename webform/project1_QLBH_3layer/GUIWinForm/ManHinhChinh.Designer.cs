namespace GUIWinForm
{
    partial class ManHinhChinh
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
            this.qltb = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvDSTB = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.cmbTraCuuLoaiTB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTraCuuTenTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSLTon = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLoaiTB = new System.Windows.Forms.ComboBox();
            this.qlhd = new System.Windows.Forms.TabPage();
            this.btnInHD = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.qltb.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.qlhd.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qltb
            // 
            this.qltb.Controls.Add(this.groupBox2);
            this.qltb.Controls.Add(this.groupBox1);
            this.qltb.Controls.Add(this.txtSLTon);
            this.qltb.Controls.Add(this.txtDonGia);
            this.qltb.Controls.Add(this.txtTenTB);
            this.qltb.Controls.Add(this.label4);
            this.qltb.Controls.Add(this.label3);
            this.qltb.Controls.Add(this.label2);
            this.qltb.Controls.Add(this.label1);
            this.qltb.Controls.Add(this.cmbLoaiTB);
            this.qltb.ForeColor = System.Drawing.Color.Black;
            this.qltb.Location = new System.Drawing.Point(4, 22);
            this.qltb.Name = "qltb";
            this.qltb.Padding = new System.Windows.Forms.Padding(3);
            this.qltb.Size = new System.Drawing.Size(793, 429);
            this.qltb.TabIndex = 2;
            this.qltb.Text = "Quản Lý Thiết Bị";
            this.qltb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXemTatCa);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.dgvDSTB);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(4, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 242);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Thiết Bị";
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Location = new System.Drawing.Point(589, 159);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(119, 23);
            this.btnXemTatCa.TabIndex = 15;
            this.btnXemTatCa.Text = "Xem Tất Cả Thiết Bị";
            this.btnXemTatCa.UseVisualStyleBackColor = true;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(589, 114);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // dgvDSTB
            // 
            this.dgvDSTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTB.Location = new System.Drawing.Point(8, 19);
            this.dgvDSTB.Name = "dgvDSTB";
            this.dgvDSTB.Size = new System.Drawing.Size(538, 219);
            this.dgvDSTB.TabIndex = 0;
            this.dgvDSTB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTB_CellContentClick);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(589, 65);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(589, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.cmbTraCuuLoaiTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTraCuuTenTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(512, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 78);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Thiết Bị";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(203, 19);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tra cứu";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cmbTraCuuLoaiTB
            // 
            this.cmbTraCuuLoaiTB.FormattingEnabled = true;
            this.cmbTraCuuLoaiTB.Location = new System.Drawing.Point(130, 52);
            this.cmbTraCuuLoaiTB.Name = "cmbTraCuuLoaiTB";
            this.cmbTraCuuLoaiTB.Size = new System.Drawing.Size(121, 21);
            this.cmbTraCuuLoaiTB.TabIndex = 9;
            this.cmbTraCuuLoaiTB.SelectedValueChanged += new System.EventHandler(this.cmbTraCuuLoaiTB_SelectedValueChanged);
            this.cmbTraCuuLoaiTB.Click += new System.EventHandler(this.cmbTraCuuLoaiTB_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lọc Theo Loại Thiết Bị:";
            // 
            // txtTraCuuTenTB
            // 
            this.txtTraCuuTenTB.Location = new System.Drawing.Point(81, 20);
            this.txtTraCuuTenTB.Name = "txtTraCuuTenTB";
            this.txtTraCuuTenTB.Size = new System.Drawing.Size(119, 20);
            this.txtTraCuuTenTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên Thiết Bị:";
            // 
            // txtSLTon
            // 
            this.txtSLTon.Location = new System.Drawing.Point(84, 61);
            this.txtSLTon.Name = "txtSLTon";
            this.txtSLTon.Size = new System.Drawing.Size(119, 20);
            this.txtSLTon.TabIndex = 7;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(332, 64);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(119, 20);
            this.txtDonGia.TabIndex = 6;
            // 
            // txtTenTB
            // 
            this.txtTenTB.Location = new System.Drawing.Point(332, 21);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(119, 20);
            this.txtTenTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Đơn Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Lượng Tồn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Thiết Bị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại Thiết Bị:";
            // 
            // cmbLoaiTB
            // 
            this.cmbLoaiTB.FormattingEnabled = true;
            this.cmbLoaiTB.Location = new System.Drawing.Point(84, 21);
            this.cmbLoaiTB.Name = "cmbLoaiTB";
            this.cmbLoaiTB.Size = new System.Drawing.Size(121, 21);
            this.cmbLoaiTB.TabIndex = 0;
            // 
            // qlhd
            // 
            this.qlhd.Controls.Add(this.btnInHD);
            this.qlhd.Controls.Add(this.groupBox7);
            this.qlhd.Controls.Add(this.groupBox6);
            this.qlhd.Location = new System.Drawing.Point(4, 22);
            this.qlhd.Name = "qlhd";
            this.qlhd.Padding = new System.Windows.Forms.Padding(3);
            this.qlhd.Size = new System.Drawing.Size(793, 429);
            this.qlhd.TabIndex = 1;
            this.qlhd.Text = "Quản Lý Hóa Đơn";
            this.qlhd.UseVisualStyleBackColor = true;
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(673, 327);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(75, 23);
            this.btnInHD.TabIndex = 3;
            this.btnInHD.Text = "In Hóa Đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvCTHD);
            this.groupBox7.Location = new System.Drawing.Point(3, 205);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(530, 145);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Chi tiết hóa đơn";
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(0, 13);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.Size = new System.Drawing.Size(528, 132);
            this.dgvCTHD.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvDSHD);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(760, 188);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách hóa đơn";
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Location = new System.Drawing.Point(0, 25);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.Size = new System.Drawing.Size(754, 163);
            this.dgvDSHD.TabIndex = 0;
            this.dgvDSHD.Click += new System.EventHandler(this.dgvDSHD_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.qlhd);
            this.tabControl1.Controls.Add(this.qltb);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManHinhChinh";
            this.Text = "ManHinhChinh";
            this.Load += new System.EventHandler(this.ManHinhChinh_Load);
            this.qltb.ResumeLayout(false);
            this.qltb.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.qlhd.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage qltb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvDSTB;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cmbTraCuuLoaiTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTraCuuTenTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSLTon;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLoaiTB;
        private System.Windows.Forms.TabPage qlhd;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Button btnXemTatCa;
    }
}