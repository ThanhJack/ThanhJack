namespace LAB__05GUI
{
    partial class frmStudent
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
            this.chkUnreg = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddorUpdate = new System.Windows.Forms.Button();
            this.gvListSV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picAvata = new System.Windows.Forms.PictureBox();
            this.cbbFaculty = new System.Windows.Forms.ComboBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIdsv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colIdSv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvListSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvata)).BeginInit();
            this.SuspendLayout();
            // 
            // chkUnreg
            // 
            this.chkUnreg.AutoSize = true;
            this.chkUnreg.Location = new System.Drawing.Point(992, 78);
            this.chkUnreg.Name = "chkUnreg";
            this.chkUnreg.Size = new System.Drawing.Size(166, 20);
            this.chkUnreg.TabIndex = 32;
            this.chkUnreg.Text = "Chưa ĐK chuyên ngành";
            this.chkUnreg.UseVisualStyleBackColor = true;
            this.chkUnreg.CheckedChanged += new System.EventHandler(this.chkUnreg_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(349, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 38);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddorUpdate
            // 
            this.btnAddorUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAddorUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddorUpdate.Location = new System.Drawing.Point(180, 455);
            this.btnAddorUpdate.Name = "btnAddorUpdate";
            this.btnAddorUpdate.Size = new System.Drawing.Size(144, 38);
            this.btnAddorUpdate.TabIndex = 31;
            this.btnAddorUpdate.Text = "Add/Update";
            this.btnAddorUpdate.UseVisualStyleBackColor = false;
            this.btnAddorUpdate.Click += new System.EventHandler(this.btnAddorUpdate_Click);
            // 
            // gvListSV
            // 
            this.gvListSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvListSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdSv,
            this.colName,
            this.colFaculty,
            this.colScore,
            this.colMajor});
            this.gvListSV.Location = new System.Drawing.Point(507, 104);
            this.gvListSV.Name = "gvListSV";
            this.gvListSV.RowHeadersWidth = 51;
            this.gvListSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvListSV.Size = new System.Drawing.Size(752, 315);
            this.gvListSV.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPic);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.picAvata);
            this.groupBox1.Controls.Add(this.cbbFaculty);
            this.groupBox1.Controls.Add(this.txtAverageScore);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtIdsv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 334);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ảnh đại diện";
            // 
            // picAvata
            // 
            this.picAvata.Location = new System.Drawing.Point(151, 205);
            this.picAvata.Name = "picAvata";
            this.picAvata.Size = new System.Drawing.Size(203, 110);
            this.picAvata.TabIndex = 3;
            this.picAvata.TabStop = false;
            // 
            // cbbFaculty
            // 
            this.cbbFaculty.FormattingEnabled = true;
            this.cbbFaculty.Location = new System.Drawing.Point(151, 116);
            this.cbbFaculty.Name = "cbbFaculty";
            this.cbbFaculty.Size = new System.Drawing.Size(230, 28);
            this.cbbFaculty.TabIndex = 2;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(151, 150);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(82, 28);
            this.txtAverageScore.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 28);
            this.txtName.TabIndex = 1;
            // 
            // txtIdsv
            // 
            this.txtIdsv.Location = new System.Drawing.Point(151, 41);
            this.txtIdsv.Name = "txtIdsv";
            this.txtIdsv.Size = new System.Drawing.Size(100, 28);
            this.txtIdsv.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Số SV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Điểm TB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 46);
            this.label1.TabIndex = 27;
            this.label1.Text = "Quản lý Sinh Viên";
            // 
            // colIdSv
            // 
            this.colIdSv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colIdSv.FillWeight = 241.9355F;
            this.colIdSv.HeaderText = "Mã Số SV";
            this.colIdSv.MinimumWidth = 6;
            this.colIdSv.Name = "colIdSv";
            this.colIdSv.Width = 96;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.FillWeight = 75.75078F;
            this.colName.HeaderText = "Họ Tên";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            // 
            // colFaculty
            // 
            this.colFaculty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colFaculty.FillWeight = 75.75078F;
            this.colFaculty.HeaderText = "Tên Khoa";
            this.colFaculty.MinimumWidth = 6;
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.Width = 94;
            // 
            // colScore
            // 
            this.colScore.FillWeight = 6.562957F;
            this.colScore.HeaderText = "Điểm TB";
            this.colScore.MinimumWidth = 6;
            this.colScore.Name = "colScore";
            // 
            // colMajor
            // 
            this.colMajor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMajor.HeaderText = "Chuyên Ngành";
            this.colMajor.MinimumWidth = 6;
            this.colMajor.Name = "colMajor";
            // 
            // btnPic
            // 
            this.btnPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPic.Location = new System.Drawing.Point(360, 256);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(48, 25);
            this.btnPic.TabIndex = 5;
            this.btnPic.Text = "....";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 520);
            this.Controls.Add(this.chkUnreg);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddorUpdate);
            this.Controls.Add(this.gvListSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStudent";
            this.Text = "Quản Lí Sinh Viên";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUnreg;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddorUpdate;
        private System.Windows.Forms.DataGridView gvListSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picAvata;
        private System.Windows.Forms.ComboBox cbbFaculty;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIdsv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdSv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajor;
        private System.Windows.Forms.Button btnPic;
    }
}

