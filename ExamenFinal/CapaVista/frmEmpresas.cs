﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaRRHH
{
    public partial class frmEmpresas : Form
    {
        public frmEmpresas()
        {
            InitializeComponent();
			TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
			navegador1.ObtenerCamposdeTabla(alias, "empresa", "hotelSanCarlos");
			navegador1.MetodoSalirVista(this);
			//navegador1.LlenarCombobox(cbxIDPuesto, "puesto", "pkIdPuesto", "nombre", "estado");
			//navegador1.LlenarCombobox(cbxIDEmpresa, "empresa", "idEmpresa", "nombre", "estatus");

			//inicio de elementos para dar de baja
			navegador1.campoEstado = "estado";
			//fin de elementos para dar de baja

			/* Inicio ID Aplicacion usada para reportes y ayudas */
			navegador1.idAplicacion = "2017";
			navegador1.idmodulo = "2";
			/* Inicio ID Aplicacion usada para reportes y ayudas */

			//inicio de elementos para ejecutar la ayuda
			navegador1.tablaAyuda = "Aplicacion";
			navegador1.campoAyuda = "pkId";
			//fin de elementos para ejecutar la ayuda


			// Inicio datos para ejecurar reportes
			navegador1.LlamarRutaReporte("ruta", "idAplicacion", "Reporte");
			// Final datos para ejecutar reportes

			navegador1.ObtenerNombreDGV(this.dgvVistaPrevia);
			navegador1.LlenarTabla();
			navegador1.ObtenerReferenciaFormActual(this);
			//String cadena = txtprueba.Text;
			//navegador1.pruebaMensaje(cadena);

		}
		CapaControlador.Controlador controlador = new CapaControlador.Controlador();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresas));
		private void txtEstado_TextChanged(object sender, EventArgs e)
		{
			navegador1.ActivaRadiobtn(rbnEstatusamodulo, rbnEstatusimodulo, txtEstado);
		}

		private void rbnEstatusamodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.CambioEstadoTextbox(txtEstado, rbnEstatusamodulo, "1");
		}

		private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.CambioEstadoTextbox(txtEstado, rbnEstatusimodulo, "0");
		}

		private void dgvVistaPrevia_SelectionChanged(object sender, EventArgs e)
		{

			navegador1.SelecciondeFilaDGV(dgvVistaPrevia);

		}
		public byte[] imagenAbyte()
		{
			byte[] imagen = null; MemoryStream ms = new MemoryStream();
			try
			{
				pbFoto.Image.Save(ms, ImageFormat.Png);
				ms.Seek(0, SeekOrigin.Begin);
				imagen = ms.ToArray();
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
			return imagen;
		}
		public void obtienByte(string id)
		{
			byte[] imagen = null;
			pbFoto.Image = null;
			try
			{
				imagen = controlador.obtenerByte(id);
				using (MemoryStream ms = new MemoryStream())
				{
					ms.Write(imagen, 0, imagen.Length);
					Image returnImage = Image.FromStream(ms, true);
					pbFoto.Image = returnImage;
					pbFoto.BackgroundImage = null;
				}
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}
		private void txtIdFoto_TextChanged(object sender, EventArgs e)
        {
			if (txtIdFoto.Text != "")
			{
				string id = txtIdFoto.Text;
				obtienByte(id);
			}
			else if (txtIdFoto.Text == "")
			{
				pbFoto.Image = null;
				pbFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.BackgroundImage")));
			}
		}
        private void btnSelecionImagen_Click(object sender, EventArgs e)
        {
			try
			{
				OpenFileDialog dialog = new OpenFileDialog();
				dialog.Title = "Selecione una imagen";
				dialog.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					pbFoto.ImageLocation = dialog.FileName;
					pbFoto.BackgroundImage = null;
				}
				else
				{ MessageBox.Show("Error al cargar imagen."); }
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
			try
			{
				if (txtIdFoto.Text == "")
				{
					int id = controlador.idSiguienteDeNuevoIngreso("foto", "pkId");
					byte[] imagen = imagenAbyte();
					controlador.insertaNuevaFoto(id.ToString(), imagen);
					txtIdFoto.Text = id.ToString();
				}
				else if (txtIdFoto.Text != "")
				{
					string id = txtIdFoto.Text;
					byte[] imagen = imagenAbyte();
					controlador.insertaFoto(id, imagen);
				}
			}
			catch (Exception ex) { MessageBox.Show("Error: " + ex); }
		}
    }
}
