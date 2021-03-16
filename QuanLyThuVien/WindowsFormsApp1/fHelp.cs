using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class fHelp : Form
    {
        public fHelp()
        {
            InitializeComponent();
        }

        private void fHelp_Load(object sender, EventArgs e)
        {
            treeview_Display.Nodes.Add("System", "Hệ thống");
            treeview_Display.Nodes["System"].Nodes.Add("Thông tin tài khoản");
            treeview_Display.Nodes["System"].Nodes.Add("Đăng xuất");

            treeview_Display.Nodes.Add("Management", "Quản lý");
            treeview_Display.Nodes["Management"].Nodes.Add("Quản lý sách");
            treeview_Display.Nodes["Management"].Nodes.Add("Quản lý loại sách");
            treeview_Display.Nodes["Management"].Nodes.Add("Quản lý thủ thư");
            treeview_Display.Nodes["Management"].Nodes.Add("Quản lý độc giả");
            treeview_Display.Nodes["Management"].Nodes.Add("Quản lý tác giả");

            treeview_Display.Nodes.Add("Borrow Detail", "Chi tiết mượn trả");
            treeview_Display.Nodes["Borrow Detail"].Nodes.Add("Lập phiếu mượn");
            treeview_Display.Nodes["Borrow Detail"].Nodes.Add("Chi tiết mượn trả");

            treeview_Display.Nodes.Add("Search", "Tìm kiếm");
            treeview_Display.Nodes["Search"].Nodes.Add("Tìm kiếm sách");
            treeview_Display.Nodes["Search"].Nodes.Add("Tìm kiếm độc giả");

            treeview_Display.Nodes.Add("Statistics", "Báo cáo thống kê");
            treeview_Display.Nodes["Statistics"].Nodes.Add("Thống kê sách");
            treeview_Display.Nodes["Statistics"].Nodes.Add("Thống kê độc giả");
        }

        private void treeview_Display_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch(e.Node.Text)
            {
                case "Thông tin tài khoản":
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\test.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\test.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        break;
                    }
                case "Đăng xuất":
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\test2.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\test2.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        break;
                    }
                case "Quản lý sách":
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\test2.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\test2.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        break;
                    }
                case "Quản lý loại sách":
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\test2.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\test2.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        break;
                    }
                case "Quản lý thủ thư":             //done
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\QLThuThu.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\QLThuThu.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        break;
                    }
                case "Quản lý độc giả":             //done
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\QLDocGia.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\QLDocGia.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        break;
                    }
                case "Quản lý tác giả":
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\test2.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\test2.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        break;
                    }
                case "Lập phiếu mượn":
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\test2.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\test2.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        break;
                    }
                case "Chi tiết mượn trả":
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\test2.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\test2.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        break;
                    }
                case "Tìm kiếm sách":               //done
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\TimSach.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\TimSach.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        break;
                    }
                case "Tìm kiếm độc giả":            //done
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\TimDocGia.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\TimDocGia.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        break;
                    }
                case "Thống kê sách":
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\test2.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\test2.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        break;
                    }
                case "Thống kê độc giả":
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\test2.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\test2.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        break;
                    }

            }    
        }
    }
}
