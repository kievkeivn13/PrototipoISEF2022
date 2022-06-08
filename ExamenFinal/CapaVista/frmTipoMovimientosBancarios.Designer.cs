
namespace CapaVista
{
    partial class frmTipoMovimientosBancarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoMovimientosBancarios));
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
            this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.navegador1 = new DLL.nav.navegador();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(461, 216);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(39, 20);
            this.txtEstado.TabIndex = 132;
            this.txtEstado.TabStop = false;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.rbnEstatusamodulo_CheckedChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(255, 187);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tag = "nombre";
            // 
            // txtIDTipo
            // 
            this.txtIDTipo.Location = new System.Drawing.Point(255, 161);
            this.txtIDTipo.Name = "txtIDTipo";
            this.txtIDTipo.Size = new System.Drawing.Size(200, 20);
            this.txtIDTipo.TabIndex = 1;
            this.txtIDTipo.Tag = "pkId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 134;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 135;
            this.label1.Text = "ID Tipo Cuenta:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnEstatusamodulo);
            this.panel1.Controls.Add(this.rbnEstatusimodulo);
            this.panel1.Location = new System.Drawing.Point(255, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 30);
            this.panel1.TabIndex = 133;
            // 
            // rbnEstatusamodulo
            // 
            this.rbnEstatusamodulo.AutoSize = true;
            this.rbnEstatusamodulo.Location = new System.Drawing.Point(12, 7);
            this.rbnEstatusamodulo.Name = "rbnEstatusamodulo";
            this.rbnEstatusamodulo.Size = new System.Drawing.Size(55, 17);
            this.rbnEstatusamodulo.TabIndex = 3;
            this.rbnEstatusamodulo.TabStop = true;
            this.rbnEstatusamodulo.Text = "Activo";
            this.rbnEstatusamodulo.UseVisualStyleBackColor = true;
            this.rbnEstatusamodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusamodulo_CheckedChanged);
            // 
            // rbnEstatusimodulo
            // 
            this.rbnEstatusimodulo.AutoSize = true;
            this.rbnEstatusimodulo.Location = new System.Drawing.Point(134, 7);
            this.rbnEstatusimodulo.Name = "rbnEstatusimodulo";
            this.rbnEstatusimodulo.Size = new System.Drawing.Size(63, 17);
            this.rbnEstatusimodulo.TabIndex = 4;
            this.rbnEstatusimodulo.TabStop = true;
            this.rbnEstatusimodulo.Text = "Inactivo";
            this.rbnEstatusimodulo.UseVisualStyleBackColor = true;
            this.rbnEstatusimodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusimodulo_CheckedChanged);
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(182, 219);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(45, 13);
            this.lblEstatus.TabIndex = 131;
            this.lblEstatus.Text = "Estatus:";
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.AllowUserToOrderColumns = true;
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(597, 103);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.Size = new System.Drawing.Size(579, 210);
            this.dgvVistaPrevia.TabIndex = 128;
            this.dgvVistaPrevia.TabStop = false;
            this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(1, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 127;
            // 
            // frmTipoMovimientosBancarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 328);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.dgvVistaPrevia);
            this.Controls.Add(this.navegador1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTipoMovimientosBancarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4105 Tipo Movimientos Bancarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIDTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnEstatusamodulo;
        private System.Windows.Forms.RadioButton rbnEstatusimodulo;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private DLL.nav.navegador navegador1;
    }
}