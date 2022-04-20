namespace PI_2022_I_P3_EQUIPO2.gui
{
    partial class frmEquipaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipaje));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEquipaje = new System.Windows.Forms.Label();
            this.cbxEquipaje = new System.Windows.Forms.ComboBox();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSiguientRegistro = new System.Windows.Forms.Button();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtNumeroBoleto = new System.Windows.Forms.TextBox();
            this.txtAerolinea = new System.Windows.Forms.TextBox();
            this.txtClaseBoleto = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblNumeroBoleto = new System.Windows.Forms.Label();
            this.lblTipoEquipaje = new System.Windows.Forms.Label();
            this.lblClaseBoleto = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblAerolinea = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
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
            // lblEquipaje
            // 
            this.lblEquipaje.AutoSize = true;
            this.lblEquipaje.Location = new System.Drawing.Point(639, 408);
            this.lblEquipaje.Name = "lblEquipaje";
            this.lblEquipaje.Size = new System.Drawing.Size(52, 15);
            this.lblEquipaje.TabIndex = 44;
            this.lblEquipaje.Text = "Equipaje";
            // 
            // cbxEquipaje
            // 
            this.cbxEquipaje.FormattingEnabled = true;
            this.cbxEquipaje.Location = new System.Drawing.Point(707, 400);
            this.cbxEquipaje.Name = "cbxEquipaje";
            this.cbxEquipaje.Size = new System.Drawing.Size(121, 23);
            this.cbxEquipaje.TabIndex = 43;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.BackgroundColor = System.Drawing.Color.White;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(39, 400);
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
            this.btnMostrar.Location = new System.Drawing.Point(707, 251);
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
            this.btnSeleccionar.Location = new System.Drawing.Point(707, 310);
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
            this.btnSiguientRegistro.Location = new System.Drawing.Point(707, 187);
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
            this.btnAbrirArchivo.Location = new System.Drawing.Point(707, 123);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(144, 37);
            this.btnAbrirArchivo.TabIndex = 57;
            this.btnAbrirArchivo.Text = "Abrir Archivo";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(137, 95);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(140, 23);
            this.txtId.TabIndex = 159;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(80, 103);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 158;
            this.lblId.Text = "ID";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(464, 340);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(140, 23);
            this.txtDestino.TabIndex = 157;
            // 
            // txtNumeroBoleto
            // 
            this.txtNumeroBoleto.Location = new System.Drawing.Point(464, 281);
            this.txtNumeroBoleto.Name = "txtNumeroBoleto";
            this.txtNumeroBoleto.Size = new System.Drawing.Size(140, 23);
            this.txtNumeroBoleto.TabIndex = 156;
            // 
            // txtAerolinea
            // 
            this.txtAerolinea.Location = new System.Drawing.Point(464, 217);
            this.txtAerolinea.Name = "txtAerolinea";
            this.txtAerolinea.Size = new System.Drawing.Size(140, 23);
            this.txtAerolinea.TabIndex = 155;
            // 
            // txtClaseBoleto
            // 
            this.txtClaseBoleto.Location = new System.Drawing.Point(464, 155);
            this.txtClaseBoleto.Name = "txtClaseBoleto";
            this.txtClaseBoleto.Size = new System.Drawing.Size(140, 23);
            this.txtClaseBoleto.TabIndex = 154;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(338, 347);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(47, 15);
            this.lblDestino.TabIndex = 153;
            this.lblDestino.Text = "Destino";
            // 
            // lblNumeroBoleto
            // 
            this.lblNumeroBoleto.AutoSize = true;
            this.lblNumeroBoleto.Location = new System.Drawing.Point(338, 288);
            this.lblNumeroBoleto.Name = "lblNumeroBoleto";
            this.lblNumeroBoleto.Size = new System.Drawing.Size(104, 15);
            this.lblNumeroBoleto.TabIndex = 152;
            this.lblNumeroBoleto.Text = "Numero de Boleto";
            // 
            // lblTipoEquipaje
            // 
            this.lblTipoEquipaje.AutoSize = true;
            this.lblTipoEquipaje.Location = new System.Drawing.Point(47, 347);
            this.lblTipoEquipaje.Name = "lblTipoEquipaje";
            this.lblTipoEquipaje.Size = new System.Drawing.Size(32, 15);
            this.lblTipoEquipaje.TabIndex = 151;
            this.lblTipoEquipaje.Text = "Peso";
            // 
            // lblClaseBoleto
            // 
            this.lblClaseBoleto.AutoSize = true;
            this.lblClaseBoleto.Location = new System.Drawing.Point(338, 160);
            this.lblClaseBoleto.Name = "lblClaseBoleto";
            this.lblClaseBoleto.Size = new System.Drawing.Size(69, 15);
            this.lblClaseBoleto.TabIndex = 150;
            this.lblClaseBoleto.Text = "ClaseBoleto";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(137, 339);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(140, 23);
            this.txtPeso.TabIndex = 149;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(137, 280);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(140, 23);
            this.txtHora.TabIndex = 148;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(137, 216);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(140, 23);
            this.txtCantidad.TabIndex = 147;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 154);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 23);
            this.txtNombre.TabIndex = 146;
            // 
            // lblAerolinea
            // 
            this.lblAerolinea.AutoSize = true;
            this.lblAerolinea.Location = new System.Drawing.Point(338, 226);
            this.lblAerolinea.Name = "lblAerolinea";
            this.lblAerolinea.Size = new System.Drawing.Size(57, 15);
            this.lblAerolinea.TabIndex = 145;
            this.lblAerolinea.Text = "Aerolinea";
            this.lblAerolinea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(47, 288);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 15);
            this.lblHora.TabIndex = 144;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(47, 224);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 143;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(47, 162);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 142;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEquipaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 578);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtNumeroBoleto);
            this.Controls.Add(this.txtAerolinea);
            this.Controls.Add(this.txtClaseBoleto);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblNumeroBoleto);
            this.Controls.Add(this.lblTipoEquipaje);
            this.Controls.Add(this.lblClaseBoleto);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblAerolinea);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnSiguientRegistro);
            this.Controls.Add(this.btnAbrirArchivo);
            this.Controls.Add(this.lblEquipaje);
            this.Controls.Add(this.cbxEquipaje);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEquipaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipaje";
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
        private Label lblEquipaje;
        private ComboBox cbxEquipaje;
        private DataGridView dgvMostrar;
        private Label lblSeleccionar;
        private Button btnMostrar;
        private Button btnSeleccionar;
        private Button btnSiguientRegistro;
        private Button btnAbrirArchivo;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtDestino;
        private TextBox txtNumeroBoleto;
        private TextBox txtAerolinea;
        private TextBox txtClaseBoleto;
        private Label lblDestino;
        private Label lblNumeroBoleto;
        private Label lblTipoEquipaje;
        private Label lblClaseBoleto;
        private TextBox txtPeso;
        private TextBox txtHora;
        private TextBox txtCantidad;
        private TextBox txtNombre;
        private Label lblAerolinea;
        private Label lblHora;
        private Label lblCantidad;
        private Label lblNombre;
    }
}