namespace QuanLySinhVien
{
    partial class QuanLyNganhControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbThongTinNganh = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvThongTinNganh = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoaNganh = new System.Windows.Forms.Button();
            this.btnSuaNganh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaThongTinNganh = new System.Windows.Forms.Button();
            this.btnAddNganh = new System.Windows.Forms.Button();
            this.txtTenNganh = new System.Windows.Forms.TextBox();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grbThongTinNganh.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbThongTinNganh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 279);
            this.panel1.TabIndex = 0;
            // 
            // grbThongTinNganh
            // 
            this.grbThongTinNganh.BackColor = System.Drawing.Color.Gray;
            this.grbThongTinNganh.Controls.Add(this.panel3);
            this.grbThongTinNganh.Controls.Add(this.btnXoaNganh);
            this.grbThongTinNganh.Controls.Add(this.btnSuaNganh);
            this.grbThongTinNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThongTinNganh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinNganh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbThongTinNganh.Location = new System.Drawing.Point(0, 0);
            this.grbThongTinNganh.Margin = new System.Windows.Forms.Padding(4);
            this.grbThongTinNganh.Name = "grbThongTinNganh";
            this.grbThongTinNganh.Padding = new System.Windows.Forms.Padding(4);
            this.grbThongTinNganh.Size = new System.Drawing.Size(881, 279);
            this.grbThongTinNganh.TabIndex = 0;
            this.grbThongTinNganh.TabStop = false;
            this.grbThongTinNganh.Text = "Thông tin ngành";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvThongTinNganh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(873, 190);
            this.panel3.TabIndex = 5;
            // 
            // lvThongTinNganh
            // 
            this.lvThongTinNganh.BackColor = System.Drawing.Color.Coral;
            this.lvThongTinNganh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvThongTinNganh.FullRowSelect = true;
            this.lvThongTinNganh.GridLines = true;
            this.lvThongTinNganh.HideSelection = false;
            this.lvThongTinNganh.Location = new System.Drawing.Point(0, 0);
            this.lvThongTinNganh.Name = "lvThongTinNganh";
            this.lvThongTinNganh.Size = new System.Drawing.Size(873, 190);
            this.lvThongTinNganh.TabIndex = 0;
            this.lvThongTinNganh.UseCompatibleStateImageBehavior = false;
            this.lvThongTinNganh.View = System.Windows.Forms.View.Details;
            this.lvThongTinNganh.DoubleClick += new System.EventHandler(this.lvThongTinNganh_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Ngành";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Ngành";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 446;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng lớp";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 223;
            // 
            // btnXoaNganh
            // 
            this.btnXoaNganh.BackColor = System.Drawing.Color.Red;
            this.btnXoaNganh.FlatAppearance.BorderSize = 0;
            this.btnXoaNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNganh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNganh.Location = new System.Drawing.Point(630, 215);
            this.btnXoaNganh.Name = "btnXoaNganh";
            this.btnXoaNganh.Size = new System.Drawing.Size(136, 55);
            this.btnXoaNganh.TabIndex = 1;
            this.btnXoaNganh.Text = "Xóa";
            this.btnXoaNganh.UseVisualStyleBackColor = false;
            this.btnXoaNganh.Click += new System.EventHandler(this.btnXoaNganh_Click);
            // 
            // btnSuaNganh
            // 
            this.btnSuaNganh.BackColor = System.Drawing.Color.Gold;
            this.btnSuaNganh.Enabled = false;
            this.btnSuaNganh.FlatAppearance.BorderSize = 0;
            this.btnSuaNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNganh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNganh.Location = new System.Drawing.Point(488, 215);
            this.btnSuaNganh.Name = "btnSuaNganh";
            this.btnSuaNganh.Size = new System.Drawing.Size(136, 55);
            this.btnSuaNganh.TabIndex = 0;
            this.btnSuaNganh.Text = "Sửa";
            this.btnSuaNganh.UseVisualStyleBackColor = false;
            this.btnSuaNganh.Click += new System.EventHandler(this.btnSuaNganh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.btnXoaThongTinNganh);
            this.panel2.Controls.Add(this.btnAddNganh);
            this.panel2.Controls.Add(this.txtTenNganh);
            this.panel2.Controls.Add(this.txtMaNganh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 238);
            this.panel2.TabIndex = 1;
            // 
            // btnXoaThongTinNganh
            // 
            this.btnXoaThongTinNganh.BackColor = System.Drawing.Color.LawnGreen;
            this.btnXoaThongTinNganh.FlatAppearance.BorderSize = 0;
            this.btnXoaThongTinNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaThongTinNganh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThongTinNganh.Location = new System.Drawing.Point(630, 134);
            this.btnXoaThongTinNganh.Name = "btnXoaThongTinNganh";
            this.btnXoaThongTinNganh.Size = new System.Drawing.Size(136, 55);
            this.btnXoaThongTinNganh.TabIndex = 3;
            this.btnXoaThongTinNganh.Text = "Xóa Thông Tin";
            this.btnXoaThongTinNganh.UseVisualStyleBackColor = false;
            this.btnXoaThongTinNganh.Click += new System.EventHandler(this.btnXoaThongTinNganh_Click);
            // 
            // btnAddNganh
            // 
            this.btnAddNganh.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddNganh.FlatAppearance.BorderSize = 0;
            this.btnAddNganh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNganh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNganh.Location = new System.Drawing.Point(488, 134);
            this.btnAddNganh.Name = "btnAddNganh";
            this.btnAddNganh.Size = new System.Drawing.Size(136, 55);
            this.btnAddNganh.TabIndex = 2;
            this.btnAddNganh.Text = "Add";
            this.btnAddNganh.UseVisualStyleBackColor = false;
            this.btnAddNganh.Click += new System.EventHandler(this.btnAddNganh_Click);
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.Location = new System.Drawing.Point(166, 82);
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Size = new System.Drawing.Size(689, 22);
            this.txtTenNganh.TabIndex = 1;
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Location = new System.Drawing.Point(166, 22);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(689, 22);
            this.txtMaNganh.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(57, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Ngành:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Ngành:";
            // 
            // QuanLyNganhControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyNganhControl";
            this.Size = new System.Drawing.Size(881, 517);
            this.panel1.ResumeLayout(false);
            this.grbThongTinNganh.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbThongTinNganh;
        private System.Windows.Forms.Button btnXoaNganh;
        private System.Windows.Forms.Button btnSuaNganh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoaThongTinNganh;
        private System.Windows.Forms.Button btnAddNganh;
        private System.Windows.Forms.TextBox txtTenNganh;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvThongTinNganh;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
