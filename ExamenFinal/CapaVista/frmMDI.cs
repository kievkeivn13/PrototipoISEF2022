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
                frmCuentaContable form3 = new frmCuentaContable();
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

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmpleados form3 = new frmEmpleados();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void tipoCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTipoCuenta form3 = new frmTipoCuenta();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void cuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCuentasBancarias form3 = new frmCuentasBancarias();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void tipoCuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTipoCuentaBancaria form3 = new frmTipoCuentaBancaria();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void tipoMovimientosDeBancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTipoMovimientosBancarios form3 = new frmTipoMovimientosBancarios();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
    }
}
