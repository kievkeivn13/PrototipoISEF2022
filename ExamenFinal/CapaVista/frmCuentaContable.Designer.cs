
namespace CapaVista
{
    partial class frmCuentaContable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuentaContable));
            this.navegador1 = new DLL.nav.navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDCuenta = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
            this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.txtIDTipoCuenta = new System.Windows.Forms.TextBox();
            this.cbxIDTipo = new System.Windows.Forms.ComboBox();
            this.lblIDEmpresa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaldoAcumulado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, -3);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cargo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Abono:";
            // 
            // txtIDCuenta
            // 
            this.txtIDCuenta.Location = new System.Drawing.Point(115, 113);
            this.txtIDCuenta.Name = "txtIDCuenta";
            this.txtIDCuenta.Size = new System.Drawing.Size(209, 20);
            this.txtIDCuenta.TabIndex = 1;
            this.txtIDCuenta.Tag = "pkId";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 136);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tag = "nombre";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(115, 186);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(209, 20);
            this.txtCargo.TabIndex = 4;
            this.txtCargo.Tag = "cargo";
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(115, 212);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(209, 20);
            this.txtAbono.TabIndex = 5;
            this.txtAbono.Tag = "abono";
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.AllowUserToAddRows = false;
            this.dgvVistaPrevia.AllowUserToDeleteRows = false;
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(367, 96);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.ReadOnly = true;
            this.dgvVistaPrevia.RowHeadersWidth = 51;
            this.dgvVistaPrevia.Size = new System.Drawing.Size(807, 250);
            this.dgvVistaPrevia.TabIndex = 88;
            this.dgvVistaPrevia.SelectionChanged += new System.EventHandler(this.dgvVistaPrevia_SelectionChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(328, 312);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(33, 20);
            this.txtEstado.TabIndex = 90;
            this.txtEstado.TabStop = false;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbnEstatusamodulo);
            this.panel1.Controls.Add(this.rbnEstatusimodulo);
            this.panel1.Location = new System.Drawing.Point(115, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 30);
            this.panel1.TabIndex = 91;
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
            this.lblEstatus.Location = new System.Drawing.Point(63, 315);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(45, 13);
            this.lblEstatus.TabIndex = 89;
            this.lblEstatus.Text = "Estatus:";
            // 
            // txtIDTipoCuenta
            // 
            this.txtIDTipoCuenta.Location = new System.Drawing.Point(328, 159);
            this.txtIDTipoCuenta.Name = "txtIDTipoCuenta";
            this.txtIDTipoCuenta.Size = new System.Drawing.Size(34, 20);
            this.txtIDTipoCuenta.TabIndex = 97;
            this.txtIDTipoCuenta.TabStop = false;
            this.txtIDTipoCuenta.Tag = "fkIdTipo";
            this.txtIDTipoCuenta.Visible = false;
            this.txtIDTipoCuenta.TextChanged += new System.EventHandler(this.txtIDEmpresa_TextChanged);
            // 
            // cbxIDTipo
            // 
            this.cbxIDTipo.FormattingEnabled = true;
            this.cbxIDTipo.ItemHeight = 13;
            this.cbxIDTipo.Location = new System.Drawing.Point(115, 159);
            this.cbxIDTipo.Name = "cbxIDTipo";
            this.cbxIDTipo.Size = new System.Drawing.Size(209, 21);
            this.cbxIDTipo.TabIndex = 5;
            this.cbxIDTipo.SelectedIndexChanged += new System.EventHandler(this.cbxIDEmpresa_SelectedIndexChanged);
            // 
            // lblIDEmpresa
            // 
            this.lblIDEmpresa.AutoSize = true;
            this.lblIDEmpresa.Location = new System.Drawing.Point(28, 162);
            this.lblIDEmpresa.Name = "lblIDEmpresa";
            this.lblIDEmpresa.Size = new System.Drawing.Size(82, 13);
            this.lblIDEmpresa.TabIndex = 94;
            this.lblIDEmpresa.Text = "ID Tipo Cuenta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Saldo Acumulado:";
            // 
            // txtSaldoAcumulado
            // 
            this.txtSaldoAcumulado.Location = new System.Drawing.Point(115, 238);
            this.txtSaldoAcumulado.Name = "txtSaldoAcumulado";
            this.txtSaldoAcumulado.Size = new System.Drawing.Size(209, 20);
            this.txtSaldoAcumulado.TabIndex = 6;
            this.txtSaldoAcumulado.Tag = "saldoAcumulado ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(115, 264);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(209, 42);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Tag = "descripcion";
            // 
            // frmCuentaContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 358);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtSaldoAcumulado);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtIDTipoCuenta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDCuenta);
            this.Controls.Add(this.lblIDEmpresa);
            this.Controls.Add(this.cbxIDTipo);
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
            this.Name = "frmCuentaContable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4103 Cuentas Contables";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaPrevia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDCuenta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnEstatusamodulo;
        private System.Windows.Forms.RadioButton rbnEstatusimodulo;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.TextBox txtIDTipoCuenta;
        private System.Windows.Forms.ComboBox cbxIDTipo;
        private System.Windows.Forms.Label lblIDEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaldoAcumulado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}