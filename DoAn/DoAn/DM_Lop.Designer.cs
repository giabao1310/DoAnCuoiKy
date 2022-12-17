namespace DoAn
{
    partial class DM_Lop
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
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.btnAddLop = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshLop = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dgv_Lop = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLopTruong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tb_TenLopTruong = new System.Windows.Forms.TextBox();
            this.tb_TenLop = new System.Windows.Forms.TextBox();
            this.tb_MaLop = new System.Windows.Forms.TextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 709);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(922, 28);
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
            this.btnAddLop,
            this.bbiEdit,
            this.btnDeleteLop,
            this.btnRefreshLop});
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
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // btnAddLop
            // 
            this.btnAddLop.Caption = "Add";
            this.btnAddLop.Id = 16;
            this.btnAddLop.ImageOptions.ImageUri.Uri = "New";
            this.btnAddLop.Name = "btnAddLop";
            this.btnAddLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddLop_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            // 
            // btnDeleteLop
            // 
            this.btnDeleteLop.Caption = "Delete";
            this.btnDeleteLop.Id = 18;
            this.btnDeleteLop.ImageOptions.ImageUri.Uri = "Delete";
            this.btnDeleteLop.Name = "btnDeleteLop";
            this.btnDeleteLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteLop_ItemClick);
            // 
            // btnRefreshLop
            // 
            this.btnRefreshLop.Caption = "Refresh";
            this.btnRefreshLop.Id = 19;
            this.btnRefreshLop.ImageOptions.ImageUri.Uri = "Refresh";
            this.btnRefreshLop.Name = "btnRefreshLop";
            this.btnRefreshLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshLop_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddLop);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDeleteLop);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefreshLop);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dgv_Lop);
            this.layoutControl1.Controls.Add(this.tb_TenLopTruong);
            this.layoutControl1.Controls.Add(this.tb_TenLop);
            this.layoutControl1.Controls.Add(this.tb_MaLop);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 193);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(922, 516);
            this.layoutControl1.TabIndex = 28;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dgv_Lop
            // 
            this.dgv_Lop.Location = new System.Drawing.Point(12, 99);
            this.dgv_Lop.MainView = this.gridView1;
            this.dgv_Lop.MenuManager = this.ribbonControl;
            this.dgv_Lop.Name = "dgv_Lop";
            this.dgv_Lop.Size = new System.Drawing.Size(898, 405);
            this.dgv_Lop.TabIndex = 7;
            this.dgv_Lop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaLop,
            this.TenLop,
            this.TenLopTruong});
            this.gridView1.GridControl = this.dgv_Lop;
            this.gridView1.Name = "gridView1";
            // 
            // MaLop
            // 
            this.MaLop.Caption = "Mã Lớp";
            this.MaLop.FieldName = "MALOP";
            this.MaLop.MinWidth = 25;
            this.MaLop.Name = "MaLop";
            this.MaLop.Visible = true;
            this.MaLop.VisibleIndex = 0;
            this.MaLop.Width = 94;
            // 
            // TenLop
            // 
            this.TenLop.Caption = "Tên Lớp";
            this.TenLop.FieldName = "TENLOP";
            this.TenLop.MinWidth = 25;
            this.TenLop.Name = "TenLop";
            this.TenLop.Visible = true;
            this.TenLop.VisibleIndex = 1;
            this.TenLop.Width = 94;
            // 
            // TenLopTruong
            // 
            this.TenLopTruong.Caption = "Tên Lớp Trưởng";
            this.TenLopTruong.FieldName = "TENLOPTRUONG";
            this.TenLopTruong.MinWidth = 25;
            this.TenLopTruong.Name = "TenLopTruong";
            this.TenLopTruong.Visible = true;
            this.TenLopTruong.VisibleIndex = 2;
            this.TenLopTruong.Width = 94;
            // 
            // tb_TenLopTruong
            // 
            this.tb_TenLopTruong.Location = new System.Drawing.Point(109, 70);
            this.tb_TenLopTruong.Name = "tb_TenLopTruong";
            this.tb_TenLopTruong.Size = new System.Drawing.Size(801, 25);
            this.tb_TenLopTruong.TabIndex = 6;
            // 
            // tb_TenLop
            // 
            this.tb_TenLop.Location = new System.Drawing.Point(109, 41);
            this.tb_TenLop.Name = "tb_TenLop";
            this.tb_TenLop.Size = new System.Drawing.Size(801, 25);
            this.tb_TenLop.TabIndex = 5;
            // 
            // tb_MaLop
            // 
            this.tb_MaLop.Location = new System.Drawing.Point(109, 12);
            this.tb_MaLop.Name = "tb_MaLop";
            this.tb_MaLop.Size = new System.Drawing.Size(801, 25);
            this.tb_MaLop.TabIndex = 4;
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
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tb_MaLop;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(902, 29);
            this.layoutControlItem1.Text = "Mã Lớp";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(85, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tb_TenLop;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(902, 29);
            this.layoutControlItem2.Text = "Tên Lớp";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(85, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tb_TenLopTruong;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(902, 29);
            this.layoutControlItem3.Text = "Tên lớp trưởng";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(85, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dgv_Lop;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 87);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(902, 409);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // DM_Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 737);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "DM_Lop";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Danh mục lớp";
            this.Load += new System.EventHandler(this.DM_Lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem btnAddLop;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem btnDeleteLop;
        private DevExpress.XtraBars.BarButtonItem btnRefreshLop;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.TextBox tb_TenLopTruong;
        private System.Windows.Forms.TextBox tb_TenLop;
        private System.Windows.Forms.TextBox tb_MaLop;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl dgv_Lop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn MaLop;
        private DevExpress.XtraGrid.Columns.GridColumn TenLop;
        private DevExpress.XtraGrid.Columns.GridColumn TenLopTruong;
    }
}