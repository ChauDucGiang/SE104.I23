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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoimatkhau));
            this.grDoimatkhau = new DevExpress.XtraEditors.GroupControl();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.txtNhaplaimatkhaumoi = new System.Windows.Forms.TextBox();
            this.txtMatkhaumoi = new System.Windows.Forms.TextBox();
            this.txtMatkhaucu = new System.Windows.Forms.TextBox();
            this.lblNhaplaimmatkhaumoi = new System.Windows.Forms.Label();
            this.lblMatkhaumoi = new System.Windows.Forms.Label();
            this.lblMatkhaucu = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
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
            this.grDoimatkhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.grDoimatkhau.Location = new System.Drawing.Point(0, 0);
            this.grDoimatkhau.Name = "grDoimatkhau";
            this.grDoimatkhau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grDoimatkhau.Size = new System.Drawing.Size(361, 206);
            this.grDoimatkhau.TabIndex = 0;
            this.grDoimatkhau.Text = "Đổi mật khẩu";
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(262, 168);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(66, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Location = new System.Drawing.Point(154, 168);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(66, 23);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // txtNhaplaimatkhaumoi
            // 
            this.txtNhaplaimatkhaumoi.Location = new System.Drawing.Point(154, 124);
            this.txtNhaplaimatkhaumoi.Name = "txtNhaplaimatkhaumoi";
            this.txtNhaplaimatkhaumoi.PasswordChar = '*';
            this.txtNhaplaimatkhaumoi.Size = new System.Drawing.Size(175, 23);
            this.txtNhaplaimatkhaumoi.TabIndex = 5;
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Location = new System.Drawing.Point(154, 74);
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.PasswordChar = '*';
            this.txtMatkhaumoi.Size = new System.Drawing.Size(175, 23);
            this.txtMatkhaumoi.TabIndex = 3;
            // 
            // txtMatkhaucu
            // 
            this.txtMatkhaucu.Location = new System.Drawing.Point(154, 29);
            this.txtMatkhaucu.Name = "txtMatkhaucu";
            this.txtMatkhaucu.Size = new System.Drawing.Size(175, 23);
            this.txtMatkhaucu.TabIndex = 1;
            // 
            // lblNhaplaimmatkhaumoi
            // 
            this.lblNhaplaimmatkhaumoi.AutoSize = true;
            this.lblNhaplaimmatkhaumoi.Location = new System.Drawing.Point(5, 124);
            this.lblNhaplaimmatkhaumoi.Name = "lblNhaplaimmatkhaumoi";
            this.lblNhaplaimmatkhaumoi.Size = new System.Drawing.Size(143, 17);
            this.lblNhaplaimmatkhaumoi.TabIndex = 4;
            this.lblNhaplaimmatkhaumoi.Text = "Nhập lại mật khẩu mới";
            // 
            // lblMatkhaumoi
            // 
            this.lblMatkhaumoi.AutoSize = true;
            this.lblMatkhaumoi.Location = new System.Drawing.Point(5, 74);
            this.lblMatkhaumoi.Name = "lblMatkhaumoi";
            this.lblMatkhaumoi.Size = new System.Drawing.Size(90, 17);
            this.lblMatkhaumoi.TabIndex = 2;
            this.lblMatkhaumoi.Text = "Mật khẩu mới";
            // 
            // lblMatkhaucu
            // 
            this.lblMatkhaucu.AutoSize = true;
            this.lblMatkhaucu.Location = new System.Drawing.Point(5, 29);
            this.lblMatkhaucu.Name = "lblMatkhaucu";
            this.lblMatkhaucu.Size = new System.Drawing.Size(83, 17);
            this.lblMatkhaucu.TabIndex = 0;
            this.lblMatkhaucu.Text = "Mật khẩu cũ";
            // 
            // frmDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(361, 205);
            this.Controls.Add(this.grDoimatkhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoimatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoimatkhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grDoimatkhau)).EndInit();
            this.grDoimatkhau.ResumeLayout(false);
            this.grDoimatkhau.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grDoimatkhau;
        private System.Windows.Forms.TextBox txtNhaplaimatkhaumoi;
        private System.Windows.Forms.TextBox txtMatkhaumoi;
        private System.Windows.Forms.TextBox txtMatkhaucu;
        private System.Windows.Forms.Label lblNhaplaimmatkhaumoi;
        private System.Windows.Forms.Label lblMatkhaumoi;
        private System.Windows.Forms.Label lblMatkhaucu;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}