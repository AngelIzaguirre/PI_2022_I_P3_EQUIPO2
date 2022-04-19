namespace PI_2022_I_P3_EQUIPO2.gui
{
    partial class frmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cbxEmpleado = new System.Windows.Forms.ComboBox();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSiguientRegistro = new System.Windows.Forms.Button();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.txtCiudadSalida = new System.Windows.Forms.TextBox();
            this.txtCiudadActual = new System.Windows.Forms.TextBox();
            this.txtTipoBoleto = new System.Windows.Forms.TextBox();
            this.txtNumeroBoleto = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtAerolinea = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNumeroContrato = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.menuPrincipalToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Archivo";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // menuPrincipalToolStripMenuItem1
            // 
            this.menuPrincipalToolStripMenuItem1.Name = "menuPrincipalToolStripMenuItem1";
            this.menuPrincipalToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.menuPrincipalToolStripMenuItem1.Text = "Menu principal";
            this.menuPrincipalToolStripMenuItem1.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(659, 400);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(60, 15);
            this.lblEmpleado.TabIndex = 44;
            this.lblEmpleado.Text = "Empleado";
            // 
            // cbxEmpleado
            // 
            this.cbxEmpleado.FormattingEnabled = true;
            this.cbxEmpleado.Location = new System.Drawing.Point(727, 392);
            this.cbxEmpleado.Name = "cbxEmpleado";
            this.cbxEmpleado.Size = new System.Drawing.Size(121, 23);
            this.cbxEmpleado.TabIndex = 43;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.BackgroundColor = System.Drawing.Color.White;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(59, 392);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.RowTemplate.Height = 25;
            this.dgvMostrar.Size = new System.Drawing.Size(563, 150);
            this.dgvMostrar.TabIndex = 38;
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSeleccionar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccionar.Location = new System.Drawing.Point(238, 38);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(344, 22);
            this.lblSeleccionar.TabIndex = 33;
            this.lblSeleccionar.Text = "Seleccione una de las siguientes opciones";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMostrar.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrar.Image")));
            this.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrar.Location = new System.Drawing.Point(727, 243);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(144, 37);
            this.btnMostrar.TabIndex = 60;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(727, 302);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(144, 36);
            this.btnSeleccionar.TabIndex = 59;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // btnSiguientRegistro
            // 
            this.btnSiguientRegistro.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSiguientRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguientRegistro.Image")));
            this.btnSiguientRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguientRegistro.Location = new System.Drawing.Point(727, 179);
            this.btnSiguientRegistro.Name = "btnSiguientRegistro";
            this.btnSiguientRegistro.Size = new System.Drawing.Size(144, 37);
            this.btnSiguientRegistro.TabIndex = 58;
            this.btnSiguientRegistro.Text = "Siguiente Registro";
            this.btnSiguientRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiguientRegistro.UseVisualStyleBackColor = true;
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirArchivo.Image")));
            this.btnAbrirArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirArchivo.Location = new System.Drawing.Point(727, 115);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(144, 37);
            this.btnAbrirArchivo.TabIndex = 57;
            this.btnAbrirArchivo.Text = "Abrir Archivo";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            // 
            // txtCiudadSalida
            // 
            this.txtCiudadSalida.Location = new System.Drawing.Point(484, 337);
            this.txtCiudadSalida.Name = "txtCiudadSalida";
            this.txtCiudadSalida.Size = new System.Drawing.Size(140, 23);
            this.txtCiudadSalida.TabIndex = 92;
            // 
            // txtCiudadActual
            // 
            this.txtCiudadActual.Location = new System.Drawing.Point(484, 278);
            this.txtCiudadActual.Name = "txtCiudadActual";
            this.txtCiudadActual.Size = new System.Drawing.Size(140, 23);
            this.txtCiudadActual.TabIndex = 91;
            // 
            // txtTipoBoleto
            // 
            this.txtTipoBoleto.Location = new System.Drawing.Point(484, 214);
            this.txtTipoBoleto.Name = "txtTipoBoleto";
            this.txtTipoBoleto.Size = new System.Drawing.Size(140, 23);
            this.txtTipoBoleto.TabIndex = 90;
            // 
            // txtNumeroBoleto
            // 
            this.txtNumeroBoleto.Location = new System.Drawing.Point(484, 152);
            this.txtNumeroBoleto.Name = "txtNumeroBoleto";
            this.txtNumeroBoleto.Size = new System.Drawing.Size(140, 23);
            this.txtNumeroBoleto.TabIndex = 89;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(358, 344);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(39, 15);
            this.lblCargo.TabIndex = 88;
            this.lblCargo.Text = "Cargo";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(358, 285);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 87;
            this.lblEdad.Text = "Edad";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(67, 344);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 15);
            this.lblGenero.TabIndex = 86;
            this.lblGenero.Text = "Genero";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(358, 157);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 85;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Location = new System.Drawing.Point(157, 336);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(140, 23);
            this.txtFechaActual.TabIndex = 84;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(157, 277);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(140, 23);
            this.txtCosto.TabIndex = 83;
            // 
            // txtAerolinea
            // 
            this.txtAerolinea.Location = new System.Drawing.Point(157, 213);
            this.txtAerolinea.Name = "txtAerolinea";
            this.txtAerolinea.Size = new System.Drawing.Size(140, 23);
            this.txtAerolinea.TabIndex = 82;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 151);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 23);
            this.txtNombre.TabIndex = 81;
            // 
            // lblNumeroContrato
            // 
            this.lblNumeroContrato.AutoSize = true;
            this.lblNumeroContrato.Location = new System.Drawing.Point(358, 223);
            this.lblNumeroContrato.Name = "lblNumeroContrato";
            this.lblNumeroContrato.Size = new System.Drawing.Size(117, 15);
            this.lblNumeroContrato.TabIndex = 80;
            this.lblNumeroContrato.Text = "Numero de Contrato";
            this.lblNumeroContrato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(67, 285);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 15);
            this.lblSalario.TabIndex = 79;
            this.lblSalario.Text = "Salario";
            this.lblSalario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(67, 221);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 78;
            this.lblDireccion.Text = "Direccion";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(67, 159);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 77;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(157, 98);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(140, 23);
            this.txtId.TabIndex = 102;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(100, 106);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 101;
            this.lblId.Text = "ID";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 565);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtCiudadSalida);
            this.Controls.Add(this.txtCiudadActual);
            this.Controls.Add(this.txtTipoBoleto);
            this.Controls.Add(this.txtNumeroBoleto);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtAerolinea);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNumeroContrato);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnSiguientRegistro);
            this.Controls.Add(this.btnAbrirArchivo);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.cbxEmpleado);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Label lblEmpleado;
        private ComboBox cbxEmpleado;
        private DataGridView dgvMostrar;
        private Label lblSeleccionar;
        private Button btnMostrar;
        private Button btnSeleccionar;
        private Button btnSiguientRegistro;
        private Button btnAbrirArchivo;
        private TextBox txtCiudadSalida;
        private TextBox txtCiudadActual;
        private TextBox txtTipoBoleto;
        private TextBox txtNumeroBoleto;
        private Label lblCargo;
        private Label lblEdad;
        private Label lblGenero;
        private Label lblTelefono;
        private TextBox txtFechaActual;
        private TextBox txtCosto;
        private TextBox txtAerolinea;
        private TextBox txtNombre;
        private Label lblNumeroContrato;
        private Label lblSalario;
        private Label lblDireccion;
        private Label lblNombre;
        private TextBox txtId;
        private Label lblId;
    }
}