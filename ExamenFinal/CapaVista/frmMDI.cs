using CapaVistaRRHH;
using CapaVistaSeguridadHSC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static datosUsuario;

namespace CapaVista
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }
        CapaControladorSeguridadHSC.Controlador bitacora = new CapaControladorSeguridadHSC.Controlador();
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            { this.Close(); }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ventana1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmVentana1 form3 = new frmVentana1();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void ventanaConFotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmpresas form3 = new frmEmpresas();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            {
                this.Close();
            }
        }
    }
}
