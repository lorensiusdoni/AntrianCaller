using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrianCaller
{
    public partial class FrmPilihNomor : Form
    {
        public FrmPilihNomor()
        {
            InitializeComponent();
        }

        private void BtnLoketSatu_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NomorLoket = 1;
            Properties.Settings.Default.Save();
            FrmCaller frmCall = new FrmCaller();
            frmCall.Show();
        }

        private void BtnLoketDua_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NomorLoket = 2;
            Properties.Settings.Default.Save();
            FrmCaller frmCall = new FrmCaller();
            frmCall.Show();
        }

        private void BtnLoketTiga_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NomorLoket = 3;
            Properties.Settings.Default.Save();
            FrmCaller frmCall = new FrmCaller();
            frmCall.Show();
        }

        private void FrmPilihNomor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
