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
            this.dgv_Lop = new System.Windows.Forms.DataGridView();
            this.Dm_ThongTinLop = new System.Windows.Forms.GroupBox();
            this.tb_MaLop = new System.Windows.Forms.TextBox();
            this.tb_TenLop = new System.Windows.Forms.TextBox();
            this.tb_TenLopTruong = new System.Windows.Forms.TextBox();
            this.DM_TenLopTruong = new System.Windows.Forms.Label();
            this.Dm_TenLop = new System.Windows.Forms.Label();
            this.DM_MaLop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lop)).BeginInit();
            this.Dm_ThongTinLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 707);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(922, 30);
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
            // dgv_Lop
            // 
            this.dgv_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lop.Location = new System.Drawing.Point(0, 401);
            this.dgv_Lop.Name = "dgv_Lop";
            this.dgv_Lop.RowHeadersWidth = 51;
            this.dgv_Lop.RowTemplate.Height = 24;
            this.dgv_Lop.Size = new System.Drawing.Size(922, 299);
            this.dgv_Lop.TabIndex = 20;
            this.dgv_Lop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Lop_CellClick);
            // 
            // Dm_ThongTinLop
            // 
            this.Dm_ThongTinLop.Controls.Add(this.tb_MaLop);
            this.Dm_ThongTinLop.Controls.Add(this.tb_TenLop);
            this.Dm_ThongTinLop.Controls.Add(this.tb_TenLopTruong);
            this.Dm_ThongTinLop.Controls.Add(this.DM_TenLopTruong);
            this.Dm_ThongTinLop.Controls.Add(this.Dm_TenLop);
            this.Dm_ThongTinLop.Controls.Add(this.DM_MaLop);
            this.Dm_ThongTinLop.Location = new System.Drawing.Point(94, 199);
            this.Dm_ThongTinLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dm_ThongTinLop.Name = "Dm_ThongTinLop";
            this.Dm_ThongTinLop.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dm_ThongTinLop.Size = new System.Drawing.Size(729, 151);
            this.Dm_ThongTinLop.TabIndex = 25;
            this.Dm_ThongTinLop.TabStop = false;
            this.Dm_ThongTinLop.Text = "Thông tin lớp";
            // 
            // tb_MaLop
            // 
            this.tb_MaLop.Location = new System.Drawing.Point(82, 57);
            this.tb_MaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_MaLop.Name = "tb_MaLop";
            this.tb_MaLop.Size = new System.Drawing.Size(207, 23);
            this.tb_MaLop.TabIndex = 9;
            // 
            // tb_TenLop
            // 
            this.tb_TenLop.Location = new System.Drawing.Point(82, 105);
            this.tb_TenLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TenLop.Name = "tb_TenLop";
            this.tb_TenLop.Size = new System.Drawing.Size(207, 23);
            this.tb_TenLop.TabIndex = 8;
            // 
            // tb_TenLopTruong
            // 
            this.tb_TenLopTruong.Location = new System.Drawing.Point(502, 57);
            this.tb_TenLopTruong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TenLopTruong.Name = "tb_TenLopTruong";
            this.tb_TenLopTruong.Size = new System.Drawing.Size(207, 23);
            this.tb_TenLopTruong.TabIndex = 6;
            // 
            // DM_TenLopTruong
            // 
            this.DM_TenLopTruong.AutoSize = true;
            this.DM_TenLopTruong.Location = new System.Drawing.Point(385, 60);
            this.DM_TenLopTruong.Name = "DM_TenLopTruong";
            this.DM_TenLopTruong.Size = new System.Drawing.Size(92, 16);
            this.DM_TenLopTruong.TabIndex = 3;
            this.DM_TenLopTruong.Text = "Tên lớp trưởng";
            // 
            // Dm_TenLop
            // 
            this.Dm_TenLop.AutoSize = true;
            this.Dm_TenLop.Location = new System.Drawing.Point(5, 105);
            this.Dm_TenLop.Name = "Dm_TenLop";
            this.Dm_TenLop.Size = new System.Drawing.Size(50, 16);
            this.Dm_TenLop.TabIndex = 1;
            this.Dm_TenLop.Text = "Tên lớp";
            // 
            // DM_MaLop
            // 
            this.DM_MaLop.AutoSize = true;
            this.DM_MaLop.Location = new System.Drawing.Point(5, 57);
            this.DM_MaLop.Name = "DM_MaLop";
            this.DM_MaLop.Size = new System.Drawing.Size(45, 16);
            this.DM_MaLop.TabIndex = 0;
            this.DM_MaLop.Text = "Mã lớp";
            // 
            // DM_Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 737);
            this.Controls.Add(this.Dm_ThongTinLop);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.dgv_Lop);
            this.Controls.Add(this.ribbonControl);
            this.Name = "DM_Lop";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Danh mục lớp";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lop)).EndInit();
            this.Dm_ThongTinLop.ResumeLayout(false);
            this.Dm_ThongTinLop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.DataGridView dgv_Lop;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem btnAddLop;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem btnDeleteLop;
        private DevExpress.XtraBars.BarButtonItem btnRefreshLop;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.GroupBox Dm_ThongTinLop;
        private System.Windows.Forms.TextBox tb_MaLop;
        private System.Windows.Forms.TextBox tb_TenLop;
        private System.Windows.Forms.TextBox tb_TenLopTruong;
        private System.Windows.Forms.Label DM_TenLopTruong;
        private System.Windows.Forms.Label Dm_TenLop;
        private System.Windows.Forms.Label DM_MaLop;
    }
}