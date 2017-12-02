namespace Seo
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bar_system_web = new DevExpress.XtraBars.BarButtonItem();
            this.bar_baidu_flow = new DevExpress.XtraBars.BarButtonItem();
            this.bar_baidu_up = new DevExpress.XtraBars.BarButtonItem();
            this.bar_system_proxy = new DevExpress.XtraBars.BarButtonItem();
            this.bar_baidu_sort = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bar_system_web,
            this.bar_baidu_flow,
            this.bar_baidu_up,
            this.bar_system_proxy,
            this.bar_baidu_sort});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(923, 149);
            // 
            // bar_system_web
            // 
            this.bar_system_web.Caption = "多浏览器配置";
            this.bar_system_web.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_system_web.Glyph")));
            this.bar_system_web.Id = 1;
            this.bar_system_web.Name = "bar_system_web";
            this.bar_system_web.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bar_system_web.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_system_web_ItemClick);
            // 
            // bar_baidu_flow
            // 
            this.bar_baidu_flow.Caption = "刷流量";
            this.bar_baidu_flow.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_baidu_flow.Glyph")));
            this.bar_baidu_flow.Id = 2;
            this.bar_baidu_flow.Name = "bar_baidu_flow";
            this.bar_baidu_flow.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bar_baidu_flow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_baidu_flow_ItemClick);
            // 
            // bar_baidu_up
            // 
            this.bar_baidu_up.Caption = "刷下拉框";
            this.bar_baidu_up.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_baidu_up.Glyph")));
            this.bar_baidu_up.Id = 3;
            this.bar_baidu_up.Name = "bar_baidu_up";
            this.bar_baidu_up.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bar_baidu_up.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_baidu_up_ItemClick);
            // 
            // bar_system_proxy
            // 
            this.bar_system_proxy.Caption = "代理配置";
            this.bar_system_proxy.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_system_proxy.Glyph")));
            this.bar_system_proxy.Id = 1;
            this.bar_system_proxy.Name = "bar_system_proxy";
            this.bar_system_proxy.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bar_system_proxy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_system_proxy_ItemClick);
            // 
            // bar_baidu_sort
            // 
            this.bar_baidu_sort.Caption = "刷排名";
            this.bar_baidu_sort.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_baidu_sort.Glyph")));
            this.bar_baidu_sort.Id = 2;
            this.bar_baidu_sort.Name = "bar_baidu_sort";
            this.bar_baidu_sort.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bar_baidu_sort.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_baidu_sort_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "开始SEO";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bar_baidu_flow);
            this.ribbonPageGroup1.ItemLinks.Add(this.bar_baidu_up);
            this.ribbonPageGroup1.ItemLinks.Add(this.bar_baidu_sort);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "百度";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "系统设置";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bar_system_web);
            this.ribbonPageGroup2.ItemLinks.Add(this.bar_system_proxy);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "发包设置";
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 149);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(923, 554);
            this.panelControl.TabIndex = 1;
            // 
            // Main
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 703);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Main";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bar_system_web;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bar_baidu_flow;
        private DevExpress.XtraBars.BarButtonItem bar_baidu_up;
        private DevExpress.XtraBars.BarButtonItem bar_system_proxy;
        private DevExpress.XtraBars.BarButtonItem bar_baidu_sort;
        private DevExpress.XtraEditors.PanelControl panelControl;
    }
}

