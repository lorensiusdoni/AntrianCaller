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
    }
}
