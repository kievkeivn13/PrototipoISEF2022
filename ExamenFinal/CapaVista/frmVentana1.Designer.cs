
namespace CapaVista
{
    partial class frmVentana1
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
            this.navegador1 = new DLL.nav.navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dgvVistaPrevia = new System.Windows.Forms.DataGridView();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbnEstatusamodulo = new System.Windows.Forms.RadioButton();
            this.rbnEstatusimodulo = new System.Windows.Forms.RadioButton();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.txtIDEmpresa = new System.Windows.Forms.TextBox();
            this.txtFinContrato = new System.Windows.Forms.TextBox();
            this.dtpFinContrato = new System.Windows.Forms.DateTimePicker();
            this.cbxIDEmpresa = new System.Windows.Forms.ComboBox();
            this.lblIDEmpresa = new System.Windows.Forms.Label();
            this.lblFinContrato = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Campo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Campo 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Campo 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Campo 4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(139, 190);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 20);
            this.textBox4.TabIndex = 4;
            // 
            // dgvVistaPrevia
            // 
            this.dgvVistaPrevia.AllowUserToAddRows = false;
            this.dgvVistaPrevia.AllowUserToDeleteRows = false;
            this.dgvVistaPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaPrevia.Location = new System.Drawing.Point(592, 90);
            this.dgvVistaPrevia.Name = "dgvVistaPrevia";
            this.dgvVistaPrevia.ReadOnly = true;
            this.dgvVistaPrevia.RowHeadersWidth = 51;
            this.dgvVistaPrevia.Size = new System.Drawing.Size(582, 320);
            this.dgvVistaPrevia.TabIndex = 88;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(399, 311);
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
            this.panel1.Location = new System.Drawing.Point(161, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 30);
            this.panel1.TabIndex = 91;
            // 
            // rbnEstatusamodulo
            // 
            this.rbnEstatusamodulo.AutoSize = true;
            this.rbnEstatusamodulo.Location = new System.Drawing.Point(12, 7);
            this.rbnEstatusamodulo.Name = "rbnEstatusamodulo";
            this.rbnEstatusamodulo.Size = new System.Drawing.Size(55, 17);
            this.rbnEstatusamodulo.TabIndex = 6;
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
            this.rbnEstatusimodulo.TabIndex = 7;
            this.rbnEstatusimodulo.TabStop = true;
            this.rbnEstatusimodulo.Text = "Inactivo";
            this.rbnEstatusimodulo.UseVisualStyleBackColor = true;
            this.rbnEstatusimodulo.CheckedChanged += new System.EventHandler(this.rbnEstatusimodulo_CheckedChanged);
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(51, 314);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(45, 13);
            this.lblEstatus.TabIndex = 89;
            this.lblEstatus.Text = "Estatus:";
            // 
            // txtIDEmpresa
            // 
            this.txtIDEmpresa.Location = new System.Drawing.Point(398, 256);
            this.txtIDEmpresa.Name = "txtIDEmpresa";
            this.txtIDEmpresa.Size = new System.Drawing.Size(34, 20);
            this.txtIDEmpresa.TabIndex = 97;
            this.txtIDEmpresa.TabStop = false;
            this.txtIDEmpresa.Tag = "fkIdEmpresa";
            this.txtIDEmpresa.Visible = false;
            this.txtIDEmpresa.TextChanged += new System.EventHandler(this.txtIDEmpresa_TextChanged);
            // 
            // txtFinContrato
            // 
            this.txtFinContrato.Location = new System.Drawing.Point(398, 219);
            this.txtFinContrato.Name = "txtFinContrato";
            this.txtFinContrato.Size = new System.Drawing.Size(62, 20);
            this.txtFinContrato.TabIndex = 96;
            this.txtFinContrato.TabStop = false;
            this.txtFinContrato.Tag = "finDeContrato";
            this.txtFinContrato.Visible = false;
            this.txtFinContrato.TextChanged += new System.EventHandler(this.txtFinContrato_TextChanged);
            // 
            // dtpFinContrato
            // 
            this.dtpFinContrato.Location = new System.Drawing.Point(140, 220);
            this.dtpFinContrato.Name = "dtpFinContrato";
            this.dtpFinContrato.Size = new System.Drawing.Size(240, 20);
            this.dtpFinContrato.TabIndex = 4;
            this.dtpFinContrato.ValueChanged += new System.EventHandler(this.dtpFinContrato_ValueChanged);
            // 
            // cbxIDEmpresa
            // 
            this.cbxIDEmpresa.FormattingEnabled = true;
            this.cbxIDEmpresa.Location = new System.Drawing.Point(139, 253);
            this.cbxIDEmpresa.Name = "cbxIDEmpresa";
            this.cbxIDEmpresa.Size = new System.Drawing.Size(241, 21);
            this.cbxIDEmpresa.TabIndex = 5;
            this.cbxIDEmpresa.SelectedIndexChanged += new System.EventHandler(this.cbxIDEmpresa_SelectedIndexChanged);
            // 
            // lblIDEmpresa
            // 
            this.lblIDEmpresa.AutoSize = true;
            this.lblIDEmpresa.Location = new System.Drawing.Point(52, 256);
            this.lblIDEmpresa.Name = "lblIDEmpresa";
            this.lblIDEmpresa.Size = new System.Drawing.Size(65, 13);
            this.lblIDEmpresa.TabIndex = 94;
            this.lblIDEmpresa.Text = "ID Empresa:";
            // 
            // lblFinContrato
            // 
            this.lblFinContrato.AutoSize = true;
            this.lblFinContrato.Location = new System.Drawing.Point(52, 226);
            this.lblFinContrato.Name = "lblFinContrato";
            this.lblFinContrato.Size = new System.Drawing.Size(82, 13);
            this.lblFinContrato.TabIndex = 95;
            this.lblFinContrato.Text = "Fin de Contrato:";
            // 
            // frmVentana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 425);
            this.Controls.Add(this.txtIDEmpresa);
            this.Controls.Add(this.txtFinContrato);
            this.Controls.Add(this.dtpFinContrato);
            this.Controls.Add(this.cbxIDEmpresa);
            this.Controls.Add(this.lblIDEmpresa);
            this.Controls.Add(this.lblFinContrato);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEstatus);
            this.Controls.Add(this.dgvVistaPrevia);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "frmVentana1";
            this.Text = "frmVentana1";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dgvVistaPrevia;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbnEstatusamodulo;
        private System.Windows.Forms.RadioButton rbnEstatusimodulo;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.TextBox txtIDEmpresa;
        private System.Windows.Forms.TextBox txtFinContrato;
        private System.Windows.Forms.DateTimePicker dtpFinContrato;
        private System.Windows.Forms.ComboBox cbxIDEmpresa;
        private System.Windows.Forms.Label lblIDEmpresa;
        private System.Windows.Forms.Label lblFinContrato;
    }
}