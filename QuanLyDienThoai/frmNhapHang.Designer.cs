namespace QuanLyDienThoai
{
    partial class frmNhapHang
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
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayGH = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rpvBCHangNhap = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpNgayGH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(412, 43);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(158, 37);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "&Tạo Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập vào ngày bán ";
            // 
            // dtpNgayGH
            // 
            this.dtpNgayGH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayGH.Location = new System.Drawing.Point(164, 51);
            this.dtpNgayGH.Name = "dtpNgayGH";
            this.dtpNgayGH.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayGH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày GH ";
            // 
            // rpvBCHangNhap
            // 
            this.rpvBCHangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvBCHangNhap.LocalReport.ReportEmbeddedResource = "QuanLyDienThoai.rptBCHangNhap.rdlc";
            this.rpvBCHangNhap.Location = new System.Drawing.Point(0, 100);
            this.rpvBCHangNhap.Name = "rpvBCHangNhap";
            this.rpvBCHangNhap.ServerReport.BearerToken = null;
            this.rpvBCHangNhap.Size = new System.Drawing.Size(1147, 553);
            this.rpvBCHangNhap.TabIndex = 1;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 653);
            this.Controls.Add(this.rpvBCHangNhap);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhapHang";
            this.Text = "frmNhapHang";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgayGH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBCHangNhap;
    }
}