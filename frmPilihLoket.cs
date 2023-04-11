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
    public partial class FrmPilihLoket : Form
    {
        public FrmPilihLoket()
        {
            InitializeComponent();
        }

        private void BtnKasir_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NamaLoket = "KASIR";
            Properties.Settings.Default.Save();
            FrmPilihNomor frmPilihNomor = new FrmPilihNomor();
            frmPilihNomor.Show();
        }

        private void BtnAnalis_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NamaLoket = "ANALIS";
            Properties.Settings.Default.Save();
            FrmPilihNomor frmPilihNomor = new FrmPilihNomor();
            frmPilihNomor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NamaLoket = "CS";
            Properties.Settings.Default.Save();
            FrmPilihNomor frmPilihNomor = new FrmPilihNomor();
            frmPilihNomor.Show();
        }

        private void FrmPilihLoket_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
