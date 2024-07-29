namespace QuanLyDienThoai
{
    partial class frmHangHoa
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
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.rpvBCHangHoa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgayBan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 100);
            this.panel1.TabIndex = 0;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(166, 28);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(187, 26);
            this.dtpNgayBan.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày Bán";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(390, 25);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(158, 37);
            this.btnBaoCao.TabIndex = 7;
            this.btnBaoCao.Text = "&Tạo Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // rpvBCHangHoa
            // 
            this.rpvBCHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvBCHangHoa.LocalReport.ReportEmbeddedResource = "QuanLyDienThoai.rptBCHangHoa.rdlc";
            this.rpvBCHangHoa.Location = new System.Drawing.Point(0, 100);
            this.rpvBCHangHoa.Name = "rpvBCHangHoa";
            this.rpvBCHangHoa.ServerReport.BearerToken = null;
            this.rpvBCHangHoa.Size = new System.Drawing.Size(1124, 503);
            this.rpvBCHangHoa.TabIndex = 1;
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 603);
            this.Controls.Add(this.rpvBCHangHoa);
            this.Controls.Add(this.panel1);
            this.Name = "frmHangHoa";
            this.Text = "frmHangHoa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBCHangHoa;
    }
}