namespace QLHS
{
    partial class frmNhapdiemchung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapdiemchung));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnHiemthidanhsach1 = new System.Windows.Forms.Button();
            this.lblLop1 = new System.Windows.Forms.Label();
            this.lblMonhoc1 = new System.Windows.Forms.Label();
            this.lblHocky1 = new System.Windows.Forms.Label();
            this.lblNamhoc1 = new System.Windows.Forms.Label();
            this.cmbMonHoc1 = new System.Windows.Forms.ComboBox();
            this.cmbHocky1 = new System.Windows.Forms.ComboBox();
            this.cmbLop1 = new System.Windows.Forms.ComboBox();
            this.cmbNamhoc1 = new System.Windows.Forms.ComboBox();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lblLop2 = new System.Windows.Forms.Label();
            this.btnHienthidanhsach2 = new System.Windows.Forms.Button();
            this.lblMonhoc2 = new System.Windows.Forms.Label();
            this.lblHocky2 = new System.Windows.Forms.Label();
            this.lblNamhoc2 = new System.Windows.Forms.Label();
            this.cmbMonhoc2 = new System.Windows.Forms.ComboBox();
            this.cmbHocky2 = new System.Windows.Forms.ComboBox();
            this.cmbLop2 = new System.Windows.Forms.ComboBox();
            this.cmbNamhoc2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVNhapdiemchung = new System.Windows.Forms.DataGridView();
            this.colMahocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemmieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem15phut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem45phut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorBangDiem = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNhapdiemchung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorBangDiem)).BeginInit();
            this.bindingNavigatorBangDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(377, 450);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(377, 450);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Nhập điểm";
            this.navigationPage1.Controls.Add(this.btnHiemthidanhsach1);
            this.navigationPage1.Controls.Add(this.lblLop1);
            this.navigationPage1.Controls.Add(this.lblMonhoc1);
            this.navigationPage1.Controls.Add(this.lblHocky1);
            this.navigationPage1.Controls.Add(this.lblNamhoc1);
            this.navigationPage1.Controls.Add(this.cmbMonHoc1);
            this.navigationPage1.Controls.Add(this.cmbHocky1);
            this.navigationPage1.Controls.Add(this.cmbLop1);
            this.navigationPage1.Controls.Add(this.cmbNamhoc1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(252, 377);
            // 
            // btnHiemthidanhsach1
            // 
            this.btnHiemthidanhsach1.Image = global::QLHS.Properties.Resources.kqcnamtheomon;
            this.btnHiemthidanhsach1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHiemthidanhsach1.Location = new System.Drawing.Point(54, 283);
            this.btnHiemthidanhsach1.Name = "btnHiemthidanhsach1";
            this.btnHiemthidanhsach1.Size = new System.Drawing.Size(84, 60);
            this.btnHiemthidanhsach1.TabIndex = 8;
            this.btnHiemthidanhsach1.Text = "Hiển thị";
            this.btnHiemthidanhsach1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHiemthidanhsach1.UseVisualStyleBackColor = true;
            // 
            // lblLop1
            // 
            this.lblLop1.AutoSize = true;
            this.lblLop1.Location = new System.Drawing.Point(4, 90);
            this.lblLop1.Name = "lblLop1";
            this.lblLop1.Size = new System.Drawing.Size(32, 17);
            this.lblLop1.TabIndex = 2;
            this.lblLop1.Text = "Lớp";
            // 
            // lblMonhoc1
            // 
            this.lblMonhoc1.AutoSize = true;
            this.lblMonhoc1.Location = new System.Drawing.Point(4, 217);
            this.lblMonhoc1.Name = "lblMonhoc1";
            this.lblMonhoc1.Size = new System.Drawing.Size(62, 17);
            this.lblMonhoc1.TabIndex = 6;
            this.lblMonhoc1.Text = "Môn học";
            // 
            // lblHocky1
            // 
            this.lblHocky1.AutoSize = true;
            this.lblHocky1.Location = new System.Drawing.Point(4, 158);
            this.lblHocky1.Name = "lblHocky1";
            this.lblHocky1.Size = new System.Drawing.Size(51, 17);
            this.lblHocky1.TabIndex = 4;
            this.lblHocky1.Text = "Học kỳ";
            // 
            // lblNamhoc1
            // 
            this.lblNamhoc1.AutoSize = true;
            this.lblNamhoc1.Location = new System.Drawing.Point(4, 29);
            this.lblNamhoc1.Name = "lblNamhoc1";
            this.lblNamhoc1.Size = new System.Drawing.Size(64, 17);
            this.lblNamhoc1.TabIndex = 0;
            this.lblNamhoc1.Text = "Năm học";
            // 
            // cmbMonHoc1
            // 
            this.cmbMonHoc1.FormattingEnabled = true;
            this.cmbMonHoc1.Location = new System.Drawing.Point(4, 237);
            this.cmbMonHoc1.Name = "cmbMonHoc1";
            this.cmbMonHoc1.Size = new System.Drawing.Size(239, 24);
            this.cmbMonHoc1.TabIndex = 7;
            this.cmbMonHoc1.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc1_SelectedIndexChanged);
            // 
            // cmbHocky1
            // 
            this.cmbHocky1.FormattingEnabled = true;
            this.cmbHocky1.Location = new System.Drawing.Point(4, 178);
            this.cmbHocky1.Name = "cmbHocky1";
            this.cmbHocky1.Size = new System.Drawing.Size(239, 24);
            this.cmbHocky1.TabIndex = 5;
            this.cmbHocky1.SelectedIndexChanged += new System.EventHandler(this.cmbHocky1_SelectedIndexChanged);
            // 
            // cmbLop1
            // 
            this.cmbLop1.FormattingEnabled = true;
            this.cmbLop1.Location = new System.Drawing.Point(4, 110);
            this.cmbLop1.Name = "cmbLop1";
            this.cmbLop1.Size = new System.Drawing.Size(239, 24);
            this.cmbLop1.TabIndex = 3;
            this.cmbLop1.SelectedIndexChanged += new System.EventHandler(this.cmbLop1_SelectedIndexChanged);
            // 
            // cmbNamhoc1
            // 
            this.cmbNamhoc1.FormattingEnabled = true;
            this.cmbNamhoc1.Location = new System.Drawing.Point(4, 49);
            this.cmbNamhoc1.Name = "cmbNamhoc1";
            this.cmbNamhoc1.Size = new System.Drawing.Size(239, 24);
            this.cmbNamhoc1.TabIndex = 1;
            this.cmbNamhoc1.SelectedIndexChanged += new System.EventHandler(this.cmbNamhoc1_SelectedIndexChanged);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Cập nhật điểm";
            this.navigationPage2.Controls.Add(this.lblLop2);
            this.navigationPage2.Controls.Add(this.btnHienthidanhsach2);
            this.navigationPage2.Controls.Add(this.lblMonhoc2);
            this.navigationPage2.Controls.Add(this.lblHocky2);
            this.navigationPage2.Controls.Add(this.lblNamhoc2);
            this.navigationPage2.Controls.Add(this.cmbMonhoc2);
            this.navigationPage2.Controls.Add(this.cmbHocky2);
            this.navigationPage2.Controls.Add(this.cmbLop2);
            this.navigationPage2.Controls.Add(this.cmbNamhoc2);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(252, 377);
            // 
            // lblLop2
            // 
            this.lblLop2.AutoSize = true;
            this.lblLop2.Location = new System.Drawing.Point(3, 83);
            this.lblLop2.Name = "lblLop2";
            this.lblLop2.Size = new System.Drawing.Size(32, 17);
            this.lblLop2.TabIndex = 2;
            this.lblLop2.Text = "Lớp";
            // 
            // btnHienthidanhsach2
            // 
            this.btnHienthidanhsach2.Image = global::QLHS.Properties.Resources.kqcnamtheomon;
            this.btnHienthidanhsach2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHienthidanhsach2.Location = new System.Drawing.Point(66, 286);
            this.btnHienthidanhsach2.Name = "btnHienthidanhsach2";
            this.btnHienthidanhsach2.Size = new System.Drawing.Size(86, 61);
            this.btnHienthidanhsach2.TabIndex = 8;
            this.btnHienthidanhsach2.Text = "Hiển thị";
            this.btnHienthidanhsach2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHienthidanhsach2.UseVisualStyleBackColor = true;
            // 
            // lblMonhoc2
            // 
            this.lblMonhoc2.AutoSize = true;
            this.lblMonhoc2.Location = new System.Drawing.Point(5, 223);
            this.lblMonhoc2.Name = "lblMonhoc2";
            this.lblMonhoc2.Size = new System.Drawing.Size(62, 17);
            this.lblMonhoc2.TabIndex = 6;
            this.lblMonhoc2.Text = "Môn học";
            // 
            // lblHocky2
            // 
            this.lblHocky2.AutoSize = true;
            this.lblHocky2.Location = new System.Drawing.Point(3, 154);
            this.lblHocky2.Name = "lblHocky2";
            this.lblHocky2.Size = new System.Drawing.Size(51, 17);
            this.lblHocky2.TabIndex = 4;
            this.lblHocky2.Text = "Học kỳ";
            // 
            // lblNamhoc2
            // 
            this.lblNamhoc2.AutoSize = true;
            this.lblNamhoc2.Location = new System.Drawing.Point(3, 25);
            this.lblNamhoc2.Name = "lblNamhoc2";
            this.lblNamhoc2.Size = new System.Drawing.Size(64, 17);
            this.lblNamhoc2.TabIndex = 0;
            this.lblNamhoc2.Text = "Năm học";
            // 
            // cmbMonhoc2
            // 
            this.cmbMonhoc2.FormattingEnabled = true;
            this.cmbMonhoc2.Location = new System.Drawing.Point(3, 243);
            this.cmbMonhoc2.Name = "cmbMonhoc2";
            this.cmbMonhoc2.Size = new System.Drawing.Size(240, 24);
            this.cmbMonhoc2.TabIndex = 7;
            this.cmbMonhoc2.SelectedIndexChanged += new System.EventHandler(this.cmbMonhoc2_SelectedIndexChanged);
            // 
            // cmbHocky2
            // 
            this.cmbHocky2.FormattingEnabled = true;
            this.cmbHocky2.Location = new System.Drawing.Point(3, 174);
            this.cmbHocky2.Name = "cmbHocky2";
            this.cmbHocky2.Size = new System.Drawing.Size(240, 24);
            this.cmbHocky2.TabIndex = 5;
            // 
            // cmbLop2
            // 
            this.cmbLop2.FormattingEnabled = true;
            this.cmbLop2.Location = new System.Drawing.Point(3, 106);
            this.cmbLop2.Name = "cmbLop2";
            this.cmbLop2.Size = new System.Drawing.Size(240, 24);
            this.cmbLop2.TabIndex = 3;
            // 
            // cmbNamhoc2
            // 
            this.cmbNamhoc2.FormattingEnabled = true;
            this.cmbNamhoc2.Location = new System.Drawing.Point(3, 45);
            this.cmbNamhoc2.Name = "cmbNamhoc2";
            this.cmbNamhoc2.Size = new System.Drawing.Size(240, 24);
            this.cmbNamhoc2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVNhapdiemchung);
            this.groupBox1.Controls.Add(this.bindingNavigatorBangDiem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(377, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học sinh";
            // 
            // dGVNhapdiemchung
            // 
            this.dGVNhapdiemchung.AllowUserToAddRows = false;
            this.dGVNhapdiemchung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVNhapdiemchung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNhapdiemchung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMahocsinh,
            this.colTenhocsinh,
            this.colDiemmieng,
            this.colDiem15phut,
            this.colDiem45phut,
            this.colDiemthi});
            this.dGVNhapdiemchung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVNhapdiemchung.Location = new System.Drawing.Point(3, 45);
            this.dGVNhapdiemchung.Name = "dGVNhapdiemchung";
            this.dGVNhapdiemchung.RowTemplate.Height = 24;
            this.dGVNhapdiemchung.Size = new System.Drawing.Size(623, 402);
            this.dGVNhapdiemchung.TabIndex = 1;
            // 
            // colMahocsinh
            // 
            this.colMahocsinh.DataPropertyName = "MaHS";
            this.colMahocsinh.HeaderText = "Mã học sinh";
            this.colMahocsinh.Name = "colMahocsinh";
            // 
            // colTenhocsinh
            // 
            this.colTenhocsinh.DataPropertyName = "HoTen";
            this.colTenhocsinh.HeaderText = "Tên học sinh";
            this.colTenhocsinh.Name = "colTenhocsinh";
            // 
            // colDiemmieng
            // 
            this.colDiemmieng.HeaderText = "Điểm miệng";
            this.colDiemmieng.Name = "colDiemmieng";
            // 
            // colDiem15phut
            // 
            this.colDiem15phut.HeaderText = "Điểm 15 phút";
            this.colDiem15phut.Name = "colDiem15phut";
            // 
            // colDiem45phut
            // 
            this.colDiem45phut.HeaderText = "Điểm 45 phút";
            this.colDiem45phut.Name = "colDiem45phut";
            // 
            // colDiemthi
            // 
            this.colDiemthi.HeaderText = "Điểm thi";
            this.colDiemthi.Name = "colDiemthi";
            // 
            // bindingNavigatorBangDiem
            // 
            this.bindingNavigatorBangDiem.AddNewItem = null;
            this.bindingNavigatorBangDiem.CountItem = null;
            this.bindingNavigatorBangDiem.DeleteItem = this.btnDelete;
            this.bindingNavigatorBangDiem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorBangDiem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator2,
            this.btnDelete,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.btnSave,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.btnExit});
            this.bindingNavigatorBangDiem.Location = new System.Drawing.Point(3, 18);
            this.bindingNavigatorBangDiem.MoveFirstItem = null;
            this.bindingNavigatorBangDiem.MoveLastItem = null;
            this.bindingNavigatorBangDiem.MoveNextItem = null;
            this.bindingNavigatorBangDiem.MovePreviousItem = null;
            this.bindingNavigatorBangDiem.Name = "bindingNavigatorBangDiem";
            this.bindingNavigatorBangDiem.PositionItem = null;
            this.bindingNavigatorBangDiem.Size = new System.Drawing.Size(623, 27);
            this.bindingNavigatorBangDiem.TabIndex = 0;
            this.bindingNavigatorBangDiem.Text = "bindingNavigator1";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(77, 24);
            this.btnDelete.Text = "Delete";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QLHS.Properties.Resources.save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::QLHS.Properties.Resources.thoat;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 24);
            this.btnExit.Text = "Exit";
            // 
            // frmNhapdiemchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navigationPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNhapdiemchung";
            this.Text = "Nhập điểm lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapdiemchung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNhapdiemchung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorBangDiem)).EndInit();
            this.bindingNavigatorBangDiem.ResumeLayout(false);
            this.bindingNavigatorBangDiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.Button btnHiemthidanhsach1;
        private System.Windows.Forms.Label lblLop1;
        private System.Windows.Forms.Label lblMonhoc1;
        private System.Windows.Forms.Label lblHocky1;
        private System.Windows.Forms.Label lblNamhoc1;
        private System.Windows.Forms.ComboBox cmbMonHoc1;
        private System.Windows.Forms.ComboBox cmbHocky1;
        private System.Windows.Forms.ComboBox cmbLop1;
        private System.Windows.Forms.ComboBox cmbNamhoc1;
        private System.Windows.Forms.Button btnHienthidanhsach2;
        private System.Windows.Forms.Label lblMonhoc2;
        private System.Windows.Forms.Label lblHocky2;
        private System.Windows.Forms.Label lblNamhoc2;
        private System.Windows.Forms.ComboBox cmbMonhoc2;
        private System.Windows.Forms.ComboBox cmbHocky2;
        private System.Windows.Forms.ComboBox cmbLop2;
        private System.Windows.Forms.ComboBox cmbNamhoc2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGVNhapdiemchung;
        private System.Windows.Forms.BindingNavigator bindingNavigatorBangDiem;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.Label lblLop2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMahocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenhocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemmieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem15phut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem45phut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemthi;
    }
}