namespace UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComprar));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.cmbDni = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNroVenta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTarjeta = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_numeric = new UI.lbl_numeric();
            this.btnSeleccionar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGdetalleView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnFinalizarVentas = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGdetalleView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDni
            // 
            this.cmbDni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDni.FormattingEnabled = true;
            this.cmbDni.Location = new System.Drawing.Point(4, 29);
            this.cmbDni.Name = "cmbDni";
            this.cmbDni.Size = new System.Drawing.Size(121, 21);
            this.cmbDni.TabIndex = 0;
            this.cmbDni.SelectedValueChanged += new System.EventHandler(this.cmbDni_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenidos! Tu compra esta a un click....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dni cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Monto Acumulado: ";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(116, 370);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(52, 13);
            this.lblMonto.TabIndex = 6;
            this.lblMonto.Text = "---------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Numero Venta:";
            // 
            // lblNroVenta
            // 
            this.lblNroVenta.AutoSize = true;
            this.lblNroVenta.Location = new System.Drawing.Point(116, 353);
            this.lblNroVenta.Name = "lblNroVenta";
            this.lblNroVenta.Size = new System.Drawing.Size(52, 13);
            this.lblNroVenta.TabIndex = 8;
            this.lblNroVenta.Text = "---------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 11);
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
            this.cmbProducto.Location = new System.Drawing.Point(9, 55);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(153, 21);
            this.cmbProducto.TabIndex = 11;
            this.cmbProducto.SelectionChangeCommitted += new System.EventHandler(this.cmbProducto_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Producto";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(878, 5);
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
            this.label9.Location = new System.Drawing.Point(1, 53);
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
            this.cmbTarjeta.Location = new System.Drawing.Point(4, 69);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(121, 21);
            this.cmbTarjeta.TabIndex = 18;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.White;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(7, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(201, 20);
            this.lblCliente.TabIndex = 20;
            this.lblCliente.Text = "Si aun no sos cliente =>";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.btnRegistro);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Location = new System.Drawing.Point(627, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 41);
            this.panel1.TabIndex = 22;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistro.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistro.Location = new System.Drawing.Point(214, 0);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(103, 41);
            this.btnRegistro.TabIndex = 27;
            this.btnRegistro.Text = "REGISTRARSE";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.lbl_numeric);
            this.panel2.Controls.Add(this.btnSeleccionar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbProducto);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(6, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 159);
            this.panel2.TabIndex = 23;
            // 
            // lbl_numeric
            // 
            this.lbl_numeric.Location = new System.Drawing.Point(10, 83);
            this.lbl_numeric.Name = "lbl_numeric";
            this.lbl_numeric.Size = new System.Drawing.Size(137, 44);
            this.lbl_numeric.TabIndex = 27;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AllowAnimations = true;
            this.btnSeleccionar.AllowMouseEffects = true;
            this.btnSeleccionar.AllowToggling = false;
            this.btnSeleccionar.AnimationSpeed = 200;
            this.btnSeleccionar.AutoGenerateColors = false;
            this.btnSeleccionar.AutoRoundBorders = false;
            this.btnSeleccionar.AutoSizeLeftIcon = true;
            this.btnSeleccionar.AutoSizeRightIcon = true;
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSeleccionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.BackgroundImage")));
            this.btnSeleccionar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSeleccionar.ButtonText = "Seleccionar";
            this.btnSeleccionar.ButtonTextMarginLeft = 0;
            this.btnSeleccionar.ColorContrastOnClick = 45;
            this.btnSeleccionar.ColorContrastOnHover = 45;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSeleccionar.CustomizableEdges = borderEdges1;
            this.btnSeleccionar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeleccionar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSeleccionar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSeleccionar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSeleccionar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.IconLeft = null;
            this.btnSeleccionar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSeleccionar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSeleccionar.IconMarginLeft = 11;
            this.btnSeleccionar.IconPadding = 10;
            this.btnSeleccionar.IconRight = null;
            this.btnSeleccionar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSeleccionar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSeleccionar.IconSize = 25;
            this.btnSeleccionar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSeleccionar.IdleBorderRadius = 0;
            this.btnSeleccionar.IdleBorderThickness = 0;
            this.btnSeleccionar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSeleccionar.IdleIconLeftImage = null;
            this.btnSeleccionar.IdleIconRightImage = null;
            this.btnSeleccionar.IndicateFocus = false;
            this.btnSeleccionar.Location = new System.Drawing.Point(27, 133);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSeleccionar.OnDisabledState.BorderRadius = 1;
            this.btnSeleccionar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSeleccionar.OnDisabledState.BorderThickness = 1;
            this.btnSeleccionar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSeleccionar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSeleccionar.OnDisabledState.IconLeftImage = null;
            this.btnSeleccionar.OnDisabledState.IconRightImage = null;
            this.btnSeleccionar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSeleccionar.onHoverState.BorderRadius = 1;
            this.btnSeleccionar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSeleccionar.onHoverState.BorderThickness = 1;
            this.btnSeleccionar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSeleccionar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.onHoverState.IconLeftImage = null;
            this.btnSeleccionar.onHoverState.IconRightImage = null;
            this.btnSeleccionar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSeleccionar.OnIdleState.BorderRadius = 1;
            this.btnSeleccionar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSeleccionar.OnIdleState.BorderThickness = 1;
            this.btnSeleccionar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSeleccionar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.OnIdleState.IconLeftImage = null;
            this.btnSeleccionar.OnIdleState.IconRightImage = null;
            this.btnSeleccionar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSeleccionar.OnPressedState.BorderRadius = 1;
            this.btnSeleccionar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSeleccionar.OnPressedState.BorderThickness = 1;
            this.btnSeleccionar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSeleccionar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.OnPressedState.IconLeftImage = null;
            this.btnSeleccionar.OnPressedState.IconRightImage = null;
            this.btnSeleccionar.Size = new System.Drawing.Size(120, 23);
            this.btnSeleccionar.TabIndex = 27;
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSeleccionar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSeleccionar.TextMarginLeft = 0;
            this.btnSeleccionar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSeleccionar.UseDefaultRadiusAndThickness = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cmbTarjeta);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cmbDni);
            this.panel3.Location = new System.Drawing.Point(7, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 107);
            this.panel3.TabIndex = 24;
            // 
            // DGdetalleView
            // 
            this.DGdetalleView.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DGdetalleView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGdetalleView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGdetalleView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGdetalleView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGdetalleView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGdetalleView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGdetalleView.ColumnHeadersHeight = 40;
            this.DGdetalleView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DGdetalleView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGdetalleView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGdetalleView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DGdetalleView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGdetalleView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DGdetalleView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DGdetalleView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.DGdetalleView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DGdetalleView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGdetalleView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.DGdetalleView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DGdetalleView.CurrentTheme.Name = null;
            this.DGdetalleView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGdetalleView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGdetalleView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGdetalleView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DGdetalleView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGdetalleView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGdetalleView.EnableHeadersVisualStyles = false;
            this.DGdetalleView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DGdetalleView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DGdetalleView.HeaderBgColor = System.Drawing.Color.Empty;
            this.DGdetalleView.HeaderForeColor = System.Drawing.Color.White;
            this.DGdetalleView.Location = new System.Drawing.Point(275, 99);
            this.DGdetalleView.Name = "DGdetalleView";
            this.DGdetalleView.RowHeadersVisible = false;
            this.DGdetalleView.RowTemplate.Height = 40;
            this.DGdetalleView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGdetalleView.Size = new System.Drawing.Size(669, 450);
            this.DGdetalleView.TabIndex = 25;
            this.DGdetalleView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // btnFinalizarVentas
            // 
            this.btnFinalizarVentas.AllowAnimations = true;
            this.btnFinalizarVentas.AllowMouseEffects = true;
            this.btnFinalizarVentas.AllowToggling = false;
            this.btnFinalizarVentas.AnimationSpeed = 200;
            this.btnFinalizarVentas.AutoGenerateColors = false;
            this.btnFinalizarVentas.AutoRoundBorders = false;
            this.btnFinalizarVentas.AutoSizeLeftIcon = true;
            this.btnFinalizarVentas.AutoSizeRightIcon = true;
            this.btnFinalizarVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarVentas.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnFinalizarVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinalizarVentas.BackgroundImage")));
            this.btnFinalizarVentas.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinalizarVentas.ButtonText = "Finalizar Venta";
            this.btnFinalizarVentas.ButtonTextMarginLeft = 0;
            this.btnFinalizarVentas.ColorContrastOnClick = 45;
            this.btnFinalizarVentas.ColorContrastOnHover = 45;
            this.btnFinalizarVentas.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnFinalizarVentas.CustomizableEdges = borderEdges2;
            this.btnFinalizarVentas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFinalizarVentas.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFinalizarVentas.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnFinalizarVentas.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnFinalizarVentas.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFinalizarVentas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFinalizarVentas.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVentas.IconLeft = null;
            this.btnFinalizarVentas.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizarVentas.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFinalizarVentas.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnFinalizarVentas.IconMarginLeft = 11;
            this.btnFinalizarVentas.IconPadding = 10;
            this.btnFinalizarVentas.IconRight = null;
            this.btnFinalizarVentas.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizarVentas.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFinalizarVentas.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnFinalizarVentas.IconSize = 25;
            this.btnFinalizarVentas.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnFinalizarVentas.IdleBorderRadius = 0;
            this.btnFinalizarVentas.IdleBorderThickness = 0;
            this.btnFinalizarVentas.IdleFillColor = System.Drawing.Color.Empty;
            this.btnFinalizarVentas.IdleIconLeftImage = null;
            this.btnFinalizarVentas.IdleIconRightImage = null;
            this.btnFinalizarVentas.IndicateFocus = false;
            this.btnFinalizarVentas.Location = new System.Drawing.Point(7, 405);
            this.btnFinalizarVentas.Name = "btnFinalizarVentas";
            this.btnFinalizarVentas.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFinalizarVentas.OnDisabledState.BorderRadius = 1;
            this.btnFinalizarVentas.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinalizarVentas.OnDisabledState.BorderThickness = 1;
            this.btnFinalizarVentas.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFinalizarVentas.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFinalizarVentas.OnDisabledState.IconLeftImage = null;
            this.btnFinalizarVentas.OnDisabledState.IconRightImage = null;
            this.btnFinalizarVentas.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnFinalizarVentas.onHoverState.BorderRadius = 1;
            this.btnFinalizarVentas.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinalizarVentas.onHoverState.BorderThickness = 1;
            this.btnFinalizarVentas.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnFinalizarVentas.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVentas.onHoverState.IconLeftImage = null;
            this.btnFinalizarVentas.onHoverState.IconRightImage = null;
            this.btnFinalizarVentas.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnFinalizarVentas.OnIdleState.BorderRadius = 1;
            this.btnFinalizarVentas.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinalizarVentas.OnIdleState.BorderThickness = 1;
            this.btnFinalizarVentas.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnFinalizarVentas.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVentas.OnIdleState.IconLeftImage = null;
            this.btnFinalizarVentas.OnIdleState.IconRightImage = null;
            this.btnFinalizarVentas.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFinalizarVentas.OnPressedState.BorderRadius = 1;
            this.btnFinalizarVentas.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFinalizarVentas.OnPressedState.BorderThickness = 1;
            this.btnFinalizarVentas.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFinalizarVentas.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVentas.OnPressedState.IconLeftImage = null;
            this.btnFinalizarVentas.OnPressedState.IconRightImage = null;
            this.btnFinalizarVentas.Size = new System.Drawing.Size(201, 22);
            this.btnFinalizarVentas.TabIndex = 26;
            this.btnFinalizarVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinalizarVentas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFinalizarVentas.TextMarginLeft = 0;
            this.btnFinalizarVentas.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFinalizarVentas.UseDefaultRadiusAndThickness = true;
            this.btnFinalizarVentas.Click += new System.EventHandler(this.btnFinalizarVentas_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 45;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(462, 3);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(90, 90);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 27;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // FormComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(956, 561);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.btnFinalizarVentas);
            this.Controls.Add(this.DGdetalleView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblNroVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormComprar";
            this.Text = "FormComprar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGdetalleView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNroVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTarjeta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuDataGridView DGdetalleView;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFinalizarVentas;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSeleccionar;
        private lbl_numeric lbl_numeric;
        private System.Windows.Forms.Button btnRegistro;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}