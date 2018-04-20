namespace QLHS
{
    partial class frmDoimatkhau
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
            this.grDoimatkhau = new DevExpress.XtraEditors.GroupControl();
            this.lblMatkhaucu = new System.Windows.Forms.Label();
            this.txtMatkhaucu = new System.Windows.Forms.TextBox();
            this.lblMatkhaumoi = new System.Windows.Forms.Label();
            this.txtMatkhaumoi = new System.Windows.Forms.TextBox();
            this.lblNhaplaimmatkhaumoi = new System.Windows.Forms.Label();
            this.txtNhaplaimatkhaumoi = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grDoimatkhau)).BeginInit();
            this.grDoimatkhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDoimatkhau
            // 
            this.grDoimatkhau.Controls.Add(this.btnHuy);
            this.grDoimatkhau.Controls.Add(this.btnLuu);
            this.grDoimatkhau.Controls.Add(this.txtNhaplaimatkhaumoi);
            this.grDoimatkhau.Controls.Add(this.txtMatkhaumoi);
            this.grDoimatkhau.Controls.Add(this.txtMatkhaucu);
            this.grDoimatkhau.Controls.Add(this.lblNhaplaimmatkhaumoi);
            this.grDoimatkhau.Controls.Add(this.lblMatkhaumoi);
            this.grDoimatkhau.Controls.Add(this.lblMatkhaucu);
            this.grDoimatkhau.Location = new System.Drawing.Point(109, 13);
            this.grDoimatkhau.Name = "grDoimatkhau";
            this.grDoimatkhau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grDoimatkhau.Size = new System.Drawing.Size(400, 195);
            this.grDoimatkhau.TabIndex = 0;
            this.grDoimatkhau.Text = "Đổi mật khẩu";
            // 
            // lblMatkhaucu
            // 
            this.lblMatkhaucu.AutoSize = true;
            this.lblMatkhaucu.Location = new System.Drawing.Point(6, 29);
            this.lblMatkhaucu.Name = "lblMatkhaucu";
            this.lblMatkhaucu.Size = new System.Drawing.Size(83, 17);
            this.lblMatkhaucu.TabIndex = 0;
            this.lblMatkhaucu.Text = "Mật khẩu cũ";
            // 
            // txtMatkhaucu
            // 
            this.txtMatkhaucu.Location = new System.Drawing.Point(176, 29);
            this.txtMatkhaucu.Name = "txtMatkhaucu";
            this.txtMatkhaucu.Size = new System.Drawing.Size(199, 23);
            this.txtMatkhaucu.TabIndex = 1;
            // 
            // lblMatkhaumoi
            // 
            this.lblMatkhaumoi.AutoSize = true;
            this.lblMatkhaumoi.Location = new System.Drawing.Point(6, 74);
            this.lblMatkhaumoi.Name = "lblMatkhaumoi";
            this.lblMatkhaumoi.Size = new System.Drawing.Size(90, 17);
            this.lblMatkhaumoi.TabIndex = 0;
            this.lblMatkhaumoi.Text = "Mật khẩu mới";
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Location = new System.Drawing.Point(176, 74);
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.PasswordChar = '*';
            this.txtMatkhaumoi.Size = new System.Drawing.Size(199, 23);
            this.txtMatkhaumoi.TabIndex = 1;
            // 
            // lblNhaplaimmatkhaumoi
            // 
            this.lblNhaplaimmatkhaumoi.AutoSize = true;
            this.lblNhaplaimmatkhaumoi.Location = new System.Drawing.Point(6, 124);
            this.lblNhaplaimmatkhaumoi.Name = "lblNhaplaimmatkhaumoi";
            this.lblNhaplaimmatkhaumoi.Size = new System.Drawing.Size(143, 17);
            this.lblNhaplaimmatkhaumoi.TabIndex = 0;
            this.lblNhaplaimmatkhaumoi.Text = "Nhập lại mật khẩu mới";
            // 
            // txtNhaplaimatkhaumoi
            // 
            this.txtNhaplaimatkhaumoi.Location = new System.Drawing.Point(176, 124);
            this.txtNhaplaimatkhaumoi.Name = "txtNhaplaimatkhaumoi";
            this.txtNhaplaimatkhaumoi.PasswordChar = '*';
            this.txtNhaplaimatkhaumoi.Size = new System.Drawing.Size(199, 23);
            this.txtNhaplaimatkhaumoi.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.Location = new System.Drawing.Point(176, 153);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 32);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(300, 153);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 32);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // frmDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 341);
            this.Controls.Add(this.grDoimatkhau);
            this.Name = "frmDoimatkhau";
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.grDoimatkhau)).EndInit();
            this.grDoimatkhau.ResumeLayout(false);
            this.grDoimatkhau.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grDoimatkhau;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtNhaplaimatkhaumoi;
        private System.Windows.Forms.TextBox txtMatkhaumoi;
        private System.Windows.Forms.TextBox txtMatkhaucu;
        private System.Windows.Forms.Label lblNhaplaimmatkhaumoi;
        private System.Windows.Forms.Label lblMatkhaumoi;
        private System.Windows.Forms.Label lblMatkhaucu;
    }
}