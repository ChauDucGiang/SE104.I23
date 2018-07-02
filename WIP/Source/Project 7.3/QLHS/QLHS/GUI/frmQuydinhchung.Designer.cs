namespace QLHS
{
    partial class frmQuydinhchung
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btEditAge = new System.Windows.Forms.Button();
            this.txtDotuoitoida = new System.Windows.Forms.TextBox();
            this.lblDotuoitoida = new System.Windows.Forms.Label();
            this.txtDotuoitoithieu = new System.Windows.Forms.TextBox();
            this.lblDotuoitoithieu = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCapNhatSiSo = new System.Windows.Forms.Button();
            this.txtSisotoida = new System.Windows.Forms.TextBox();
            this.lblSisotoida = new System.Windows.Forms.Label();
            this.txtSisotoithieu = new System.Windows.Forms.TextBox();
            this.lblSisotoithieu = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(419, 139);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btEditAge);
            this.tabPage1.Controls.Add(this.txtDotuoitoida);
            this.tabPage1.Controls.Add(this.lblDotuoitoida);
            this.tabPage1.Controls.Add(this.txtDotuoitoithieu);
            this.tabPage1.Controls.Add(this.lblDotuoitoithieu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(411, 113);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quy định độ tuổi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btEditAge
            // 
            this.btEditAge.Location = new System.Drawing.Point(317, 92);
            this.btEditAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btEditAge.Name = "btEditAge";
            this.btEditAge.Size = new System.Drawing.Size(82, 19);
            this.btEditAge.TabIndex = 4;
            this.btEditAge.Text = "Cập nhật";
            this.btEditAge.UseVisualStyleBackColor = true;
            this.btEditAge.Click += new System.EventHandler(this.btEditAge_Click);
            // 
            // txtDotuoitoida
            // 
            this.txtDotuoitoida.Location = new System.Drawing.Point(185, 61);
            this.txtDotuoitoida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDotuoitoida.Name = "txtDotuoitoida";
            this.txtDotuoitoida.Size = new System.Drawing.Size(139, 20);
            this.txtDotuoitoida.TabIndex = 3;
            // 
            // lblDotuoitoida
            // 
            this.lblDotuoitoida.AutoSize = true;
            this.lblDotuoitoida.Location = new System.Drawing.Point(82, 61);
            this.lblDotuoitoida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDotuoitoida.Name = "lblDotuoitoida";
            this.lblDotuoitoida.Size = new System.Drawing.Size(71, 13);
            this.lblDotuoitoida.TabIndex = 2;
            this.lblDotuoitoida.Text = "Độ tuổi tối đa";
            // 
            // txtDotuoitoithieu
            // 
            this.txtDotuoitoithieu.Location = new System.Drawing.Point(185, 28);
            this.txtDotuoitoithieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDotuoitoithieu.Name = "txtDotuoitoithieu";
            this.txtDotuoitoithieu.Size = new System.Drawing.Size(139, 20);
            this.txtDotuoitoithieu.TabIndex = 1;
            // 
            // lblDotuoitoithieu
            // 
            this.lblDotuoitoithieu.AutoSize = true;
            this.lblDotuoitoithieu.Location = new System.Drawing.Point(82, 30);
            this.lblDotuoitoithieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDotuoitoithieu.Name = "lblDotuoitoithieu";
            this.lblDotuoitoithieu.Size = new System.Drawing.Size(81, 13);
            this.lblDotuoitoithieu.TabIndex = 0;
            this.lblDotuoitoithieu.Text = "Độ tuổi tối thiểu";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCapNhatSiSo);
            this.tabPage2.Controls.Add(this.txtSisotoida);
            this.tabPage2.Controls.Add(this.lblSisotoida);
            this.tabPage2.Controls.Add(this.txtSisotoithieu);
            this.tabPage2.Controls.Add(this.lblSisotoithieu);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(411, 113);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quy định sĩ số";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatSiSo
            // 
            this.btnCapNhatSiSo.Location = new System.Drawing.Point(313, 94);
            this.btnCapNhatSiSo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapNhatSiSo.Name = "btnCapNhatSiSo";
            this.btnCapNhatSiSo.Size = new System.Drawing.Size(82, 19);
            this.btnCapNhatSiSo.TabIndex = 4;
            this.btnCapNhatSiSo.Text = "Cập nhật";
            this.btnCapNhatSiSo.UseVisualStyleBackColor = true;
            this.btnCapNhatSiSo.Click += new System.EventHandler(this.btnCapNhatSiSo_Click);
            // 
            // txtSisotoida
            // 
            this.txtSisotoida.Location = new System.Drawing.Point(164, 61);
            this.txtSisotoida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSisotoida.Name = "txtSisotoida";
            this.txtSisotoida.Size = new System.Drawing.Size(139, 20);
            this.txtSisotoida.TabIndex = 3;
            // 
            // lblSisotoida
            // 
            this.lblSisotoida.AutoSize = true;
            this.lblSisotoida.Location = new System.Drawing.Point(85, 61);
            this.lblSisotoida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSisotoida.Name = "lblSisotoida";
            this.lblSisotoida.Size = new System.Drawing.Size(63, 13);
            this.lblSisotoida.TabIndex = 2;
            this.lblSisotoida.Text = "Sĩ số tối đa";
            // 
            // txtSisotoithieu
            // 
            this.txtSisotoithieu.Location = new System.Drawing.Point(164, 30);
            this.txtSisotoithieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSisotoithieu.Name = "txtSisotoithieu";
            this.txtSisotoithieu.Size = new System.Drawing.Size(139, 20);
            this.txtSisotoithieu.TabIndex = 1;
            // 
            // lblSisotoithieu
            // 
            this.lblSisotoithieu.AutoSize = true;
            this.lblSisotoithieu.Location = new System.Drawing.Point(85, 30);
            this.lblSisotoithieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSisotoithieu.Name = "lblSisotoithieu";
            this.lblSisotoithieu.Size = new System.Drawing.Size(73, 13);
            this.lblSisotoithieu.TabIndex = 0;
            this.lblSisotoithieu.Text = "Sĩ số tối thiểu";
            // 
            // frmQuydinhchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 151);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmQuydinhchung";
            this.Text = "Quy định về độ tuổi";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtDotuoitoida;
        private System.Windows.Forms.Label lblDotuoitoida;
        private System.Windows.Forms.TextBox txtDotuoitoithieu;
        private System.Windows.Forms.Label lblDotuoitoithieu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSisotoida;
        private System.Windows.Forms.Label lblSisotoida;
        private System.Windows.Forms.TextBox txtSisotoithieu;
        private System.Windows.Forms.Label lblSisotoithieu;
        private System.Windows.Forms.Button btnCapNhatSiSo;
        private System.Windows.Forms.Button btEditAge;
    }
}