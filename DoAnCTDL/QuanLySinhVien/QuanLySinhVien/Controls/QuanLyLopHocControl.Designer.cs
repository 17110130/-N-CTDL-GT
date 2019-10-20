using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace QuanLySinhVien
{
    partial class QuanLyLopHocControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new Panel();
            this.grbDanhSachNganh = new GroupBox();
            this.lstDanhSachNganh = new ListBox();
            this.panel2 = new Panel();
            this.panel4 = new Panel();
            this.btnXoaThongTinLop = new Button();
            this.btnLuuLop = new Button();
            this.txtTenLop = new TextBox();
            this.txtMaLop = new TextBox();
            this.txtNganh = new TextBox();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.panel3 = new Panel();
            this.grbDanhSachLop = new GroupBox();
            this.btnXoaLop = new Button();
            this.btnSuaLop = new Button();
            this.dgvLopHoc = new DataGridView();
            this.dgvCheckBox = new DataGridViewCheckBoxColumn();
            this.clMaLop = new DataGridViewTextBoxColumn();
            this.clTenLop = new DataGridViewTextBoxColumn();
            this.clSiSo = new DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new BackgroundWorker();
            this.panel1.SuspendLayout();
            this.grbDanhSachNganh.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grbDanhSachLop.SuspendLayout();
            ((ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbDanhSachNganh);
            this.panel1.Dock = DockStyle.Left;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(221, 517);
            this.panel1.TabIndex = 0;
            // 
            // grbDanhSachNganh
            // 
            this.grbDanhSachNganh.Controls.Add(this.lstDanhSachNganh);
            this.grbDanhSachNganh.Dock = DockStyle.Fill;
            this.grbDanhSachNganh.FlatStyle = FlatStyle.Popup;
            this.grbDanhSachNganh.Location = new Point(0, 0);
            this.grbDanhSachNganh.Name = "grbDanhSachNganh";
            this.grbDanhSachNganh.Size = new Size(221, 517);
            this.grbDanhSachNganh.TabIndex = 0;
            this.grbDanhSachNganh.TabStop = false;
            this.grbDanhSachNganh.Text = "Danh sách ngành";
            // 
            // lstDanhSachNganh
            // 
            this.lstDanhSachNganh.BackColor = Color.White;
            this.lstDanhSachNganh.Dock = DockStyle.Fill;
            this.lstDanhSachNganh.FormattingEnabled = true;
            this.lstDanhSachNganh.Location = new Point(3, 16);
            this.lstDanhSachNganh.Name = "lstDanhSachNganh";
            this.lstDanhSachNganh.Size = new Size(215, 498);
            this.lstDanhSachNganh.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Location = new Point(221, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(660, 517);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = Color.White;
            this.panel4.Controls.Add(this.btnXoaThongTinLop);
            this.panel4.Controls.Add(this.btnLuuLop);
            this.panel4.Controls.Add(this.txtTenLop);
            this.panel4.Controls.Add(this.txtMaLop);
            this.panel4.Controls.Add(this.txtNganh);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = DockStyle.Fill;
            this.panel4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new Point(0, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new Size(660, 267);
            this.panel4.TabIndex = 1;
            // 
            // btnXoaThongTinLop
            // 
            this.btnXoaThongTinLop.FlatStyle = FlatStyle.Popup;
            this.btnXoaThongTinLop.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThongTinLop.Location = new Point(336, 158);
            this.btnXoaThongTinLop.Name = "btnXoaThongTinLop";
            this.btnXoaThongTinLop.Size = new Size(136, 55);
            this.btnXoaThongTinLop.TabIndex = 4;
            this.btnXoaThongTinLop.Text = "Xóa Thông TIn";
            this.btnXoaThongTinLop.UseVisualStyleBackColor = true;
            // 
            // btnLuuLop
            // 
            this.btnLuuLop.FlatStyle = FlatStyle.Popup;
            this.btnLuuLop.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuLop.Location = new Point(194, 158);
            this.btnLuuLop.Name = "btnLuuLop";
            this.btnLuuLop.Size = new Size(136, 55);
            this.btnLuuLop.TabIndex = 3;
            this.btnLuuLop.Text = "Lưu";
            this.btnLuuLop.UseVisualStyleBackColor = true;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new Point(110, 109);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new Size(527, 23);
            this.txtTenLop.TabIndex = 1;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new Point(110, 61);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new Size(527, 23);
            this.txtMaLop.TabIndex = 1;
            // 
            // txtNganh
            // 
            this.txtNganh.Location = new Point(110, 23);
            this.txtNganh.Name = "txtNganh";
            this.txtNganh.Size = new Size(527, 23);
            this.txtNganh.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new Point(23, 115);
            this.label3.Name = "label3";
            this.label3.Size = new Size(60, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new Size(59, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngành:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grbDanhSachLop);
            this.panel3.Dock = DockStyle.Top;
            this.panel3.Location = new Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(660, 250);
            this.panel3.TabIndex = 0;
            // 
            // grbDanhSachLop
            // 
            this.grbDanhSachLop.BackColor = Color.White;
            this.grbDanhSachLop.Controls.Add(this.btnXoaLop);
            this.grbDanhSachLop.Controls.Add(this.btnSuaLop);
            this.grbDanhSachLop.Controls.Add(this.dgvLopHoc);
            this.grbDanhSachLop.Dock = DockStyle.Fill;
            this.grbDanhSachLop.Location = new Point(0, 0);
            this.grbDanhSachLop.Name = "grbDanhSachLop";
            this.grbDanhSachLop.Size = new Size(660, 250);
            this.grbDanhSachLop.TabIndex = 0;
            this.grbDanhSachLop.TabStop = false;
            this.grbDanhSachLop.Text = "Danh sách lớp";
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.FlatStyle = FlatStyle.Popup;
            this.btnXoaLop.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLop.Location = new Point(501, 190);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new Size(136, 55);
            this.btnXoaLop.TabIndex = 2;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.FlatStyle = FlatStyle.Popup;
            this.btnSuaLop.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLop.Location = new Point(359, 189);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new Size(136, 55);
            this.btnSuaLop.TabIndex = 2;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = true;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHoc.BorderStyle = BorderStyle.Fixed3D;
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.Columns.AddRange(new DataGridViewColumn[] {
            this.dgvCheckBox,
            this.clMaLop,
            this.clTenLop,
            this.clSiSo});
            this.dgvLopHoc.Dock = DockStyle.Top;
            this.dgvLopHoc.Location = new Point(3, 16);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.RowHeadersVisible = false;
            this.dgvLopHoc.Size = new Size(654, 168);
            this.dgvLopHoc.TabIndex = 0;
            this.dgvLopHoc.AllowUserToAddRows = false;

            // dgv check box select
            this.dgvCheckBox.HeaderText = "Select";
            this.dgvCheckBox.Name = "ckbSelect";
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
            // QuanLyLopHocControl
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyLopHocControl";
            this.Size = new Size(881, 517);
            this.panel1.ResumeLayout(false);
            this.grbDanhSachNganh.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.grbDanhSachLop.ResumeLayout(false);
            ((ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox grbDanhSachNganh;
        private Panel panel2;
        private Panel panel3;
        private GroupBox grbDanhSachLop;
        private DataGridView dgvLopHoc;
        private ListBox lstDanhSachNganh;
        private Panel panel4;
        private TextBox txtTenLop;
        private TextBox txtMaLop;
        private TextBox txtNganh;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewCheckBoxColumn dgvCheckBox;
        private DataGridViewTextBoxColumn clMaLop;
        private DataGridViewTextBoxColumn clTenLop;
        private DataGridViewTextBoxColumn clSiSo;
        private Button btnXoaThongTinLop;
        private Button btnLuuLop;
        private Button btnXoaLop;
        private Button btnSuaLop;
        private BackgroundWorker backgroundWorker1;
    }
}
