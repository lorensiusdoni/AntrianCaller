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
            if ( namaLoket == "" )
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
    }
}
