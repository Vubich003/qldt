namespace QuanLyDienThoai
{
    partial class frmTonKho
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
            this.dtpNgayThang = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.rpvBCTKho = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgayThang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 63);
            this.panel1.TabIndex = 1;
            // 
            // dtpNgayThang
            // 
            this.dtpNgayThang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThang.Location = new System.Drawing.Point(177, 15);
            this.dtpNgayThang.Name = "dtpNgayThang";
            this.dtpNgayThang.Size = new System.Drawing.Size(187, 26);
            this.dtpNgayThang.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tồn Kho";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(401, 12);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(158, 37);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "&Tạo Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // rpvBCTKho
            // 
            this.rpvBCTKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvBCTKho.LocalReport.ReportEmbeddedResource = "QuanLyDienThoai.rptBCTonKho.rdlc";
            this.rpvBCTKho.Location = new System.Drawing.Point(0, 63);
            this.rpvBCTKho.Name = "rpvBCTKho";
            this.rpvBCTKho.ServerReport.BearerToken = null;
            this.rpvBCTKho.Size = new System.Drawing.Size(1184, 387);
            this.rpvBCTKho.TabIndex = 2;
            // 
            // frmTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.rpvBCTKho);
            this.Controls.Add(this.panel1);
            this.Name = "frmTonKho";
            this.Text = "Tồn Kho";
            this.Load += new System.EventHandler(this.frmTonKho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBCTKho;
        private System.Windows.Forms.DateTimePicker dtpNgayThang;
        private System.Windows.Forms.Label label2;
    }
}