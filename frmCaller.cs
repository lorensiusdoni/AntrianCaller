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
    public partial class FrmCaller : Form
    {
        public FrmCaller()
        {
            InitializeComponent();
        }

        private void FrmCaller_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmCaller_Activated(object sender, EventArgs e)
        {
            var namaLoket = Properties.Settings.Default.NamaLoket;
            var nomorLoket = Properties.Settings.Default.NomorLoket;

            this.Text = "Loket : " + namaLoket + " - Nomor : " + nomorLoket;
            this.Update();
        }
    }
}
