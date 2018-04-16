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
            this.colMahocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoisinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1391, 563);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Location = new System.Drawing.Point(3, 3);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(324, 552);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(324, 552);
            this.navigationPane1.TabIndex = 2;
            this.navigationPane1.Text = "Tìm kiếm";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Thêm dữ liệu";
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
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(209, 479);
            // 
            // btnThemvaodanhsach
            // 
            this.btnThemvaodanhsach.Location = new System.Drawing.Point(29, 391);
            this.btnThemvaodanhsach.Name = "btnThemvaodanhsach";
            this.btnThemvaodanhsach.Size = new System.Drawing.Size(125, 46);
            this.btnThemvaodanhsach.TabIndex = 4;
            this.btnThemvaodanhsach.Text = "Thêm vào danh sách";
            this.btnThemvaodanhsach.UseVisualStyleBackColor = true;
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(4, 288);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(71, 17);
            this.lblNgaysinh.TabIndex = 3;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblNoisinh
            // 
            this.lblNoisinh.AutoSize = true;
            this.lblNoisinh.Location = new System.Drawing.Point(4, 219);
            this.lblNoisinh.Name = "lblNoisinh";
            this.lblNoisinh.Size = new System.Drawing.Size(59, 17);
            this.lblNoisinh.TabIndex = 3;
            this.lblNoisinh.Text = "Nơi sinh";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(4, 150);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(60, 17);
            this.lblGioitinh.TabIndex = 3;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // lblTenhocsinh
            // 
            this.lblTenhocsinh.AutoSize = true;
            this.lblTenhocsinh.Location = new System.Drawing.Point(4, 77);
            this.lblTenhocsinh.Name = "lblTenhocsinh";
            this.lblTenhocsinh.Size = new System.Drawing.Size(90, 17);
            this.lblTenhocsinh.TabIndex = 3;
            this.lblTenhocsinh.Text = "Tên học sinh";
            // 
            // lblMahocsinh
            // 
            this.lblMahocsinh.AutoSize = true;
            this.lblMahocsinh.Location = new System.Drawing.Point(4, 15);
            this.lblMahocsinh.Name = "lblMahocsinh";
            this.lblMahocsinh.Size = new System.Drawing.Size(84, 17);
            this.lblMahocsinh.TabIndex = 3;
            this.lblMahocsinh.Text = "Mã học sinh";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinh.Location = new System.Drawing.Point(4, 308);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(178, 22);
            this.dtpNgaysinh.TabIndex = 2;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(97, 179);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 21);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(17, 179);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(58, 21);
            this.radNam.TabIndex = 1;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtNoisinh
            // 
            this.txtNoisinh.Location = new System.Drawing.Point(4, 239);
            this.txtNoisinh.Name = "txtNoisinh";
            this.txtNoisinh.Size = new System.Drawing.Size(100, 22);
            this.txtNoisinh.TabIndex = 0;
            // 
            // txtTenhocsinh
            // 
            this.txtTenhocsinh.Location = new System.Drawing.Point(4, 97);
            this.txtTenhocsinh.Name = "txtTenhocsinh";
            this.txtTenhocsinh.Size = new System.Drawing.Size(100, 22);
            this.txtTenhocsinh.TabIndex = 0;
            // 
            // txtMahocsinh
            // 
            this.txtMahocsinh.Location = new System.Drawing.Point(4, 38);
            this.txtMahocsinh.Name = "txtMahocsinh";
            this.txtMahocsinh.Size = new System.Drawing.Size(100, 22);
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
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(209, 479);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(32, 247);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(105, 33);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // radTimtheotenhocsinh
            // 
            this.radTimtheotenhocsinh.AutoSize = true;
            this.radTimtheotenhocsinh.Location = new System.Drawing.Point(7, 163);
            this.radTimtheotenhocsinh.Name = "radTimtheotenhocsinh";
            this.radTimtheotenhocsinh.Size = new System.Drawing.Size(165, 21);
            this.radTimtheotenhocsinh.TabIndex = 2;
            this.radTimtheotenhocsinh.TabStop = true;
            this.radTimtheotenhocsinh.Text = "Tìm theo tên học sinh";
            this.radTimtheotenhocsinh.UseVisualStyleBackColor = true;
            // 
            // radTimtheomahocsinh
            // 
            this.radTimtheomahocsinh.AutoSize = true;
            this.radTimtheomahocsinh.Location = new System.Drawing.Point(7, 123);
            this.radTimtheomahocsinh.Name = "radTimtheomahocsinh";
            this.radTimtheomahocsinh.Size = new System.Drawing.Size(164, 21);
            this.radTimtheomahocsinh.TabIndex = 2;
            this.radTimtheomahocsinh.TabStop = true;
            this.radTimtheomahocsinh.Text = "Tìm theo mã học sinh";
            this.radTimtheomahocsinh.UseVisualStyleBackColor = true;
            // 
            // txtNhapthongtincantimkiem
            // 
            this.txtNhapthongtincantimkiem.Location = new System.Drawing.Point(7, 73);
            this.txtNhapthongtincantimkiem.Name = "txtNhapthongtincantimkiem";
            this.txtNhapthongtincantimkiem.Size = new System.Drawing.Size(165, 22);
            this.txtNhapthongtincantimkiem.TabIndex = 1;
            // 
            // lblNhapthongtincantimkiem
            // 
            this.lblNhapthongtincantimkiem.AutoSize = true;
            this.lblNhapthongtincantimkiem.Location = new System.Drawing.Point(4, 39);
            this.lblNhapthongtincantimkiem.Name = "lblNhapthongtincantimkiem";
            this.lblNhapthongtincantimkiem.Size = new System.Drawing.Size(183, 17);
            this.lblNhapthongtincantimkiem.TabIndex = 0;
            this.lblNhapthongtincantimkiem.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(this.dGVHocsinh);
            this.groupBox1.Location = new System.Drawing.Point(333, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 552);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học sinh";
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
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 18);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1040, 27);
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
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 24);
            this.btnAdd.Text = "Add new";
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
            this.btnDelete.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            this.btnExit.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // dGVHocsinh
            // 
            this.dGVHocsinh.AllowUserToAddRows = false;
            this.dGVHocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHocsinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMahocsinh,
            this.colTenhocsinh,
            this.colGioitinh,
            this.colNgaysinh,
            this.colNoisinh});
            this.dGVHocsinh.Location = new System.Drawing.Point(0, 49);
            this.dGVHocsinh.Name = "dGVHocsinh";
            this.dGVHocsinh.RowTemplate.Height = 24;
            this.dGVHocsinh.Size = new System.Drawing.Size(1009, 490);
            this.dGVHocsinh.TabIndex = 0;
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
            // colGioitinh
            // 
            this.colGioitinh.HeaderText = "Giới tính";
            this.colGioitinh.Name = "colGioitinh";
            // 
            // colNgaysinh
            // 
            this.colNgaysinh.HeaderText = "Ngày sinh";
            this.colNgaysinh.Name = "colNgaysinh";
            // 
            // colNoisinh
            // 
            this.colNoisinh.HeaderText = "Nơi sinh";
            this.colNoisinh.Name = "colNoisinh";
            // 
            // frmHocsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 563);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmHocsinh";
            this.Text = "Học sinh";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colMahocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenhocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoisinh;
    }
}