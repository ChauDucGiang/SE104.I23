﻿namespace QLHS
{
    partial class frmNhapdiemrieng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapdiemrieng));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblLoaidiem = new System.Windows.Forms.Label();
            this.lblHocsinh = new System.Windows.Forms.Label();
            this.lblHocky = new System.Windows.Forms.Label();
            this.lblMonhoc = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblNamhoc = new System.Windows.Forms.Label();
            this.cmbLoaidiem = new System.Windows.Forms.ComboBox();
            this.cmbHocsinh = new System.Windows.Forms.ComboBox();
            this.cmbHocky = new System.Windows.Forms.ComboBox();
            this.cmbMonhoc = new System.Windows.Forms.ComboBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.cmbNamhoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVNhapdiemrieng = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.colMahocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenhocsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaidiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNhapdiemrieng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.txtDiem);
            this.panelControl1.Controls.Add(this.lblDiem);
            this.panelControl1.Controls.Add(this.lblLoaidiem);
            this.panelControl1.Controls.Add(this.lblHocsinh);
            this.panelControl1.Controls.Add(this.lblHocky);
            this.panelControl1.Controls.Add(this.lblMonhoc);
            this.panelControl1.Controls.Add(this.lblLop);
            this.panelControl1.Controls.Add(this.lblNamhoc);
            this.panelControl1.Controls.Add(this.cmbLoaidiem);
            this.panelControl1.Controls.Add(this.cmbHocsinh);
            this.panelControl1.Controls.Add(this.cmbHocky);
            this.panelControl1.Controls.Add(this.cmbMonhoc);
            this.panelControl1.Controls.Add(this.cmbLop);
            this.panelControl1.Controls.Add(this.cmbNamhoc);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(275, 593);
            this.panelControl1.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.Image = global::QLHS.Properties.Resources.luuchuyenlop;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(5, 497);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(265, 56);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Lưu";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiem.Location = new System.Drawing.Point(5, 448);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(265, 23);
            this.txtDiem.TabIndex = 0;
            // 
            // lblDiem
            // 
            this.lblDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(6, 428);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(39, 17);
            this.lblDiem.TabIndex = 3;
            this.lblDiem.Text = "Điểm";
            // 
            // lblLoaidiem
            // 
            this.lblLoaidiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoaidiem.AutoSize = true;
            this.lblLoaidiem.Location = new System.Drawing.Point(6, 356);
            this.lblLoaidiem.Name = "lblLoaidiem";
            this.lblLoaidiem.Size = new System.Drawing.Size(65, 17);
            this.lblLoaidiem.TabIndex = 2;
            this.lblLoaidiem.Text = "Loại điểm";
            // 
            // lblHocsinh
            // 
            this.lblHocsinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHocsinh.AutoSize = true;
            this.lblHocsinh.Location = new System.Drawing.Point(5, 231);
            this.lblHocsinh.Name = "lblHocsinh";
            this.lblHocsinh.Size = new System.Drawing.Size(60, 17);
            this.lblHocsinh.TabIndex = 2;
            this.lblHocsinh.Text = "Học sinh";
            // 
            // lblHocky
            // 
            this.lblHocky.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHocky.AutoSize = true;
            this.lblHocky.Location = new System.Drawing.Point(6, 106);
            this.lblHocky.Name = "lblHocky";
            this.lblHocky.Size = new System.Drawing.Size(51, 17);
            this.lblHocky.TabIndex = 2;
            this.lblHocky.Text = "Học kỳ";
            // 
            // lblMonhoc
            // 
            this.lblMonhoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonhoc.AutoSize = true;
            this.lblMonhoc.Location = new System.Drawing.Point(5, 299);
            this.lblMonhoc.Name = "lblMonhoc";
            this.lblMonhoc.Size = new System.Drawing.Size(61, 17);
            this.lblMonhoc.TabIndex = 2;
            this.lblMonhoc.Text = "Môn học";
            // 
            // lblLop
            // 
            this.lblLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(6, 174);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(31, 17);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Lớp";
            // 
            // lblNamhoc
            // 
            this.lblNamhoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamhoc.AutoSize = true;
            this.lblNamhoc.Location = new System.Drawing.Point(6, 46);
            this.lblNamhoc.Name = "lblNamhoc";
            this.lblNamhoc.Size = new System.Drawing.Size(63, 17);
            this.lblNamhoc.TabIndex = 2;
            this.lblNamhoc.Text = "Năm học";
            // 
            // cmbLoaidiem
            // 
            this.cmbLoaidiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLoaidiem.FormattingEnabled = true;
            this.cmbLoaidiem.Location = new System.Drawing.Point(5, 376);
            this.cmbLoaidiem.Name = "cmbLoaidiem";
            this.cmbLoaidiem.Size = new System.Drawing.Size(265, 24);
            this.cmbLoaidiem.TabIndex = 1;
            // 
            // cmbHocsinh
            // 
            this.cmbHocsinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHocsinh.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.cmbHocsinh.FormattingEnabled = true;
            this.cmbHocsinh.Location = new System.Drawing.Point(5, 251);
            this.cmbHocsinh.Name = "cmbHocsinh";
            this.cmbHocsinh.Size = new System.Drawing.Size(265, 24);
            this.cmbHocsinh.TabIndex = 1;
            // 
            // cmbHocky
            // 
            this.cmbHocky.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHocky.FormattingEnabled = true;
            this.cmbHocky.Location = new System.Drawing.Point(5, 126);
            this.cmbHocky.Name = "cmbHocky";
            this.cmbHocky.Size = new System.Drawing.Size(265, 24);
            this.cmbHocky.TabIndex = 1;
            // 
            // cmbMonhoc
            // 
            this.cmbMonhoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMonhoc.FormattingEnabled = true;
            this.cmbMonhoc.Location = new System.Drawing.Point(5, 319);
            this.cmbMonhoc.Name = "cmbMonhoc";
            this.cmbMonhoc.Size = new System.Drawing.Size(265, 24);
            this.cmbMonhoc.TabIndex = 1;
            // 
            // cmbLop
            // 
            this.cmbLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(5, 194);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(265, 24);
            this.cmbLop.TabIndex = 1;
            this.cmbLop.SelectedIndexChanged += new System.EventHandler(this.cmbLop_SelectedIndexChanged);
            // 
            // cmbNamhoc
            // 
            this.cmbNamhoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNamhoc.FormattingEnabled = true;
            this.cmbNamhoc.Location = new System.Drawing.Point(5, 69);
            this.cmbNamhoc.Name = "cmbNamhoc";
            this.cmbNamhoc.Size = new System.Drawing.Size(265, 24);
            this.cmbNamhoc.TabIndex = 1;
            this.cmbNamhoc.SelectedIndexChanged += new System.EventHandler(this.cmbNamhoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP DỮ LIỆU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVNhapdiemrieng);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(275, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 593);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học sinh";
            // 
            // dGVNhapdiemrieng
            // 
            this.dGVNhapdiemrieng.AllowUserToAddRows = false;
            this.dGVNhapdiemrieng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVNhapdiemrieng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNhapdiemrieng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMahocsinh,
            this.colTenhocsinh,
            this.colHocky,
            this.colNamhoc,
            this.colLoaidiem,
            this.colDiem,
            this.colTenmon});
            this.dGVNhapdiemrieng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVNhapdiemrieng.Location = new System.Drawing.Point(3, 45);
            this.dGVNhapdiemrieng.Name = "dGVNhapdiemrieng";
            this.dGVNhapdiemrieng.RowTemplate.Height = 24;
            this.dGVNhapdiemrieng.Size = new System.Drawing.Size(691, 545);
            this.dGVNhapdiemrieng.TabIndex = 1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.toolStripSeparator2,
            this.btnDelete,
            this.toolStripSeparator6,
            this.toolStripSeparator3,
            this.btnSave,
            this.toolStripSeparator4,
            this.toolStripSeparator7,
            this.btnExit});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 18);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(691, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(77, 24);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
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
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::QLHS.Properties.Resources.thoat;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 24);
            this.btnExit.Text = "Exit";
            // 
            // colMahocsinh
            // 
            this.colMahocsinh.DataPropertyName = "MaHS";
            this.colMahocsinh.FillWeight = 97.41205F;
            this.colMahocsinh.HeaderText = "Mã học sinh";
            this.colMahocsinh.Name = "colMahocsinh";
            // 
            // colTenhocsinh
            // 
            this.colTenhocsinh.DataPropertyName = "HoTen";
            this.colTenhocsinh.FillWeight = 98.81193F;
            this.colTenhocsinh.HeaderText = "Tên học sinh";
            this.colTenhocsinh.Name = "colTenhocsinh";
            // 
            // colHocky
            // 
            this.colHocky.DataPropertyName = "TenHocKi";
            this.colHocky.FillWeight = 101.1362F;
            this.colHocky.HeaderText = "Học kỳ";
            this.colHocky.Name = "colHocky";
            // 
            // colNamhoc
            // 
            this.colNamhoc.DataPropertyName = "TenNamHoc";
            this.colNamhoc.FillWeight = 101.7887F;
            this.colNamhoc.HeaderText = "Năm học";
            this.colNamhoc.Name = "colNamhoc";
            // 
            // colLoaidiem
            // 
            this.colLoaidiem.DataPropertyName = "TenCotDiem";
            this.colLoaidiem.FillWeight = 100.5749F;
            this.colLoaidiem.HeaderText = "Loại điểm";
            this.colLoaidiem.Name = "colLoaidiem";
            // 
            // colDiem
            // 
            this.colDiem.DataPropertyName = "Diem";
            this.colDiem.FillWeight = 100.2762F;
            this.colDiem.HeaderText = "Điểm";
            this.colDiem.Name = "colDiem";
            // 
            // colTenmon
            // 
            this.colTenmon.DataPropertyName = "TenMon";
            this.colTenmon.HeaderText = "Môn học";
            this.colTenmon.Name = "colTenmon";
            // 
            // frmNhapdiemrieng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNhapdiemrieng";
            this.Text = "Nhập điểm học sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapdiemrieng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNhapdiemrieng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblLoaidiem;
        private System.Windows.Forms.Label lblHocsinh;
        private System.Windows.Forms.Label lblHocky;
        private System.Windows.Forms.Label lblMonhoc;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblNamhoc;
        private System.Windows.Forms.ComboBox cmbLoaidiem;
        private System.Windows.Forms.ComboBox cmbHocsinh;
        private System.Windows.Forms.ComboBox cmbHocky;
        private System.Windows.Forms.ComboBox cmbMonhoc;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.ComboBox cmbNamhoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGVNhapdiemrieng;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMahocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenhocsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaidiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenmon;
    }
}