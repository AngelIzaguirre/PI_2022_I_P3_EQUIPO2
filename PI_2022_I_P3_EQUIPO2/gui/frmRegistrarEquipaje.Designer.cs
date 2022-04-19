namespace PI_2022_I_P3_EQUIPO2.gui
{
    partial class frmRegistrarEquipaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarEquipaje));
            this.lblLlenar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLecturaEquipaje = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnGuardarComo = new System.Windows.Forms.Button();
            this.txtCiudadSalida = new System.Windows.Forms.TextBox();
            this.txtCiudadActual = new System.Windows.Forms.TextBox();
            this.txtTipoBoleto = new System.Windows.Forms.TextBox();
            this.txtNumeroBoleto = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblNumeroBoleto = new System.Windows.Forms.Label();
            this.lblTipoEquipaje = new System.Windows.Forms.Label();
            this.lblClaseBoleto = new System.Windows.Forms.Label();
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtAerolinea = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblAerolinea = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLlenar
            // 
            this.lblLlenar.AutoSize = true;
            this.lblLlenar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLlenar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLlenar.Location = new System.Drawing.Point(277, 41);
            this.lblLlenar.Name = "lblLlenar";
            this.lblLlenar.Size = new System.Drawing.Size(231, 22);
            this.lblLlenar.TabIndex = 99;
            this.lblLlenar.Text = "Llenar los siguientes datos ";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(671, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 31);
            this.btnSalir.TabIndex = 123;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLecturaEquipaje
            // 
            this.btnLecturaEquipaje.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLecturaEquipaje.Image = ((System.Drawing.Image)(resources.GetObject("btnLecturaEquipaje.Image")));
            this.btnLecturaEquipaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLecturaEquipaje.Location = new System.Drawing.Point(671, 294);
            this.btnLecturaEquipaje.Name = "btnLecturaEquipaje";
            this.btnLecturaEquipaje.Size = new System.Drawing.Size(135, 31);
            this.btnLecturaEquipaje.TabIndex = 122;
            this.btnLecturaEquipaje.Text = "Lectura Equipaje";
            this.btnLecturaEquipaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLecturaEquipaje.UseVisualStyleBackColor = true;
            this.btnLecturaEquipaje.Click += new System.EventHandler(this.btnLecturaEquipaje_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(671, 230);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(135, 31);
            this.btnRegistrar.TabIndex = 121;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarComo
            // 
            this.btnGuardarComo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarComo.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarComo.Image")));
            this.btnGuardarComo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarComo.Location = new System.Drawing.Point(671, 168);
            this.btnGuardarComo.Name = "btnGuardarComo";
            this.btnGuardarComo.Size = new System.Drawing.Size(135, 31);
            this.btnGuardarComo.TabIndex = 120;
            this.btnGuardarComo.Text = "Guardar Como";
            this.btnGuardarComo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarComo.UseVisualStyleBackColor = true;
            // 
            // txtCiudadSalida
            // 
            this.txtCiudadSalida.Location = new System.Drawing.Point(479, 359);
            this.txtCiudadSalida.Name = "txtCiudadSalida";
            this.txtCiudadSalida.Size = new System.Drawing.Size(140, 23);
            this.txtCiudadSalida.TabIndex = 139;
            // 
            // txtCiudadActual
            // 
            this.txtCiudadActual.Location = new System.Drawing.Point(479, 300);
            this.txtCiudadActual.Name = "txtCiudadActual";
            this.txtCiudadActual.Size = new System.Drawing.Size(140, 23);
            this.txtCiudadActual.TabIndex = 138;
            // 
            // txtTipoBoleto
            // 
            this.txtTipoBoleto.Location = new System.Drawing.Point(479, 236);
            this.txtTipoBoleto.Name = "txtTipoBoleto";
            this.txtTipoBoleto.Size = new System.Drawing.Size(140, 23);
            this.txtTipoBoleto.TabIndex = 137;
            // 
            // txtNumeroBoleto
            // 
            this.txtNumeroBoleto.Location = new System.Drawing.Point(479, 174);
            this.txtNumeroBoleto.Name = "txtNumeroBoleto";
            this.txtNumeroBoleto.Size = new System.Drawing.Size(140, 23);
            this.txtNumeroBoleto.TabIndex = 136;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(353, 366);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(47, 15);
            this.lblDestino.TabIndex = 135;
            this.lblDestino.Text = "Destino";
            // 
            // lblNumeroBoleto
            // 
            this.lblNumeroBoleto.AutoSize = true;
            this.lblNumeroBoleto.Location = new System.Drawing.Point(353, 307);
            this.lblNumeroBoleto.Name = "lblNumeroBoleto";
            this.lblNumeroBoleto.Size = new System.Drawing.Size(104, 15);
            this.lblNumeroBoleto.TabIndex = 134;
            this.lblNumeroBoleto.Text = "Numero de Boleto";
            // 
            // lblTipoEquipaje
            // 
            this.lblTipoEquipaje.AutoSize = true;
            this.lblTipoEquipaje.Location = new System.Drawing.Point(62, 366);
            this.lblTipoEquipaje.Name = "lblTipoEquipaje";
            this.lblTipoEquipaje.Size = new System.Drawing.Size(32, 15);
            this.lblTipoEquipaje.TabIndex = 133;
            this.lblTipoEquipaje.Text = "Peso";
            // 
            // lblClaseBoleto
            // 
            this.lblClaseBoleto.AutoSize = true;
            this.lblClaseBoleto.Location = new System.Drawing.Point(353, 179);
            this.lblClaseBoleto.Name = "lblClaseBoleto";
            this.lblClaseBoleto.Size = new System.Drawing.Size(69, 15);
            this.lblClaseBoleto.TabIndex = 132;
            this.lblClaseBoleto.Text = "ClaseBoleto";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Location = new System.Drawing.Point(152, 358);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(140, 23);
            this.txtFechaActual.TabIndex = 131;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(152, 299);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(140, 23);
            this.txtCosto.TabIndex = 130;
            // 
            // txtAerolinea
            // 
            this.txtAerolinea.Location = new System.Drawing.Point(152, 235);
            this.txtAerolinea.Name = "txtAerolinea";
            this.txtAerolinea.Size = new System.Drawing.Size(140, 23);
            this.txtAerolinea.TabIndex = 129;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(152, 173);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 23);
            this.txtNombre.TabIndex = 128;
            // 
            // lblAerolinea
            // 
            this.lblAerolinea.AutoSize = true;
            this.lblAerolinea.Location = new System.Drawing.Point(353, 245);
            this.lblAerolinea.Name = "lblAerolinea";
            this.lblAerolinea.Size = new System.Drawing.Size(57, 15);
            this.lblAerolinea.TabIndex = 127;
            this.lblAerolinea.Text = "Aerolinea";
            this.lblAerolinea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(62, 307);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 15);
            this.lblHora.TabIndex = 126;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(62, 243);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 125;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(62, 181);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 124;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(152, 114);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(140, 23);
            this.txtId.TabIndex = 141;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(95, 122);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 140;
            this.lblId.Text = "ID";
            // 
            // frmRegistrarEquipaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtCiudadSalida);
            this.Controls.Add(this.txtCiudadActual);
            this.Controls.Add(this.txtTipoBoleto);
            this.Controls.Add(this.txtNumeroBoleto);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblNumeroBoleto);
            this.Controls.Add(this.lblTipoEquipaje);
            this.Controls.Add(this.lblClaseBoleto);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtAerolinea);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblAerolinea);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLecturaEquipaje);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnGuardarComo);
            this.Controls.Add(this.lblLlenar);
            this.Name = "frmRegistrarEquipaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroEquipaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblLlenar;
        private Button btnSalir;
        private Button btnLecturaEquipaje;
        private Button btnRegistrar;
        private Button btnGuardarComo;
        private TextBox txtCiudadSalida;
        private TextBox txtCiudadActual;
        private TextBox txtTipoBoleto;
        private TextBox txtNumeroBoleto;
        private Label lblDestino;
        private Label lblNumeroBoleto;
        private Label lblTipoEquipaje;
        private Label lblClaseBoleto;
        private TextBox txtFechaActual;
        private TextBox txtCosto;
        private TextBox txtAerolinea;
        private TextBox txtNombre;
        private Label lblAerolinea;
        private Label lblHora;
        private Label lblCantidad;
        private Label lblNombre;
        private TextBox txtId;
        private Label lblId;
    }
}