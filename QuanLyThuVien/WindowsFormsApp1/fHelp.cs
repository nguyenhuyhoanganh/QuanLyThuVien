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
            richtextbox_Display.Text = File.ReadAllText(@"HelpResources\test.txt");

            Clipboard.SetImage(Image.FromFile(@"HelpResources\test.jpg"));
            richtextbox_Display.AppendText("\n");
            richtextbox_Display.Paste();
        }
    }
}
