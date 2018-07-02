namespace QLHS
{
    partial class frmThongtintruonghoc
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
            this.lblTruong = new System.Windows.Forms.Label();
            this.lblTentruong = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblMatruong = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTruong
            // 
            this.lblTruong.AutoSize = true;
            this.lblTruong.Location = new System.Drawing.Point(57, 11);
            this.lblTruong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTruong.Name = "lblTruong";
            this.lblTruong.Size = new System.Drawing.Size(47, 13);
            this.lblTruong.TabIndex = 0;
            this.lblTruong.Text = "Trường :";
            // 
            // lblTentruong
            // 
            this.lblTentruong.AutoSize = true;
            this.lblTentruong.Location = new System.Drawing.Point(122, 11);
            this.lblTentruong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTentruong.Name = "lblTentruong";
            this.lblTentruong.Size = new System.Drawing.Size(0, 13);
            this.lblTentruong.TabIndex = 0;
            this.lblTentruong.Click += new System.EventHandler(this.lblTentruong_Click);
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(57, 61);
            this.lblDC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(55, 13);
            this.lblDC.TabIndex = 0;
            this.lblDC.Text = "Mã trường";
            // 
            // lblMatruong
            // 
            this.lblMatruong.AutoSize = true;
            this.lblMatruong.Location = new System.Drawing.Point(122, 61);
            this.lblMatruong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatruong.Name = "lblMatruong";
            this.lblMatruong.Size = new System.Drawing.Size(0, 13);
            this.lblMatruong.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QLHS.Properties.Resources.exit1;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDong.Location = new System.Drawing.Point(232, 105);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(62, 34);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmThongtintruonghoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 149);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblMatruong);
            this.Controls.Add(this.lblDC);
            this.Controls.Add(this.lblTentruong);
            this.Controls.Add(this.lblTruong);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongtintruonghoc";
            this.Text = "Thông tin trường học";
            this.Load += new System.EventHandler(this.frmThongtintruonghoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTruong;
        private System.Windows.Forms.Label lblTentruong;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblMatruong;
        private System.Windows.Forms.Button btnDong;
    }
}