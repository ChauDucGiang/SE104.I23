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
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
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
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(225, 487);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(653, 487);
            this.navigationPane1.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Expanded;
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "Tìm kiếm";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Thêm Lớp";
            this.navigationPage1.Controls.Add(this.lbNotice);
            this.navigationPage1.Controls.Add(this.cmbNamHoc);
            this.navigationPage1.Controls.Add(this.lbNamHoc);
            this.navigationPage1.Controls.Add(this.btnLuu);
            this.navigationPage1.Controls.Add(this.lblGiaovienchunhiem);
            this.navigationPage1.Controls.Add(this.lblKhoilop);
            this.navigationPage1.Controls.Add(this.cmbGiaovienchunhiem);
            this.navigationPage1.Controls.Add(this.cmbKhoilop);
            this.navigationPage1.Controls.Add(this.lblSiso);
            this.navigationPage1.Controls.Add(this.txtSiso);
            this.navigationPage1.Controls.Add(this.lblTenlop);
            this.navigationPage1.Controls.Add(this.txtTenlop);
            this.navigationPage1.Controls.Add(this.lblMalop);
            this.navigationPage1.Controls.Add(this.txtMalop);
            this.navigationPage1.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(577, 424);
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.Location = new System.Drawing.Point(5, 51);
            this.lbNotice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(136, 13);
            this.lbNotice.TabIndex = 7;
            this.lbNotice.Text = "Bắt đầu bằng 1**NAMHOC";
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Location = new System.Drawing.Point(6, 277);
            this.cmbNamHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(92, 21);
            this.cmbNamHoc.TabIndex = 6;
            // 
            // lbNamHoc
            // 
            this.lbNamHoc.AutoSize = true;
            this.lbNamHoc.Location = new System.Drawing.Point(5, 262);
            this.lbNamHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNamHoc.Name = "lbNamHoc";
            this.lbNamHoc.Size = new System.Drawing.Size(50, 13);
            this.lbNamHoc.TabIndex = 5;
            this.lbNamHoc.Text = "Năm học";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(20, 390);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 32);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblGiaovienchunhiem
            // 
            this.lblGiaovienchunhiem.AutoSize = true;
            this.lblGiaovienchunhiem.Location = new System.Drawing.Point(2, 333);
            this.lblGiaovienchunhiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaovienchunhiem.Name = "lblGiaovienchunhiem";
            this.lblGiaovienchunhiem.Size = new System.Drawing.Size(104, 13);
            this.lblGiaovienchunhiem.TabIndex = 3;
            this.lblGiaovienchunhiem.Text = "Giáo viên chủ nhiệm";
            // 
            // lblKhoilop
            // 
            this.lblKhoilop.AutoSize = true;
            this.lblKhoilop.Location = new System.Drawing.Point(5, 190);
            this.lblKhoilop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhoilop.Name = "lblKhoilop";
            this.lblKhoilop.Size = new System.Drawing.Size(45, 13);
            this.lblKhoilop.TabIndex = 3;
            this.lblKhoilop.Text = "Khối lớp";
            // 
            // cmbGiaovienchunhiem
            // 
            this.cmbGiaovienchunhiem.FormattingEnabled = true;
            this.cmbGiaovienchunhiem.Location = new System.Drawing.Point(5, 348);
            this.cmbGiaovienchunhiem.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGiaovienchunhiem.Name = "cmbGiaovienchunhiem";
            this.cmbGiaovienchunhiem.Size = new System.Drawing.Size(92, 21);
            this.cmbGiaovienchunhiem.TabIndex = 2;
            // 
            // cmbKhoilop
            // 
            this.cmbKhoilop.FormattingEnabled = true;
            this.cmbKhoilop.Location = new System.Drawing.Point(5, 209);
            this.cmbKhoilop.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKhoilop.Name = "cmbKhoilop";
            this.cmbKhoilop.Size = new System.Drawing.Size(92, 21);
            this.cmbKhoilop.TabIndex = 2;
            // 
            // lblSiso
            // 
            this.lblSiso.AutoSize = true;
            this.lblSiso.Location = new System.Drawing.Point(3, 128);
            this.lblSiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSiso.Name = "lblSiso";
            this.lblSiso.Size = new System.Drawing.Size(33, 13);
            this.lblSiso.TabIndex = 1;
            this.lblSiso.Text = "Sĩ số";
            // 
            // txtSiso
            // 
            this.txtSiso.Location = new System.Drawing.Point(5, 145);
            this.txtSiso.Margin = new System.Windows.Forms.Padding(2);
            this.txtSiso.Name = "txtSiso";
            this.txtSiso.ReadOnly = true;
            this.txtSiso.Size = new System.Drawing.Size(76, 20);
            this.txtSiso.TabIndex = 0;
            this.txtSiso.Text = "0";
            // 
            // lblTenlop
            // 
            this.lblTenlop.AutoSize = true;
            this.lblTenlop.Location = new System.Drawing.Point(3, 68);
            this.lblTenlop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenlop.Name = "lblTenlop";
            this.lblTenlop.Size = new System.Drawing.Size(43, 13);
            this.lblTenlop.TabIndex = 1;
            this.lblTenlop.Text = "Tên lớp";
            // 
            // txtTenlop
            // 
            this.txtTenlop.Location = new System.Drawing.Point(5, 84);
            this.txtTenlop.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(76, 20);
            this.txtTenlop.TabIndex = 0;
            this.txtTenlop.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblMalop
            // 
            this.lblMalop.AutoSize = true;
            this.lblMalop.Location = new System.Drawing.Point(3, 13);
            this.lblMalop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMalop.Name = "lblMalop";
            this.lblMalop.Size = new System.Drawing.Size(39, 13);
            this.lblMalop.TabIndex = 1;
            this.lblMalop.Text = "Mã lớp";
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(5, 29);
            this.txtMalop.Margin = new System.Windows.Forms.Padding(2);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(76, 20);
            this.txtMalop.TabIndex = 0;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Tìm kiếm";
            this.navigationPage2.Controls.Add(this.btnTimkiem);
            this.navigationPage2.Controls.Add(this.radTimtheotenlop);
            this.navigationPage2.Controls.Add(this.radTimtheomalop);
            this.navigationPage2.Controls.Add(this.txtNhapthongtincantimkiem);
            this.navigationPage2.Controls.Add(this.lblNhapthongtuncantimkiem);
            this.navigationPage2.Margin = new System.Windows.Forms.Padding(2);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(573, 427);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(28, 197);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 31);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "TÌM KIẾM";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // radTimtheotenlop
            // 
            this.radTimtheotenlop.AutoSize = true;
            this.radTimtheotenlop.Location = new System.Drawing.Point(5, 131);
            this.radTimtheotenlop.Margin = new System.Windows.Forms.Padding(2);
            this.radTimtheotenlop.Name = "radTimtheotenlop";
            this.radTimtheotenlop.Size = new System.Drawing.Size(101, 17);
            this.radTimtheotenlop.TabIndex = 2;
            this.radTimtheotenlop.TabStop = true;
            this.radTimtheotenlop.Text = "Tìm theo tên lớp";
            this.radTimtheotenlop.UseVisualStyleBackColor = true;
            // 
            // radTimtheomalop
            // 
            this.radTimtheomalop.AutoSize = true;
            this.radTimtheomalop.Location = new System.Drawing.Point(5, 98);
            this.radTimtheomalop.Margin = new System.Windows.Forms.Padding(2);
            this.radTimtheomalop.Name = "radTimtheomalop";
            this.radTimtheomalop.Size = new System.Drawing.Size(100, 17);
            this.radTimtheomalop.TabIndex = 2;
            this.radTimtheomalop.TabStop = true;
            this.radTimtheomalop.Text = "Tìm theo mã lớp";
            this.radTimtheomalop.UseVisualStyleBackColor = true;
            // 
            // txtNhapthongtincantimkiem
            // 
            this.txtNhapthongtincantimkiem.Location = new System.Drawing.Point(2, 52);
            this.txtNhapthongtincantimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhapthongtincantimkiem.Name = "txtNhapthongtincantimkiem";
            this.txtNhapthongtincantimkiem.Size = new System.Drawing.Size(134, 20);
            this.txtNhapthongtincantimkiem.TabIndex = 1;
            // 
            // lblNhapthongtuncantimkiem
            // 
            this.lblNhapthongtuncantimkiem.AutoSize = true;
            this.lblNhapthongtuncantimkiem.Location = new System.Drawing.Point(3, 25);
            this.lblNhapthongtuncantimkiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhapthongtuncantimkiem.Name = "lblNhapthongtuncantimkiem";
            this.lblNhapthongtuncantimkiem.Size = new System.Drawing.Size(133, 13);
            this.lblNhapthongtuncantimkiem.TabIndex = 0;
            this.lblNhapthongtuncantimkiem.Text = "Nhập thông tin cần tìm iếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVLop);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Location = new System.Drawing.Point(230, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(422, 472);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp";
            // 
            // dGVLop
            // 
            this.dGVLop.AllowUserToAddRows = false;
            this.dGVLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dGVLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVLop.Location = new System.Drawing.Point(2, 42);
            this.dGVLop.Margin = new System.Windows.Forms.Padding(2);
            this.dGVLop.Name = "dGVLop";
            this.dGVLop.RowTemplate.Height = 24;
            this.dGVLop.Size = new System.Drawing.Size(418, 428);
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
            this.Column3.DataPropertyName = "MaKhoiLop";
            this.Column3.HeaderText = "Khối Lớp";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NamHoc";
            this.Column4.HeaderText = "Năm học";
            this.Column4.Name = "Column4";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigator1.Location = new System.Drawing.Point(2, 15);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(418, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // btnAdd
            // 
            this.btnAdd.Image = global::QLHS.Properties.Resources.edit;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(51, 24);
            this.btnAdd.Text = "Edit";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(64, 24);
            this.btnDelete.Text = "Delete";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QLHS.Properties.Resources.save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 24);
            this.btnSave.Text = "Save";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::QLHS.Properties.Resources.thoat;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 24);
            this.btnExit.Text = "Exit";
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navigationPane1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLop";
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
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
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cmbNamHoc;
        private System.Windows.Forms.Label lbNamHoc;
        private System.Windows.Forms.Label lbNotice;
    }
}