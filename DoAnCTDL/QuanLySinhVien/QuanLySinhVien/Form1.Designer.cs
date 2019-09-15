namespace QuanLySinhVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchSV = new System.Windows.Forms.Button();
            this.btnQLN = new System.Windows.Forms.Button();
            this.btnQLLH = new System.Windows.Forms.Button();
            this.btnQLSV = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnManHinhChinh = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnShow = new System.Windows.Forms.Panel();
            this.timKiemSinhVienControl1 = new QuanLySinhVien.TimKiemSinhVienControl();
            this.quanLyNganhControl1 = new QuanLySinhVien.QuanLyNganhControl();
            this.quanLyLopHocControl1 = new QuanLySinhVien.QuanLyLopHocControl();
            this.quanLySinhVienControl1 = new QuanLySinhVien.QuanLySinhVienControl();
            this.manHinhChinhControl1 = new QuanLySinhVien.ManHinhChinhControl();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.pnShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnManHinhChinh);
            this.panel1.Controls.Add(this.btnQLSV);
            this.panel1.Controls.Add(this.btnQLLH);
            this.panel1.Controls.Add(this.btnQLN);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnSearchSV);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 525);
            this.panel1.TabIndex = 0;
            // 
            // btnSearchSV
            // 
            this.btnSearchSV.FlatAppearance.BorderSize = 0;
            this.btnSearchSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSV.Font = new System.Drawing.Font("Elephant", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSV.ForeColor = System.Drawing.Color.White;
            this.btnSearchSV.Location = new System.Drawing.Point(1, 384);
            this.btnSearchSV.Name = "btnSearchSV";
            this.btnSearchSV.Size = new System.Drawing.Size(216, 64);
            this.btnSearchSV.TabIndex = 4;
            this.btnSearchSV.Text = "     Tìm kiếm sinh viên";
            this.btnSearchSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchSV.UseVisualStyleBackColor = true;
            this.btnSearchSV.Click += new System.EventHandler(this.btnSearchSV_Click);
            // 
            // btnQLN
            // 
            this.btnQLN.FlatAppearance.BorderSize = 0;
            this.btnQLN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLN.Font = new System.Drawing.Font("Elephant", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLN.ForeColor = System.Drawing.Color.White;
            this.btnQLN.Location = new System.Drawing.Point(1, 313);
            this.btnQLN.Name = "btnQLN";
            this.btnQLN.Size = new System.Drawing.Size(216, 64);
            this.btnQLN.TabIndex = 3;
            this.btnQLN.Text = "     Quản lý ngành";
            this.btnQLN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLN.UseVisualStyleBackColor = true;
            this.btnQLN.Click += new System.EventHandler(this.btnQLN_Click);
            // 
            // btnQLLH
            // 
            this.btnQLLH.FlatAppearance.BorderSize = 0;
            this.btnQLLH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLLH.Font = new System.Drawing.Font("Elephant", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLLH.ForeColor = System.Drawing.Color.White;
            this.btnQLLH.Location = new System.Drawing.Point(1, 243);
            this.btnQLLH.Name = "btnQLLH";
            this.btnQLLH.Size = new System.Drawing.Size(216, 64);
            this.btnQLLH.TabIndex = 2;
            this.btnQLLH.Text = "     Quản lý lớp học";
            this.btnQLLH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLLH.UseVisualStyleBackColor = true;
            this.btnQLLH.Click += new System.EventHandler(this.btnQLLH_Click);
            // 
            // btnQLSV
            // 
            this.btnQLSV.FlatAppearance.BorderSize = 0;
            this.btnQLSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSV.Font = new System.Drawing.Font("Elephant", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSV.ForeColor = System.Drawing.Color.White;
            this.btnQLSV.Location = new System.Drawing.Point(1, 173);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(216, 64);
            this.btnQLSV.TabIndex = 1;
            this.btnQLSV.Text = "     Quản lý sinh viên";
            this.btnQLSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSV.UseVisualStyleBackColor = true;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Elephant", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(1, 452);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(216, 64);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "     Xuất ra file Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnManHinhChinh
            // 
            this.btnManHinhChinh.FlatAppearance.BorderSize = 0;
            this.btnManHinhChinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManHinhChinh.Font = new System.Drawing.Font("Elephant", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManHinhChinh.ForeColor = System.Drawing.Color.White;
            this.btnManHinhChinh.Location = new System.Drawing.Point(2, 102);
            this.btnManHinhChinh.Name = "btnManHinhChinh";
            this.btnManHinhChinh.Size = new System.Drawing.Size(216, 64);
            this.btnManHinhChinh.TabIndex = 0;
            this.btnManHinhChinh.Text = "     Màn hình chính";
            this.btnManHinhChinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManHinhChinh.UseVisualStyleBackColor = true;
            this.btnManHinhChinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.pnShow);
            this.panel5.Controls.Add(this.pnTop);
            this.panel5.Location = new System.Drawing.Point(227, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(661, 522);
            this.panel5.TabIndex = 2;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.Firebrick;
            this.pnTop.Controls.Add(this.lbTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(661, 101);
            this.pnTop.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(13, 54);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(142, 20);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Màn hình chính";
            // 
            // pnShow
            // 
            this.pnShow.BackColor = System.Drawing.SystemColors.Control;
            this.pnShow.BackgroundImage = global::QuanLySinhVien.Properties.Resources.laptop_sinh_vien_ok_800x450;
            this.pnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnShow.Controls.Add(this.manHinhChinhControl1);
            this.pnShow.Controls.Add(this.timKiemSinhVienControl1);
            this.pnShow.Controls.Add(this.quanLyNganhControl1);
            this.pnShow.Controls.Add(this.quanLyLopHocControl1);
            this.pnShow.Controls.Add(this.quanLySinhVienControl1);
            this.pnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnShow.Location = new System.Drawing.Point(0, 101);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(661, 421);
            this.pnShow.TabIndex = 1;
            // 
            // timKiemSinhVienControl1
            // 
            this.timKiemSinhVienControl1.BackColor = System.Drawing.Color.White;
            this.timKiemSinhVienControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timKiemSinhVienControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timKiemSinhVienControl1.Location = new System.Drawing.Point(0, 0);
            this.timKiemSinhVienControl1.Margin = new System.Windows.Forms.Padding(4);
            this.timKiemSinhVienControl1.Name = "timKiemSinhVienControl1";
            this.timKiemSinhVienControl1.Size = new System.Drawing.Size(661, 421);
            this.timKiemSinhVienControl1.TabIndex = 3;
            // 
            // quanLyNganhControl1
            // 
            this.quanLyNganhControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyNganhControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyNganhControl1.Location = new System.Drawing.Point(0, 0);
            this.quanLyNganhControl1.Margin = new System.Windows.Forms.Padding(4);
            this.quanLyNganhControl1.Name = "quanLyNganhControl1";
            this.quanLyNganhControl1.Size = new System.Drawing.Size(661, 421);
            this.quanLyNganhControl1.TabIndex = 2;
            // 
            // quanLyLopHocControl1
            // 
            this.quanLyLopHocControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyLopHocControl1.Location = new System.Drawing.Point(0, 0);
            this.quanLyLopHocControl1.Name = "quanLyLopHocControl1";
            this.quanLyLopHocControl1.Size = new System.Drawing.Size(661, 421);
            this.quanLyLopHocControl1.TabIndex = 1;
            // 
            // quanLySinhVienControl1
            // 
            this.quanLySinhVienControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLySinhVienControl1.Location = new System.Drawing.Point(0, 0);
            this.quanLySinhVienControl1.Name = "quanLySinhVienControl1";
            this.quanLySinhVienControl1.Size = new System.Drawing.Size(661, 421);
            this.quanLySinhVienControl1.TabIndex = 0;
            // 
            // manHinhChinhControl1
            // 
            this.manHinhChinhControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manHinhChinhControl1.Location = new System.Drawing.Point(0, 0);
            this.manHinhChinhControl1.Name = "manHinhChinhControl1";
            this.manHinhChinhControl1.Size = new System.Drawing.Size(661, 421);
            this.manHinhChinhControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(888, 525);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQLSV;
        private System.Windows.Forms.Button btnQLLH;
        private System.Windows.Forms.Button btnQLN;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnSearchSV;
        private System.Windows.Forms.Button btnManHinhChinh;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnShow;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbTitle;
        private QuanLySinhVienControl quanLySinhVienControl1;
        private QuanLyLopHocControl quanLyLopHocControl1;
        private QuanLyNganhControl quanLyNganhControl1;
        private TimKiemSinhVienControl timKiemSinhVienControl1;
        private ManHinhChinhControl manHinhChinhControl1;
    }
}

