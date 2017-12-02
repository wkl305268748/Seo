using Seo.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seo
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XtraBaiduFlow baiduFlow = new XtraBaiduFlow();
        XtraBaiduUp baiduUp = new XtraBaiduUp();
        public Main()
        {
            InitializeComponent();
        }

        private void bar_baidu_flow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(baiduFlow);
        }

        private void bar_baidu_up_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(baiduUp);
        }

        private void bar_baidu_sort_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(baiduUp);

        }

        private void bar_system_web_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(baiduFlow);

        }

        private void bar_system_proxy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            panelControl.Controls.Clear();
            panelControl.Controls.Add(baiduUp);
        }
    }
}
