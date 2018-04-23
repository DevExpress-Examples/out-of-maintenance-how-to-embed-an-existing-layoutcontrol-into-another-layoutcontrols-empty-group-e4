using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraLayout;

namespace radialMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LayoutControlItem item = new LayoutControlItem();
            item.SizeConstraintsType = SizeConstraintsType.Custom;
            item.TextVisible = false;
            item.Control = layoutControl1;
            layoutControlGroup3.AddItem(item);
        }
    }
}
