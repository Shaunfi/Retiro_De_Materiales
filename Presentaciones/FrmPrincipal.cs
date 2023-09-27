using RetiroDeMateriales.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetiroDeMateriales.Presentaciones
{
    public partial class FrmPrincipal : Form
    {
        private FabricaServicio fabrica;

        public FrmPrincipal(FabricaServicio fabrica)
        {
            InitializeComponent();
            this.fabrica = fabrica;
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNuevoRetiro(fabrica).ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
