namespace Examen_RentaCar_BerneyJadierGomezSantana
{
    partial class frmAlquiler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtVehiculo = new TextBox();
            txtTarifa = new TextBox();
            txtCliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpSalida = new DateTimePicker();
            nudDias = new NumericUpDown();
            rbtBasico = new RadioButton();
            radioButton1 = new RadioButton();
            chkCorporativo = new CheckBox();
            label7 = new Label();
            rbtSucursal = new RadioButton();
            rbtDomicilio = new RadioButton();
            chkGps = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            lblEncabezado = new Label();
            lstAlquileres = new ListBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            lblDomicilio = new Label();
            lblItbis = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            SuspendLayout();
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(106, 212);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(125, 27);
            txtVehiculo.TabIndex = 0;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(106, 273);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(125, 27);
            txtTarifa.TabIndex = 1;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(106, 48);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(125, 27);
            txtCliente.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 51);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 3;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 156);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "Salida:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 215);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 5;
            label3.Text = "Vehiculo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 397);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 6;
            label4.Text = "Seguro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 276);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 7;
            label5.Text = "Tarifa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 334);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 8;
            label6.Text = "Dias:";
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(106, 156);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(250, 27);
            dtpSalida.TabIndex = 9;
            // 
            // nudDias
            // 
            nudDias.Location = new Point(106, 332);
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(150, 27);
            nudDias.TabIndex = 10;
            // 
            // rbtBasico
            // 
            rbtBasico.AutoSize = true;
            rbtBasico.Location = new Point(87, 449);
            rbtBasico.Name = "rbtBasico";
            rbtBasico.Size = new Size(73, 24);
            rbtBasico.TabIndex = 11;
            rbtBasico.TabStop = true;
            rbtBasico.Text = "Basico";
            rbtBasico.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AccessibleDescription = "rbtCompleto";
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(87, 491);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(176, 24);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Completo (+ RD$300)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // chkCorporativo
            // 
            chkCorporativo.AutoSize = true;
            chkCorporativo.Location = new Point(44, 105);
            chkCorporativo.Name = "chkCorporativo";
            chkCorporativo.Size = new Size(158, 24);
            chkCorporativo.TabIndex = 13;
            chkCorporativo.Text = "Cliente corporativo";
            chkCorporativo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(321, 397);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 14;
            label7.Text = "Entrega";
            // 
            // rbtSucursal
            // 
            rbtSucursal.AutoSize = true;
            rbtSucursal.Location = new Point(321, 449);
            rbtSucursal.Name = "rbtSucursal";
            rbtSucursal.Size = new Size(102, 24);
            rbtSucursal.TabIndex = 15;
            rbtSucursal.TabStop = true;
            rbtSucursal.Text = "En sucursal";
            rbtSucursal.UseVisualStyleBackColor = true;
            // 
            // rbtDomicilio
            // 
            rbtDomicilio.AutoSize = true;
            rbtDomicilio.Location = new Point(321, 491);
            rbtDomicilio.Name = "rbtDomicilio";
            rbtDomicilio.Size = new Size(175, 24);
            rbtDomicilio.TabIndex = 16;
            rbtDomicilio.TabStop = true;
            rbtDomicilio.Text = "Domicilio (+ RD$500)";
            rbtDomicilio.UseVisualStyleBackColor = true;
            // 
            // chkGps
            // 
            chkGps.AutoSize = true;
            chkGps.Location = new Point(44, 560);
            chkGps.Name = "chkGps";
            chkGps.Size = new Size(185, 24);
            chkGps.TabIndex = 17;
            chkGps.Text = "GPS (+RD$100 por dia)";
            chkGps.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(49, 634);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(111, 29);
            btnCalcular.TabIndex = 18;
            btnCalcular.Text = "Calcular total";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(189, 634);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(129, 29);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Nuevo alquiler";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(346, 634);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(111, 29);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(597, 51);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(235, 29);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Agregar al alquiler";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Location = new Point(583, 163);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(34, 20);
            lblEncabezado.TabIndex = 22;
            lblEncabezado.Text = "lbl1";
            // 
            // lstAlquileres
            // 
            lstAlquileres.FormattingEnabled = true;
            lstAlquileres.Location = new Point(583, 195);
            lstAlquileres.Name = "lstAlquileres";
            lstAlquileres.Size = new Size(246, 124);
            lstAlquileres.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(588, 399);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 27;
            label12.Text = "Subtotal";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(588, 433);
            label13.Name = "label13";
            label13.Size = new Size(79, 20);
            label13.TabIndex = 28;
            label13.Text = "Descuento";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(588, 464);
            label14.Name = "label14";
            label14.Size = new Size(74, 20);
            label14.TabIndex = 29;
            label14.Text = "Domicilio";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(588, 495);
            label15.Name = "label15";
            label15.Size = new Size(84, 20);
            label15.TabIndex = 30;
            label15.Text = "ITBIS (18%)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(583, 618);
            label16.Name = "label16";
            label16.Size = new Size(114, 20);
            label16.TabIndex = 31;
            label16.Text = "TOTAL A PAGAR";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(702, 401);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(58, 20);
            lblSubtotal.TabIndex = 32;
            lblSubtotal.Text = "label17";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(702, 433);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(58, 20);
            lblDescuento.TabIndex = 33;
            lblDescuento.Text = "label18";
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Location = new Point(702, 464);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(58, 20);
            lblDomicilio.TabIndex = 34;
            lblDomicilio.Text = "label19";
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new Point(701, 495);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(58, 20);
            lblItbis.TabIndex = 35;
            lblItbis.Text = "label20";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(714, 618);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 20);
            lblTotal.TabIndex = 36;
            lblTotal.Text = "label17";
            // 
            // frmAlquiler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 702);
            Controls.Add(lblTotal);
            Controls.Add(lblItbis);
            Controls.Add(lblDomicilio);
            Controls.Add(lblDescuento);
            Controls.Add(lblSubtotal);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(lstAlquileres);
            Controls.Add(lblEncabezado);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(chkGps);
            Controls.Add(rbtDomicilio);
            Controls.Add(rbtSucursal);
            Controls.Add(label7);
            Controls.Add(chkCorporativo);
            Controls.Add(radioButton1);
            Controls.Add(rbtBasico);
            Controls.Add(nudDias);
            Controls.Add(dtpSalida);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCliente);
            Controls.Add(txtTarifa);
            Controls.Add(txtVehiculo);
            Name = "frmAlquiler";
            Text = "RentaCar Express - Alquileres";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVehiculo;
        private TextBox txtTarifa;
        private TextBox txtCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpSalida;
        private NumericUpDown nudDias;
        private RadioButton rbtBasico;
        private RadioButton radioButton1;
        private CheckBox chkCorporativo;
        private Label label7;
        private RadioButton rbtSucursal;
        private RadioButton rbtDomicilio;
        private CheckBox chkGps;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnAgregar;
        private Label lblEncabezado;
        private ListBox lstAlquileres;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblDomicilio;
        private Label lblItbis;
        private Label lblTotal;
    }
}
