namespace DoAn
{
    partial class DM_DungCu
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
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnAddDC = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnDeleteDC = new DevExpress.XtraBars.BarButtonItem();
            this.BarBtnDC_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.rb_No = new System.Windows.Forms.RadioButton();
            this.rb_Yes = new System.Windows.Forms.RadioButton();
            this.dtp_NgayMua = new System.Windows.Forms.DateTimePicker();
            this.tb_MaDC = new System.Windows.Forms.TextBox();
            this.tb_TenDC = new System.Windows.Forms.TextBox();
            this.tb_GiaTien = new System.Windows.Forms.TextBox();
            this.dgv_DungCu = new System.Windows.Forms.DataGridView();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DungCu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 709);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(922, 28);
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
            this.BarBtnAddDC,
            this.bbiEdit,
            this.BarBtnDeleteDC,
            this.BarBtnDC_Refresh});
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
            // BarBtnAddDC
            // 
            this.BarBtnAddDC.Caption = "Add";
            this.BarBtnAddDC.Id = 16;
            this.BarBtnAddDC.ImageOptions.ImageUri.Uri = "New";
            this.BarBtnAddDC.Name = "BarBtnAddDC";
            this.BarBtnAddDC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnAddDC_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            // 
            // BarBtnDeleteDC
            // 
            this.BarBtnDeleteDC.Caption = "Delete";
            this.BarBtnDeleteDC.Id = 18;
            this.BarBtnDeleteDC.ImageOptions.ImageUri.Uri = "Delete";
            this.BarBtnDeleteDC.Name = "BarBtnDeleteDC";
            this.BarBtnDeleteDC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnDeleteDC_ItemClick);
            // 
            // BarBtnDC_Refresh
            // 
            this.BarBtnDC_Refresh.Caption = "Refresh";
            this.BarBtnDC_Refresh.Id = 19;
            this.BarBtnDC_Refresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.BarBtnDC_Refresh.Name = "BarBtnDC_Refresh";
            this.BarBtnDC_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarBtnDC_Refresh_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.BarBtnAddDC);
            this.ribbonPageGroup1.ItemLinks.Add(this.BarBtnDeleteDC);
            this.ribbonPageGroup1.ItemLinks.Add(this.BarBtnDC_Refresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.rb_No);
            this.layoutControl1.Controls.Add(this.rb_Yes);
            this.layoutControl1.Controls.Add(this.dgv_DungCu);
            this.layoutControl1.Controls.Add(this.tb_GiaTien);
            this.layoutControl1.Controls.Add(this.dtp_NgayMua);
            this.layoutControl1.Controls.Add(this.tb_TenDC);
            this.layoutControl1.Controls.Add(this.tb_MaDC);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 193);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1033, 406, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(922, 516);
            this.layoutControl1.TabIndex = 16;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem9,
            this.layoutControlItem2,
            this.layoutControlItem8,
            this.simpleLabelItem1,
            this.layoutControlItem5,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(922, 516);
            this.Root.TextVisible = false;
            // 
            // rb_No
            // 
            this.rb_No.Location = new System.Drawing.Point(463, 99);
            this.rb_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_No.Name = "rb_No";
            this.rb_No.Size = new System.Drawing.Size(447, 31);
            this.rb_No.TabIndex = 12;
            this.rb_No.TabStop = true;
            this.rb_No.Text = "Không";
            this.rb_No.UseVisualStyleBackColor = true;
            // 
            // rb_Yes
            // 
            this.rb_Yes.Checked = true;
            this.rb_Yes.Location = new System.Drawing.Point(157, 99);
            this.rb_Yes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Yes.Name = "rb_Yes";
            this.rb_Yes.Size = new System.Drawing.Size(302, 31);
            this.rb_Yes.TabIndex = 11;
            this.rb_Yes.TabStop = true;
            this.rb_Yes.Text = "Được";
            this.rb_Yes.UseVisualStyleBackColor = true;
            // 
            // dtp_NgayMua
            // 
            this.dtp_NgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayMua.Location = new System.Drawing.Point(133, 41);
            this.dtp_NgayMua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_NgayMua.Name = "dtp_NgayMua";
            this.dtp_NgayMua.Size = new System.Drawing.Size(777, 23);
            this.dtp_NgayMua.TabIndex = 10;
            // 
            // tb_MaDC
            // 
            this.tb_MaDC.Location = new System.Drawing.Point(133, 12);
            this.tb_MaDC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_MaDC.Name = "tb_MaDC";
            this.tb_MaDC.Size = new System.Drawing.Size(326, 25);
            this.tb_MaDC.TabIndex = 9;
            // 
            // tb_TenDC
            // 
            this.tb_TenDC.Location = new System.Drawing.Point(584, 12);
            this.tb_TenDC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TenDC.Name = "tb_TenDC";
            this.tb_TenDC.Size = new System.Drawing.Size(326, 25);
            this.tb_TenDC.TabIndex = 8;
            // 
            // tb_GiaTien
            // 
            this.tb_GiaTien.Location = new System.Drawing.Point(133, 70);
            this.tb_GiaTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_GiaTien.Name = "tb_GiaTien";
            this.tb_GiaTien.Size = new System.Drawing.Size(777, 25);
            this.tb_GiaTien.TabIndex = 6;
            this.tb_GiaTien.Text = "0";
            // 
            // dgv_DungCu
            // 
            this.dgv_DungCu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DungCu.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.dgv_DungCu.Location = new System.Drawing.Point(12, 134);
            this.dgv_DungCu.Name = "dgv_DungCu";
            this.dgv_DungCu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_DungCu.RowTemplate.Height = 24;
            this.dgv_DungCu.Size = new System.Drawing.Size(898, 370);
            this.dgv_DungCu.TabIndex = 14;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dgv_DungCu;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 122);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(902, 374);
            this.layoutControlItem2.Text = " ";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tb_MaDC;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(451, 29);
            this.layoutControlItem3.Text = "Mã dụng cụ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(109, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tb_TenDC;
            this.layoutControlItem4.Location = new System.Drawing.Point(451, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(451, 29);
            this.layoutControlItem4.Text = "Tên dụng cụ";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(109, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dtp_NgayMua;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(902, 29);
            this.layoutControlItem5.Text = "Ngày mua";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(109, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.tb_GiaTien;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(902, 29);
            this.layoutControlItem6.Text = "Giá tiền";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(109, 16);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.rb_Yes;
            this.layoutControlItem8.Location = new System.Drawing.Point(145, 87);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(306, 35);
            this.layoutControlItem8.Text = "Được";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.rb_No;
            this.layoutControlItem9.Location = new System.Drawing.Point(451, 87);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(451, 35);
            this.layoutControlItem9.Text = "Không";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 87);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(145, 35);
            this.simpleLabelItem1.Text = "Tình trạng sử dụng";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(109, 16);
            // 
            // DM_DungCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 737);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "DM_DungCu";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Danh mục dụng cụ";
            this.Load += new System.EventHandler(this.DM_DungCu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DungCu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarButtonItem BarBtnAddDC;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem BarBtnDeleteDC;
        private DevExpress.XtraBars.BarButtonItem BarBtnDC_Refresh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.RadioButton rb_No;
        private System.Windows.Forms.RadioButton rb_Yes;
        private System.Windows.Forms.DataGridView dgv_DungCu;
        private System.Windows.Forms.TextBox tb_GiaTien;
        private System.Windows.Forms.DateTimePicker dtp_NgayMua;
        private System.Windows.Forms.TextBox tb_TenDC;
        private System.Windows.Forms.TextBox tb_MaDC;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
    }
}