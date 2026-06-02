namespace ProyectoLavanderia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkEstudiante = new System.Windows.Forms.CheckBox();
            this.chkPlanchado = new System.Windows.Forms.CheckBox();
            this.chkDetergentePremium = new System.Windows.Forms.CheckBox();
            this.textNumeroOrden = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textCarnet = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textRecibo = new System.Windows.Forms.TextBox();
            this.numPrendas = new System.Windows.Forms.NumericUpDown();
            this.cmbTipoRopa = new System.Windows.Forms.ComboBox();
            this.btnGenerarRecibo = new System.Windows.Forms.Button();
            this.dgvMaquinas = new System.Windows.Forms.DataGridView();
            this.btnIniciarMaquina = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVentasTitulo = new System.Windows.Forms.Label();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.lblDecuentosTitulo = new System.Windows.Forms.Label();
            this.btnCierreCaja = new System.Windows.Forms.Button();
            this.btnGuardarResumen = new System.Windows.Forms.Button();
            this.lblTotalDescuentos = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(881, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGenerarRecibo);
            this.tabPage1.Controls.Add(this.cmbTipoRopa);
            this.tabPage1.Controls.Add(this.numPrendas);
            this.tabPage1.Controls.Add(this.textRecibo);
            this.tabPage1.Controls.Add(this.textTelefono);
            this.tabPage1.Controls.Add(this.textCarnet);
            this.tabPage1.Controls.Add(this.textNombre);
            this.tabPage1.Controls.Add(this.textNumeroOrden);
            this.tabPage1.Controls.Add(this.chkDetergentePremium);
            this.tabPage1.Controls.Add(this.chkPlanchado);
            this.tabPage1.Controls.Add(this.chkEstudiante);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(873, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro de Servicio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnIniciarMaquina);
            this.tabPage2.Controls.Add(this.dgvMaquinas);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(873, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Control de Maquinaria";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblTotalDescuentos);
            this.tabPage3.Controls.Add(this.btnGuardarResumen);
            this.tabPage3.Controls.Add(this.btnCierreCaja);
            this.tabPage3.Controls.Add(this.lblDecuentosTitulo);
            this.tabPage3.Controls.Add(this.lblTotalVentas);
            this.tabPage3.Controls.Add(this.lblVentasTitulo);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(873, 498);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reportes Administrativos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Orden: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teléfono: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carnet: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de Prendas: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de ropa: ";
            // 
            // chkEstudiante
            // 
            this.chkEstudiante.AutoSize = true;
            this.chkEstudiante.Location = new System.Drawing.Point(100, 149);
            this.chkEstudiante.Name = "chkEstudiante";
            this.chkEstudiante.Size = new System.Drawing.Size(124, 20);
            this.chkEstudiante.TabIndex = 6;
            this.chkEstudiante.Text = "¿Es estudiante?";
            this.chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // chkPlanchado
            // 
            this.chkPlanchado.AutoSize = true;
            this.chkPlanchado.Location = new System.Drawing.Point(103, 298);
            this.chkPlanchado.Name = "chkPlanchado";
            this.chkPlanchado.Size = new System.Drawing.Size(94, 20);
            this.chkPlanchado.TabIndex = 7;
            this.chkPlanchado.Text = "Planchado";
            this.chkPlanchado.UseVisualStyleBackColor = true;
            // 
            // chkDetergentePremium
            // 
            this.chkDetergentePremium.AutoSize = true;
            this.chkDetergentePremium.Location = new System.Drawing.Point(103, 324);
            this.chkDetergentePremium.Name = "chkDetergentePremium";
            this.chkDetergentePremium.Size = new System.Drawing.Size(152, 20);
            this.chkDetergentePremium.TabIndex = 8;
            this.chkDetergentePremium.Text = "Detergente Premium";
            this.chkDetergentePremium.UseVisualStyleBackColor = true;
            // 
            // textNumeroOrden
            // 
            this.textNumeroOrden.Location = new System.Drawing.Point(358, 32);
            this.textNumeroOrden.Name = "textNumeroOrden";
            this.textNumeroOrden.Size = new System.Drawing.Size(100, 22);
            this.textNumeroOrden.TabIndex = 9;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(358, 69);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 22);
            this.textNombre.TabIndex = 10;
            // 
            // textCarnet
            // 
            this.textCarnet.Location = new System.Drawing.Point(358, 178);
            this.textCarnet.Name = "textCarnet";
            this.textCarnet.Size = new System.Drawing.Size(100, 22);
            this.textCarnet.TabIndex = 11;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(358, 117);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(100, 22);
            this.textTelefono.TabIndex = 12;
            // 
            // textRecibo
            // 
            this.textRecibo.Location = new System.Drawing.Point(358, 308);
            this.textRecibo.Multiline = true;
            this.textRecibo.Name = "textRecibo";
            this.textRecibo.ReadOnly = true;
            this.textRecibo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textRecibo.Size = new System.Drawing.Size(267, 167);
            this.textRecibo.TabIndex = 13;
            // 
            // numPrendas
            // 
            this.numPrendas.Location = new System.Drawing.Point(358, 216);
            this.numPrendas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrendas.Name = "numPrendas";
            this.numPrendas.Size = new System.Drawing.Size(120, 22);
            this.numPrendas.TabIndex = 14;
            this.numPrendas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbTipoRopa
            // 
            this.cmbTipoRopa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoRopa.FormattingEnabled = true;
            this.cmbTipoRopa.Location = new System.Drawing.Point(358, 256);
            this.cmbTipoRopa.Name = "cmbTipoRopa";
            this.cmbTipoRopa.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoRopa.TabIndex = 15;
            // 
            // btnGenerarRecibo
            // 
            this.btnGenerarRecibo.Location = new System.Drawing.Point(103, 354);
            this.btnGenerarRecibo.Name = "btnGenerarRecibo";
            this.btnGenerarRecibo.Size = new System.Drawing.Size(121, 23);
            this.btnGenerarRecibo.TabIndex = 16;
            this.btnGenerarRecibo.Text = "Generar Recibo";
            this.btnGenerarRecibo.UseVisualStyleBackColor = true;
            // 
            // dgvMaquinas
            // 
            this.dgvMaquinas.AllowUserToAddRows = false;
            this.dgvMaquinas.AllowUserToDeleteRows = false;
            this.dgvMaquinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinas.Location = new System.Drawing.Point(114, 123);
            this.dgvMaquinas.MultiSelect = false;
            this.dgvMaquinas.Name = "dgvMaquinas";
            this.dgvMaquinas.ReadOnly = true;
            this.dgvMaquinas.RowHeadersWidth = 51;
            this.dgvMaquinas.RowTemplate.Height = 24;
            this.dgvMaquinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaquinas.Size = new System.Drawing.Size(395, 195);
            this.dgvMaquinas.TabIndex = 0;
            // 
            // btnIniciarMaquina
            // 
            this.btnIniciarMaquina.Location = new System.Drawing.Point(114, 378);
            this.btnIniciarMaquina.Name = "btnIniciarMaquina";
            this.btnIniciarMaquina.Size = new System.Drawing.Size(151, 23);
            this.btnIniciarMaquina.TabIndex = 1;
            this.btnIniciarMaquina.Text = "Iniciar Maquina";
            this.btnIniciarMaquina.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Control de Maquina";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Reportes Administrativos";
            // 
            // lblVentasTitulo
            // 
            this.lblVentasTitulo.AutoSize = true;
            this.lblVentasTitulo.Location = new System.Drawing.Point(116, 91);
            this.lblVentasTitulo.Name = "lblVentasTitulo";
            this.lblVentasTitulo.Size = new System.Drawing.Size(140, 16);
            this.lblVentasTitulo.TabIndex = 1;
            this.lblVentasTitulo.Text = "Total vendido del día: ";
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Location = new System.Drawing.Point(116, 142);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(44, 16);
            this.lblTotalVentas.TabIndex = 2;
            this.lblTotalVentas.Text = "Q 0.00";
            // 
            // lblDecuentosTitulo
            // 
            this.lblDecuentosTitulo.AutoSize = true;
            this.lblDecuentosTitulo.Location = new System.Drawing.Point(116, 191);
            this.lblDecuentosTitulo.Name = "lblDecuentosTitulo";
            this.lblDecuentosTitulo.Size = new System.Drawing.Size(180, 16);
            this.lblDecuentosTitulo.TabIndex = 3;
            this.lblDecuentosTitulo.Text = "Total de descuentos del día: ";
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.Location = new System.Drawing.Point(119, 322);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new System.Drawing.Size(125, 23);
            this.btnCierreCaja.TabIndex = 4;
            this.btnCierreCaja.Text = "Cierre de Caja";
            this.btnCierreCaja.UseVisualStyleBackColor = true;
            // 
            // btnGuardarResumen
            // 
            this.btnGuardarResumen.Location = new System.Drawing.Point(119, 383);
            this.btnGuardarResumen.Name = "btnGuardarResumen";
            this.btnGuardarResumen.Size = new System.Drawing.Size(160, 23);
            this.btnGuardarResumen.TabIndex = 5;
            this.btnGuardarResumen.Text = "Guardar Resumen";
            this.btnGuardarResumen.UseVisualStyleBackColor = true;
            // 
            // lblTotalDescuentos
            // 
            this.lblTotalDescuentos.AutoSize = true;
            this.lblTotalDescuentos.Location = new System.Drawing.Point(116, 247);
            this.lblTotalDescuentos.Name = "lblTotalDescuentos";
            this.lblTotalDescuentos.Size = new System.Drawing.Size(44, 16);
            this.lblTotalDescuentos.TabIndex = 6;
            this.lblTotalDescuentos.Text = "Q 0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 551);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRecibo;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textCarnet;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textNumeroOrden;
        private System.Windows.Forms.CheckBox chkDetergentePremium;
        private System.Windows.Forms.CheckBox chkPlanchado;
        private System.Windows.Forms.CheckBox chkEstudiante;
        private System.Windows.Forms.Button btnGenerarRecibo;
        private System.Windows.Forms.ComboBox cmbTipoRopa;
        private System.Windows.Forms.NumericUpDown numPrendas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIniciarMaquina;
        private System.Windows.Forms.DataGridView dgvMaquinas;
        private System.Windows.Forms.Button btnGuardarResumen;
        private System.Windows.Forms.Button btnCierreCaja;
        private System.Windows.Forms.Label lblDecuentosTitulo;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Label lblVentasTitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalDescuentos;
    }
}

