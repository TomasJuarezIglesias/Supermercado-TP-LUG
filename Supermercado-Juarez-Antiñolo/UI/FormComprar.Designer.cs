﻿namespace UI
{
    partial class FormComprar
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
            this.cmbDni = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNroVenta = new System.Windows.Forms.Label();
            this.DGdetalleView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarProdu = new System.Windows.Forms.Button();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTarjeta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGdetalleView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDni
            // 
            this.cmbDni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDni.FormattingEnabled = true;
            this.cmbDni.Location = new System.Drawing.Point(7, 74);
            this.cmbDni.Name = "cmbDni";
            this.cmbDni.Size = new System.Drawing.Size(121, 21);
            this.cmbDni.TabIndex = 0;
            this.cmbDni.SelectedValueChanged += new System.EventHandler(this.cmbDni_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenidos! Tu compra esta a un click....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dni cliente";
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(7, 152);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(200, 20);
            this.datePick.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Monto Acumulado: ";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(742, 58);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(52, 13);
            this.lblMonto.TabIndex = 6;
            this.lblMonto.Text = "---------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(637, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Numero Venta:";
            // 
            // lblNroVenta
            // 
            this.lblNroVenta.AutoSize = true;
            this.lblNroVenta.Location = new System.Drawing.Point(742, 41);
            this.lblNroVenta.Name = "lblNroVenta";
            this.lblNroVenta.Size = new System.Drawing.Size(52, 13);
            this.lblNroVenta.TabIndex = 8;
            this.lblNroVenta.Text = "---------------";
            // 
            // DGdetalleView
            // 
            this.DGdetalleView.AllowUserToAddRows = false;
            this.DGdetalleView.AllowUserToDeleteRows = false;
            this.DGdetalleView.AllowUserToResizeColumns = false;
            this.DGdetalleView.AllowUserToResizeRows = false;
            this.DGdetalleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGdetalleView.Location = new System.Drawing.Point(224, 75);
            this.DGdetalleView.Name = "DGdetalleView";
            this.DGdetalleView.ReadOnly = true;
            this.DGdetalleView.Size = new System.Drawing.Size(570, 363);
            this.DGdetalleView.TabIndex = 9;
            this.DGdetalleView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGdetalleView_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "SELECCION DE PRODUCTOS";
            // 
            // cmbProducto
            // 
            this.cmbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(15, 238);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(153, 21);
            this.cmbProducto.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cantidad";
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(14, 278);
            this.numericCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(153, 20);
            this.numericCantidad.TabIndex = 14;
            this.numericCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregarProdu
            // 
            this.btnAgregarProdu.Location = new System.Drawing.Point(28, 304);
            this.btnAgregarProdu.Name = "btnAgregarProdu";
            this.btnAgregarProdu.Size = new System.Drawing.Size(116, 23);
            this.btnAgregarProdu.TabIndex = 15;
            this.btnAgregarProdu.Text = "Agregar Producto";
            this.btnAgregarProdu.UseVisualStyleBackColor = true;
            this.btnAgregarProdu.Click += new System.EventHandler(this.btnAgregarProdu_Click);
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.Location = new System.Drawing.Point(7, 400);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(200, 23);
            this.btnFinalizarVenta.TabIndex = 16;
            this.btnFinalizarVenta.Text = "Finalizar Venta";
            this.btnFinalizarVenta.UseVisualStyleBackColor = true;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.Location = new System.Drawing.Point(719, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Elegir Nro Tarjeta";
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTarjeta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarjeta.FormattingEnabled = true;
            this.cmbTarjeta.Location = new System.Drawing.Point(7, 114);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(121, 21);
            this.cmbTarjeta.TabIndex = 18;
            // 
            // FormComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbTarjeta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFinalizarVenta);
            this.Controls.Add(this.btnAgregarProdu);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DGdetalleView);
            this.Controls.Add(this.lblNroVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDni);
            this.Name = "FormComprar";
            this.Text = "FormComprar";
            ((System.ComponentModel.ISupportInitialize)(this.DGdetalleView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNroVenta;
        private System.Windows.Forms.DataGridView DGdetalleView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.Button btnAgregarProdu;
        private System.Windows.Forms.Button btnFinalizarVenta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTarjeta;
    }
}