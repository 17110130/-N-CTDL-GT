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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clMaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuongLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaNganh = new System.Windows.Forms.Button();
            this.btnXoaNganh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.txtTenNganh = new System.Windows.Forms.TextBox();
            this.btnLuuNganh = new System.Windows.Forms.Button();
            this.btnXoaThongTinNganh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grbThongTinNganh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbThongTinNganh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 279);
            this.panel1.TabIndex = 0;
            // 
            // grbThongTinNganh
            // 
            this.grbThongTinNganh.BackColor = System.Drawing.Color.White;
            this.grbThongTinNganh.Controls.Add(this.btnXoaNganh);
            this.grbThongTinNganh.Controls.Add(this.btnSuaNganh);
            this.grbThongTinNganh.Controls.Add(this.dataGridView1);
            this.grbThongTinNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThongTinNganh.Location = new System.Drawing.Point(0, 0);
            this.grbThongTinNganh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbThongTinNganh.Name = "grbThongTinNganh";
            this.grbThongTinNganh.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbThongTinNganh.Size = new System.Drawing.Size(881, 279);
            this.grbThongTinNganh.TabIndex = 0;
            this.grbThongTinNganh.TabStop = false;
            this.grbThongTinNganh.Text = "Thông tin ngành";
            this.grbThongTinNganh.Enter += new System.EventHandler(this.grbThongTinNganh_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaNganh,
            this.clTenNganh,
            this.clSoLuongLop});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(4, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(873, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // clMaNganh
            // 
            this.clMaNganh.HeaderText = "Mã ngành";
            this.clMaNganh.Name = "clMaNganh";
            // 
            // clTenNganh
            // 
            this.clTenNganh.HeaderText = "Tên ngành";
            this.clTenNganh.Name = "clTenNganh";
            // 
            // clSoLuongLop
            // 
            this.clSoLuongLop.HeaderText = "Số lượng lớp";
            this.clSoLuongLop.Name = "clSoLuongLop";
            // 
            // btnSuaNganh
            // 
            this.btnSuaNganh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaNganh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNganh.Location = new System.Drawing.Point(488, 215);
            this.btnSuaNganh.Name = "btnSuaNganh";
            this.btnSuaNganh.Size = new System.Drawing.Size(136, 55);
            this.btnSuaNganh.TabIndex = 3;
            this.btnSuaNganh.Text = "Sửa";
            this.btnSuaNganh.UseVisualStyleBackColor = true;
            // 
            // btnXoaNganh
            // 
            this.btnXoaNganh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaNganh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNganh.Location = new System.Drawing.Point(630, 215);
            this.btnXoaNganh.Name = "btnXoaNganh";
            this.btnXoaNganh.Size = new System.Drawing.Size(136, 55);
            this.btnXoaNganh.TabIndex = 4;
            this.btnXoaNganh.Text = "Xóa";
            this.btnXoaNganh.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnXoaThongTinNganh);
            this.panel2.Controls.Add(this.btnLuuNganh);
            this.panel2.Controls.Add(this.txtTenNganh);
            this.panel2.Controls.Add(this.txtMaNganh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 238);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Ngành:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(57, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Ngành:";
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Location = new System.Drawing.Point(166, 22);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(689, 23);
            this.txtMaNganh.TabIndex = 2;
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.Location = new System.Drawing.Point(166, 82);
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Size = new System.Drawing.Size(689, 23);
            this.txtTenNganh.TabIndex = 2;
            // 
            // btnLuuNganh
            // 
            this.btnLuuNganh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuuNganh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuNganh.Location = new System.Drawing.Point(203, 134);
            this.btnLuuNganh.Name = "btnLuuNganh";
            this.btnLuuNganh.Size = new System.Drawing.Size(136, 55);
            this.btnLuuNganh.TabIndex = 4;
            this.btnLuuNganh.Text = "Lưu";
            this.btnLuuNganh.UseVisualStyleBackColor = true;
            // 
            // btnXoaThongTinNganh
            // 
            this.btnXoaThongTinNganh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaThongTinNganh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThongTinNganh.Location = new System.Drawing.Point(345, 134);
            this.btnXoaThongTinNganh.Name = "btnXoaThongTinNganh";
            this.btnXoaThongTinNganh.Size = new System.Drawing.Size(136, 55);
            this.btnXoaThongTinNganh.TabIndex = 5;
            this.btnXoaThongTinNganh.Text = "Xóa Thông Tin";
            this.btnXoaThongTinNganh.UseVisualStyleBackColor = true;
            // 
            // QuanLyNganhControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanLyNganhControl";
            this.Size = new System.Drawing.Size(881, 517);
            this.panel1.ResumeLayout(false);
            this.grbThongTinNganh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbThongTinNganh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuongLop;
        private System.Windows.Forms.Button btnXoaNganh;
        private System.Windows.Forms.Button btnSuaNganh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoaThongTinNganh;
        private System.Windows.Forms.Button btnLuuNganh;
        private System.Windows.Forms.TextBox txtTenNganh;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
