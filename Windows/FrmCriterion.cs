﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XCoder
{
    public partial class FrmCriterion : Form
    {
        #region 初始化界面
        public FrmCriterion()
        {
            InitializeComponent();

            this.Icon = FileSource.GetIcon();
        }

        public static FrmCriterion Create()
        {
            FrmCriterion frm = new FrmCriterion();

            return frm;
        }

        private void FrmCriterion_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
