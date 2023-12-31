﻿using modeloParcial.Presentaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modeloParcial
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaOrden nuevaOrden = new FrmNuevaOrden();
            nuevaOrden.ShowDialog();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteStock reporteStock = new FrmReporteStock();
            reporteStock.ShowDialog();
        }
    }
}
