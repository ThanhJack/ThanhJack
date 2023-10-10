namespace frmSinhvien
{
    partial class frmSinhvien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHotenSV = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btKhong = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.lvSinhvien = new System.Windows.Forms.ListView();
            this.colMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN CHI TIẾT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lớp học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sinh viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ tên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(199, 67);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(169, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // txtHotenSV
            // 
            this.txtHotenSV.Location = new System.Drawing.Point(536, 67);
            this.txtHotenSV.Name = "txtHotenSV";
            this.txtHotenSV.Size = new System.Drawing.Size(220, 22);
            this.txtHotenSV.TabIndex = 1;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(536, 114);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(169, 24);
            this.cboLop.TabIndex = 2;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(24, 178);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(169, 22);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(314, 177);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(82, 31);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(402, 177);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(82, 31);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(490, 177);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(82, 31);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btLuu
            // 
            this.btLuu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(583, 174);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(82, 31);
            this.btLuu.TabIndex = 3;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = false;
            // 
            // btKhong
            // 
            this.btKhong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btKhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKhong.Location = new System.Drawing.Point(684, 177);
            this.btKhong.Name = "btKhong";
            this.btKhong.Size = new System.Drawing.Size(82, 31);
            this.btKhong.TabIndex = 3;
            this.btKhong.Text = "K.Lưu";
            this.btKhong.UseVisualStyleBackColor = false;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(800, 177);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(82, 31);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // lvSinhvien
            // 
            this.lvSinhvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSinhvien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSV,
            this.colName,
            this.colBirthday,
            this.colLop});
            this.lvSinhvien.FullRowSelect = true;
            this.lvSinhvien.HideSelection = false;
            this.lvSinhvien.Location = new System.Drawing.Point(89, 214);
            this.lvSinhvien.Name = "lvSinhvien";
            this.lvSinhvien.Size = new System.Drawing.Size(819, 217);
            this.lvSinhvien.TabIndex = 5;
            this.lvSinhvien.UseCompatibleStateImageBehavior = false;
            this.lvSinhvien.View = System.Windows.Forms.View.Details;
            this.lvSinhvien.SelectedIndexChanged += new System.EventHandler(this.lvSinhvien_SelectedIndexChanged);
            // 
            // colMaSV
            // 
            this.colMaSV.Text = "Mã SV";
            this.colMaSV.Width = 100;
            // 
            // colName
            // 
            this.colName.Text = "Họ và Tên";
            this.colName.Width = 150;
            // 
            // colBirthday
            // 
            this.colBirthday.Text = "Ngày sinh";
            this.colBirthday.Width = 200;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            this.colLop.Width = 100;
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Location = new System.Drawing.Point(196, 110);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(255, 22);
            this.dtNgaysinh.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(209, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tìm";
            // 
            // frmSinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtNgaysinh);
            this.Controls.Add(this.lvSinhvien);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btKhong);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.txtHotenSV);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSinhvien";
            this.Text = "DANH SÁCH SINH VIÊN";
            this.Load += new System.EventHandler(this.frmSinhvien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHotenSV;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btKhong;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.ListView lvSinhvien;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        public System.Windows.Forms.ColumnHeader colBirthday;
        public System.Windows.Forms.ColumnHeader colMaSV;
        public System.Windows.Forms.ColumnHeader colName;
        public System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.Label label6;
    }
}

