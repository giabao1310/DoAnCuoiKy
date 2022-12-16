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
            this.dgv_GiaoVien = new System.Windows.Forms.DataGridView();
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
            this.Dm_TenGV = new System.Windows.Forms.GroupBox();
            this.tb_MaGV = new System.Windows.Forms.TextBox();
            this.tb_TenGV = new System.Windows.Forms.TextBox();
            this.tb_ThuocBM = new System.Windows.Forms.TextBox();
            this.DM_ThuocBoMon = new System.Windows.Forms.Label();
            this.Dm_TenGiaoVien = new System.Windows.Forms.Label();
            this.DM_MaGiaoVien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.Dm_TenGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_GiaoVien
            // 
            this.dgv_GiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GiaoVien.Location = new System.Drawing.Point(0, 398);
            this.dgv_GiaoVien.Name = "dgv_GiaoVien";
            this.dgv_GiaoVien.RowHeadersWidth = 51;
            this.dgv_GiaoVien.RowTemplate.Height = 24;
            this.dgv_GiaoVien.Size = new System.Drawing.Size(922, 299);
            this.dgv_GiaoVien.TabIndex = 12;
            this.dgv_GiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GiaoVien_CellClick);
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 707);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(922, 30);
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
            // Dm_TenGV
            // 
            this.Dm_TenGV.Controls.Add(this.tb_MaGV);
            this.Dm_TenGV.Controls.Add(this.tb_TenGV);
            this.Dm_TenGV.Controls.Add(this.tb_ThuocBM);
            this.Dm_TenGV.Controls.Add(this.DM_ThuocBoMon);
            this.Dm_TenGV.Controls.Add(this.Dm_TenGiaoVien);
            this.Dm_TenGV.Controls.Add(this.DM_MaGiaoVien);
            this.Dm_TenGV.Location = new System.Drawing.Point(56, 215);
            this.Dm_TenGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dm_TenGV.Name = "Dm_TenGV";
            this.Dm_TenGV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dm_TenGV.Size = new System.Drawing.Size(773, 150);
            this.Dm_TenGV.TabIndex = 17;
            this.Dm_TenGV.TabStop = false;
            this.Dm_TenGV.Text = "Thông tin giáo viên";
            // 
            // tb_MaGV
            // 
            this.tb_MaGV.Location = new System.Drawing.Point(105, 57);
            this.tb_MaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_MaGV.Name = "tb_MaGV";
            this.tb_MaGV.Size = new System.Drawing.Size(207, 23);
            this.tb_MaGV.TabIndex = 9;
            // 
            // tb_TenGV
            // 
            this.tb_TenGV.Location = new System.Drawing.Point(105, 105);
            this.tb_TenGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TenGV.Name = "tb_TenGV";
            this.tb_TenGV.Size = new System.Drawing.Size(207, 23);
            this.tb_TenGV.TabIndex = 8;
            // 
            // tb_ThuocBM
            // 
            this.tb_ThuocBM.Location = new System.Drawing.Point(538, 57);
            this.tb_ThuocBM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ThuocBM.Name = "tb_ThuocBM";
            this.tb_ThuocBM.Size = new System.Drawing.Size(207, 23);
            this.tb_ThuocBM.TabIndex = 6;
            // 
            // DM_ThuocBoMon
            // 
            this.DM_ThuocBoMon.AutoSize = true;
            this.DM_ThuocBoMon.Location = new System.Drawing.Point(421, 60);
            this.DM_ThuocBoMon.Name = "DM_ThuocBoMon";
            this.DM_ThuocBoMon.Size = new System.Drawing.Size(89, 16);
            this.DM_ThuocBoMon.TabIndex = 3;
            this.DM_ThuocBoMon.Text = "Thuộc bộ môn";
            // 
            // Dm_TenGiaoVien
            // 
            this.Dm_TenGiaoVien.AutoSize = true;
            this.Dm_TenGiaoVien.Location = new System.Drawing.Point(5, 105);
            this.Dm_TenGiaoVien.Name = "Dm_TenGiaoVien";
            this.Dm_TenGiaoVien.Size = new System.Drawing.Size(84, 16);
            this.Dm_TenGiaoVien.TabIndex = 1;
            this.Dm_TenGiaoVien.Text = "Tên giáo viên";
            // 
            // DM_MaGiaoVien
            // 
            this.DM_MaGiaoVien.AutoSize = true;
            this.DM_MaGiaoVien.Location = new System.Drawing.Point(5, 57);
            this.DM_MaGiaoVien.Name = "DM_MaGiaoVien";
            this.DM_MaGiaoVien.Size = new System.Drawing.Size(79, 16);
            this.DM_MaGiaoVien.TabIndex = 0;
            this.DM_MaGiaoVien.Text = "Mã giáo viên";
            // 
            // DM_GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 737);
            this.Controls.Add(this.Dm_TenGV);
            this.Controls.Add(this.dgv_GiaoVien);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "DM_GiaoVien";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Danh mục giáo viên";
            this.Load += new System.EventHandler(this.DM_GiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.Dm_TenGV.ResumeLayout(false);
            this.Dm_TenGV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_GiaoVien;
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
        private System.Windows.Forms.GroupBox Dm_TenGV;
        private System.Windows.Forms.TextBox tb_MaGV;
        private System.Windows.Forms.TextBox tb_TenGV;
        private System.Windows.Forms.TextBox tb_ThuocBM;
        private System.Windows.Forms.Label DM_ThuocBoMon;
        private System.Windows.Forms.Label Dm_TenGiaoVien;
        private System.Windows.Forms.Label DM_MaGiaoVien;
    }
}