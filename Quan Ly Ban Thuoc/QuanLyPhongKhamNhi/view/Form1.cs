using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyPhongKhamNhi
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static int admin = 0;

        public Form1()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Valentine");
            admin = 0;// quyên nhân viên
        }
        public Form1(int a)
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Valentine");
            admin = 1;// quyên admin
        }
      
    }
}
