namespace QLTinhHinh.GUI
{
    partial class FormBaoCao
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Khai báo các thành phần
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.lblChon = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();

            // 
            // panelTop (Chứa thanh chọn trạng thái)
            // 
            this.panelTop.Controls.Add(this.btnXem);
            this.panelTop.Controls.Add(this.cmbTrangThai);
            this.panelTop.Controls.Add(this.lblChon);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 60);
            this.panelTop.TabIndex = 0;
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;

            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(360, 15);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 30);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);

            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(100, 18);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(240, 24);
            this.cmbTrangThai.TabIndex = 1;

            // 
            // lblChon
            // 
            this.lblChon.AutoSize = true;
            this.lblChon.Location = new System.Drawing.Point(20, 21);
            this.lblChon.Name = "lblChon";
            this.lblChon.Size = new System.Drawing.Size(73, 17);
            this.lblChon.Text = "Trạng thái";

            // 
            // lblTieuDe (Tiêu đề to chính giữa)
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 60); // Nằm dưới Panel Top
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(800, 60);
            this.lblTieuDe.Text = "Thông tin tình hình dịch bệnh\ntại các địa phương";

            // 
            // lblSubTitle (Dòng chữ nghiêng: Tình hình...)
            // 
            this.lblSubTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubTitle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubTitle.Location = new System.Drawing.Point(0, 120); // Nằm dưới Tiêu đề to
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(800, 30);
            this.lblSubTitle.Text = "Tình hình: ...";

            // 
            // dgvBaoCao (Bảng dữ liệu)
            // 
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.White; // Nền trắng cho giống giấy in
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.ReadOnly = true; // Chỉ xem không sửa
            this.dgvBaoCao.RowHeadersVisible = false; // Ẩn cột thừa bên trái
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBaoCao.Location = new System.Drawing.Point(50, 160); // Căn lề một chút cho đẹp
            this.dgvBaoCao.Size = new System.Drawing.Size(700, 250);
            this.dgvBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));

            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White; // Toàn bộ nền trắng
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.panelTop);
            this.Name = "FormBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.Label lblChon;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.DataGridView dgvBaoCao;
    }
}