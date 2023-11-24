namespace UI
{
    partial class FormInicio
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
            this.BIENVENIDOS = new System.Windows.Forms.Label();
            this.btnGestion1 = new System.Windows.Forms.Button();
            this.btnGestion2 = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnGestion3 = new System.Windows.Forms.Button();
            this.btnMetodosPago = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BIENVENIDOS
            // 
            this.BIENVENIDOS.AutoSize = true;
            this.BIENVENIDOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIENVENIDOS.Location = new System.Drawing.Point(12, 9);
            this.BIENVENIDOS.Name = "BIENVENIDOS";
            this.BIENVENIDOS.Size = new System.Drawing.Size(148, 24);
            this.BIENVENIDOS.TabIndex = 0;
            this.BIENVENIDOS.Text = "BIENVENIDOS";
            // 
            // btnGestion1
            // 
            this.btnGestion1.Location = new System.Drawing.Point(12, 98);
            this.btnGestion1.Name = "btnGestion1";
            this.btnGestion1.Size = new System.Drawing.Size(75, 42);
            this.btnGestion1.TabIndex = 2;
            this.btnGestion1.Text = "Gestion Clientes";
            this.btnGestion1.UseVisualStyleBackColor = true;
            this.btnGestion1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGestion2
            // 
            this.btnGestion2.Location = new System.Drawing.Point(104, 98);
            this.btnGestion2.Name = "btnGestion2";
            this.btnGestion2.Size = new System.Drawing.Size(75, 42);
            this.btnGestion2.TabIndex = 5;
            this.btnGestion2.Text = "Gestion Producto";
            this.btnGestion2.UseVisualStyleBackColor = true;
            this.btnGestion2.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(449, 98);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(117, 42);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "Realizar Compra";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnGestion3
            // 
            this.btnGestion3.Location = new System.Drawing.Point(194, 98);
            this.btnGestion3.Name = "btnGestion3";
            this.btnGestion3.Size = new System.Drawing.Size(108, 42);
            this.btnGestion3.TabIndex = 18;
            this.btnGestion3.Text = "Gestion Ventas Realizadas";
            this.btnGestion3.UseVisualStyleBackColor = true;
            this.btnGestion3.Click += new System.EventHandler(this.btnGestion3_Click);
            // 
            // btnMetodosPago
            // 
            this.btnMetodosPago.Location = new System.Drawing.Point(322, 98);
            this.btnMetodosPago.Name = "btnMetodosPago";
            this.btnMetodosPago.Size = new System.Drawing.Size(108, 42);
            this.btnMetodosPago.TabIndex = 19;
            this.btnMetodosPago.Text = "Gestion de Metodos de Pago";
            this.btnMetodosPago.UseVisualStyleBackColor = true;
            this.btnMetodosPago.Click += new System.EventHandler(this.btnMetodosPago_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMetodosPago);
            this.Controls.Add(this.btnGestion3);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnGestion2);
            this.Controls.Add(this.btnGestion1);
            this.Controls.Add(this.BIENVENIDOS);
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BIENVENIDOS;
        private System.Windows.Forms.Button btnGestion1;
        private System.Windows.Forms.Button btnGestion2;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnGestion3;
        private System.Windows.Forms.Button btnMetodosPago;
    }
}