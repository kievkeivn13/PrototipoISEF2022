
namespace CapaVista
{
    partial class frmCuentasBancarias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuentasBancarias));
            this.txtIDTipoCuenta = new System.Windows.Forms.TextBox();
            this.cbxIDTipo = new System.Windows.Forms.ComboBox();
            this.lblIDEmpresa = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
            this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtSaldoAcumulado = new System.Windows.Forms.TextBox();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDCuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDTipoCuenta
            // 
            this.txtIDTipoCuenta.Location = new System.Drawing.Point(328, 160);
            this.txtIDTipoCuenta.Name = "txtIDTipoCuenta";
            this.txtIDTipoCuenta.Size = new System.Drawing.Size(34, 20);
            this.txtIDTipoCuenta.TabIndex = 117;
            this.txtIDTipoCuenta.TabStop = false;
            this.txtIDTipoCuenta.Tag = "fkIdTipo";
            this.txtIDTipoCuenta.Visible = false;
            this.txtIDTipoCuenta.TextChanged += new System.EventHandler(this.txtIDEmpresa_TextChanged);
            // 
            // cbxIDTipo
            // 
            this.cbxIDTipo.FormattingEnabled = true;
            this.cbxIDTipo.ItemHeight = 13;
            this.cbxIDTipo.Location = new System.Drawing.Point(115, 160);
            this.cbxIDTipo.Name = "cbxIDTipo";
            this.cbxIDTipo.Size = new System.Drawing.Size(209, 21);
            this.cbxIDTipo.TabIndex = 103;
            this.cbxIDTipo.SelectedIndexChanged += new System.EventHandler(this.cbxIDEmpresa_SelectedIndexChanged);
            // 
            // lblIDEmpresa
            // 
            this.lblIDEmpresa.AutoSize = true;
            this.lblIDEmpresa.Location = new System.Drawing.Point(28, 163);
            this.lblIDEmpresa.Name = "lblIDEmpresa";
            this.lblIDEmpresa.Size = new System.Drawing.Size(82, 13);
            this.lblIDEmpresa.TabIndex = 116;
            this.lblIDEmpresa.Text = "ID Tipo Cuenta:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(328, 313);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(33, 20);
            this.txtEstado.TabIndex = 114;
            this.txtEstado.TabStop = false;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnEstatusamodulo);
            this.panel1.Controls.Add(this.rbnEstatusimodulo);
            this.panel1.Location = new System.Drawing.Point(115, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 30);
            this.panel1.TabIndex = 115;
            // 
            // rbnEstatusamodulo
            // 
            this.rbnEstatusamodulo.AutoSize = true;
            this.rbnEstatusamodulo.Location = new System.Drawing.Point(12, 7);
            this.rbnEstatusamodulo.Name = "rbnEstatusamodulo";
            this.rbnEstatusamodulo.Size = new System.Drawing.Size(55, 17);
            this.rbnEstatusamodulo.TabIndex = 8;
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
            this.rbnEstatusimodulo.TabIndex = 9;
            this.rbnEstatusimodulo.TabStop = true;
            this.rbnEstatusimodulo.Text = "Inactivo";
            this.rbnEstatusimodulo.UseVisualStyleBackColor = true;
            this.rbnEstatusimodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusimodulo_CheckedChanged);
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(63, 316);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(45, 13);
            this.lblEstatus.TabIndex = 113;
            this.lblEstatus.Text = "Estatus:";
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.AllowUserToAddRows = false;
            this.dgvVistaPrevia.AllowUserToDeleteRows = false;
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(367, 97);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.ReadOnly = true;
            this.dgvVistaPrevia.RowHeadersWidth = 51;
            this.dgvVistaPrevia.Size = new System.Drawing.Size(807, 250);
            this.dgvVistaPrevia.TabIndex = 112;
            this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(115, 265);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(209, 42);
            this.txtDescripcion.TabIndex = 105;
            this.txtDescripcion.Tag = "descripcion";
            // 
            // txtSaldoAcumulado
            // 
            this.txtSaldoAcumulado.Location = new System.Drawing.Point(115, 239);
            this.txtSaldoAcumulado.Name = "txtSaldoAcumulado";
            this.txtSaldoAcumulado.Size = new System.Drawing.Size(209, 20);
            this.txtSaldoAcumulado.TabIndex = 104;
            this.txtSaldoAcumulado.Tag = "saldoAcumulado ";
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(115, 213);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(209, 20);
            this.txtAbono.TabIndex = 102;
            this.txtAbono.Tag = "abono";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(115, 187);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(209, 20);
            this.txtCargo.TabIndex = 101;
            this.txtCargo.Tag = "cargo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 137);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 20);
            this.txtNombre.TabIndex = 100;
            this.txtNombre.Tag = "nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 110;
            this.label5.Text = "Saldo Acumulado:";
            // 
            // txtIDCuenta
            // 
            this.txtIDCuenta.Location = new System.Drawing.Point(115, 114);
            this.txtIDCuenta.Name = "txtIDCuenta";
            this.txtIDCuenta.Size = new System.Drawing.Size(209, 20);
            this.txtIDCuenta.TabIndex = 99;
            this.txtIDCuenta.Tag = "pkId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "Abono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Cargo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "ID Cuenta:";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, -2);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 98;
            // 
            // frmCuentasBancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 359);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtSaldoAcumulado);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtIDTipoCuenta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDCuenta);
            this.Controls.Add(this.cbxIDTipo);
            this.Controls.Add(this.lblIDEmpresa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.dgvVistaPrevia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCuentasBancarias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4104 Cuentas Bancarias";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDTipoCuenta;
        private System.Windows.Forms.ComboBox cbxIDTipo;
        private System.Windows.Forms.Label lblIDEmpresa;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnEstatusamodulo;
        private System.Windows.Forms.RadioButton rbnEstatusimodulo;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtSaldoAcumulado;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DLL.nav.navegador navegador1;
    }
}