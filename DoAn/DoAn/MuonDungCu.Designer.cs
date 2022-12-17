namespace DoAn
{
    partial class MuonDungCu
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
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.btnAddMuon = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteMuon = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshMuon = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Dm_MuonDC = new System.Windows.Forms.GroupBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cbb_MaLop = new System.Windows.Forms.ComboBox();
            this.DM_GiaTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_MaGV = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.MuonDC_SoPhieuMuon = new System.Windows.Forms.Label();
            this.tb_SoPM = new System.Windows.Forms.TextBox();
            this.dtp_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.Dm_NgayMuon = new System.Windows.Forms.Label();
            this.dtp_GioMuon = new System.Windows.Forms.DateTimePicker();
            this.DM_GioMuon = new System.Windows.Forms.Label();
            this.dgv_MuonDC = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SoPhieuMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaGiaoVien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.Dm_MuonDC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MuonDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonControl
            // 
            this.ribbonControl.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.btnAddMuon,
            this.bbiEdit,
            this.btnDeleteMuon,
            this.btnRefreshMuon});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.OptionsMenuMinWidth = 385;
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(922, 193);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // btnAddMuon
            // 
            this.btnAddMuon.Caption = "Add";
            this.btnAddMuon.Id = 16;
            this.btnAddMuon.ImageOptions.ImageUri.Uri = "New";
            this.btnAddMuon.Name = "btnAddMuon";
            this.btnAddMuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddMuon_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            // 
            // btnDeleteMuon
            // 
            this.btnDeleteMuon.Caption = "Delete";
            this.btnDeleteMuon.Id = 18;
            this.btnDeleteMuon.ImageOptions.ImageUri.Uri = "Delete";
            this.btnDeleteMuon.Name = "btnDeleteMuon";
            this.btnDeleteMuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteMuon_ItemClick);
            // 
            // btnRefreshMuon
            // 
            this.btnRefreshMuon.Caption = "Refresh";
            this.btnRefreshMuon.Id = 19;
            this.btnRefreshMuon.ImageOptions.ImageUri.Uri = "Refresh";
            this.btnRefreshMuon.Name = "btnRefreshMuon";
            this.btnRefreshMuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshMuon_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddMuon);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDeleteMuon);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefreshMuon);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // Dm_MuonDC
            // 
            this.Dm_MuonDC.Controls.Add(this.groupControl3);
            this.Dm_MuonDC.Controls.Add(this.groupControl2);
            this.Dm_MuonDC.Controls.Add(this.groupControl1);
            this.Dm_MuonDC.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dm_MuonDC.Location = new System.Drawing.Point(0, 193);
            this.Dm_MuonDC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dm_MuonDC.Name = "Dm_MuonDC";
            this.Dm_MuonDC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dm_MuonDC.Size = new System.Drawing.Size(922, 191);
            this.Dm_MuonDC.TabIndex = 27;
            this.Dm_MuonDC.TabStop = false;
            this.Dm_MuonDC.Text = "Mượn dụng cụ";
            // 
            // groupControl3
            // 
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl3.Location = new System.Drawing.Point(603, 18);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(316, 171);
            this.groupControl3.TabIndex = 20;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cbb_MaLop);
            this.groupControl2.Controls.Add(this.DM_GiaTien);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.cbb_MaGV);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(319, 18);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(600, 171);
            this.groupControl2.TabIndex = 19;
            // 
            // cbb_MaLop
            // 
            this.cbb_MaLop.FormattingEnabled = true;
            this.cbb_MaLop.Location = new System.Drawing.Point(100, 40);
            this.cbb_MaLop.Name = "cbb_MaLop";
            this.cbb_MaLop.Size = new System.Drawing.Size(167, 24);
            this.cbb_MaLop.TabIndex = 17;
            // 
            // DM_GiaTien
            // 
            this.DM_GiaTien.AutoSize = true;
            this.DM_GiaTien.Location = new System.Drawing.Point(11, 48);
            this.DM_GiaTien.Name = "DM_GiaTien";
            this.DM_GiaTien.Size = new System.Drawing.Size(45, 16);
            this.DM_GiaTien.TabIndex = 3;
            this.DM_GiaTien.Text = "Mã lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã giáo viên";
            // 
            // cbb_MaGV
            // 
            this.cbb_MaGV.FormattingEnabled = true;
            this.cbb_MaGV.Location = new System.Drawing.Point(100, 83);
            this.cbb_MaGV.Name = "cbb_MaGV";
            this.cbb_MaGV.Size = new System.Drawing.Size(167, 24);
            this.cbb_MaGV.TabIndex = 16;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.MuonDC_SoPhieuMuon);
            this.groupControl1.Controls.Add(this.tb_SoPM);
            this.groupControl1.Controls.Add(this.dtp_NgayMuon);
            this.groupControl1.Controls.Add(this.Dm_NgayMuon);
            this.groupControl1.Controls.Add(this.dtp_GioMuon);
            this.groupControl1.Controls.Add(this.DM_GioMuon);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(3, 18);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(316, 171);
            this.groupControl1.TabIndex = 18;
            // 
            // MuonDC_SoPhieuMuon
            // 
            this.MuonDC_SoPhieuMuon.AutoSize = true;
            this.MuonDC_SoPhieuMuon.Location = new System.Drawing.Point(5, 40);
            this.MuonDC_SoPhieuMuon.Name = "MuonDC_SoPhieuMuon";
            this.MuonDC_SoPhieuMuon.Size = new System.Drawing.Size(94, 16);
            this.MuonDC_SoPhieuMuon.TabIndex = 0;
            this.MuonDC_SoPhieuMuon.Text = "Số phiếu mượn";
            // 
            // tb_SoPM
            // 
            this.tb_SoPM.Location = new System.Drawing.Point(105, 37);
            this.tb_SoPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SoPM.Name = "tb_SoPM";
            this.tb_SoPM.Size = new System.Drawing.Size(183, 23);
            this.tb_SoPM.TabIndex = 9;
            // 
            // dtp_NgayMuon
            // 
            this.dtp_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayMuon.Location = new System.Drawing.Point(105, 66);
            this.dtp_NgayMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_NgayMuon.Name = "dtp_NgayMuon";
            this.dtp_NgayMuon.Size = new System.Drawing.Size(183, 23);
            this.dtp_NgayMuon.TabIndex = 13;
            // 
            // Dm_NgayMuon
            // 
            this.Dm_NgayMuon.AutoSize = true;
            this.Dm_NgayMuon.Location = new System.Drawing.Point(15, 71);
            this.Dm_NgayMuon.Name = "Dm_NgayMuon";
            this.Dm_NgayMuon.Size = new System.Drawing.Size(72, 16);
            this.Dm_NgayMuon.TabIndex = 1;
            this.Dm_NgayMuon.Text = "Ngày mượn";
            // 
            // dtp_GioMuon
            // 
            this.dtp_GioMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_GioMuon.Location = new System.Drawing.Point(105, 111);
            this.dtp_GioMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_GioMuon.Name = "dtp_GioMuon";
            this.dtp_GioMuon.Size = new System.Drawing.Size(183, 23);
            this.dtp_GioMuon.TabIndex = 14;
            // 
            // DM_GioMuon
            // 
            this.DM_GioMuon.AutoSize = true;
            this.DM_GioMuon.Location = new System.Drawing.Point(15, 111);
            this.DM_GioMuon.Name = "DM_GioMuon";
            this.DM_GioMuon.Size = new System.Drawing.Size(62, 16);
            this.DM_GioMuon.TabIndex = 2;
            this.DM_GioMuon.Text = "Giờ mượn";
            // 
            // dgv_MuonDC
            // 
            this.dgv_MuonDC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_MuonDC.Location = new System.Drawing.Point(0, 384);
            this.dgv_MuonDC.MainView = this.gridView1;
            this.dgv_MuonDC.MenuManager = this.ribbonControl;
            this.dgv_MuonDC.Name = "dgv_MuonDC";
            this.dgv_MuonDC.Size = new System.Drawing.Size(922, 353);
            this.dgv_MuonDC.TabIndex = 30;
            this.dgv_MuonDC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SoPhieuMuon,
            this.NgayMuon,
            this.GioMuon,
            this.MaLop,
            this.MaGiaoVien});
            this.gridView1.GridControl = this.dgv_MuonDC;
            this.gridView1.Name = "gridView1";
            // 
            // SoPhieuMuon
            // 
            this.SoPhieuMuon.Caption = "Số Phiếu Mượn";
            this.SoPhieuMuon.FieldName = "SOPHIEUMUON";
            this.SoPhieuMuon.MinWidth = 25;
            this.SoPhieuMuon.Name = "SoPhieuMuon";
            this.SoPhieuMuon.Visible = true;
            this.SoPhieuMuon.VisibleIndex = 0;
            this.SoPhieuMuon.Width = 94;
            // 
            // NgayMuon
            // 
            this.NgayMuon.Caption = "Ngày Mượn";
            this.NgayMuon.FieldName = "NGAYMUON";
            this.NgayMuon.MinWidth = 25;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Visible = true;
            this.NgayMuon.VisibleIndex = 1;
            this.NgayMuon.Width = 94;
            // 
            // GioMuon
            // 
            this.GioMuon.Caption = "Giờ Mượn";
            this.GioMuon.FieldName = "GIOMUON";
            this.GioMuon.MinWidth = 25;
            this.GioMuon.Name = "GioMuon";
            this.GioMuon.Visible = true;
            this.GioMuon.VisibleIndex = 2;
            this.GioMuon.Width = 94;
            // 
            // MaLop
            // 
            this.MaLop.Caption = "Mã Lớp";
            this.MaLop.FieldName = "MALOP";
            this.MaLop.MinWidth = 25;
            this.MaLop.Name = "MaLop";
            this.MaLop.Visible = true;
            this.MaLop.VisibleIndex = 3;
            this.MaLop.Width = 94;
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.Caption = "Mã Giáo Viên";
            this.MaGiaoVien.FieldName = "MAGIAOVIEN";
            this.MaGiaoVien.MinWidth = 25;
            this.MaGiaoVien.Name = "MaGiaoVien";
            this.MaGiaoVien.Visible = true;
            this.MaGiaoVien.VisibleIndex = 4;
            this.MaGiaoVien.Width = 94;
            // 
            // MuonDungCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 737);
            this.Controls.Add(this.dgv_MuonDC);
            this.Controls.Add(this.Dm_MuonDC);
            this.Controls.Add(this.ribbonControl);
            this.Name = "MuonDungCu";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mượn dụng cụ";
            this.Load += new System.EventHandler(this.MuonDungCu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.Dm_MuonDC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MuonDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem btnAddMuon;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem btnDeleteMuon;
        private DevExpress.XtraBars.BarButtonItem btnRefreshMuon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.GroupBox Dm_MuonDC;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label MuonDC_SoPhieuMuon;
        private System.Windows.Forms.TextBox tb_SoPM;
        private System.Windows.Forms.DateTimePicker dtp_NgayMuon;
        private System.Windows.Forms.Label Dm_NgayMuon;
        private System.Windows.Forms.DateTimePicker dtp_GioMuon;
        private System.Windows.Forms.Label DM_GioMuon;
        private System.Windows.Forms.ComboBox cbb_MaLop;
        private System.Windows.Forms.ComboBox cbb_MaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DM_GiaTien;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl dgv_MuonDC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn SoPhieuMuon;
        private DevExpress.XtraGrid.Columns.GridColumn NgayMuon;
        private DevExpress.XtraGrid.Columns.GridColumn GioMuon;
        private DevExpress.XtraGrid.Columns.GridColumn MaLop;
        private DevExpress.XtraGrid.Columns.GridColumn MaGiaoVien;
    }
}