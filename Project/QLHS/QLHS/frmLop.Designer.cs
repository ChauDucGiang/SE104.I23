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
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblGiaovienchunhiem = new System.Windows.Forms.Label();
            this.lblNamhoc = new System.Windows.Forms.Label();
            this.lblKhoilop = new System.Windows.Forms.Label();
            this.cmbGiaovienchunhiem = new System.Windows.Forms.ComboBox();
            this.cmbNamhoc = new System.Windows.Forms.ComboBox();
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
            this.lblNhapthongtincantimkiem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVLop = new System.Windows.Forms.DataGridView();
            this.colMalop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoilop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDalete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
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
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(300, 607);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(300, 607);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "Tìm kiếm";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Thêm Lớp";
            this.navigationPage1.Controls.Add(this.btnLuu);
            this.navigationPage1.Controls.Add(this.lblGiaovienchunhiem);
            this.navigationPage1.Controls.Add(this.lblNamhoc);
            this.navigationPage1.Controls.Add(this.lblKhoilop);
            this.navigationPage1.Controls.Add(this.cmbGiaovienchunhiem);
            this.navigationPage1.Controls.Add(this.cmbNamhoc);
            this.navigationPage1.Controls.Add(this.cmbKhoilop);
            this.navigationPage1.Controls.Add(this.lblSiso);
            this.navigationPage1.Controls.Add(this.txtSiso);
            this.navigationPage1.Controls.Add(this.lblTenlop);
            this.navigationPage1.Controls.Add(this.txtTenlop);
            this.navigationPage1.Controls.Add(this.lblMalop);
            this.navigationPage1.Controls.Add(this.txtMalop);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(202, 534);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(32, 469);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(115, 40);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // lblGiaovienchunhiem
            // 
            this.lblGiaovienchunhiem.AutoSize = true;
            this.lblGiaovienchunhiem.Location = new System.Drawing.Point(10, 396);
            this.lblGiaovienchunhiem.Name = "lblGiaovienchunhiem";
            this.lblGiaovienchunhiem.Size = new System.Drawing.Size(137, 17);
            this.lblGiaovienchunhiem.TabIndex = 3;
            this.lblGiaovienchunhiem.Text = "Giáo viên chủ nhiệm";
            // 
            // lblNamhoc
            // 
            this.lblNamhoc.AutoSize = true;
            this.lblNamhoc.Location = new System.Drawing.Point(7, 314);
            this.lblNamhoc.Name = "lblNamhoc";
            this.lblNamhoc.Size = new System.Drawing.Size(64, 17);
            this.lblNamhoc.TabIndex = 3;
            this.lblNamhoc.Text = "Năm học";
            // 
            // lblKhoilop
            // 
            this.lblKhoilop.AutoSize = true;
            this.lblKhoilop.Location = new System.Drawing.Point(7, 234);
            this.lblKhoilop.Name = "lblKhoilop";
            this.lblKhoilop.Size = new System.Drawing.Size(59, 17);
            this.lblKhoilop.TabIndex = 3;
            this.lblKhoilop.Text = "Khối lớp";
            // 
            // cmbGiaovienchunhiem
            // 
            this.cmbGiaovienchunhiem.FormattingEnabled = true;
            this.cmbGiaovienchunhiem.Location = new System.Drawing.Point(10, 419);
            this.cmbGiaovienchunhiem.Name = "cmbGiaovienchunhiem";
            this.cmbGiaovienchunhiem.Size = new System.Drawing.Size(121, 24);
            this.cmbGiaovienchunhiem.TabIndex = 2;
            // 
            // cmbNamhoc
            // 
            this.cmbNamhoc.FormattingEnabled = true;
            this.cmbNamhoc.Location = new System.Drawing.Point(7, 337);
            this.cmbNamhoc.Name = "cmbNamhoc";
            this.cmbNamhoc.Size = new System.Drawing.Size(121, 24);
            this.cmbNamhoc.TabIndex = 2;
            // 
            // cmbKhoilop
            // 
            this.cmbKhoilop.FormattingEnabled = true;
            this.cmbKhoilop.Location = new System.Drawing.Point(7, 257);
            this.cmbKhoilop.Name = "cmbKhoilop";
            this.cmbKhoilop.Size = new System.Drawing.Size(121, 24);
            this.cmbKhoilop.TabIndex = 2;
            // 
            // lblSiso
            // 
            this.lblSiso.AutoSize = true;
            this.lblSiso.Location = new System.Drawing.Point(4, 158);
            this.lblSiso.Name = "lblSiso";
            this.lblSiso.Size = new System.Drawing.Size(39, 17);
            this.lblSiso.TabIndex = 1;
            this.lblSiso.Text = "Sĩ số";
            // 
            // txtSiso
            // 
            this.txtSiso.Location = new System.Drawing.Point(7, 178);
            this.txtSiso.Name = "txtSiso";
            this.txtSiso.Size = new System.Drawing.Size(100, 22);
            this.txtSiso.TabIndex = 0;
            // 
            // lblTenlop
            // 
            this.lblTenlop.AutoSize = true;
            this.lblTenlop.Location = new System.Drawing.Point(4, 84);
            this.lblTenlop.Name = "lblTenlop";
            this.lblTenlop.Size = new System.Drawing.Size(56, 17);
            this.lblTenlop.TabIndex = 1;
            this.lblTenlop.Text = "Tên lớp";
            // 
            // txtTenlop
            // 
            this.txtTenlop.Location = new System.Drawing.Point(7, 104);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(100, 22);
            this.txtTenlop.TabIndex = 0;
            this.txtTenlop.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblMalop
            // 
            this.lblMalop.AutoSize = true;
            this.lblMalop.Location = new System.Drawing.Point(4, 16);
            this.lblMalop.Name = "lblMalop";
            this.lblMalop.Size = new System.Drawing.Size(50, 17);
            this.lblMalop.TabIndex = 1;
            this.lblMalop.Text = "Mã lớp";
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(7, 36);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(100, 22);
            this.txtMalop.TabIndex = 0;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Tìm kiếm";
            this.navigationPage2.Controls.Add(this.btnTimkiem);
            this.navigationPage2.Controls.Add(this.radTimtheotenlop);
            this.navigationPage2.Controls.Add(this.radTimtheomalop);
            this.navigationPage2.Controls.Add(this.txtNhapthongtincantimkiem);
            this.navigationPage2.Controls.Add(this.lblNhapthongtincantimkiem);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(202, 534);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(38, 243);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(100, 38);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "TÌM KIẾM";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // radTimtheotenlop
            // 
            this.radTimtheotenlop.AutoSize = true;
            this.radTimtheotenlop.Location = new System.Drawing.Point(7, 161);
            this.radTimtheotenlop.Name = "radTimtheotenlop";
            this.radTimtheotenlop.Size = new System.Drawing.Size(131, 21);
            this.radTimtheotenlop.TabIndex = 2;
            this.radTimtheotenlop.TabStop = true;
            this.radTimtheotenlop.Text = "Tìm theo tên lớp";
            this.radTimtheotenlop.UseVisualStyleBackColor = true;
            // 
            // radTimtheomalop
            // 
            this.radTimtheomalop.AutoSize = true;
            this.radTimtheomalop.Location = new System.Drawing.Point(7, 121);
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
            this.txtNhapthongtincantimkiem.Name = "txtNhapthongtincantimkiem";
            this.txtNhapthongtincantimkiem.Size = new System.Drawing.Size(177, 22);
            this.txtNhapthongtincantimkiem.TabIndex = 1;
            // 
            // lblNhapthongtincantimkiem
            // 
            this.lblNhapthongtincantimkiem.AutoSize = true;
            this.lblNhapthongtincantimkiem.Location = new System.Drawing.Point(4, 31);
            this.lblNhapthongtincantimkiem.Name = "lblNhapthongtincantimkiem";
            this.lblNhapthongtincantimkiem.Size = new System.Drawing.Size(176, 17);
            this.lblNhapthongtincantimkiem.TabIndex = 0;
            this.lblNhapthongtincantimkiem.Text = "Nhập thông tin cần tìm iếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVLop);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Location = new System.Drawing.Point(307, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 581);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp";
            // 
            // dGVLop
            // 
            this.dGVLop.AllowUserToAddRows = false;
            this.dGVLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMalop,
            this.colTenlop,
            this.colKhoilop,
            this.colNamhoc,
            this.colGiaovien});
            this.dGVLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVLop.Location = new System.Drawing.Point(3, 45);
            this.dGVLop.Name = "dGVLop";
            this.dGVLop.RowTemplate.Height = 24;
            this.dGVLop.Size = new System.Drawing.Size(557, 533);
            this.dGVLop.TabIndex = 1;
            // 
            // colMalop
            // 
            this.colMalop.HeaderText = "Mã lớp";
            this.colMalop.Name = "colMalop";
            // 
            // colTenlop
            // 
            this.colTenlop.HeaderText = "Tên lớp";
            this.colTenlop.Name = "colTenlop";
            // 
            // colKhoilop
            // 
            this.colKhoilop.HeaderText = "Khối lớp";
            this.colKhoilop.Name = "colKhoilop";
            // 
            // colNamhoc
            // 
            this.colNamhoc.HeaderText = "Năm học";
            this.colNamhoc.Name = "colNamhoc";
            // 
            // colGiaovien
            // 
            this.colGiaovien.HeaderText = "Giáo viên chủ nhiệm";
            this.colGiaovien.Name = "colGiaovien";
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
            this.btnDalete,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.btnSave,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.btnExit});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 18);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(557, 27);
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
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(92, 24);
            this.btnAdd.Text = "Add new";
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
            // btnDalete
            // 
            this.btnDalete.Image = ((System.Drawing.Image)(resources.GetObject("btnDalete.Image")));
            this.btnDalete.Name = "btnDalete";
            this.btnDalete.RightToLeftAutoMirrorImage = true;
            this.btnDalete.Size = new System.Drawing.Size(77, 24);
            this.btnDalete.Text = "Delete";
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
            this.ClientSize = new System.Drawing.Size(882, 607);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frmLop";
            this.Text = "Lớp";
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
        private System.Windows.Forms.Label lblNamhoc;
        private System.Windows.Forms.Label lblKhoilop;
        private System.Windows.Forms.ComboBox cmbGiaovienchunhiem;
        private System.Windows.Forms.ComboBox cmbNamhoc;
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
        private System.Windows.Forms.Label lblNhapthongtincantimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGVLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMalop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoilop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaovien;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDalete;
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
    }
}