namespace LAB__05GUI
{
    partial class frmRegister
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
            this.button1 = new System.Windows.Forms.Button();
            this.gvSv = new System.Windows.Forms.DataGridView();
            this.colChoose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbMajor = new System.Windows.Forms.ComboBox();
            this.cbbFaculty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvSv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(174, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gvSv
            // 
            this.gvSv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChoose,
            this.colStudentID,
            this.colFullName,
            this.colFaculty,
            this.colAverageScore});
            this.gvSv.Location = new System.Drawing.Point(49, 213);
            this.gvSv.Name = "gvSv";
            this.gvSv.RowHeadersWidth = 51;
            this.gvSv.RowTemplate.Height = 24;
            this.gvSv.Size = new System.Drawing.Size(801, 231);
            this.gvSv.TabIndex = 18;
            // 
            // colChoose
            // 
            this.colChoose.HeaderText = "Chọn";
            this.colChoose.MinimumWidth = 6;
            this.colChoose.Name = "colChoose";
            this.colChoose.Width = 125;
            // 
            // colStudentID
            // 
            this.colStudentID.HeaderText = "MSSV";
            this.colStudentID.MinimumWidth = 6;
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.Width = 125;
            // 
            // colFullName
            // 
            this.colFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFullName.HeaderText = "Họ Tên";
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            // 
            // colFaculty
            // 
            this.colFaculty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFaculty.HeaderText = "Khoa";
            this.colFaculty.MinimumWidth = 6;
            this.colFaculty.Name = "colFaculty";
            // 
            // colAverageScore
            // 
            this.colAverageScore.HeaderText = "DTB";
            this.colAverageScore.MinimumWidth = 6;
            this.colAverageScore.Name = "colAverageScore";
            this.colAverageScore.Width = 125;
            // 
            // cbbMajor
            // 
            this.cbbMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMajor.FormattingEnabled = true;
            this.cbbMajor.Location = new System.Drawing.Point(335, 145);
            this.cbbMajor.Name = "cbbMajor";
            this.cbbMajor.Size = new System.Drawing.Size(388, 33);
            this.cbbMajor.TabIndex = 16;
            // 
            // cbbFaculty
            // 
            this.cbbFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFaculty.FormattingEnabled = true;
            this.cbbFaculty.Location = new System.Drawing.Point(335, 91);
            this.cbbFaculty.Name = "cbbFaculty";
            this.cbbFaculty.Size = new System.Drawing.Size(388, 33);
            this.cbbFaculty.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Chuyên ngành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Đăng ký chuyên ngành";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gvSv);
            this.Controls.Add(this.cbbMajor);
            this.Controls.Add(this.cbbFaculty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            ((System.ComponentModel.ISupportInitialize)(this.gvSv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gvSv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAverageScore;
        private System.Windows.Forms.ComboBox cbbMajor;
        private System.Windows.Forms.ComboBox cbbFaculty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}