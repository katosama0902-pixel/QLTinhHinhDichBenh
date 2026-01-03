namespace QLTinhHinh.GUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSapXep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNguyCo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtSoCa = new System.Windows.Forms.TextBox();
            this.txtTenDP = new System.Windows.Forms.TextBox();
            this.txtMaDP = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblSoCa = new System.Windows.Forms.Label();
            this.lblTenDP = new System.Windows.Forms.Label();
            this.lblMaDP = new System.Windows.Forms.Label();
            this.dgvDiaPhuong = new System.Windows.Forms.DataGridView();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaPhuong)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuChucNang
            // 
            this.mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSapXep,
            this.mnuNguyCo,
            this.mnuBaoCao});
            this.mnuChucNang.Name = "mnuChucNang";
            this.mnuChucNang.Size = new System.Drawing.Size(93, 24);
            this.mnuChucNang.Text = "Chức năng";
            // 
            // mnuSapXep
            // 
            this.mnuSapXep.Name = "mnuSapXep";
            this.mnuSapXep.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuSapXep.Size = new System.Drawing.Size(319, 26);
            this.mnuSapXep.Text = "Sắp xếp theo số ca nhiễm";
            this.mnuSapXep.Click += new System.EventHandler(this.mnuSapXep_Click);
            // 
            // mnuNguyCo
            // 
            this.mnuNguyCo.Name = "mnuNguyCo";
            this.mnuNguyCo.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuNguyCo.Size = new System.Drawing.Size(319, 26);
            this.mnuNguyCo.Text = "Các địa phương nhóm nguy cơ";
            this.mnuNguyCo.Click += new System.EventHandler(this.mnuNguyCo_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuBaoCao.Size = new System.Drawing.Size(319, 26);
            this.mnuBaoCao.Text = "Xuất Báo cáo";
            this.mnuBaoCao.Click += new System.EventHandler(this.mnuBaoCao_Click);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.btnCapNhat);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.cmbTrangThai);
            this.grpThongTin.Controls.Add(this.txtSoCa);
            this.grpThongTin.Controls.Add(this.txtTenDP);
            this.grpThongTin.Controls.Add(this.txtMaDP);
            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.lblSoCa);
            this.grpThongTin.Controls.Add(this.lblTenDP);
            this.grpThongTin.Controls.Add(this.lblMaDP);
            this.grpThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTin.Location = new System.Drawing.Point(12, 80);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(350, 350);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin địa phương";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(198, 260);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(120, 40);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 260);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(150, 190);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(180, 28);
            this.cmbTrangThai.TabIndex = 3;
            // 
            // txtSoCa
            // 
            this.txtSoCa.Location = new System.Drawing.Point(150, 140);
            this.txtSoCa.Name = "txtSoCa";
            this.txtSoCa.Size = new System.Drawing.Size(180, 26);
            this.txtSoCa.TabIndex = 2;
            // 
            // txtTenDP
            // 
            this.txtTenDP.Location = new System.Drawing.Point(150, 90);
            this.txtTenDP.Name = "txtTenDP";
            this.txtTenDP.Size = new System.Drawing.Size(180, 26);
            this.txtTenDP.TabIndex = 1;
            // 
            // txtMaDP
            // 
            this.txtMaDP.Location = new System.Drawing.Point(150, 40);
            this.txtMaDP.MaxLength = 3;
            this.txtMaDP.Name = "txtMaDP";
            this.txtMaDP.Size = new System.Drawing.Size(100, 26);
            this.txtMaDP.TabIndex = 0;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(15, 193);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(89, 20);
            this.lblTrangThai.TabIndex = 0;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // lblSoCa
            // 
            this.lblSoCa.AutoSize = true;
            this.lblSoCa.Location = new System.Drawing.Point(15, 143);
            this.lblSoCa.Name = "lblSoCa";
            this.lblSoCa.Size = new System.Drawing.Size(134, 20);
            this.lblSoCa.TabIndex = 0;
            this.lblSoCa.Text = "Số ca nhiễm mới";
            // 
            // lblTenDP
            // 
            this.lblTenDP.AutoSize = true;
            this.lblTenDP.Location = new System.Drawing.Point(15, 93);
            this.lblTenDP.Name = "lblTenDP";
            this.lblTenDP.Size = new System.Drawing.Size(128, 20);
            this.lblTenDP.TabIndex = 0;
            this.lblTenDP.Text = "Tên Địa Phương";
            // 
            // lblMaDP
            // 
            this.lblMaDP.AutoSize = true;
            this.lblMaDP.Location = new System.Drawing.Point(15, 43);
            this.lblMaDP.Name = "lblMaDP";
            this.lblMaDP.Size = new System.Drawing.Size(123, 20);
            this.lblMaDP.TabIndex = 0;
            this.lblMaDP.Text = "Mã Địa Phương";
            // 
            // dgvDiaPhuong
            // 
            this.dgvDiaPhuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiaPhuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiaPhuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiaPhuong.Location = new System.Drawing.Point(380, 80);
            this.dgvDiaPhuong.MultiSelect = false;
            this.dgvDiaPhuong.Name = "dgvDiaPhuong";
            this.dgvDiaPhuong.ReadOnly = true;
            this.dgvDiaPhuong.RowHeadersWidth = 51;
            this.dgvDiaPhuong.RowTemplate.Height = 24;
            this.dgvDiaPhuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiaPhuong.Size = new System.Drawing.Size(600, 350);
            this.dgvDiaPhuong.TabIndex = 6;
            this.dgvDiaPhuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiaPhuong_CellClick);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.Location = new System.Drawing.Point(350, 35);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(397, 39);
            this.lblTieuDe.TabIndex = 3;
            this.lblTieuDe.Text = "Tình hình dịch Covid 19";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 460);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.dgvDiaPhuong);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin địa phương";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiaPhuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang;
        private System.Windows.Forms.ToolStripMenuItem mnuSapXep;
        private System.Windows.Forms.ToolStripMenuItem mnuNguyCo;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaDP;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblSoCa;
        private System.Windows.Forms.Label lblTenDP;
        private System.Windows.Forms.TextBox txtSoCa;
        private System.Windows.Forms.TextBox txtTenDP;
        private System.Windows.Forms.TextBox txtMaDP;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDiaPhuong;
        private System.Windows.Forms.Label lblTieuDe;
    }
}