namespace PI_2022_I_P3_EQUIPO2.gui
{
    partial class frmPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersona));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPersona = new System.Windows.Forms.Label();
            this.cboPersona = new System.Windows.Forms.ComboBox();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSiguientRegistro = new System.Windows.Forms.Button();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNumeroPasaporte = new System.Windows.Forms.TextBox();
            this.txtNumeroIdentidad = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblIdentidad = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNumeroIdentidad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtRTN = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNumeroPasaporte = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblRTN = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
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
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(645, 406);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(49, 15);
            this.lblPersona.TabIndex = 44;
            this.lblPersona.Text = "Persona";
            // 
            // cboPersona
            // 
            this.cboPersona.FormattingEnabled = true;
            this.cboPersona.Location = new System.Drawing.Point(713, 398);
            this.cboPersona.Name = "cboPersona";
            this.cboPersona.Size = new System.Drawing.Size(121, 23);
            this.cboPersona.TabIndex = 43;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.BackgroundColor = System.Drawing.Color.White;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(45, 398);
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
            this.lblSeleccionar.Location = new System.Drawing.Point(205, 40);
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
            this.btnMostrar.Location = new System.Drawing.Point(713, 249);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(144, 37);
            this.btnMostrar.TabIndex = 60;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(713, 308);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(144, 36);
            this.btnSeleccionar.TabIndex = 59;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnSiguientRegistro
            // 
            this.btnSiguientRegistro.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSiguientRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguientRegistro.Image")));
            this.btnSiguientRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguientRegistro.Location = new System.Drawing.Point(713, 185);
            this.btnSiguientRegistro.Name = "btnSiguientRegistro";
            this.btnSiguientRegistro.Size = new System.Drawing.Size(144, 37);
            this.btnSiguientRegistro.TabIndex = 58;
            this.btnSiguientRegistro.Text = "Siguiente Registro";
            this.btnSiguientRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiguientRegistro.UseVisualStyleBackColor = true;
            this.btnSiguientRegistro.Click += new System.EventHandler(this.btnSiguientRegistro_Click);
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirArchivo.Image")));
            this.btnAbrirArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirArchivo.Location = new System.Drawing.Point(713, 121);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(144, 37);
            this.btnAbrirArchivo.TabIndex = 57;
            this.btnAbrirArchivo.Text = "Abrir Archivo";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(142, 93);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(140, 23);
            this.txtId.TabIndex = 176;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(85, 101);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 175;
            this.lblId.Text = "ID";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(469, 344);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(140, 23);
            this.txtNacionalidad.TabIndex = 174;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(469, 285);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(140, 23);
            this.txtTelefono.TabIndex = 173;
            // 
            // txtNumeroPasaporte
            // 
            this.txtNumeroPasaporte.Location = new System.Drawing.Point(469, 221);
            this.txtNumeroPasaporte.Name = "txtNumeroPasaporte";
            this.txtNumeroPasaporte.Size = new System.Drawing.Size(140, 23);
            this.txtNumeroPasaporte.TabIndex = 172;
            // 
            // txtNumeroIdentidad
            // 
            this.txtNumeroIdentidad.Location = new System.Drawing.Point(469, 159);
            this.txtNumeroIdentidad.Name = "txtNumeroIdentidad";
            this.txtNumeroIdentidad.Size = new System.Drawing.Size(140, 23);
            this.txtNumeroIdentidad.TabIndex = 171;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(343, 351);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(77, 15);
            this.lblNacionalidad.TabIndex = 170;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblIdentidad
            // 
            this.lblIdentidad.AutoSize = true;
            this.lblIdentidad.Location = new System.Drawing.Point(52, 287);
            this.lblIdentidad.Name = "lblIdentidad";
            this.lblIdentidad.Size = new System.Drawing.Size(45, 15);
            this.lblIdentidad.TabIndex = 169;
            this.lblIdentidad.Text = "Genero";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(52, 351);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 168;
            this.lblEdad.Text = "Edad";
            // 
            // lblNumeroIdentidad
            // 
            this.lblNumeroIdentidad.AutoSize = true;
            this.lblNumeroIdentidad.Location = new System.Drawing.Point(343, 164);
            this.lblNumeroIdentidad.Name = "lblNumeroIdentidad";
            this.lblNumeroIdentidad.Size = new System.Drawing.Size(120, 15);
            this.lblNumeroIdentidad.TabIndex = 167;
            this.lblNumeroIdentidad.Text = "Numero de Identidad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(142, 343);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(140, 23);
            this.txtEdad.TabIndex = 166;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(142, 284);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(140, 23);
            this.txtGenero.TabIndex = 165;
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(142, 220);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Size = new System.Drawing.Size(140, 23);
            this.txtRTN.TabIndex = 164;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(142, 158);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 23);
            this.txtNombre.TabIndex = 163;
            // 
            // lblNumeroPasaporte
            // 
            this.lblNumeroPasaporte.AutoSize = true;
            this.lblNumeroPasaporte.Location = new System.Drawing.Point(343, 230);
            this.lblNumeroPasaporte.Name = "lblNumeroPasaporte";
            this.lblNumeroPasaporte.Size = new System.Drawing.Size(122, 15);
            this.lblNumeroPasaporte.TabIndex = 162;
            this.lblNumeroPasaporte.Text = "Numero de Pasaporte";
            this.lblNumeroPasaporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(343, 288);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 161;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRTN
            // 
            this.lblRTN.AutoSize = true;
            this.lblRTN.Location = new System.Drawing.Point(52, 228);
            this.lblRTN.Name = "lblRTN";
            this.lblRTN.Size = new System.Drawing.Size(28, 15);
            this.lblRTN.TabIndex = 160;
            this.lblRTN.Text = "RTN";
            this.lblRTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(52, 166);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 159;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 574);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNumeroPasaporte);
            this.Controls.Add(this.txtNumeroIdentidad);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblIdentidad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNumeroIdentidad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtRTN);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNumeroPasaporte);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblRTN);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnSiguientRegistro);
            this.Controls.Add(this.btnAbrirArchivo);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.cboPersona);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persona";
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
        private Label lblPersona;
        private ComboBox cboPersona;
        private DataGridView dgvMostrar;
        private Label lblSeleccionar;
        private Button btnMostrar;
        private Button btnSeleccionar;
        private Button btnSiguientRegistro;
        private Button btnAbrirArchivo;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtNacionalidad;
        private TextBox txtTelefono;
        private TextBox txtNumeroPasaporte;
        private TextBox txtNumeroIdentidad;
        private Label lblNacionalidad;
        private Label lblIdentidad;
        private Label lblEdad;
        private Label lblNumeroIdentidad;
        private TextBox txtEdad;
        private TextBox txtGenero;
        private TextBox txtRTN;
        private TextBox txtNombre;
        private Label lblNumeroPasaporte;
        private Label lblTelefono;
        private Label lblRTN;
        private Label lblNombre;
    }
}