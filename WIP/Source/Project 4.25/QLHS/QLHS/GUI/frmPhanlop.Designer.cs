namespace QLHS
{
    partial class frmPhanlop
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblLopcu = new System.Windows.Forms.Label();
            this.lblKhoilopcu = new System.Windows.Forms.Label();
            this.lblNamhoccu = new System.Windows.Forms.Label();
            this.cmbLopcu = new System.Windows.Forms.ComboBox();
            this.cmbKhoilopcu = new System.Windows.Forms.ComboBox();
            this.cmbNamhoccu = new System.Windows.Forms.ComboBox();
            this.lvLopcu = new System.Windows.Forms.ListView();
            this.colMahocsinhcu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenhocsinhcu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbNewStudent = new System.Windows.Forms.CheckBox();
            this.btnChuyentatca = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChuyentungnguoimot = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblLopmoi = new System.Windows.Forms.Label();
            this.cmbNamhocmoi = new System.Windows.Forms.ComboBox();
            this.cmbKhoilopmoi = new System.Windows.Forms.ComboBox();
            this.lblKhoilopmoi = new System.Windows.Forms.Label();
            this.cmbLopmoi = new System.Windows.Forms.ComboBox();
            this.lblNamhocmoi = new System.Windows.Forms.Label();
            this.lvLopmoi = new System.Windows.Forms.ListView();
            this.colMahocsinhmoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenhocsinhmoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.panelControl1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(757, 549);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupControl1);
            this.flowLayoutPanel2.Controls.Add(this.lvLopcu);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(286, 543);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblLopcu);
            this.groupControl1.Controls.Add(this.lblKhoilopcu);
            this.groupControl1.Controls.Add(this.lblNamhoccu);
            this.groupControl1.Controls.Add(this.cmbLopcu);
            this.groupControl1.Controls.Add(this.cmbKhoilopcu);
            this.groupControl1.Controls.Add(this.cmbNamhoccu);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(278, 153);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin lớp cũ";
            // 
            // lblLopcu
            // 
            this.lblLopcu.AutoSize = true;
            this.lblLopcu.Location = new System.Drawing.Point(6, 121);
            this.lblLopcu.Name = "lblLopcu";
            this.lblLopcu.Size = new System.Drawing.Size(31, 17);
            this.lblLopcu.TabIndex = 1;
            this.lblLopcu.Text = "Lớp";
            // 
            // lblKhoilopcu
            // 
            this.lblKhoilopcu.AutoSize = true;
            this.lblKhoilopcu.Location = new System.Drawing.Point(6, 79);
            this.lblKhoilopcu.Name = "lblKhoilopcu";
            this.lblKhoilopcu.Size = new System.Drawing.Size(56, 17);
            this.lblKhoilopcu.TabIndex = 1;
            this.lblKhoilopcu.Text = "Khối lớp";
            // 
            // lblNamhoccu
            // 
            this.lblNamhoccu.AutoSize = true;
            this.lblNamhoccu.Location = new System.Drawing.Point(6, 37);
            this.lblNamhoccu.Name = "lblNamhoccu";
            this.lblNamhoccu.Size = new System.Drawing.Size(63, 17);
            this.lblNamhoccu.TabIndex = 1;
            this.lblNamhoccu.Text = "Năm học";
            // 
            // cmbLopcu
            // 
            this.cmbLopcu.FormattingEnabled = true;
            this.cmbLopcu.Location = new System.Drawing.Point(138, 118);
            this.cmbLopcu.Name = "cmbLopcu";
            this.cmbLopcu.Size = new System.Drawing.Size(121, 24);
            this.cmbLopcu.TabIndex = 0;
            this.cmbLopcu.SelectedIndexChanged += new System.EventHandler(this.cmbLopcu_SelectedIndexChanged);
            // 
            // cmbKhoilopcu
            // 
            this.cmbKhoilopcu.FormattingEnabled = true;
            this.cmbKhoilopcu.Location = new System.Drawing.Point(138, 76);
            this.cmbKhoilopcu.Name = "cmbKhoilopcu";
            this.cmbKhoilopcu.Size = new System.Drawing.Size(121, 24);
            this.cmbKhoilopcu.TabIndex = 0;
            this.cmbKhoilopcu.SelectedIndexChanged += new System.EventHandler(this.cmbKhoilopcu_SelectedIndexChanged);
            // 
            // cmbNamhoccu
            // 
            this.cmbNamhoccu.FormattingEnabled = true;
            this.cmbNamhoccu.Location = new System.Drawing.Point(138, 31);
            this.cmbNamhoccu.Name = "cmbNamhoccu";
            this.cmbNamhoccu.Size = new System.Drawing.Size(121, 24);
            this.cmbNamhoccu.TabIndex = 0;
            this.cmbNamhoccu.SelectedIndexChanged += new System.EventHandler(this.cmbNamhoccu_SelectedIndexChanged);
            // 
            // lvLopcu
            // 
            this.lvLopcu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMahocsinhcu,
            this.colTenhocsinhcu});
            this.lvLopcu.Location = new System.Drawing.Point(3, 162);
            this.lvLopcu.Name = "lvLopcu";
            this.lvLopcu.Size = new System.Drawing.Size(278, 379);
            this.lvLopcu.TabIndex = 1;
            this.lvLopcu.UseCompatibleStateImageBehavior = false;
            this.lvLopcu.View = System.Windows.Forms.View.Details;
            // 
            // colMahocsinhcu
            // 
            this.colMahocsinhcu.Text = "Mã học sinh";
            this.colMahocsinhcu.Width = 86;
            // 
            // colTenhocsinhcu
            // 
            this.colTenhocsinhcu.Text = "Tên học sinh";
            this.colTenhocsinhcu.Width = 182;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbNewStudent);
            this.panelControl1.Controls.Add(this.btnChuyentatca);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnChuyentungnguoimot);
            this.panelControl1.Location = new System.Drawing.Point(295, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(105, 543);
            this.panelControl1.TabIndex = 4;
            // 
            // cbNewStudent
            // 
            this.cbNewStudent.AutoSize = true;
            this.cbNewStudent.Location = new System.Drawing.Point(11, 65);
            this.cbNewStudent.Name = "cbNewStudent";
            this.cbNewStudent.Size = new System.Drawing.Size(86, 38);
            this.cbNewStudent.TabIndex = 3;
            this.cbNewStudent.Text = "Học sinh \r\nmới";
            this.cbNewStudent.UseVisualStyleBackColor = true;
            this.cbNewStudent.CheckedChanged += new System.EventHandler(this.cbNewStudent_CheckedChanged);
            // 
            // btnChuyentatca
            // 
            this.btnChuyentatca.Image = global::QLHS.Properties.Resources.all;
            this.btnChuyentatca.Location = new System.Drawing.Point(5, 176);
            this.btnChuyentatca.Name = "btnChuyentatca";
            this.btnChuyentatca.Size = new System.Drawing.Size(95, 65);
            this.btnChuyentatca.TabIndex = 2;
            this.btnChuyentatca.UseVisualStyleBackColor = true;
            this.btnChuyentatca.Click += new System.EventHandler(this.btnChuyentatca_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QLHS.Properties.Resources.thoat;
            this.btnThoat.Location = new System.Drawing.Point(5, 460);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 65);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QLHS.Properties.Resources.luuchuyenlop;
            this.btnLuu.Location = new System.Drawing.Point(5, 389);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 65);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QLHS.Properties.Resources.xoachuyenlop;
            this.btnXoa.Location = new System.Drawing.Point(5, 318);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 65);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnChuyentungnguoimot
            // 
            this.btnChuyentungnguoimot.Image = global::QLHS.Properties.Resources.chuyenlop;
            this.btnChuyentungnguoimot.Location = new System.Drawing.Point(5, 247);
            this.btnChuyentungnguoimot.Name = "btnChuyentungnguoimot";
            this.btnChuyentungnguoimot.Size = new System.Drawing.Size(95, 65);
            this.btnChuyentungnguoimot.TabIndex = 0;
            this.btnChuyentungnguoimot.UseVisualStyleBackColor = true;
            this.btnChuyentungnguoimot.Click += new System.EventHandler(this.btnChuyentungnguoimot_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.groupControl2);
            this.flowLayoutPanel3.Controls.Add(this.lvLopmoi);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(406, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(348, 543);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblLopmoi);
            this.groupControl2.Controls.Add(this.cmbNamhocmoi);
            this.groupControl2.Controls.Add(this.cmbKhoilopmoi);
            this.groupControl2.Controls.Add(this.lblKhoilopmoi);
            this.groupControl2.Controls.Add(this.cmbLopmoi);
            this.groupControl2.Controls.Add(this.lblNamhocmoi);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(276, 153);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông tin lớp mới";
            // 
            // lblLopmoi
            // 
            this.lblLopmoi.AutoSize = true;
            this.lblLopmoi.Location = new System.Drawing.Point(17, 121);
            this.lblLopmoi.Name = "lblLopmoi";
            this.lblLopmoi.Size = new System.Drawing.Size(31, 17);
            this.lblLopmoi.TabIndex = 1;
            this.lblLopmoi.Text = "Lớp";
            // 
            // cmbNamhocmoi
            // 
            this.cmbNamhocmoi.FormattingEnabled = true;
            this.cmbNamhocmoi.Location = new System.Drawing.Point(149, 31);
            this.cmbNamhocmoi.Name = "cmbNamhocmoi";
            this.cmbNamhocmoi.Size = new System.Drawing.Size(121, 24);
            this.cmbNamhocmoi.TabIndex = 0;
            // 
            // cmbKhoilopmoi
            // 
            this.cmbKhoilopmoi.FormattingEnabled = true;
            this.cmbKhoilopmoi.Location = new System.Drawing.Point(149, 76);
            this.cmbKhoilopmoi.Name = "cmbKhoilopmoi";
            this.cmbKhoilopmoi.Size = new System.Drawing.Size(121, 24);
            this.cmbKhoilopmoi.TabIndex = 0;
            // 
            // lblKhoilopmoi
            // 
            this.lblKhoilopmoi.AutoSize = true;
            this.lblKhoilopmoi.Location = new System.Drawing.Point(17, 79);
            this.lblKhoilopmoi.Name = "lblKhoilopmoi";
            this.lblKhoilopmoi.Size = new System.Drawing.Size(56, 17);
            this.lblKhoilopmoi.TabIndex = 1;
            this.lblKhoilopmoi.Text = "Khối lớp";
            // 
            // cmbLopmoi
            // 
            this.cmbLopmoi.FormattingEnabled = true;
            this.cmbLopmoi.Location = new System.Drawing.Point(149, 118);
            this.cmbLopmoi.Name = "cmbLopmoi";
            this.cmbLopmoi.Size = new System.Drawing.Size(121, 24);
            this.cmbLopmoi.TabIndex = 0;
            // 
            // lblNamhocmoi
            // 
            this.lblNamhocmoi.AutoSize = true;
            this.lblNamhocmoi.Location = new System.Drawing.Point(17, 37);
            this.lblNamhocmoi.Name = "lblNamhocmoi";
            this.lblNamhocmoi.Size = new System.Drawing.Size(63, 17);
            this.lblNamhocmoi.TabIndex = 1;
            this.lblNamhocmoi.Text = "Năm học";
            // 
            // lvLopmoi
            // 
            this.lvLopmoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMahocsinhmoi,
            this.colTenhocsinhmoi});
            this.lvLopmoi.Location = new System.Drawing.Point(3, 162);
            this.lvLopmoi.Name = "lvLopmoi";
            this.lvLopmoi.Size = new System.Drawing.Size(222, 379);
            this.lvLopmoi.TabIndex = 1;
            this.lvLopmoi.UseCompatibleStateImageBehavior = false;
            this.lvLopmoi.View = System.Windows.Forms.View.Details;
            // 
            // colMahocsinhmoi
            // 
            this.colMahocsinhmoi.Text = "Mã học sinh";
            this.colMahocsinhmoi.Width = 86;
            // 
            // colTenhocsinhmoi
            // 
            this.colTenhocsinhmoi.Text = "Tên học sinh";
            this.colTenhocsinhmoi.Width = 223;
            // 
            // frmPhanlop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 549);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPhanlop";
            this.Text = "Phân lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhanlop_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lblLopcu;
        private System.Windows.Forms.Label lblKhoilopcu;
        private System.Windows.Forms.Label lblNamhoccu;
        private System.Windows.Forms.ComboBox cmbLopcu;
        private System.Windows.Forms.ComboBox cmbKhoilopcu;
        private System.Windows.Forms.ComboBox cmbNamhoccu;
        private System.Windows.Forms.ListView lvLopcu;
        private System.Windows.Forms.ColumnHeader colMahocsinhcu;
        private System.Windows.Forms.ColumnHeader colTenhocsinhcu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnChuyentatca;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChuyentungnguoimot;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label lblLopmoi;
        private System.Windows.Forms.ComboBox cmbNamhocmoi;
        private System.Windows.Forms.ComboBox cmbKhoilopmoi;
        private System.Windows.Forms.Label lblKhoilopmoi;
        private System.Windows.Forms.ComboBox cmbLopmoi;
        private System.Windows.Forms.Label lblNamhocmoi;
        private System.Windows.Forms.ListView lvLopmoi;
        private System.Windows.Forms.ColumnHeader colMahocsinhmoi;
        private System.Windows.Forms.ColumnHeader colTenhocsinhmoi;
        private System.Windows.Forms.CheckBox cbNewStudent;
    }
}