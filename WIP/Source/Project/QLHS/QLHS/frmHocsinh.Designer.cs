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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dGVHocsinh = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHocsinh)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.navigationPane1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1043, 457);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Location = new System.Drawing.Point(2, 2);
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(243, 448);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(243, 448);
            this.navigationPane1.TabIndex = 2;
            this.navigationPane1.Text = "Tìm kiếm";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Thêm dữ liệu";
            this.navigationPage1.Controls.Add(this.txbDiaChi);
            this.navigationPage1.Controls.Add(this.lbDiachi);
            this.navigationPage1.Controls.Add(this.txbEmail);
            this.navigationPage1.Controls.Add(this.lbEmail);
            this.navigationPage1.Controls.Add(this.txbSoDienThoai);
            this.navigationPage1.Controls.Add(this.lvSDT);
            this.navigationPage1.Controls.Add(this.btnThemvaodanhsach);
            this.navigationPage1.Controls.Add(this.lblNgaysinh);
            this.navigationPage1.Controls.Add(this.lblNoisinh);
            this.navigationPage1.Controls.Add(this.lblGioitinh);
            this.navigationPage1.Controls.Add(this.lblTenhocsinh);
            this.navigationPage1.Controls.Add(this.lblMahocsinh);
            this.navigationPage1.Controls.Add(this.dtpNgaysinh);
            this.navigationPage1.Controls.Add(this.radNu);
            this.navigationPage1.Controls.Add(this.radNam);
            this.navigationPage1.Controls.Add(this.txtNoisinh);
            this.navigationPage1.Controls.Add(this.txtTenhocsinh);
            this.navigationPage1.Controls.Add(this.txtMahocsinh);
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(148, 388);
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(4, 188);
            this.txbDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(148, 20);
            this.txbDiaChi.TabIndex = 10;
            // 
            // lbDiachi
            // 
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Location = new System.Drawing.Point(3, 172);
            this.lbDiachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(40, 13);
            this.lbDiachi.TabIndex = 9;
            this.lbDiachi.Text = "Địa chỉ";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(4, 141);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(114, 20);
            this.txbEmail.TabIndex = 8;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(3, 124);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "Email";
            // 
            // txbSoDienThoai
            // 
            this.txbSoDienThoai.Location = new System.Drawing.Point(2, 103);
            this.txbSoDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txbSoDienThoai.Name = "txbSoDienThoai";
            this.txbSoDienThoai.Size = new System.Drawing.Size(116, 20);
            this.txbSoDienThoai.TabIndex = 6;
            // 
            // lvSDT
            // 
            this.lvSDT.AutoSize = true;
            this.lvSDT.Location = new System.Drawing.Point(3, 88);
            this.lvSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvSDT.Name = "lvSDT";
            this.lvSDT.Size = new System.Drawing.Size(70, 13);
            this.lvSDT.TabIndex = 5;
            this.lvSDT.Text = "Số điện thoại";
            // 
            // btnThemvaodanhsach
            // 
            this.btnThemvaodanhsach.Location = new System.Drawing.Point(33, 338);
            this.btnThemvaodanhsach.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemvaodanhsach.Name = "btnThemvaodanhsach";
            this.btnThemvaodanhsach.Size = new System.Drawing.Size(94, 37);
            this.btnThemvaodanhsach.TabIndex = 4;
            this.btnThemvaodanhsach.Text = "Thêm vào danh sách";
            this.btnThemvaodanhsach.UseVisualStyleBackColor = true;
            this.btnThemvaodanhsach.Click += new System.EventHandler(this.btnThemvaodanhsach_Click);
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(4, 299);
            this.lblNgaysinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(54, 13);
            this.lblNgaysinh.TabIndex = 3;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblNoisinh
            // 
            this.lblNoisinh.AutoSize = true;
            this.lblNoisinh.Location = new System.Drawing.Point(4, 262);
            this.lblNoisinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoisinh.Name = "lblNoisinh";
            this.lblNoisinh.Size = new System.Drawing.Size(45, 13);
            this.lblNoisinh.TabIndex = 3;
            this.lblNoisinh.Text = "Nơi sinh";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(3, 219);
            this.lblGioitinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(47, 13);
            this.lblGioitinh.TabIndex = 3;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // lblTenhocsinh
            // 
            this.lblTenhocsinh.AutoSize = true;
            this.lblTenhocsinh.Location = new System.Drawing.Point(2, 51);
            this.lblTenhocsinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenhocsinh.Name = "lblTenhocsinh";
            this.lblTenhocsinh.Size = new System.Drawing.Size(69, 13);
            this.lblTenhocsinh.TabIndex = 3;
            this.lblTenhocsinh.Text = "Tên học sinh";
            // 
            // lblMahocsinh
            // 
            this.lblMahocsinh.AutoSize = true;
            this.lblMahocsinh.Location = new System.Drawing.Point(3, 12);
            this.lblMahocsinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMahocsinh.Name = "lblMahocsinh";
            this.lblMahocsinh.Size = new System.Drawing.Size(65, 13);
            this.lblMahocsinh.TabIndex = 3;
            this.lblMahocsinh.Text = "Mã học sinh";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinh.Location = new System.Drawing.Point(3, 315);
            this.dtpNgaysinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(134, 20);
            this.dtpNgaysinh.TabIndex = 2;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(71, 235);
            this.radNu.Margin = new System.Windows.Forms.Padding(2);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(12, 235);
            this.radNam.Margin = new System.Windows.Forms.Padding(2);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(47, 17);
            this.radNam.TabIndex = 1;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtNoisinh
            // 
            this.txtNoisinh.Location = new System.Drawing.Point(4, 279);
            this.txtNoisinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoisinh.Name = "txtNoisinh";
            this.txtNoisinh.Size = new System.Drawing.Size(76, 20);
            this.txtNoisinh.TabIndex = 0;
            // 
            // txtTenhocsinh
            // 
            this.txtTenhocsinh.Location = new System.Drawing.Point(2, 67);
            this.txtTenhocsinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenhocsinh.Name = "txtTenhocsinh";
            this.txtTenhocsinh.Size = new System.Drawing.Size(76, 20);
            this.txtTenhocsinh.TabIndex = 0;
            // 
            // txtMahocsinh
            // 
            this.txtMahocsinh.Location = new System.Drawing.Point(3, 31);
            this.txtMahocsinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtMahocsinh.Name = "txtMahocsinh";
            this.txtMahocsinh.Size = new System.Drawing.Size(76, 20);
            this.txtMahocsinh.TabIndex = 0;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Tìm kiếm";
            this.navigationPage2.Controls.Add(this.btnTimkiem);
            this.navigationPage2.Controls.Add(this.radTimtheotenhocsinh);
            this.navigationPage2.Controls.Add(this.radTimtheomahocsinh);
            this.navigationPage2.Controls.Add(this.txtNhapthongtincantimkiem);
            this.navigationPage2.Controls.Add(this.lblNhapthongtincantimkiem);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(152, 385);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(24, 201);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(79, 27);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // radTimtheotenhocsinh
            // 
            this.radTimtheotenhocsinh.AutoSize = true;
            this.radTimtheotenhocsinh.Location = new System.Drawing.Point(5, 132);
            this.radTimtheotenhocsinh.Margin = new System.Windows.Forms.Padding(2);
            this.radTimtheotenhocsinh.Name = "radTimtheotenhocsinh";
            this.radTimtheotenhocsinh.Size = new System.Drawing.Size(127, 17);
            this.radTimtheotenhocsinh.TabIndex = 2;
            this.radTimtheotenhocsinh.TabStop = true;
            this.radTimtheotenhocsinh.Text = "Tìm theo tên học sinh";
            this.radTimtheotenhocsinh.UseVisualStyleBackColor = true;
            // 
            // radTimtheomahocsinh
            // 
            this.radTimtheomahocsinh.AutoSize = true;
            this.radTimtheomahocsinh.Location = new System.Drawing.Point(5, 100);
            this.radTimtheomahocsinh.Margin = new System.Windows.Forms.Padding(2);
            this.radTimtheomahocsinh.Name = "radTimtheomahocsinh";
            this.radTimtheomahocsinh.Size = new System.Drawing.Size(126, 17);
            this.radTimtheomahocsinh.TabIndex = 2;
            this.radTimtheomahocsinh.TabStop = true;
            this.radTimtheomahocsinh.Text = "Tìm theo mã học sinh";
            this.radTimtheomahocsinh.UseVisualStyleBackColor = true;
            // 
            // txtNhapthongtincantimkiem
            // 
            this.txtNhapthongtincantimkiem.Location = new System.Drawing.Point(5, 59);
            this.txtNhapthongtincantimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhapthongtincantimkiem.Name = "txtNhapthongtincantimkiem";
            this.txtNhapthongtincantimkiem.Size = new System.Drawing.Size(125, 20);
            this.txtNhapthongtincantimkiem.TabIndex = 1;
            // 
            // lblNhapthongtincantimkiem
            // 
            this.lblNhapthongtincantimkiem.AutoSize = true;
            this.lblNhapthongtincantimkiem.Location = new System.Drawing.Point(3, 32);
            this.lblNhapthongtincantimkiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhapthongtincantimkiem.Name = "lblNhapthongtincantimkiem";
            this.lblNhapthongtincantimkiem.Size = new System.Drawing.Size(139, 13);
            this.lblNhapthongtincantimkiem.TabIndex = 0;
            this.lblNhapthongtincantimkiem.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(this.dGVHocsinh);
            this.groupBox1.Location = new System.Drawing.Point(249, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(784, 448);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(579, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "- Ngày sinh theo kiểu\r\n       mm/dd/yyyy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(579, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "- Mã học sinh là kiểu số \r\n   nguyên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(578, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chú Ý:";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigator1.Location = new System.Drawing.Point(2, 15);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(780, 27);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            this.btnAdd.Size = new System.Drawing.Size(51, 24);
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
            this.btnDelete.Size = new System.Drawing.Size(64, 24);
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
            this.btnSave.Size = new System.Drawing.Size(55, 24);
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
            this.btnExit.Size = new System.Drawing.Size(49, 24);
            this.btnExit.Text = "Exit";
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
            this.Email});
            this.dGVHocsinh.Location = new System.Drawing.Point(0, 40);
            this.dGVHocsinh.Margin = new System.Windows.Forms.Padding(2);
            this.dGVHocsinh.Name = "dGVHocsinh";
            this.dGVHocsinh.RowTemplate.Height = 24;
            this.dGVHocsinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGVHocsinh.Size = new System.Drawing.Size(558, 398);
            this.dGVHocsinh.TabIndex = 0;
            this.dGVHocsinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dGVHocsinh_KeyPress);
            // 
            // MaHS
            // 
            this.MaHS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.Name = "MaHS";
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
            // frmHocsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 457);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHocsinh";
            this.Text = "Học sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHocsinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
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
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.DataGridView dGVHocsinh;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txbSoDienThoai;
        private System.Windows.Forms.Label lvSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}