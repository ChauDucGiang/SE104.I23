namespace QLHS
{
    partial class frmKetquacanamtheomon
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXem = new System.Windows.Forms.Button();
            this.cmbMonhoc = new System.Windows.Forms.ComboBox();
            this.lblMonhoc = new System.Windows.Forms.Label();
            this.cmbNamhoc = new System.Windows.Forms.ComboBox();
            this.lblNamhoc = new System.Windows.Forms.Label();
            this.lblNhapthongtin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVKetquacanamtheomon = new System.Windows.Forms.DataGridView();
            this.colMahocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemtrungbinhmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaidiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKetquacanamtheomon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnXem);
            this.panelControl1.Controls.Add(this.cmbMonhoc);
            this.panelControl1.Controls.Add(this.lblMonhoc);
            this.panelControl1.Controls.Add(this.cmbNamhoc);
            this.panelControl1.Controls.Add(this.lblNamhoc);
            this.panelControl1.Controls.Add(this.lblNhapthongtin);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(200, 450);
            this.panelControl1.TabIndex = 0;
            // 
            // btnXem
            // 
            this.btnXem.Image = global::QLHS.Properties.Resources.xemdiem;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXem.Location = new System.Drawing.Point(0, 308);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(197, 40);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // cmbMonhoc
            // 
            this.cmbMonhoc.FormattingEnabled = true;
            this.cmbMonhoc.Location = new System.Drawing.Point(0, 205);
            this.cmbMonhoc.Name = "cmbMonhoc";
            this.cmbMonhoc.Size = new System.Drawing.Size(197, 24);
            this.cmbMonhoc.TabIndex = 4;
            // 
            // lblMonhoc
            // 
            this.lblMonhoc.AutoSize = true;
            this.lblMonhoc.Location = new System.Drawing.Point(0, 185);
            this.lblMonhoc.Name = "lblMonhoc";
            this.lblMonhoc.Size = new System.Drawing.Size(61, 17);
            this.lblMonhoc.TabIndex = 3;
            this.lblMonhoc.Text = "Môn học";
            // 
            // cmbNamhoc
            // 
            this.cmbNamhoc.FormattingEnabled = true;
            this.cmbNamhoc.Location = new System.Drawing.Point(0, 114);
            this.cmbNamhoc.Name = "cmbNamhoc";
            this.cmbNamhoc.Size = new System.Drawing.Size(197, 24);
            this.cmbNamhoc.TabIndex = 2;
            // 
            // lblNamhoc
            // 
            this.lblNamhoc.AutoSize = true;
            this.lblNamhoc.Location = new System.Drawing.Point(0, 94);
            this.lblNamhoc.Name = "lblNamhoc";
            this.lblNamhoc.Size = new System.Drawing.Size(63, 17);
            this.lblNamhoc.TabIndex = 1;
            this.lblNamhoc.Text = "Năm học";
            // 
            // lblNhapthongtin
            // 
            this.lblNhapthongtin.AutoSize = true;
            this.lblNhapthongtin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblNhapthongtin.Location = new System.Drawing.Point(5, 2);
            this.lblNhapthongtin.Name = "lblNhapthongtin";
            this.lblNhapthongtin.Size = new System.Drawing.Size(188, 24);
            this.lblNhapthongtin.TabIndex = 0;
            this.lblNhapthongtin.Text = "NHẬP THÔNG TIN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVKetquacanamtheomon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(200, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học sinh";
            // 
            // dGVKetquacanamtheomon
            // 
            this.dGVKetquacanamtheomon.AllowUserToAddRows = false;
            this.dGVKetquacanamtheomon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVKetquacanamtheomon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVKetquacanamtheomon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMahocsinh,
            this.colTenhocsinh,
            this.colDiemtrungbinhmon,
            this.colLoaidiem});
            this.dGVKetquacanamtheomon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVKetquacanamtheomon.Location = new System.Drawing.Point(3, 18);
            this.dGVKetquacanamtheomon.Name = "dGVKetquacanamtheomon";
            this.dGVKetquacanamtheomon.RowTemplate.Height = 24;
            this.dGVKetquacanamtheomon.Size = new System.Drawing.Size(594, 429);
            this.dGVKetquacanamtheomon.TabIndex = 0;
            // 
            // colMahocsinh
            // 
            this.colMahocsinh.HeaderText = "Mã học sinh";
            this.colMahocsinh.Name = "colMahocsinh";
            // 
            // colTenhocsinh
            // 
            this.colTenhocsinh.HeaderText = "Tên học sinh";
            this.colTenhocsinh.Name = "colTenhocsinh";
            // 
            // colDiemtrungbinhmon
            // 
            this.colDiemtrungbinhmon.HeaderText = "Điểm trung bình môn";
            this.colDiemtrungbinhmon.Name = "colDiemtrungbinhmon";
            // 
            // colLoaidiem
            // 
            this.colLoaidiem.HeaderText = "Loại điểm";
            this.colLoaidiem.Name = "colLoaidiem";
            // 
            // frmKetquacanamtheomon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmKetquacanamtheomon";
            this.Text = "Kết quả cả năm theo môn";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVKetquacanamtheomon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cmbMonhoc;
        private System.Windows.Forms.Label lblMonhoc;
        private System.Windows.Forms.ComboBox cmbNamhoc;
        private System.Windows.Forms.Label lblNamhoc;
        private System.Windows.Forms.Label lblNhapthongtin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGVKetquacanamtheomon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMahocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenhocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemtrungbinhmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaidiem;
    }
}