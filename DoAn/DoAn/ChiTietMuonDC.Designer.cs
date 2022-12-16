namespace DoAn
{
    partial class ChiTietMuonDC
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
            this.ThongTinCTMuon = new System.Windows.Forms.GroupBox();
            this.dtp_GioTra = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.cbb_MaDungCu = new System.Windows.Forms.ComboBox();
            this.cbb_SoPhieuMuon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CtMuon_NgayTra = new System.Windows.Forms.Label();
            this.CtMuon_MaDC = new System.Windows.Forms.Label();
            this.CtMuon_SoPhieuMuon = new System.Windows.Forms.Label();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.dgv_CtMuon = new System.Windows.Forms.DataGridView();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.btnAddCtMuon = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteCtMuon = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshCtMuon = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ThongTinCTMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CtMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ThongTinCTMuon
            // 
            this.ThongTinCTMuon.Controls.Add(this.dtp_GioTra);
            this.ThongTinCTMuon.Controls.Add(this.dtp_NgayTra);
            this.ThongTinCTMuon.Controls.Add(this.cbb_MaDungCu);
            this.ThongTinCTMuon.Controls.Add(this.cbb_SoPhieuMuon);
            this.ThongTinCTMuon.Controls.Add(this.label1);
            this.ThongTinCTMuon.Controls.Add(this.CtMuon_NgayTra);
            this.ThongTinCTMuon.Controls.Add(this.CtMuon_MaDC);
            this.ThongTinCTMuon.Controls.Add(this.CtMuon_SoPhieuMuon);
            this.ThongTinCTMuon.Location = new System.Drawing.Point(82, 213);
            this.ThongTinCTMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThongTinCTMuon.Name = "ThongTinCTMuon";
            this.ThongTinCTMuon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThongTinCTMuon.Size = new System.Drawing.Size(739, 160);
            this.ThongTinCTMuon.TabIndex = 12;
            this.ThongTinCTMuon.TabStop = false;
            this.ThongTinCTMuon.Text = "Chi tiết mượn";
            // 
            // dtp_GioTra
            // 
            this.dtp_GioTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_GioTra.Location = new System.Drawing.Point(531, 98);
            this.dtp_GioTra.Name = "dtp_GioTra";
            this.dtp_GioTra.Size = new System.Drawing.Size(195, 23);
            this.dtp_GioTra.TabIndex = 13;
            // 
            // dtp_NgayTra
            // 
            this.dtp_NgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayTra.Location = new System.Drawing.Point(531, 55);
            this.dtp_NgayTra.Name = "dtp_NgayTra";
            this.dtp_NgayTra.Size = new System.Drawing.Size(195, 23);
            this.dtp_NgayTra.TabIndex = 12;
            // 
            // cbb_MaDungCu
            // 
            this.cbb_MaDungCu.FormattingEnabled = true;
            this.cbb_MaDungCu.Location = new System.Drawing.Point(121, 102);
            this.cbb_MaDungCu.Name = "cbb_MaDungCu";
            this.cbb_MaDungCu.Size = new System.Drawing.Size(195, 24);
            this.cbb_MaDungCu.TabIndex = 11;
            // 
            // cbb_SoPhieuMuon
            // 
            this.cbb_SoPhieuMuon.FormattingEnabled = true;
            this.cbb_SoPhieuMuon.Location = new System.Drawing.Point(121, 54);
            this.cbb_SoPhieuMuon.Name = "cbb_SoPhieuMuon";
            this.cbb_SoPhieuMuon.Size = new System.Drawing.Size(195, 24);
            this.cbb_SoPhieuMuon.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giờ trả";
            // 
            // CtMuon_NgayTra
            // 
            this.CtMuon_NgayTra.AutoSize = true;
            this.CtMuon_NgayTra.Location = new System.Drawing.Point(447, 57);
            this.CtMuon_NgayTra.Name = "CtMuon_NgayTra";
            this.CtMuon_NgayTra.Size = new System.Drawing.Size(55, 16);
            this.CtMuon_NgayTra.TabIndex = 3;
            this.CtMuon_NgayTra.Text = "Ngày trả";
            // 
            // CtMuon_MaDC
            // 
            this.CtMuon_MaDC.AutoSize = true;
            this.CtMuon_MaDC.Location = new System.Drawing.Point(4, 105);
            this.CtMuon_MaDC.Name = "CtMuon_MaDC";
            this.CtMuon_MaDC.Size = new System.Drawing.Size(73, 16);
            this.CtMuon_MaDC.TabIndex = 1;
            this.CtMuon_MaDC.Text = "Mã dụng cụ";
            // 
            // CtMuon_SoPhieuMuon
            // 
            this.CtMuon_SoPhieuMuon.AutoSize = true;
            this.CtMuon_SoPhieuMuon.Location = new System.Drawing.Point(4, 57);
            this.CtMuon_SoPhieuMuon.Name = "CtMuon_SoPhieuMuon";
            this.CtMuon_SoPhieuMuon.Size = new System.Drawing.Size(94, 16);
            this.CtMuon_SoPhieuMuon.TabIndex = 0;
            this.CtMuon_SoPhieuMuon.Text = "Số phiếu mượn";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 717);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Size = new System.Drawing.Size(922, 20);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // dgv_CtMuon
            // 
            this.dgv_CtMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CtMuon.Location = new System.Drawing.Point(0, 402);
            this.dgv_CtMuon.Name = "dgv_CtMuon";
            this.dgv_CtMuon.RowHeadersWidth = 51;
            this.dgv_CtMuon.RowTemplate.Height = 24;
            this.dgv_CtMuon.Size = new System.Drawing.Size(922, 299);
            this.dgv_CtMuon.TabIndex = 21;
            this.dgv_CtMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CtMuon_CellClick);
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
            this.btnAddCtMuon,
            this.bbiEdit,
            this.btnDeleteCtMuon,
            this.btnRefreshCtMuon});
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
            // btnAddCtMuon
            // 
            this.btnAddCtMuon.Caption = "Add";
            this.btnAddCtMuon.Id = 16;
            this.btnAddCtMuon.ImageOptions.ImageUri.Uri = "New";
            this.btnAddCtMuon.Name = "btnAddCtMuon";
            this.btnAddCtMuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddCtMuon_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            // 
            // btnDeleteCtMuon
            // 
            this.btnDeleteCtMuon.Caption = "Delete";
            this.btnDeleteCtMuon.Id = 18;
            this.btnDeleteCtMuon.ImageOptions.ImageUri.Uri = "Delete";
            this.btnDeleteCtMuon.Name = "btnDeleteCtMuon";
            this.btnDeleteCtMuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteCtMuon_ItemClick);
            // 
            // btnRefreshCtMuon
            // 
            this.btnRefreshCtMuon.Caption = "Refresh";
            this.btnRefreshCtMuon.Id = 19;
            this.btnRefreshCtMuon.ImageOptions.ImageUri.Uri = "Refresh";
            this.btnRefreshCtMuon.Name = "btnRefreshCtMuon";
            this.btnRefreshCtMuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshCtMuon_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddCtMuon);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDeleteCtMuon);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefreshCtMuon);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ChiTietMuonDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 737);
            this.Controls.Add(this.dgv_CtMuon);
            this.Controls.Add(this.ThongTinCTMuon);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "ChiTietMuonDC";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Thông tin chi tiết các dụng cụ được mượn";
            this.Load += new System.EventHandler(this.ChiTietMuonDC_Load);
            this.ThongTinCTMuon.ResumeLayout(false);
            this.ThongTinCTMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CtMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox ThongTinCTMuon;
        private System.Windows.Forms.Label CtMuon_NgayTra;
        private System.Windows.Forms.Label CtMuon_MaDC;
        private System.Windows.Forms.Label CtMuon_SoPhieuMuon;
        private System.Windows.Forms.DateTimePicker dtp_GioTra;
        private System.Windows.Forms.DateTimePicker dtp_NgayTra;
        private System.Windows.Forms.ComboBox cbb_MaDungCu;
        private System.Windows.Forms.ComboBox cbb_SoPhieuMuon;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private System.Windows.Forms.DataGridView dgv_CtMuon;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem btnAddCtMuon;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem btnDeleteCtMuon;
        private DevExpress.XtraBars.BarButtonItem btnRefreshCtMuon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}