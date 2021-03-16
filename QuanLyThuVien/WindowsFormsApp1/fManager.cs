using QLTV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
        }

        private void fManager_Load(object sender, EventArgs e)
        {

        }

        private void danhSáchSáchĐangMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMuonTraSach pm = new FrmMuonTraSach();
            pm.ShowDialog();
        }
    }
}
