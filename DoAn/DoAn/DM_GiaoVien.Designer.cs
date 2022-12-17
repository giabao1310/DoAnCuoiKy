namespace DoAn
{
    partial class DM_GiaoVien
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
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddGV = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteGV = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshGV = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.MaGiaoVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenGiaoVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThuocBoMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tb_MaGV = new System.Windows.Forms.TextBox();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tb_TenGV = new System.Windows.Forms.TextBox();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tb_ThuocBM = new System.Windows.Forms.TextBox();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgv_GiaoVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.MaGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThuocBM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 709);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(922, 28);
            this.ribbonStatusBar1.Click += new System.EventHandler(this.ribbonStatusBar1_Click);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
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
            this.btnAddGV,
            this.bbiEdit,
            this.btnDeleteGV,
            this.btnRefreshGV});
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
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            // 
            // btnAddGV
            // 
            this.btnAddGV.Caption = "Add";
            this.btnAddGV.Id = 16;
            this.btnAddGV.ImageOptions.ImageUri.Uri = "New";
            this.btnAddGV.Name = "btnAddGV";
            this.btnAddGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddGV_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            // 
            // btnDeleteGV
            // 
            this.btnDeleteGV.Caption = "Delete";
            this.btnDeleteGV.Id = 18;
            this.btnDeleteGV.ImageOptions.ImageUri.Uri = "Delete";
            this.btnDeleteGV.Name = "btnDeleteGV";
            this.btnDeleteGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteGV_ItemClick);
            // 
            // btnRefreshGV
            // 
            this.btnRefreshGV.Caption = "Refresh";
            this.btnRefreshGV.Id = 19;
            this.btnRefreshGV.ImageOptions.ImageUri.Uri = "Refresh";
            this.btnRefreshGV.Name = "btnRefreshGV";
            this.btnRefreshGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshGV_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddGV);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDeleteGV);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefreshGV);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.Caption = "Mã Giáo Viên";
            this.MaGiaoVien.FieldName = "MAGIAOVIEN";
            this.MaGiaoVien.MinWidth = 25;
            this.MaGiaoVien.Name = "MaGiaoVien";
            this.MaGiaoVien.Visible = true;
            this.MaGiaoVien.VisibleIndex = 0;
            this.MaGiaoVien.Width = 94;
            // 
            // TenGiaoVien
            // 
            this.TenGiaoVien.Caption = "Tên Giáo Viên";
            this.TenGiaoVien.FieldName = "TENGIAOVIEN";
            this.TenGiaoVien.MinWidth = 25;
            this.TenGiaoVien.Name = "TenGiaoVien";
            this.TenGiaoVien.Visible = true;
            this.TenGiaoVien.VisibleIndex = 1;
            this.TenGiaoVien.Width = 94;
            // 
            // ThuocBoMon
            // 
            this.ThuocBoMon.Caption = "Thuộc Bộ Môn";
            this.ThuocBoMon.FieldName = "THUOCBOMON";
            this.ThuocBoMon.MinWidth = 25;
            this.ThuocBoMon.Name = "ThuocBoMon";
            this.ThuocBoMon.Visible = true;
            this.ThuocBoMon.VisibleIndex = 2;
            this.ThuocBoMon.Width = 94;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dgv_GiaoVien);
            this.layoutControl1.Controls.Add(this.tb_ThuocBM);
            this.layoutControl1.Controls.Add(this.tb_TenGV);
            this.layoutControl1.Controls.Add(this.tb_MaGV);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 193);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(922, 516);
            this.layoutControl1.TabIndex = 23;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(922, 516);
            this.Root.TextVisible = false;
            // 
            // tb_MaGV
            // 
            this.tb_MaGV.Location = new System.Drawing.Point(106, 12);
            this.tb_MaGV.Name = "tb_MaGV";
            this.tb_MaGV.Size = new System.Drawing.Size(804, 25);
            this.tb_MaGV.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tb_MaGV;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(902, 29);
            this.layoutControlItem1.Text = "Mã giáo viên";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(82, 16);
            // 
            // tb_TenGV
            // 
            this.tb_TenGV.Location = new System.Drawing.Point(106, 41);
            this.tb_TenGV.Name = "tb_TenGV";
            this.tb_TenGV.Size = new System.Drawing.Size(804, 25);
            this.tb_TenGV.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tb_TenGV;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(902, 29);
            this.layoutControlItem2.Text = "Tên giáo viên";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(82, 16);
            // 
            // tb_ThuocBM
            // 
            this.tb_ThuocBM.Location = new System.Drawing.Point(106, 70);
            this.tb_ThuocBM.Name = "tb_ThuocBM";
            this.tb_ThuocBM.Size = new System.Drawing.Size(804, 25);
            this.tb_ThuocBM.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tb_ThuocBM;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(902, 29);
            this.layoutControlItem3.Text = "Thuộc bộ môn";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(82, 16);
            // 
            // dgv_GiaoVien
            // 
            this.dgv_GiaoVien.Location = new System.Drawing.Point(12, 99);
            this.dgv_GiaoVien.MainView = this.gridView1;
            this.dgv_GiaoVien.MenuManager = this.ribbonControl;
            this.dgv_GiaoVien.Name = "dgv_GiaoVien";
            this.dgv_GiaoVien.Size = new System.Drawing.Size(898, 405);
            this.dgv_GiaoVien.TabIndex = 7;
            this.dgv_GiaoVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaGV,
            this.TenGV,
            this.ThuocBM});
            this.gridView1.GridControl = this.dgv_GiaoVien;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dgv_GiaoVien;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 87);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(902, 409);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // MaGV
            // 
            this.MaGV.Caption = "Mã Giáo Viên";
            this.MaGV.FieldName = "MAGIAOVIEN";
            this.MaGV.MinWidth = 25;
            this.MaGV.Name = "MaGV";
            this.MaGV.Visible = true;
            this.MaGV.VisibleIndex = 0;
            this.MaGV.Width = 94;
            // 
            // TenGV
            // 
            this.TenGV.Caption = "Tên Giáo Viên";
            this.TenGV.FieldName = "TENGIAOVIEN";
            this.TenGV.MinWidth = 25;
            this.TenGV.Name = "TenGV";
            this.TenGV.Visible = true;
            this.TenGV.VisibleIndex = 1;
            this.TenGV.Width = 94;
            // 
            // ThuocBM
            // 
            this.ThuocBM.Caption = "Thuộc Bộ Môn";
            this.ThuocBM.FieldName = "THUOCBOMON";
            this.ThuocBM.MinWidth = 25;
            this.ThuocBM.Name = "ThuocBM";
            this.ThuocBM.Visible = true;
            this.ThuocBM.VisibleIndex = 2;
            this.ThuocBM.Width = 94;
            // 
            // DM_GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 737);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "DM_GiaoVien";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Danh mục giáo viên";
            this.Load += new System.EventHandler(this.DM_GiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarButtonItem btnAddGV;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem btnDeleteGV;
        private DevExpress.XtraBars.BarButtonItem btnRefreshGV;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn MaGiaoVien;
        private DevExpress.XtraGrid.Columns.GridColumn TenGiaoVien;
        private DevExpress.XtraGrid.Columns.GridColumn ThuocBoMon;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.TextBox tb_ThuocBM;
        private System.Windows.Forms.TextBox tb_TenGV;
        private System.Windows.Forms.TextBox tb_MaGV;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl dgv_GiaoVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaGV;
        private DevExpress.XtraGrid.Columns.GridColumn TenGV;
        private DevExpress.XtraGrid.Columns.GridColumn ThuocBM;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}