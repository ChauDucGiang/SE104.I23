namespace QLHS
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblDangnhap = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMatkhau = new System.Windows.Forms.Label();
            this.lblThongbaodangnhap = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.grDangnhap = new System.Windows.Forms.GroupBox();
            this.chkGhinhodangnhap = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grDangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDangnhap
            // 
            this.lblDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangnhap.Location = new System.Drawing.Point(12, 9);
            this.lblDangnhap.Name = "lblDangnhap";
            this.lblDangnhap.Size = new System.Drawing.Size(627, 38);
            this.lblDangnhap.TabIndex = 0;
            this.lblDangnhap.Text = "ĐĂNG NHẬP HỆ THỐNG QUẢN LÝ HỌC SINH";
            this.lblDangnhap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(27, 39);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(33, 17);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên";
            // 
            // lblMatkhau
            // 
            this.lblMatkhau.AutoSize = true;
            this.lblMatkhau.Location = new System.Drawing.Point(27, 87);
            this.lblMatkhau.Name = "lblMatkhau";
            this.lblMatkhau.Size = new System.Drawing.Size(66, 17);
            this.lblMatkhau.TabIndex = 2;
            this.lblMatkhau.Text = "Mật khẩu";
            // 
            // lblThongbaodangnhap
            // 
            this.lblThongbaodangnhap.AutoSize = true;
            this.lblThongbaodangnhap.Location = new System.Drawing.Point(133, 107);
            this.lblThongbaodangnhap.Name = "lblThongbaodangnhap";
            this.lblThongbaodangnhap.Size = new System.Drawing.Size(0, 17);
            this.lblThongbaodangnhap.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(133, 34);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(231, 22);
            this.txtTen.TabIndex = 1;
            this.txtTen.Enter += new System.EventHandler(this.txtTen_Enter);
            this.txtTen.Leave += new System.EventHandler(this.txtTen_Leave);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(133, 82);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(231, 22);
            this.txtMatkhau.TabIndex = 3;
            this.txtMatkhau.UseSystemPasswordChar = true;
            this.txtMatkhau.Enter += new System.EventHandler(this.txtMatkhau_Enter);
            this.txtMatkhau.Leave += new System.EventHandler(this.txtMatkhau_Leave);
            // 
            // grDangnhap
            // 
            this.grDangnhap.Controls.Add(this.chkGhinhodangnhap);
            this.grDangnhap.Controls.Add(this.btnThoat);
            this.grDangnhap.Controls.Add(this.btnDangnhap);
            this.grDangnhap.Controls.Add(this.txtTen);
            this.grDangnhap.Controls.Add(this.lblThongbaodangnhap);
            this.grDangnhap.Controls.Add(this.txtMatkhau);
            this.grDangnhap.Controls.Add(this.lblMatkhau);
            this.grDangnhap.Controls.Add(this.lblTen);
            this.grDangnhap.Location = new System.Drawing.Point(263, 50);
            this.grDangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grDangnhap.Name = "grDangnhap";
            this.grDangnhap.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grDangnhap.Size = new System.Drawing.Size(376, 225);
            this.grDangnhap.TabIndex = 0;
            this.grDangnhap.TabStop = false;
            this.grDangnhap.Text = "Đăng nhập";
            // 
            // chkGhinhodangnhap
            // 
            this.chkGhinhodangnhap.AutoSize = true;
            this.chkGhinhodangnhap.Location = new System.Drawing.Point(133, 127);
            this.chkGhinhodangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkGhinhodangnhap.Name = "chkGhinhodangnhap";
            this.chkGhinhodangnhap.Size = new System.Drawing.Size(152, 21);
            this.chkGhinhodangnhap.TabIndex = 5;
            this.chkGhinhodangnhap.Text = "Ghi nhớ đăng nhập";
            this.chkGhinhodangnhap.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QLHS.Properties.Resources.thoat;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(277, 167);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 57);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Image = global::QLHS.Properties.Resources.dangnhap1;
            this.btnDangnhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDangnhap.Location = new System.Drawing.Point(133, 167);
            this.btnDangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(83, 57);
            this.btnDangnhap.TabIndex = 6;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLHS.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(17, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnDangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(653, 286);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grDangnhap);
            this.Controls.Add(this.lblDangnhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grDangnhap.ResumeLayout(false);
            this.grDangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDangnhap;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMatkhau;
        private System.Windows.Forms.Label lblThongbaodangnhap;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.GroupBox grDangnhap;
        private System.Windows.Forms.CheckBox chkGhinhodangnhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}