namespace PresentacionGUI
{
    partial class FormVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVehiculo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonales = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtidconductor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtkilometros = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.aniouso = new System.Windows.Forms.NumericUpDown();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.listaVehiculos = new System.Windows.Forms.DataGridView();
            this.txtgasolina = new System.Windows.Forms.ComboBox();
            this.txtestado = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPersonales.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aniouso)).BeginInit();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPersonales);
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1134, 494);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPersonales
            // 
            this.tabPersonales.Controls.Add(this.groupBox2);
            this.tabPersonales.Location = new System.Drawing.Point(4, 29);
            this.tabPersonales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPersonales.Name = "tabPersonales";
            this.tabPersonales.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPersonales.Size = new System.Drawing.Size(1126, 461);
            this.tabPersonales.TabIndex = 0;
            this.tabPersonales.Text = "Registrar Conductores";
            this.tabPersonales.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtestado);
            this.groupBox2.Controls.Add(this.txtgasolina);
            this.groupBox2.Controls.Add(this.txtidconductor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.txtkilometros);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.aniouso);
            this.groupBox2.Controls.Add(this.txtplaca);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtmarca);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(172, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(795, 438);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtidconductor
            // 
            this.txtidconductor.Location = new System.Drawing.Point(264, 368);
            this.txtidconductor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtidconductor.Name = "txtidconductor";
            this.txtidconductor.Size = new System.Drawing.Size(214, 26);
            this.txtidconductor.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 372);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Id del conductor";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 263);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(584, 334);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 35);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 195);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(584, 123);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 35);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "CONSULTAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado del Vehiculo";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(584, 49);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(129, 35);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "GUARDAR";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtkilometros
            // 
            this.txtkilometros.Location = new System.Drawing.Point(264, 243);
            this.txtkilometros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtkilometros.Name = "txtkilometros";
            this.txtkilometros.Size = new System.Drawing.Size(214, 26);
            this.txtkilometros.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kilometros recorridos";
            // 
            // aniouso
            // 
            this.aniouso.Location = new System.Drawing.Point(264, 135);
            this.aniouso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aniouso.Name = "aniouso";
            this.aniouso.Size = new System.Drawing.Size(216, 26);
            this.aniouso.TabIndex = 9;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(264, 78);
            this.txtplaca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(214, 26);
            this.txtplaca.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Placa del Vehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Años de Uso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Gasolina";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(264, 20);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(214, 26);
            this.txtmarca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca del Vehiculo";
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.listaVehiculos);
            this.tabGeneral.Location = new System.Drawing.Point(4, 29);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabGeneral.Size = new System.Drawing.Size(1126, 461);
            this.tabGeneral.TabIndex = 1;
            this.tabGeneral.Text = "Ver listado de Vehiculos";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // listaVehiculos
            // 
            this.listaVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaVehiculos.Location = new System.Drawing.Point(4, 5);
            this.listaVehiculos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listaVehiculos.Name = "listaVehiculos";
            this.listaVehiculos.RowHeadersWidth = 62;
            this.listaVehiculos.Size = new System.Drawing.Size(1118, 451);
            this.listaVehiculos.TabIndex = 0;
            // 
            // txtgasolina
            // 
            this.txtgasolina.FormattingEnabled = true;
            this.txtgasolina.Items.AddRange(new object[] {
            "Corriente",
            "Diesel"});
            this.txtgasolina.Location = new System.Drawing.Point(264, 186);
            this.txtgasolina.Name = "txtgasolina";
            this.txtgasolina.Size = new System.Drawing.Size(216, 28);
            this.txtgasolina.TabIndex = 19;
            // 
            // txtestado
            // 
            this.txtestado.FormattingEnabled = true;
            this.txtestado.Items.AddRange(new object[] {
            "Nuevo",
            "Viejo",
            "Dañado"});
            this.txtestado.Location = new System.Drawing.Point(264, 300);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(216, 28);
            this.txtestado.TabIndex = 20;
            // 
            // FormVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1130, 494);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehiculos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVehiculo_FormClosing);
            this.Load += new System.EventHandler(this.FormVehiculo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPersonales.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aniouso)).EndInit();
            this.tabGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPersonales;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown aniouso;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.DataGridView listaVehiculos;
        private System.Windows.Forms.TextBox txtkilometros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtidconductor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtestado;
        private System.Windows.Forms.ComboBox txtgasolina;
    }
}