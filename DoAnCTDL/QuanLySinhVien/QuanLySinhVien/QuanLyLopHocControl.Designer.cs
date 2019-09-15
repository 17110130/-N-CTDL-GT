namespace QuanLySinhVien
{
    partial class QuanLyLopHocControl
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
            this.grbDanhSachNganh = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grbDanhSachLop = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNganh = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lstDanhSachNganh = new System.Windows.Forms.ListBox();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnLuuLop = new System.Windows.Forms.Button();
            this.btnXoaThongTinLop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grbDanhSachNganh.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grbDanhSachLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbDanhSachNganh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 517);
            this.panel1.TabIndex = 0;
            // 
            // grbDanhSachNganh
            // 
            this.grbDanhSachNganh.Controls.Add(this.lstDanhSachNganh);
            this.grbDanhSachNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDanhSachNganh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbDanhSachNganh.Location = new System.Drawing.Point(0, 0);
            this.grbDanhSachNganh.Name = "grbDanhSachNganh";
            this.grbDanhSachNganh.Size = new System.Drawing.Size(221, 517);
            this.grbDanhSachNganh.TabIndex = 0;
            this.grbDanhSachNganh.TabStop = false;
            this.grbDanhSachNganh.Text = "Danh sách ngành";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(221, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 517);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grbDanhSachLop);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 250);
            this.panel3.TabIndex = 0;
            // 
            // grbDanhSachLop
            // 
            this.grbDanhSachLop.BackColor = System.Drawing.Color.White;
            this.grbDanhSachLop.Controls.Add(this.btnXoaLop);
            this.grbDanhSachLop.Controls.Add(this.btnSuaLop);
            this.grbDanhSachLop.Controls.Add(this.dataGridView1);
            this.grbDanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDanhSachLop.Location = new System.Drawing.Point(0, 0);
            this.grbDanhSachLop.Name = "grbDanhSachLop";
            this.grbDanhSachLop.Size = new System.Drawing.Size(660, 250);
            this.grbDanhSachLop.TabIndex = 0;
            this.grbDanhSachLop.TabStop = false;
            this.grbDanhSachLop.Text = "Danh sách lớp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaLop,
            this.clTenLop,
            this.clSiSo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(654, 168);
            this.dataGridView1.TabIndex = 0;
            // 
            // clMaLop
            // 
            this.clMaLop.HeaderText = "Mã lớp";
            this.clMaLop.Name = "clMaLop";
            // 
            // clTenLop
            // 
            this.clTenLop.HeaderText = "Tên lớp";
            this.clTenLop.Name = "clTenLop";
            // 
            // clSiSo
            // 
            this.clSiSo.HeaderText = "Sỉ số";
            this.clSiSo.Name = "clSiSo";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnXoaThongTinLop);
            this.panel4.Controls.Add(this.btnLuuLop);
            this.panel4.Controls.Add(this.txtTenLop);
            this.panel4.Controls.Add(this.txtMaLop);
            this.panel4.Controls.Add(this.txtNganh);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(660, 267);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngành:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên lớp:";
            // 
            // txtNganh
            // 
            this.txtNganh.Location = new System.Drawing.Point(110, 23);
            this.txtNganh.Name = "txtNganh";
            this.txtNganh.Size = new System.Drawing.Size(527, 23);
            this.txtNganh.TabIndex = 1;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(110, 61);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(527, 23);
            this.txtMaLop.TabIndex = 1;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(110, 109);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(527, 23);
            this.txtTenLop.TabIndex = 1;
            // 
            // lstDanhSachNganh
            // 
            this.lstDanhSachNganh.BackColor = System.Drawing.Color.White;
            this.lstDanhSachNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDanhSachNganh.FormattingEnabled = true;
            this.lstDanhSachNganh.Location = new System.Drawing.Point(3, 16);
            this.lstDanhSachNganh.Name = "lstDanhSachNganh";
            this.lstDanhSachNganh.Size = new System.Drawing.Size(215, 498);
            this.lstDanhSachNganh.TabIndex = 0;
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaLop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLop.Location = new System.Drawing.Point(359, 189);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(136, 55);
            this.btnSuaLop.TabIndex = 2;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = true;
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaLop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLop.Location = new System.Drawing.Point(501, 190);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(136, 55);
            this.btnXoaLop.TabIndex = 2;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            // 
            // btnLuuLop
            // 
            this.btnLuuLop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuuLop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuLop.Location = new System.Drawing.Point(194, 158);
            this.btnLuuLop.Name = "btnLuuLop";
            this.btnLuuLop.Size = new System.Drawing.Size(136, 55);
            this.btnLuuLop.TabIndex = 3;
            this.btnLuuLop.Text = "Lưu";
            this.btnLuuLop.UseVisualStyleBackColor = true;
            // 
            // btnXoaThongTinLop
            // 
            this.btnXoaThongTinLop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaThongTinLop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThongTinLop.Location = new System.Drawing.Point(336, 158);
            this.btnXoaThongTinLop.Name = "btnXoaThongTinLop";
            this.btnXoaThongTinLop.Size = new System.Drawing.Size(136, 55);
            this.btnXoaThongTinLop.TabIndex = 4;
            this.btnXoaThongTinLop.Text = "Xóa Thông TIn";
            this.btnXoaThongTinLop.UseVisualStyleBackColor = true;
            // 
            // QuanLyLopHocControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyLopHocControl";
            this.Size = new System.Drawing.Size(881, 517);
            this.panel1.ResumeLayout(false);
            this.grbDanhSachNganh.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.grbDanhSachLop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbDanhSachNganh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grbDanhSachLop;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstDanhSachNganh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtNganh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSiSo;
        private System.Windows.Forms.Button btnXoaThongTinLop;
        private System.Windows.Forms.Button btnLuuLop;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Button btnSuaLop;
    }
}
