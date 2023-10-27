namespace UI
{
    partial class FormDetalles
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
            this.DGdetallesView = new System.Windows.Forms.DataGridView();
            this.cmbDetalles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarDetalles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.DGventaView = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGdetallesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGventaView)).BeginInit();
            this.SuspendLayout();
            // 
            // DGdetallesView
            // 
            this.DGdetallesView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGdetallesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGdetallesView.Location = new System.Drawing.Point(2, 201);
            this.DGdetallesView.Name = "DGdetallesView";
            this.DGdetallesView.ReadOnly = true;
            this.DGdetallesView.Size = new System.Drawing.Size(460, 237);
            this.DGdetallesView.TabIndex = 0;
            // 
            // cmbDetalles
            // 
            this.cmbDetalles.FormattingEnabled = true;
            this.cmbDetalles.Location = new System.Drawing.Point(9, 60);
            this.cmbDetalles.Name = "cmbDetalles";
            this.cmbDetalles.Size = new System.Drawing.Size(121, 21);
            this.cmbDetalles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Venta";
            // 
            // btnMostrarDetalles
            // 
            this.btnMostrarDetalles.Location = new System.Drawing.Point(24, 88);
            this.btnMostrarDetalles.Name = "btnMostrarDetalles";
            this.btnMostrarDetalles.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarDetalles.TabIndex = 3;
            this.btnMostrarDetalles.Text = "Mostrar";
            this.btnMostrarDetalles.UseVisualStyleBackColor = true;
            this.btnMostrarDetalles.Click += new System.EventHandler(this.btnMostrarDetalles_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "DETALLES DE VENTA";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(82, 178);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(0, 20);
            this.lblMonto.TabIndex = 6;
            // 
            // DGventaView
            // 
            this.DGventaView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGventaView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGventaView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGventaView.Location = new System.Drawing.Point(160, 44);
            this.DGventaView.Name = "DGventaView";
            this.DGventaView.ReadOnly = true;
            this.DGventaView.Size = new System.Drawing.Size(312, 151);
            this.DGventaView.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(713, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.DGventaView);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrarDetalles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDetalles);
            this.Controls.Add(this.DGdetallesView);
            this.Name = "FormDetalles";
            this.Text = "DETALLES DE VENTA";
            ((System.ComponentModel.ISupportInitialize)(this.DGdetallesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGventaView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGdetallesView;
        private System.Windows.Forms.ComboBox cmbDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarDetalles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.DataGridView DGventaView;
        private System.Windows.Forms.Button btnSalir;
    }
}