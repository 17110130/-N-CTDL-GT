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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbDanhSachNganh = new System.Windows.Forms.GroupBox();
            this.tvNganh = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbNganh = new System.Windows.Forms.ComboBox();
            this.btnXoaThongTinLop = new System.Windows.Forms.Button();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grbDanhSachLop = new System.Windows.Forms.GroupBox();
            this.lvDanhSachLop = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.grbDanhSachNganh.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grbDanhSachLop.SuspendLayout();
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
            this.grbDanhSachNganh.BackColor = System.Drawing.Color.White;
            this.grbDanhSachNganh.Controls.Add(this.tvNganh);
            this.grbDanhSachNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDanhSachNganh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbDanhSachNganh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachNganh.Location = new System.Drawing.Point(0, 0);
            this.grbDanhSachNganh.Name = "grbDanhSachNganh";
            this.grbDanhSachNganh.Size = new System.Drawing.Size(221, 517);
            this.grbDanhSachNganh.TabIndex = 0;
            this.grbDanhSachNganh.TabStop = false;
            this.grbDanhSachNganh.Text = "Danh sách ngành";
            // 
            // tvNganh
            // 
            this.tvNganh.BackColor = System.Drawing.Color.Chartreuse;
            this.tvNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvNganh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNganh.Location = new System.Drawing.Point(3, 18);
            this.tvNganh.Name = "tvNganh";
            this.tvNganh.Size = new System.Drawing.Size(215, 496);
            this.tvNganh.TabIndex = 0;
            this.tvNganh.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvNganh_AfterSelect);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Khaki;
            this.panel4.Controls.Add(this.cbNganh);
            this.panel4.Controls.Add(this.btnXoaThongTinLop);
            this.panel4.Controls.Add(this.btnThemLop);
            this.panel4.Controls.Add(this.txtTenLop);
            this.panel4.Controls.Add(this.txtMaLop);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(660, 267);
            this.panel4.TabIndex = 1;
            // 
            // cbNganh
            // 
            this.cbNganh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNganh.FormattingEnabled = true;
            this.cbNganh.Location = new System.Drawing.Point(110, 23);
            this.cbNganh.Name = "cbNganh";
            this.cbNganh.Size = new System.Drawing.Size(527, 27);
            this.cbNganh.TabIndex = 0;
            this.cbNganh.SelectedIndexChanged += new System.EventHandler(this.cbNganh_SelectedIndexChanged);
            this.cbNganh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNganh_KeyPress);
            // 
            // btnXoaThongTinLop
            // 
            this.btnXoaThongTinLop.BackColor = System.Drawing.Color.LawnGreen;
            this.btnXoaThongTinLop.FlatAppearance.BorderSize = 0;
            this.btnXoaThongTinLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaThongTinLop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThongTinLop.Location = new System.Drawing.Point(336, 158);
            this.btnXoaThongTinLop.Name = "btnXoaThongTinLop";
            this.btnXoaThongTinLop.Size = new System.Drawing.Size(136, 55);
            this.btnXoaThongTinLop.TabIndex = 4;
            this.btnXoaThongTinLop.Text = "Xóa Thông TIn";
            this.btnXoaThongTinLop.UseVisualStyleBackColor = false;
            this.btnXoaThongTinLop.Click += new System.EventHandler(this.btnXoaThongTinLop_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThemLop.FlatAppearance.BorderSize = 0;
            this.btnThemLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLop.Location = new System.Drawing.Point(194, 158);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(136, 55);
            this.btnThemLop.TabIndex = 3;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.UseVisualStyleBackColor = false;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(110, 109);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(527, 22);
            this.txtTenLop.TabIndex = 2;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(110, 61);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(527, 22);
            this.txtMaLop.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngành:";
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
            this.grbDanhSachLop.BackColor = System.Drawing.Color.Gray;
            this.grbDanhSachLop.Controls.Add(this.lvDanhSachLop);
            this.grbDanhSachLop.Controls.Add(this.btnXoaLop);
            this.grbDanhSachLop.Controls.Add(this.btnSuaLop);
            this.grbDanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDanhSachLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachLop.Location = new System.Drawing.Point(0, 0);
            this.grbDanhSachLop.Name = "grbDanhSachLop";
            this.grbDanhSachLop.Size = new System.Drawing.Size(660, 250);
            this.grbDanhSachLop.TabIndex = 0;
            this.grbDanhSachLop.TabStop = false;
            this.grbDanhSachLop.Text = "Danh sách lớp";
            // 
            // lvDanhSachLop
            // 
            this.lvDanhSachLop.BackColor = System.Drawing.Color.Coral;
            this.lvDanhSachLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvDanhSachLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDanhSachLop.FullRowSelect = true;
            this.lvDanhSachLop.GridLines = true;
            this.lvDanhSachLop.HideSelection = false;
            this.lvDanhSachLop.Location = new System.Drawing.Point(6, 19);
            this.lvDanhSachLop.Name = "lvDanhSachLop";
            this.lvDanhSachLop.Size = new System.Drawing.Size(631, 165);
            this.lvDanhSachLop.TabIndex = 0;
            this.lvDanhSachLop.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachLop.View = System.Windows.Forms.View.Details;
            this.lvDanhSachLop.DoubleClick += new System.EventHandler(this.lvDanhSachLop_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Lớp";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Lớp";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 329;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng sinh viên";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 158;
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.BackColor = System.Drawing.Color.Red;
            this.btnXoaLop.FlatAppearance.BorderSize = 0;
            this.btnXoaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLop.Location = new System.Drawing.Point(501, 190);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(136, 55);
            this.btnXoaLop.TabIndex = 2;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = false;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.BackColor = System.Drawing.Color.Gold;
            this.btnSuaLop.Enabled = false;
            this.btnSuaLop.FlatAppearance.BorderSize = 0;
            this.btnSuaLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLop.Location = new System.Drawing.Point(359, 189);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(136, 55);
            this.btnSuaLop.TabIndex = 1;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = false;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // QuanLyLopHocControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyLopHocControl";
            this.Size = new System.Drawing.Size(881, 517);
            this.Load += new System.EventHandler(this.QuanLyLopHocControl_Load);
            this.panel1.ResumeLayout(false);
            this.grbDanhSachNganh.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.grbDanhSachLop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox grbDanhSachNganh;
        private Panel panel2;
        private Panel panel3;
        private GroupBox grbDanhSachLop;
        private Panel panel4;
        private TextBox txtTenLop;
        private TextBox txtMaLop;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewCheckBoxColumn dgvCheckBox;
        private Button btnXoaThongTinLop;
        private Button btnThemLop;
        private Button btnXoaLop;
        private Button btnSuaLop;
        private BackgroundWorker backgroundWorker1;
        private ListView lvDanhSachLop;
        private TreeView tvNganh;
        private ComboBox cbNganh;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
