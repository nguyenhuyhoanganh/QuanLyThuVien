using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fQuanLy : Form
    {
        public DataTable data;

        private Form activeForm = new Form();//Form đang dùng

        private Guna2Button currentBtn;//btuton đang ấn
        private Guna2Button subBtn;//Subbtuton đang ấn

        int thongTinTaiKhoan = 0;
        int quanLy = 0;
        int timKiem = 0;
        int muonTra = 0;
        int thongKe = 0;
        int troGiup = 0;
        public fQuanLy()
        {
            InitializeComponent();
            customizeDesing();
            statusSub();
            showStatus(btnStatus1);
            //openForm(new fBanVe());
            
        }

        private void openForm(Form form)
        {

            if (activeForm != null)
                activeForm.Close();
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelForm.Controls.Add(form);
            panelForm.Tag = form;
            form.BringToFront();
            form.Show();
        }
        #region Status in TillerBar
        public void statusSub()
        {
            btnStatus1.Visible = false;
            btnStatus2.Visible = false;
            btnStatus3.Visible = false;
            btnStatus4.Visible = false;
            btnStatus5.Visible = false;
            btnStatus6.Visible = false;
            btnStatus7.Visible = false;
        }
        public void hidenStatus()
        {
            if (btnStatus1.Visible == true)
                btnStatus1.Visible = false;
            if (btnStatus2.Visible == true)
                btnStatus2.Visible = false;
            if (btnStatus3.Visible == true)
                btnStatus3.Visible = false;
            if (btnStatus4.Visible == true)
                btnStatus4.Visible = false;
            if (btnStatus5.Visible == true)
                btnStatus5.Visible = false;
            if (btnStatus6.Visible == true)
                btnStatus6.Visible = false;
            if (btnStatus7.Visible == true)
                btnStatus7.Visible = false;
        }
        public void showStatus(Guna2Button status)
        {
            if (status.Visible == false)
            {
                hidenStatus();
                status.Visible = true;
            }
        }
        #endregion
        #region Show Submenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void customizeDesing()
        {
            panelSubQuanLy.Visible = false;
            panelSubTimKiem.Visible = false;
            panelSubMuonTra.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubQuanLy.Visible == true)
                panelSubQuanLy.Visible = false;
            if (panelSubTimKiem.Visible == true)
                panelSubTimKiem.Visible = false;
            if (panelSubMuonTra.Visible == true)
                panelSubMuonTra.Visible = false;
        }

        #endregion
        #region Button đóng
        private void DisableButton()
        {
            if (currentBtn != null)//nếu btn đang ấn chưa đóng 
            {
                currentBtn.FillColor = CColor.color10;//Đưa màu về như cũ
                //currentBtn.ForeColor = Color.FromArgb(78, 184, 206);//màu chữ về như cũ

            }
        }
        private void DisableSubButton()
        {
            if (subBtn != null)//nếu btn đang ấn chưa đóng 
            {
                subBtn.FillColor = CColor.color10;//Đưa màu về như cũ
                //subBtn.ForeColor = Color.LightGray;//màu chữ về như cũ
            }
        }
        private void Reset()
        {
            DisableButton();
            DisableSubButton();
            lbTillerBar.Text = "Home";
            //if (activeForm != null)
            //activeForm.Close();
            //openForm(new fBanVe());

            if (activeForm != null)
                activeForm.Close();

        }

        #endregion
        #region Button mở
        private void ActivateButton(object senderBtn /*, Color color */)
        {
            if (senderBtn != null)
            {
                DisableButton();//hủy button hiện tại
                //Button
                currentBtn = (Guna2Button)senderBtn;
                currentBtn.FillColor = CColor.color8;
                lbTillerBar.Text = currentBtn.Text;
                //currentBtn.ForeColor = color;//Đổi Màu Chữ Thành Màu Được truyền Vào
                if (activeForm != null)
                    activeForm.Close();
            }
        }
        private void ActivateSubButton(object senderBtn /*, Color color */)
        {
            if (senderBtn != null)
            {
                DisableSubButton();//hủy button hiện tại
                //Button
                subBtn = (Guna2Button)senderBtn;
                subBtn.FillColor = CColor.color8;//Đổi Màu Back Color
            }
        }
        #endregion

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (thongTinTaiKhoan == 0)
            {
                timKiem = 0;
                quanLy = 0;
                muonTra = 0;
                thongKe = 0;
                troGiup = 0;
                thongTinTaiKhoan = 1;

                showStatus(btnStatus5);
                ActivateButton(sender);
                hideSubMenu();
                fThongTinTaiKhoan form = new fThongTinTaiKhoan();
                form.dt = data;
                openForm(form);
            }
            else
            {
                Reset();

                showStatus(btnStatus1);
                thongTinTaiKhoan = 0;
            }
        }
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            if (quanLy == 0)
            {
                timKiem = 0;
                quanLy = 1;
                muonTra = 0;
                thongKe = 0;
                troGiup = 0;
                thongTinTaiKhoan = 0;
                showStatus(btnStatus2);
                ActivateButton(sender);
                btnSach_Click(sender, e);
            }//Đang đóng
            else
            {
                Reset();

                showStatus(btnStatus1);
                quanLy = 0;
            }//Đang Mở

            showSubMenu(panelSubQuanLy);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (timKiem == 0)
            {
                timKiem = 1;
                quanLy = 0;
                muonTra = 0;
                thongKe = 0;
                troGiup = 0;
                thongTinTaiKhoan = 0;

                showStatus(btnStatus3);
                ActivateButton(sender);
                btnTKSach_Click(sender, e);
            }//Đang đóng
            else
            {
                Reset();

                showStatus(btnStatus1);
                timKiem = 0;
            }//Đang Mở
            showSubMenu(panelSubTimKiem);

        }


        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            if (muonTra == 0)
            {
                timKiem = 0;
                quanLy = 0;
                muonTra = 1;
                thongKe = 0;
                troGiup = 0;
                thongTinTaiKhoan = 0;

                showStatus(btnStatus4);
                ActivateButton(sender);
                btnMuonSach_Click(sender, e);
            }
            else
            {
                Reset();

                showStatus(btnStatus1);
                muonTra = 0;
            }
            showSubMenu(panelSubMuonTra);
        }

 

        #region Thanh Tiêu Đề, Thoát, Thu Nhỏ, Home, SignOut
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            timKiem = 0;
            quanLy = 0;
            muonTra = 0;
            thongKe = 0;
            troGiup = 0;
            thongTinTaiKhoan = 0;
            showStatus(btnStatus1);
            Reset();
            hideSubMenu();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (thongKe == 0)
            {
                timKiem = 0;
                quanLy = 0;
                muonTra = 0;
                thongKe = 1;
                troGiup = 0;
                thongTinTaiKhoan = 0;

                showStatus(btnStatus6);
                ActivateButton(sender);
                hideSubMenu();
                openForm(new fThongKe());
            }
            else
            {
                Reset();

                showStatus(btnStatus1);
                thongKe = 0;
            }
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            if (troGiup == 0)
            {
                timKiem = 0;
                quanLy = 0;
                muonTra = 0;
                thongKe = 0;
                troGiup = 1;
                thongTinTaiKhoan = 0;

                showStatus(btnStatus7);
                ActivateButton(sender);
                hideSubMenu();
                openForm(new fHelp());
            }
            else
            {
                Reset();

                showStatus(btnStatus1);
                troGiup = 0;
            }
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnSach);
            openForm(new fSachR());
        }

        private void btnLoaiSach_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnLoaiSach);
            openForm(new fTheLoai());
        }

        private void btnThuThu_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnThuThu);
            openForm(new FormThuThu());
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnDocGia);
            openForm(new FormDocGia());
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnTacGia);
            openForm(new fTacGia());
        }

        private void btnTKSach_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnTKSach);
            openForm(new fTimKiemSachR());
        }

        private void btnTKDocGia_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnTKDocGia);
            openForm(new fTimKiemDocGiaR());
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnMuonSach);
            openForm(new fMuonSach());
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            ActivateSubButton(btnTraSach);
            openForm(new fTraSach());
        }

        private void fQuanLy_Load(object sender, EventArgs e)
        {
            btnTaiKhoan.Text = data.Rows[0]["hoten"].ToString();
        }
    }
}

