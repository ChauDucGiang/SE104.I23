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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtNhaplaimatkhaumoi = new System.Windows.Forms.TextBox();
            this.txtMatkhaumoi = new System.Windows.Forms.TextBox();
            this.txtMatkhaucu = new System.Windows.Forms.TextBox();
            this.lblNhaplaimmatkhaumoi = new System.Windows.Forms.Label();
            this.lblMatkhaumoi = new System.Windows.Forms.Label();
            this.lblMatkhaucu = new System.Windows.Forms.Label();
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
            this.grDoimatkhau.Location = new System.Drawing.Point(9, 5);
            this.grDoimatkhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grDoimatkhau.Name = "grDoimatkhau";
            this.grDoimatkhau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grDoimatkhau.Size = new System.Drawing.Size(300, 174);
            this.grDoimatkhau.TabIndex = 0;
            this.grDoimatkhau.Text = "Đổi mật khẩu";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(225, 124);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(56, 46);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.Image = global::QLHS.Properties.Resources.save;
            this.btnLuu.Location = new System.Drawing.Point(132, 124);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(56, 46);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtNhaplaimatkhaumoi
            // 
            this.txtNhaplaimatkhaumoi.Location = new System.Drawing.Point(132, 101);
            this.txtNhaplaimatkhaumoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNhaplaimatkhaumoi.Name = "txtNhaplaimatkhaumoi";
            this.txtNhaplaimatkhaumoi.PasswordChar = '*';
            this.txtNhaplaimatkhaumoi.Size = new System.Drawing.Size(150, 21);
            this.txtNhaplaimatkhaumoi.TabIndex = 5;
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Location = new System.Drawing.Point(132, 60);
            this.txtMatkhaumoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.PasswordChar = '*';
            this.txtMatkhaumoi.Size = new System.Drawing.Size(150, 21);
            this.txtMatkhaumoi.TabIndex = 3;
            // 
            // txtMatkhaucu
            // 
            this.txtMatkhaucu.Location = new System.Drawing.Point(132, 24);
            this.txtMatkhaucu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatkhaucu.Name = "txtMatkhaucu";
            this.txtMatkhaucu.Size = new System.Drawing.Size(150, 21);
            this.txtMatkhaucu.TabIndex = 1;
            // 
            // lblNhaplaimmatkhaumoi
            // 
            this.lblNhaplaimmatkhaumoi.AutoSize = true;
            this.lblNhaplaimmatkhaumoi.Location = new System.Drawing.Point(4, 101);
            this.lblNhaplaimmatkhaumoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhaplaimmatkhaumoi.Name = "lblNhaplaimmatkhaumoi";
            this.lblNhaplaimmatkhaumoi.Size = new System.Drawing.Size(111, 13);
            this.lblNhaplaimmatkhaumoi.TabIndex = 4;
            this.lblNhaplaimmatkhaumoi.Text = "Nhập lại mật khẩu mới";
            // 
            // lblMatkhaumoi
            // 
            this.lblMatkhaumoi.AutoSize = true;
            this.lblMatkhaumoi.Location = new System.Drawing.Point(4, 60);
            this.lblMatkhaumoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatkhaumoi.Name = "lblMatkhaumoi";
            this.lblMatkhaumoi.Size = new System.Drawing.Size(70, 13);
            this.lblMatkhaumoi.TabIndex = 2;
            this.lblMatkhaumoi.Text = "Mật khẩu mới";
            // 
            // lblMatkhaucu
            // 
            this.lblMatkhaucu.AutoSize = true;
            this.lblMatkhaucu.Location = new System.Drawing.Point(4, 24);
            this.lblMatkhaucu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatkhaucu.Name = "lblMatkhaucu";
            this.lblMatkhaucu.Size = new System.Drawing.Size(65, 13);
            this.lblMatkhaucu.TabIndex = 0;
            this.lblMatkhaucu.Text = "Mật khẩu cũ";
            // 
            // frmDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 188);
            this.Controls.Add(this.grDoimatkhau);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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