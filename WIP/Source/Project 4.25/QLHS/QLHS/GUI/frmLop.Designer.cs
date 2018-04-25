namespace QLHS
{
    partial class frmLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
            this.navigationPaneAddClass = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navAddClass = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lbNotice = new System.Windows.Forms.Label();
            this.cmbNamHoc = new System.Windows.Forms.ComboBox();
            this.lbNamHoc = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblGiaovienchunhiem = new System.Windows.Forms.Label();
            this.lblKhoilop = new System.Windows.Forms.Label();
            this.cmbGiaovienchunhiem = new System.Windows.Forms.ComboBox();
            this.cmbKhoilop = new System.Windows.Forms.ComboBox();
            this.lblSiso = new System.Windows.Forms.Label();
            this.txtSiso = new System.Windows.Forms.TextBox();
            this.lblTenlop = new System.Windows.Forms.Label();
            this.txtTenlop = new System.Windows.Forms.TextBox();
            this.lblMalop = new System.Windows.Forms.Label();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.radTimtheotenlop = new System.Windows.Forms.RadioButton();
            this.radTimtheomalop = new System.Windows.Forms.RadioButton();
            this.txtNhapthongtincantimkiem = new System.Windows.Forms.TextBox();
            this.lblNhapthongtuncantimkiem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVLop = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorClass = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneAddClass)).BeginInit();
            this.navigationPaneAddClass.SuspendLayout();
            this.navAddClass.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorClass)).BeginInit();
            this.bindingNavigatorClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPaneAddClass
            // 
            this.navigationPaneAddClass.Controls.Add(this.navAddClass);
            this.navigationPaneAddClass.Controls.Add(this.navigationPage2);
            this.navigationPaneAddClass.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPaneAddClass.Location = new System.Drawing.Point(0, 0);
            this.navigationPaneAddClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navigationPaneAddClass.Name = "navigationPaneAddClass";
            this.navigationPaneAddClass.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navAddClass,
            this.navigationPage2});
            this.navigationPaneAddClass.RegularSize = new System.Drawing.Size(300, 593);
            this.navigationPaneAddClass.SelectedPage = this.navAddClass;
            this.navigationPaneAddClass.Size = new System.Drawing.Size(300, 593);
            this.navigationPaneAddClass.TabIndex = 0;
            this.navigationPaneAddClass.Text = "Tìm kiếm";
            this.navigationPaneAddClass.Click += new System.EventHandler(this.navigationPane1_Click);
            // 
            // navAddClass
            // 
            this.navAddClass.Caption = "Thêm Lớp";
            this.navAddClass.Controls.Add(this.lbNotice);
            this.navAddClass.Controls.Add(this.cmbNamHoc);
            this.navAddClass.Controls.Add(this.lbNamHoc);
            this.navAddClass.Controls.Add(this.btnLuu);
            this.navAddClass.Controls.Add(this.lblGiaovienchunhiem);
            this.navAddClass.Controls.Add(this.lblKhoilop);
            this.navAddClass.Controls.Add(this.cmbGiaovienchunhiem);
            this.navAddClass.Controls.Add(this.cmbKhoilop);
            this.navAddClass.Controls.Add(this.lblSiso);
            this.navAddClass.Controls.Add(this.txtSiso);
            this.navAddClass.Controls.Add(this.lblTenlop);
            this.navAddClass.Controls.Add(this.txtTenlop);
            this.navAddClass.Controls.Add(this.lblMalop);
            this.navAddClass.Controls.Add(this.txtMalop);
            this.navAddClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navAddClass.Name = "navAddClass";
            this.navAddClass.Size = new System.Drawing.Size(202, 520);
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.Location = new System.Drawing.Point(7, 63);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(175, 17);
            this.lbNotice.TabIndex = 2;
            this.lbNotice.Text = "Bắt đầu bằng 1**NAMHOC";
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Location = new System.Drawing.Point(7, 341);
            this.cmbNamHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(186, 24);
            this.cmbNamHoc.TabIndex = 10;
            // 
            // lbNamHoc
            // 
            this.lbNamHoc.AutoSize = true;
            this.lbNamHoc.Location = new System.Drawing.Point(7, 322);
            this.lbNamHoc.Name = "lbNamHoc";
            this.lbNamHoc.Size = new System.Drawing.Size(64, 17);
            this.lbNamHoc.TabIndex = 9;
            this.lbNamHoc.Text = "Năm học";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QLHS.Properties.Resources.all;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(40, 456);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(115, 66);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Thêm vào";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblGiaovienchunhiem
            // 
            this.lblGiaovienchunhiem.AutoSize = true;
            this.lblGiaovienchunhiem.Location = new System.Drawing.Point(3, 410);
            this.lblGiaovienchunhiem.Name = "lblGiaovienchunhiem";
            this.lblGiaovienchunhiem.Size = new System.Drawing.Size(137, 17);
            this.lblGiaovienchunhiem.TabIndex = 11;
            this.lblGiaovienchunhiem.Text = "Giáo viên chủ nhiệm";
            // 
            // lblKhoilop
            // 
            this.lblKhoilop.AutoSize = true;
            this.lblKhoilop.Location = new System.Drawing.Point(7, 234);
            this.lblKhoilop.Name = "lblKhoilop";
            this.lblKhoilop.Size = new System.Drawing.Size(59, 17);
            this.lblKhoilop.TabIndex = 7;
            this.lblKhoilop.Text = "Khối lớp";
            // 
            // cmbGiaovienchunhiem
            // 
            this.cmbGiaovienchunhiem.FormattingEnabled = true;
            this.cmbGiaovienchunhiem.Location = new System.Drawing.Point(7, 428);
            this.cmbGiaovienchunhiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGiaovienchunhiem.Name = "cmbGiaovienchunhiem";
            this.cmbGiaovienchunhiem.Size = new System.Drawing.Size(186, 24);
            this.cmbGiaovienchunhiem.TabIndex = 12;
            // 
            // cmbKhoilop
            // 
            this.cmbKhoilop.FormattingEnabled = true;
            this.cmbKhoilop.Location = new System.Drawing.Point(7, 257);
            this.cmbKhoilop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKhoilop.Name = "cmbKhoilop";
            this.cmbKhoilop.Size = new System.Drawing.Size(186, 24);
            this.cmbKhoilop.TabIndex = 8;
            // 
            // lblSiso
            // 
            this.lblSiso.AutoSize = true;
            this.lblSiso.Location = new System.Drawing.Point(4, 158);
            this.lblSiso.Name = "lblSiso";
            this.lblSiso.Size = new System.Drawing.Size(39, 17);
            this.lblSiso.TabIndex = 5;
            this.lblSiso.Text = "Sĩ số";
            // 
            // txtSiso
            // 
            this.txtSiso.Location = new System.Drawing.Point(7, 178);
            this.txtSiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSiso.Name = "txtSiso";
            this.txtSiso.ReadOnly = true;
            this.txtSiso.Size = new System.Drawing.Size(186, 22);
            this.txtSiso.TabIndex = 6;
            this.txtSiso.Text = "0";
            // 
            // lblTenlop
            // 
            this.lblTenlop.AutoSize = true;
            this.lblTenlop.Location = new System.Drawing.Point(4, 84);
            this.lblTenlop.Name = "lblTenlop";
            this.lblTenlop.Size = new System.Drawing.Size(56, 17);
            this.lblTenlop.TabIndex = 3;
            this.lblTenlop.Text = "Tên lớp";
            // 
            // txtTenlop
            // 
            this.txtTenlop.Location = new System.Drawing.Point(7, 103);
            this.txtTenlop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(186, 22);
            this.txtTenlop.TabIndex = 4;
            this.txtTenlop.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblMalop
            // 
            this.lblMalop.AutoSize = true;
            this.lblMalop.Location = new System.Drawing.Point(4, 16);
            this.lblMalop.Name = "lblMalop";
            this.lblMalop.Size = new System.Drawing.Size(50, 17);
            this.lblMalop.TabIndex = 0;
            this.lblMalop.Text = "Mã lớp";
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(7, 36);
            this.txtMalop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(186, 22);
            this.txtMalop.TabIndex = 1;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Tìm kiếm";
            this.navigationPage2.Controls.Add(this.btnTimkiem);
            this.navigationPage2.Controls.Add(this.radTimtheotenlop);
            this.navigationPage2.Controls.Add(this.radTimtheomalop);
            this.navigationPage2.Controls.Add(this.txtNhapthongtincantimkiem);
            this.navigationPage2.Controls.Add(this.lblNhapthongtuncantimkiem);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(202, 520);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = global::QLHS.Properties.Resources.xemdiem;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimkiem.Location = new System.Drawing.Point(47, 236);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(105, 48);
            this.btnTimkiem.TabIndex = 4;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // radTimtheotenlop
            // 
            this.radTimtheotenlop.AutoSize = true;
            this.radTimtheotenlop.Location = new System.Drawing.Point(7, 161);
            this.radTimtheotenlop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTimtheotenlop.Name = "radTimtheotenlop";
            this.radTimtheotenlop.Size = new System.Drawing.Size(131, 21);
            this.radTimtheotenlop.TabIndex = 3;
            this.radTimtheotenlop.TabStop = true;
            this.radTimtheotenlop.Text = "Tìm theo tên lớp";
            this.radTimtheotenlop.UseVisualStyleBackColor = true;
            // 
            // radTimtheomalop
            // 
            this.radTimtheomalop.AutoSize = true;
            this.radTimtheomalop.Location = new System.Drawing.Point(7, 121);
            this.radTimtheomalop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTimtheomalop.Name = "radTimtheomalop";
            this.radTimtheomalop.Size = new System.Drawing.Size(130, 21);
            this.radTimtheomalop.TabIndex = 2;
            this.radTimtheomalop.TabStop = true;
            this.radTimtheomalop.Text = "Tìm theo mã lớp";
            this.radTimtheomalop.UseVisualStyleBackColor = true;
            // 
            // txtNhapthongtincantimkiem
            // 
            this.txtNhapthongtincantimkiem.Location = new System.Drawing.Point(3, 64);
            this.txtNhapthongtincantimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhapthongtincantimkiem.Name = "txtNhapthongtincantimkiem";
            this.txtNhapthongtincantimkiem.Size = new System.Drawing.Size(190, 22);
            this.txtNhapthongtincantimkiem.TabIndex = 1;
            // 
            // lblNhapthongtuncantimkiem
            // 
            this.lblNhapthongtuncantimkiem.AutoSize = true;
            this.lblNhapthongtuncantimkiem.Location = new System.Drawing.Point(4, 31);
            this.lblNhapthongtuncantimkiem.Name = "lblNhapthongtuncantimkiem";
            this.lblNhapthongtuncantimkiem.Size = new System.Drawing.Size(183, 17);
            this.lblNhapthongtuncantimkiem.TabIndex = 0;
            this.lblNhapthongtuncantimkiem.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVLop);
            this.groupBox1.Controls.Add(this.bindingNavigatorClass);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(300, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(666, 593);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp";
            // 
            // dGVLop
            // 
            this.dGVLop.AllowUserToAddRows = false;
            this.dGVLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dGVLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVLop.Location = new System.Drawing.Point(3, 44);
            this.dGVLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVLop.Name = "dGVLop";
            this.dGVLop.RowTemplate.Height = 24;
            this.dGVLop.Size = new System.Drawing.Size(660, 547);
            this.dGVLop.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaLop";
            this.Column1.HeaderText = "Mã Lớp";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenLop";
            this.Column2.HeaderText = "Tên Lớp";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "TenKhoiLop";
            this.Column3.HeaderText = "Khối Lớp";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TenGV";
            this.Column5.HeaderText = "Giáo Viên Chủ Nhiệm";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "TenNamHoc";
            this.Column4.HeaderText = "Năm học";
            this.Column4.Name = "Column4";
            // 
            // bindingNavigatorClass
            // 
            this.bindingNavigatorClass.AddNewItem = null;
            this.bindingNavigatorClass.CountItem = null;
            this.bindingNavigatorClass.DeleteItem = null;
            this.bindingNavigatorClass.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorClass.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.btnAdd,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.btnDelete,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.btnSave,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.btnExit});
            this.bindingNavigatorClass.Location = new System.Drawing.Point(3, 17);
            this.bindingNavigatorClass.MoveFirstItem = null;
            this.bindingNavigatorClass.MoveLastItem = null;
            this.bindingNavigatorClass.MoveNextItem = null;
            this.bindingNavigatorClass.MovePreviousItem = null;
            this.bindingNavigatorClass.Name = "bindingNavigatorClass";
            this.bindingNavigatorClass.PositionItem = null;
            this.bindingNavigatorClass.Size = new System.Drawing.Size(660, 27);
            this.bindingNavigatorClass.TabIndex = 0;
            this.bindingNavigatorClass.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QLHS.Properties.Resources.edit;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(59, 24);
            this.btnAdd.Text = "Edit";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(77, 24);
            this.btnDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QLHS.Properties.Resources.save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 24);
            this.btnSave.Text = "Save";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::QLHS.Properties.Resources.thoat;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 24);
            this.btnExit.Text = "Exit";
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navigationPaneAddClass);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLop";
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneAddClass)).EndInit();
            this.navigationPaneAddClass.ResumeLayout(false);
            this.navAddClass.ResumeLayout(false);
            this.navAddClass.PerformLayout();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorClass)).EndInit();
            this.bindingNavigatorClass.ResumeLayout(false);
            this.bindingNavigatorClass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPaneAddClass;
        private DevExpress.XtraBars.Navigation.NavigationPage navAddClass;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.Label lblGiaovienchunhiem;
        private System.Windows.Forms.Label lblKhoilop;
        private System.Windows.Forms.ComboBox cmbGiaovienchunhiem;
        private System.Windows.Forms.ComboBox cmbKhoilop;
        private System.Windows.Forms.Label lblSiso;
        private System.Windows.Forms.TextBox txtSiso;
        private System.Windows.Forms.Label lblTenlop;
        private System.Windows.Forms.TextBox txtTenlop;
        private System.Windows.Forms.Label lblMalop;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.RadioButton radTimtheotenlop;
        private System.Windows.Forms.RadioButton radTimtheomalop;
        private System.Windows.Forms.TextBox txtNhapthongtincantimkiem;
        private System.Windows.Forms.Label lblNhapthongtuncantimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGVLop;
        private System.Windows.Forms.BindingNavigator bindingNavigatorClass;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ComboBox cmbNamHoc;
        private System.Windows.Forms.Label lbNamHoc;
        private System.Windows.Forms.Label lbNotice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}