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
        private void butPhieuKham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             panel1.Controls.Clear();
             FormPhieuKham fPk = new FormPhieuKham();
             fPk.TopLevel = false;
             panel1.Controls.Add(fPk);
             fPk.Dock = DockStyle.Fill;
             fPk.Show();
            
        }

        private void butThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            formThuoc fT = new formThuoc();
            fT.TopLevel = false;
            panel1.Controls.Add(fT);
            fT.Dock = DockStyle.Fill;
            fT.Show();
        }

        private void butBacSi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            FormBacSi fBs = new FormBacSi();
            fBs.TopLevel = false;
            panel1.Controls.Add(fBs);
            fBs.Dock = DockStyle.Fill;
            fBs.Show();
        }

        private void butDuocSi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            FormDuocSi fDs = new FormDuocSi();
            fDs.TopLevel = false;
            panel1.Controls.Add(fDs);
            fDs.Dock = DockStyle.Fill;
            fDs.Show();
        }

        private void butHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            FormHoaDon fHd = new FormHoaDon();
            fHd.TopLevel = false;
            panel1.Controls.Add(fHd);
            fHd.Dock = DockStyle.Fill;
            fHd.Show();
        }

        private void butThanhTichBanThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (admin == 0)
            {
                XtraMessageBox.Show("Bạn cần đăng nhập với quyền admin");
                butThanhTichBanThuoc.Enabled = false;
            }
            else
            {
                panel1.Controls.Clear();
                FormTkThanhTich fTkTc = new FormTkThanhTich();
                fTkTc.TopLevel = false;
                panel1.Controls.Add(fTkTc);
                fTkTc.Dock = DockStyle.Fill;
                fTkTc.Show();
            }
            
        }

        private void butSoLuongThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (admin == 0)
            {
                XtraMessageBox.Show("Bạn cần đăng nhập với quyền admin");
                butSoLuongThuoc.Enabled = false;
            }
            else
            {
                panel1.Controls.Clear();
                FormTkThuoc fTkT = new FormTkThuoc();
                fTkT.TopLevel = false;
                panel1.Controls.Add(fTkT);
                fTkT.Dock = DockStyle.Fill;
                fTkT.Show();
            }
           
        }


        private void butDoanThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (admin == 0)
            {
                XtraMessageBox.Show("Bạn cần đăng nhập với quyền admin");
                butDoanhThu.Enabled = false;
            }
            else
            {
                panel1.Controls.Clear();
                FormTkDoanhThu fTkDt = new FormTkDoanhThu();
                fTkDt.TopLevel = false;
                panel1.Controls.Add(fTkDt);
                fTkDt.Dock = DockStyle.Fill;
                fTkDt.Show();
            }
         
        }

        private void butToaThuoc_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            FrmToaThuoc fTt = new FrmToaThuoc();
            fTt.TopLevel = false;
            panel1.Controls.Add(fTt);
            fTt.Dock = DockStyle.Fill;
            fTt.Show();
        }

        private void butBenhNhan_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            FormBenhNhan fBn = new FormBenhNhan();
            fBn.TopLevel = false;
            panel1.Controls.Add(fBn);
            fBn.Dock = DockStyle.Fill;
            fBn.Show();
        }

        private void butThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void butQuanLyDN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(admin == 0)
            {
                XtraMessageBox.Show("Bạn cần đăng nhập với quyền admin");
                butQuanLyDN.Enabled = false;
            }
            else
            {
                butQuanLyDN.Enabled = true;
                panel1.Controls.Clear();
                FormQuanLyDN fQL = new FormQuanLyDN();
                fQL.TopLevel = false;
                panel1.Controls.Add(fQL);
                fQL.Dock = DockStyle.Fill;
                fQL.Show();
            }  
        }
    }
}
