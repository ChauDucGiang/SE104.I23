namespace QLHS
{
    partial class frmGiaovien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaovien));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.lblMamonhoc = new System.Windows.Forms.Label();
            this.txtTengiaovien = new System.Windows.Forms.TextBox();
            this.txtMagiaovien = new System.Windows.Forms.TextBox();
            this.cmbMamonhoc = new System.Windows.Forms.ComboBox();
            this.lblTengiaovien = new System.Windows.Forms.Label();
            this.lblMagiaovien = new System.Windows.Forms.Label();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.radTimtheotengiaovien = new System.Windows.Forms.RadioButton();
            this.radTimtheomagiaovien = new System.Windows.Forms.RadioButton();
            this.lblNhapthongtincantimkiem = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVGiaovien = new System.Windows.Forms.DataGridView();
            this.colMagiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTengiaovien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExite = new System.Windows.Forms.ToolStripButton();
            this.btnThemvaodanhsach = new System.Windows.Forms.Button();
            this.txtNhapthongtincantimkiem = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiaovien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.navigationPane1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(325, 425);
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
            this.navigationPane1.RegularSize = new System.Drawing.Size(316, 422);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.Size = new System.Drawing.Size(316, 422);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Thêm dữ liệu";
            this.navigationPage1.Controls.Add(this.btnThemvaodanhsach);
            this.navigationPage1.Controls.Add(this.txtDienthoai);
            this.navigationPage1.Controls.Add(this.lblDienthoai);
            this.navigationPage1.Controls.Add(this.lblMamonhoc);
            this.navigationPage1.Controls.Add(this.txtTengiaovien);
            this.navigationPage1.Controls.Add(this.txtMagiaovien);
            this.navigationPage1.Controls.Add(this.cmbMamonhoc);
            this.navigationPage1.Controls.Add(this.lblTengiaovien);
            this.navigationPage1.Controls.Add(this.lblMagiaovien);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(195, 352);
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(7, 242);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(121, 22);
            this.txtDienthoai.TabIndex = 6;
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.AutoSize = true;
            this.lblDienthoai.Location = new System.Drawing.Point(7, 221);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(72, 17);
            this.lblDienthoai.TabIndex = 5;
            this.lblDienthoai.Text = "Điện thoại";
            // 
            // lblMamonhoc
            // 
            this.lblMamonhoc.AutoSize = true;
            this.lblMamonhoc.Location = new System.Drawing.Point(7, 143);
            this.lblMamonhoc.Name = "lblMamonhoc";
            this.lblMamonhoc.Size = new System.Drawing.Size(85, 17);
            this.lblMamonhoc.TabIndex = 4;
            this.lblMamonhoc.Text = "Mã môn học";
            // 
            // txtTengiaovien
            // 
            this.txtTengiaovien.Location = new System.Drawing.Point(7, 90);
            this.txtTengiaovien.Name = "txtTengiaovien";
            this.txtTengiaovien.Size = new System.Drawing.Size(121, 22);
            this.txtTengiaovien.TabIndex = 3;
            // 
            // txtMagiaovien
            // 
            this.txtMagiaovien.Location = new System.Drawing.Point(7, 25);
            this.txtMagiaovien.Name = "txtMagiaovien";
            this.txtMagiaovien.Size = new System.Drawing.Size(121, 22);
            this.txtMagiaovien.TabIndex = 2;
            // 
            // cmbMamonhoc
            // 
            this.cmbMamonhoc.FormattingEnabled = true;
            this.cmbMamonhoc.Location = new System.Drawing.Point(7, 163);
            this.cmbMamonhoc.Name = "cmbMamonhoc";
            this.cmbMamonhoc.Size = new System.Drawing.Size(121, 24);
            this.cmbMamonhoc.TabIndex = 1;
            // 
            // lblTengiaovien
            // 
            this.lblTengiaovien.AutoSize = true;
            this.lblTengiaovien.Location = new System.Drawing.Point(4, 69);
            this.lblTengiaovien.Name = "lblTengiaovien";
            this.lblTengiaovien.Size = new System.Drawing.Size(94, 17);
            this.lblTengiaovien.TabIndex = 0;
            this.lblTengiaovien.Text = "Tên giáo viên";
            // 
            // lblMagiaovien
            // 
            this.lblMagiaovien.AutoSize = true;
            this.lblMagiaovien.Location = new System.Drawing.Point(4, 4);
            this.lblMagiaovien.Name = "lblMagiaovien";
            this.lblMagiaovien.Size = new System.Drawing.Size(88, 17);
            this.lblMagiaovien.TabIndex = 0;
            this.lblMagiaovien.Text = "Mã giáo viên";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Tìm kiếm";
            this.navigationPage2.Controls.Add(this.txtNhapthongtincantimkiem);
            this.navigationPage2.Controls.Add(this.btnTimkiem);
            this.navigationPage2.Controls.Add(this.radTimtheotengiaovien);
            this.navigationPage2.Controls.Add(this.radTimtheomagiaovien);
            this.navigationPage2.Controls.Add(this.lblNhapthongtincantimkiem);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(195, 352);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(48, 239);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(87, 33);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // radTimtheotengiaovien
            // 
            this.radTimtheotengiaovien.AutoSize = true;
            this.radTimtheotengiaovien.Location = new System.Drawing.Point(6, 157);
            this.radTimtheotengiaovien.Name = "radTimtheotengiaovien";
            this.radTimtheotengiaovien.Size = new System.Drawing.Size(169, 21);
            this.radTimtheotengiaovien.TabIndex = 1;
            this.radTimtheotengiaovien.TabStop = true;
            this.radTimtheotengiaovien.Text = "Tìm theo tên giáo viên";
            this.radTimtheotengiaovien.UseVisualStyleBackColor = true;
            // 
            // radTimtheomagiaovien
            // 
            this.radTimtheomagiaovien.AutoSize = true;
            this.radTimtheomagiaovien.Location = new System.Drawing.Point(6, 111);
            this.radTimtheomagiaovien.Name = "radTimtheomagiaovien";
            this.radTimtheomagiaovien.Size = new System.Drawing.Size(168, 21);
            this.radTimtheomagiaovien.TabIndex = 1;
            this.radTimtheomagiaovien.TabStop = true;
            this.radTimtheomagiaovien.Text = "Tìm theo mã giáo viên";
            this.radTimtheomagiaovien.UseVisualStyleBackColor = true;
            // 
            // lblNhapthongtincantimkiem
            // 
            this.lblNhapthongtincantimkiem.AutoSize = true;
            this.lblNhapthongtincantimkiem.Location = new System.Drawing.Point(3, 9);
            this.lblNhapthongtincantimkiem.Name = "lblNhapthongtincantimkiem";
            this.lblNhapthongtincantimkiem.Size = new System.Drawing.Size(183, 17);
            this.lblNhapthongtincantimkiem.TabIndex = 0;
            this.lblNhapthongtincantimkiem.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVGiaovien);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Location = new System.Drawing.Point(338, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 435);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách giáo viên";
            // 
            // dGVGiaovien
            // 
            this.dGVGiaovien.AllowUserToAddRows = false;
            this.dGVGiaovien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGiaovien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMagiaovien,
            this.colTengiaovien,
            this.colMamonhoc,
            this.colDienthoai});
            this.dGVGiaovien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVGiaovien.Location = new System.Drawing.Point(3, 45);
            this.dGVGiaovien.Name = "dGVGiaovien";
            this.dGVGiaovien.RowTemplate.Height = 24;
            this.dGVGiaovien.Size = new System.Drawing.Size(550, 387);
            this.dGVGiaovien.TabIndex = 1;
            // 
            // colMagiaovien
            // 
            this.colMagiaovien.HeaderText = "Mã giáo viên";
            this.colMagiaovien.Name = "colMagiaovien";
            // 
            // colTengiaovien
            // 
            this.colTengiaovien.HeaderText = "Tên giáo viên";
            this.colTengiaovien.Name = "colTengiaovien";
            // 
            // colMamonhoc
            // 
            this.colMamonhoc.HeaderText = "Mã môn học";
            this.colMamonhoc.Name = "colMamonhoc";
            // 
            // colDienthoai
            // 
            this.colDienthoai.HeaderText = "Điện thoại";
            this.colDienthoai.Name = "colDienthoai";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator2,
            this.btnAdd,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.btnDelete,
            this.toolStripSeparator1,
            this.toolStripSeparator4,
            this.btnSave,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.btnExite});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 18);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(550, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(24, 24);
            this.btnAdd.Text = "Add new";
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
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(24, 24);
            this.btnDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(24, 24);
            this.btnSave.Text = "toolStripButton1";
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
            // btnExite
            // 
            this.btnExite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExite.Image = ((System.Drawing.Image)(resources.GetObject("btnExite.Image")));
            this.btnExite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExite.Name = "btnExite";
            this.btnExite.Size = new System.Drawing.Size(24, 24);
            this.btnExite.Text = "toolStripButton1";
            // 
            // btnThemvaodanhsach
            // 
            this.btnThemvaodanhsach.Location = new System.Drawing.Point(25, 295);
            this.btnThemvaodanhsach.Name = "btnThemvaodanhsach";
            this.btnThemvaodanhsach.Size = new System.Drawing.Size(116, 46);
            this.btnThemvaodanhsach.TabIndex = 7;
            this.btnThemvaodanhsach.Text = "Thêm vào danh sách";
            this.btnThemvaodanhsach.UseVisualStyleBackColor = true;
            // 
            // txtNhapthongtincantimkiem
            // 
            this.txtNhapthongtincantimkiem.Location = new System.Drawing.Point(6, 40);
            this.txtNhapthongtincantimkiem.Name = "txtNhapthongtincantimkiem";
            this.txtNhapthongtincantimkiem.Size = new System.Drawing.Size(180, 22);
            this.txtNhapthongtincantimkiem.TabIndex = 3;
            // 
            // frmGiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmGiaovien";
            this.Text = "Giáo viên";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGiaovien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.Label lblMamonhoc;
        private System.Windows.Forms.TextBox txtTengiaovien;
        private System.Windows.Forms.TextBox txtMagiaovien;
        private System.Windows.Forms.ComboBox cmbMamonhoc;
        private System.Windows.Forms.Label lblTengiaovien;
        private System.Windows.Forms.Label lblMagiaovien;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.RadioButton radTimtheotengiaovien;
        private System.Windows.Forms.RadioButton radTimtheomagiaovien;
        private System.Windows.Forms.Label lblNhapthongtincantimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGVGiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMagiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTengiaovien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMamonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienthoai;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnExite;
        private System.Windows.Forms.Button btnThemvaodanhsach;
        private System.Windows.Forms.TextBox txtNhapthongtincantimkiem;
    }
}