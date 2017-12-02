﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraScheduler;


namespace DXApplication1 {
    public partial class Form1 : RibbonForm {
        public Form1() {
            InitializeComponent();
            InitSkinGallery();
schedulerControl.Start = System.DateTime.Now;
        }
        void InitSkinGallery() {
    SkinHelper.InitSkinGallery(rgbiSkins, true);
}

    }
}