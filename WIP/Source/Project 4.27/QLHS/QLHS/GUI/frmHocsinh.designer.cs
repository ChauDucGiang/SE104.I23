namespace QLHS
{
    partial class frmHocsinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocsinh));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPageAddHocSinh = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txbSoDienThoai = new System.Windows.Forms.TextBox();
            this.lvSDT = new System.Windows.Forms.Label();
            this.btnThemvaodanhsach = new System.Windows.Forms.Button();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblNoisinh = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblTenhocsinh = new System.Windows.Forms.Label();
            this.lblMahocsinh = new System.Windows.Forms.Label();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtNoisinh = new System.Windows.Forms.TextBox();
            this.txtTenhocsinh = new System.Windows.Forms.TextBox();
            this.txtMahocsinh = new System.Windows.Forms.TextBox();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.radTimtheotenhocsinh = new System.Windows.Forms.RadioButton();
            this.radTimtheomahocsinh = new System.Windows.Forms.RadioButton();
            this.txtNhapthongtincantimkiem = new System.Windows.Forms.TextBox();
            this.lblNhapthongtincantimkiem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVHocsinh = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddHS = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPageAddHocSinh.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHocsinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAddHS)).BeginInit();
            this.bindingNavigatorAddHS.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPageAddHocSinh);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageAddHocSinh,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(337, 573);
            this.navigationPane1.SelectedPage = this.navigationPageAddHocSinh;
            this.navigationPane1.Size = new System.Drawing.Size(337, 573);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "Tìm kiếm";
            this.navigationPane1.Click += new System.EventHandler(this.navigationPane1_Click);
            // 
            // navigationPageAddHocSinh
            // 
            this.navigationPageAddHocSinh.Caption = "Thêm dữ liệu";
            this.navigationPageAddHocSinh.Controls.Add(this.txbDiaChi);
            this.navigationPageAddHocSinh.Controls.Add(this.lbDiachi);
            this.navigationPageAddHocSinh.Controls.Add(this.txbEmail);
            this.navigationPageAddHocSinh.Controls.Add(this.lbEmail);
            this.navigationPageAddHocSinh.Controls.Add(this.txbSoDienThoai);
            this.navigationPageAddHocSinh.Controls.Add(this.lvSDT);
            this.navigationPageAddHocSinh.Controls.Add(this.btnThemvaodanhsach);
            this.navigationPageAddHocSinh.Controls.Add(this.lblNgaysinh);
            this.navigationPageAddHocSinh.Controls.Add(this.lblNoisinh);
            this.navigationPageAddHocSinh.Controls.Add(this.lblGioitinh);
            this.navigationPageAddHocSinh.Controls.Add(this.lblTenhocsinh);
            this.navigationPageAddHocSinh.Controls.Add(this.lblMahocsinh);
            this.navigationPageAddHocSinh.Controls.Add(this.dtpNgaysinh);
            this.navigationPageAddHocSinh.Controls.Add(this.radNu);
            this.navigationPageAddHocSinh.Controls.Add(this.radNam);
            this.navigationPageAddHocSinh.Controls.Add(this.txtNoisinh);
            this.navigationPageAddHocSinh.Controls.Add(this.txtTenhocsinh);
            this.navigationPageAddHocSinh.Controls.Add(this.txtMahocsinh);
            this.navigationPageAddHocSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navigationPageAddHocSinh.Name = "navigationPageAddHocSinh";
            this.navigationPageAddHocSinh.Size = new System.Drawing.Size(216, 503);
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDiaChi.Location = new System.Drawing.Point(4, 231);
            this.txbDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(209, 22);
            this.txbDiaChi.TabIndex = 9;
            // 
            // lbDiachi
            // 
            this.lbDiachi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Location = new System.Drawing.Point(4, 212);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(51, 17);
            this.lbDiachi.TabIndex = 8;
            this.lbDiachi.Text = "Địa chỉ";
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEmail.Location = new System.Drawing.Point(4, 174);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(209, 22);
            this.txbEmail.TabIndex = 7;
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(4, 153);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 17);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "Email";
            // 
            // txbSoDienThoai
            // 
            this.txbSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSoDienThoai.Location = new System.Drawing.Point(4, 127);
            this.txbSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSoDienThoai.Name = "txbSoDienThoai";
            this.txbSoDienThoai.Size = new System.Drawing.Size(209, 22);
            this.txbSoDienThoai.TabIndex = 5;
            // 
            // lvSDT
            // 
            this.lvSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSDT.AutoSize = true;
            this.lvSDT.Location = new System.Drawing.Point(4, 108);
            this.lvSDT.Name = "lvSDT";
            this.lvSDT.Size = new System.Drawing.Size(91, 17);
            this.lvSDT.TabIndex = 4;
            this.lvSDT.Text = "Số điện thoại";
            // 
            // btnThemvaodanhsach
            // 
            this.btnThemvaodanhsach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemvaodanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemvaodanhsach.Image = global::QLHS.Properties.Resources.add;
            this.btnThemvaodanhsach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemvaodanhsach.Location = new System.Drawing.Point(4, 434);
            this.btnThemvaodanhsach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemvaodanhsach.Name = "btnThemvaodanhsach";
            this.btnThemvaodanhsach.Size = new System.Drawing.Size(209, 46);
            this.btnThemvaodanhsach.TabIndex = 17;
            this.btnThemvaodanhsach.Text = "Thêm";
            this.btnThemvaodanhsach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemvaodanhsach.UseVisualStyleBackColor = true;
            this.btnThemvaodanhsach.Click += new System.EventHandler(this.btnThemvaodanhsach_Click);
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(5, 377);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(71, 17);
            this.lblNgaysinh.TabIndex = 15;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblNoisinh
            // 
            this.lblNoisinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoisinh.AutoSize = true;
            this.lblNoisinh.Location = new System.Drawing.Point(5, 322);
            this.lblNoisinh.Name = "lblNoisinh";
            this.lblNoisinh.Size = new System.Drawing.Size(59, 17);
            this.lblNoisinh.TabIndex = 13;
            this.lblNoisinh.Text = "Nơi sinh";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(4, 270);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(60, 17);
            this.lblGioitinh.TabIndex = 10;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // lblTenhocsinh
            // 
            this.lblTenhocsinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenhocsinh.AutoSize = true;
            this.lblTenhocsinh.Location = new System.Drawing.Point(3, 63);
            this.lblTenhocsinh.Name = "lblTenhocsinh";
            this.lblTenhocsinh.Size = new System.Drawing.Size(90, 17);
            this.lblTenhocsinh.TabIndex = 2;
            this.lblTenhocsinh.Text = "Tên học sinh";
            // 
            // lblMahocsinh
            // 
            this.lblMahocsinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMahocsinh.AutoSize = true;
            this.lblMahocsinh.Location = new System.Drawing.Point(4, 15);
            this.lblMahocsinh.Name = "lblMahocsinh";
            this.lblMahocsinh.Size = new System.Drawing.Size(84, 17);
            this.lblMahocsinh.TabIndex = 0;
            this.lblMahocsinh.Text = "Mã học sinh";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinh.Location = new System.Drawing.Point(4, 396);
            this.dtpNgaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(209, 22);
            this.dtpNgaysinh.TabIndex = 16;
            // 
            // radNu
            // 
            this.radNu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(95, 289);
            this.radNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 21);
            this.radNu.TabIndex = 12;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(16, 289);
            this.radNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(58, 21);
            this.radNam.TabIndex = 11;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtNoisinh
            // 
            this.txtNoisinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoisinh.Location = new System.Drawing.Point(4, 343);
            this.txtNoisinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoisinh.Name = "txtNoisinh";
            this.txtNoisinh.Size = new System.Drawing.Size(209, 22);
            this.txtNoisinh.TabIndex = 14;
            // 
            // txtTenhocsinh
            // 
            this.txtTenhocsinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenhocsinh.Location = new System.Drawing.Point(4, 82);
            this.txtTenhocsinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenhocsinh.Name = "txtTenhocsinh";
            this.txtTenhocsinh.Size = new System.Drawing.Size(209, 22);
            this.txtTenhocsinh.TabIndex = 3;
            // 
            // txtMahocsinh
            // 
            this.txtMahocsinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMahocsinh.Location = new System.Drawing.Point(4, 38);
            this.txtMahocsinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMahocsinh.Name = "txtMahocsinh";
            this.txtMahocsinh.Size = new System.Drawing.Size(209, 22);
            this.txtMahocsinh.TabIndex = 1;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Tìm kiếm";
            this.navigationPage2.Controls.Add(this.btnTimkiem);
            this.navigationPage2.Controls.Add(this.radTimtheotenhocsinh);
            this.navigationPage2.Controls.Add(this.radTimtheomahocsinh);
            this.navigationPage2.Controls.Add(this.txtNhapthongtincantimkiem);
            this.navigationPage2.Controls.Add(this.lblNhapthongtincantimkiem);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(216, 503);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Image = global::QLHS.Properties.Resources.tracuugiaovien;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimkiem.Location = new System.Drawing.Point(7, 273);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(206, 50);
            this.btnTimkiem.TabIndex = 4;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // radTimtheotenhocsinh
            // 
            this.radTimtheotenhocsinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTimtheotenhocsinh.AutoSize = true;
            this.radTimtheotenhocsinh.Location = new System.Drawing.Point(7, 162);
            this.radTimtheotenhocsinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTimtheotenhocsinh.Name = "radTimtheotenhocsinh";
            this.radTimtheotenhocsinh.Size = new System.Drawing.Size(165, 21);
            this.radTimtheotenhocsinh.TabIndex = 3;
            this.radTimtheotenhocsinh.TabStop = true;
            this.radTimtheotenhocsinh.Text = "Tìm theo tên học sinh";
            this.radTimtheotenhocsinh.UseVisualStyleBackColor = true;
            // 
            // radTimtheomahocsinh
            // 
            this.radTimtheomahocsinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTimtheomahocsinh.AutoSize = true;
            this.radTimtheomahocsinh.Location = new System.Drawing.Point(7, 123);
            this.radTimtheomahocsinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTimtheomahocsinh.Name = "radTimtheomahocsinh";
            this.radTimtheomahocsinh.Size = new System.Drawing.Size(164, 21);
            this.radTimtheomahocsinh.TabIndex = 2;
            this.radTimtheomahocsinh.TabStop = true;
            this.radTimtheomahocsinh.Text = "Tìm theo mã học sinh";
            this.radTimtheomahocsinh.UseVisualStyleBackColor = true;
            // 
            // txtNhapthongtincantimkiem
            // 
            this.txtNhapthongtincantimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhapthongtincantimkiem.Location = new System.Drawing.Point(7, 73);
            this.txtNhapthongtincantimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhapthongtincantimkiem.Name = "txtNhapthongtincantimkiem";
            this.txtNhapthongtincantimkiem.Size = new System.Drawing.Size(206, 22);
            this.txtNhapthongtincantimkiem.TabIndex = 1;
            // 
            // lblNhapthongtincantimkiem
            // 
            this.lblNhapthongtincantimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNhapthongtincantimkiem.AutoSize = true;
            this.lblNhapthongtincantimkiem.Location = new System.Drawing.Point(4, 39);
            this.lblNhapthongtincantimkiem.Name = "lblNhapthongtincantimkiem";
            this.lblNhapthongtincantimkiem.Size = new System.Drawing.Size(183, 17);
            this.lblNhapthongtincantimkiem.TabIndex = 0;
            this.lblNhapthongtincantimkiem.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVHocsinh);
            this.groupBox1.Controls.Add(this.bindingNavigatorAddHS);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(337, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1034, 573);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học sinh";
            // 
            // dGVHocsinh
            // 
            this.dGVHocsinh.AllowUserToAddRows = false;
            this.dGVHocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHocsinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.HoTen,
            this.NgSinh,
            this.GioiTinh,
            this.DienThoai,
            this.NoiSinh,
            this.DiaChi,
            this.Email,
            this.Lop});
            this.dGVHocsinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVHocsinh.Location = new System.Drawing.Point(3, 44);
            this.dGVHocsinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVHocsinh.Name = "dGVHocsinh";
            this.dGVHocsinh.RowTemplate.Height = 24;
            this.dGVHocsinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGVHocsinh.Size = new System.Drawing.Size(1028, 527);
            this.dGVHocsinh.TabIndex = 2;
            // 
            // MaHS
            // 
            this.MaHS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.Name = "MaHS";
            this.MaHS.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên học sinh";
            this.HoTen.Name = "HoTen";
            // 
            // NgSinh
            // 
            this.NgSinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgSinh.DataPropertyName = "NgSinh";
            this.NgSinh.HeaderText = "Ngày sinh";
            this.NgSinh.Name = "NgSinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DienThoai
            // 
            this.DienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Số điện thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // NoiSinh
            // 
            this.NoiSinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoiSinh.DataPropertyName = "NoiSinh";
            this.NoiSinh.HeaderText = "Nơi sinh";
            this.NoiSinh.Name = "NoiSinh";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Lop
            // 
            this.Lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lop.DataPropertyName = "TenLop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.Name = "Lop";
            this.Lop.ReadOnly = true;
            // 
            // bindingNavigatorAddHS
            // 
            this.bindingNavigatorAddHS.AddNewItem = null;
            this.bindingNavigatorAddHS.CountItem = null;
            this.bindingNavigatorAddHS.DeleteItem = null;
            this.bindingNavigatorAddHS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorAddHS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.btnAdd,
            this.toolStripSeparator3,
            this.bindingNavigatorSeparator2,
            this.btnDelete,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.btnSave,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.btnExit});
            this.bindingNavigatorAddHS.Location = new System.Drawing.Point(3, 17);
            this.bindingNavigatorAddHS.MoveFirstItem = null;
            this.bindingNavigatorAddHS.MoveLastItem = null;
            this.bindingNavigatorAddHS.MoveNextItem = null;
            this.bindingNavigatorAddHS.MovePreviousItem = null;
            this.bindingNavigatorAddHS.Name = "bindingNavigatorAddHS";
            this.bindingNavigatorAddHS.PositionItem = null;
            this.bindingNavigatorAddHS.Size = new System.Drawing.Size(1028, 27);
            this.bindingNavigatorAddHS.TabIndex = 1;
            this.bindingNavigatorAddHS.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QLHS.Properties.Resources.edit;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 24);
            this.btnAdd.Text = "Edit";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 24);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
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
            // frmHocsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 573);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navigationPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHocsinh";
            this.Text = "Học sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPageAddHocSinh.ResumeLayout(false);
            this.navigationPageAddHocSinh.PerformLayout();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHocsinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAddHS)).EndInit();
            this.bindingNavigatorAddHS.ResumeLayout(false);
            this.bindingNavigatorAddHS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageAddHocSinh;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txbSoDienThoai;
        private System.Windows.Forms.Label lvSDT;
        private System.Windows.Forms.Button btnThemvaodanhsach;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblNoisinh;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblTenhocsinh;
        private System.Windows.Forms.Label lblMahocsinh;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtNoisinh;
        private System.Windows.Forms.TextBox txtTenhocsinh;
        private System.Windows.Forms.TextBox txtMahocsinh;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.RadioButton radTimtheotenhocsinh;
        private System.Windows.Forms.RadioButton radTimtheomahocsinh;
        private System.Windows.Forms.TextBox txtNhapthongtincantimkiem;
        private System.Windows.Forms.Label lblNhapthongtincantimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigatorAddHS;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.DataGridView dGVHocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
    }
}