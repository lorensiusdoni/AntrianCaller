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
    public partial class FrmMainApp : Form
    {
        public FrmMainApp()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var namaLoket = Properties.Settings.Default.NamaLoket;
            var nomorLoket = Properties.Settings.Default.NomorLoket;
            if ( namaLoket == "" || nomorLoket == 0 )
            {
                FrmPilihLoket frmLoket = new FrmPilihLoket();
                frmLoket.Show();
            }
            else
            {
                FrmCaller frmCall = new FrmCaller();
                frmCall.Show();
            }
        }

        private void BtnResetSetup_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NamaLoket = null;
            Properties.Settings.Default.NomorLoket = 0;
            Properties.Settings.Default.Save();
            MessageBox.Show("Berhasil Reset Setup Loket!");
        }

        private void FrmMainApp_Activated(object sender, EventArgs e)
        {
            var namaLoket = Properties.Settings.Default.NamaLoket;
            var nomorLoket = Properties.Settings.Default.NomorLoket;

            TSSLBottom.Text = "Loket : " + namaLoket + " Nomor : " + nomorLoket;
            this.Refresh();
        }
    }
}
