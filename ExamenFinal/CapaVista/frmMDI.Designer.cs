
namespace CapaVista
{
    partial class frmMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasBancariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventana1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaConFotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoCuentasBancariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoMovimientosDeBancosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosBancariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.catálogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión ";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasBancariasToolStripMenuItem,
            this.ventana1ToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.ventanaConFotoToolStripMenuItem,
            this.tipoCuentasBancariasToolStripMenuItem,
            this.tipoCuentaToolStripMenuItem,
            this.tipoMovimientosDeBancosToolStripMenuItem});
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.catálogosToolStripMenuItem.Text = "Catálogos ";
            // 
            // cuentasBancariasToolStripMenuItem
            // 
            this.cuentasBancariasToolStripMenuItem.Name = "cuentasBancariasToolStripMenuItem";
            this.cuentasBancariasToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.cuentasBancariasToolStripMenuItem.Text = "Cuentas Bancarias";
            this.cuentasBancariasToolStripMenuItem.Click += new System.EventHandler(this.cuentasBancariasToolStripMenuItem_Click);
            // 
            // ventana1ToolStripMenuItem
            // 
            this.ventana1ToolStripMenuItem.Name = "ventana1ToolStripMenuItem";
            this.ventana1ToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ventana1ToolStripMenuItem.Text = "Cuentas Contables";
            this.ventana1ToolStripMenuItem.Click += new System.EventHandler(this.ventana1ToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // ventanaConFotoToolStripMenuItem
            // 
            this.ventanaConFotoToolStripMenuItem.Name = "ventanaConFotoToolStripMenuItem";
            this.ventanaConFotoToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ventanaConFotoToolStripMenuItem.Text = "Empresa";
            this.ventanaConFotoToolStripMenuItem.Click += new System.EventHandler(this.ventanaConFotoToolStripMenuItem_Click);
            // 
            // tipoCuentasBancariasToolStripMenuItem
            // 
            this.tipoCuentasBancariasToolStripMenuItem.Name = "tipoCuentasBancariasToolStripMenuItem";
            this.tipoCuentasBancariasToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.tipoCuentasBancariasToolStripMenuItem.Text = "Tipo Cuentas Bancarias";
            this.tipoCuentasBancariasToolStripMenuItem.Click += new System.EventHandler(this.tipoCuentasBancariasToolStripMenuItem_Click);
            // 
            // tipoCuentaToolStripMenuItem
            // 
            this.tipoCuentaToolStripMenuItem.Name = "tipoCuentaToolStripMenuItem";
            this.tipoCuentaToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.tipoCuentaToolStripMenuItem.Text = "Tipo Cuenta Contables";
            this.tipoCuentaToolStripMenuItem.Click += new System.EventHandler(this.tipoCuentaToolStripMenuItem_Click);
            // 
            // tipoMovimientosDeBancosToolStripMenuItem
            // 
            this.tipoMovimientosDeBancosToolStripMenuItem.Name = "tipoMovimientosDeBancosToolStripMenuItem";
            this.tipoMovimientosDeBancosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.tipoMovimientosDeBancosToolStripMenuItem.Text = "Tipo Movimientos de Bancos";
            this.tipoMovimientosDeBancosToolStripMenuItem.Click += new System.EventHandler(this.tipoMovimientosDeBancosToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientosBancariosToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // movimientosBancariosToolStripMenuItem
            // 
            this.movimientosBancariosToolStripMenuItem.Name = "movimientosBancariosToolStripMenuItem";
            this.movimientosBancariosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.movimientosBancariosToolStripMenuItem.Text = "Movimientos Bancarios";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ayudasToolStripMenuItem
            // 
            this.ayudasToolStripMenuItem.Name = "ayudasToolStripMenuItem";
            this.ayudasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ayudasToolStripMenuItem.Text = "Ayudas";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(622, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Visible = false;
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVista.Properties.Resources._2ZNHHUUHCVC4RIWRIAFFAYNSBU;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudasToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem ventana1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaConFotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasBancariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoMovimientosDeBancosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosBancariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoCuentasBancariasToolStripMenuItem;
    }
}