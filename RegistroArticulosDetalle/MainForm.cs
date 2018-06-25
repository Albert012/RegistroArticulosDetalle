using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroArticulosDetalle.UI.Consultas;
using RegistroArticulosDetalle.UI.Registros;
namespace RegistroArticulosDetalle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rArticulos rArticulo = new rArticulos();
            rArticulo.MdiParent = this.MdiParent;
            rArticulo.Show();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cArticulos carticulos = new cArticulos();
            carticulos.MdiParent = this.MdiParent;
            carticulos.Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPersonas rpersonas = new rPersonas();
            rpersonas.MdiParent = this.MdiParent;
            rpersonas.Show();

        }

        private void personasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cPersonas cpersonas = new cPersonas();
            cpersonas.MdiParent = this.MdiParent;
            cpersonas.Show();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cotizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCotizar rcotizar = new rCotizar();
            rcotizar.MdiParent = this.MdiParent;
            rcotizar.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            articulosToolStripMenuItem_Click(sender, e);
        }
    }
}
