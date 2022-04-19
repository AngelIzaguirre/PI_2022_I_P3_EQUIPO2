namespace PI_2022_I_P3_EQUIPO2.gui
{
    partial class frmRegistrarPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarPersona));
            this.lblLlenar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLecturaPersona = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnGuardarComo = new System.Windows.Forms.Button();
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLlenar
            // 
            this.lblLlenar.AutoSize = true;
            this.lblLlenar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLlenar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLlenar.Location = new System.Drawing.Point(287, 32);
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
            this.btnSalir.Location = new System.Drawing.Point(678, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 31);
            this.btnSalir.TabIndex = 123;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnLecturaPersona
            // 
            this.btnLecturaPersona.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLecturaPersona.Image = ((System.Drawing.Image)(resources.GetObject("btnLecturaPersona.Image")));
            this.btnLecturaPersona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLecturaPersona.Location = new System.Drawing.Point(678, 294);
            this.btnLecturaPersona.Name = "btnLecturaPersona";
            this.btnLecturaPersona.Size = new System.Drawing.Size(132, 31);
            this.btnLecturaPersona.TabIndex = 122;
            this.btnLecturaPersona.Text = "Lectura Persona";
            this.btnLecturaPersona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLecturaPersona.UseVisualStyleBackColor = true;
            this.btnLecturaPersona.Click += new System.EventHandler(this.btnLecturaPersona_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(678, 230);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(132, 31);
            this.btnRegistrar.TabIndex = 121;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnGuardarComo
            // 
            this.btnGuardarComo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarComo.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarComo.Image")));
            this.btnGuardarComo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarComo.Location = new System.Drawing.Point(678, 168);
            this.btnGuardarComo.Name = "btnGuardarComo";
            this.btnGuardarComo.Size = new System.Drawing.Size(132, 31);
            this.btnGuardarComo.TabIndex = 120;
            this.btnGuardarComo.Text = "Guardar Como";
            this.btnGuardarComo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarComo.UseVisualStyleBackColor = true;
            this.btnGuardarComo.Click += new System.EventHandler(this.btnGuardarComo_Click);
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(499, 359);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(140, 23);
            this.txtNacionalidad.TabIndex = 156;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(499, 300);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(140, 23);
            this.txtTelefono.TabIndex = 155;
            // 
            // txtNumeroPasaporte
            // 
            this.txtNumeroPasaporte.Location = new System.Drawing.Point(499, 236);
            this.txtNumeroPasaporte.Name = "txtNumeroPasaporte";
            this.txtNumeroPasaporte.Size = new System.Drawing.Size(140, 23);
            this.txtNumeroPasaporte.TabIndex = 154;
            // 
            // txtNumeroIdentidad
            // 
            this.txtNumeroIdentidad.Location = new System.Drawing.Point(499, 174);
            this.txtNumeroIdentidad.Name = "txtNumeroIdentidad";
            this.txtNumeroIdentidad.Size = new System.Drawing.Size(140, 23);
            this.txtNumeroIdentidad.TabIndex = 153;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(373, 366);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(77, 15);
            this.lblNacionalidad.TabIndex = 152;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblIdentidad
            // 
            this.lblIdentidad.AutoSize = true;
            this.lblIdentidad.Location = new System.Drawing.Point(82, 302);
            this.lblIdentidad.Name = "lblIdentidad";
            this.lblIdentidad.Size = new System.Drawing.Size(45, 15);
            this.lblIdentidad.TabIndex = 151;
            this.lblIdentidad.Text = "Genero";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(82, 366);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 150;
            this.lblEdad.Text = "Edad";
            // 
            // lblNumeroIdentidad
            // 
            this.lblNumeroIdentidad.AutoSize = true;
            this.lblNumeroIdentidad.Location = new System.Drawing.Point(373, 179);
            this.lblNumeroIdentidad.Name = "lblNumeroIdentidad";
            this.lblNumeroIdentidad.Size = new System.Drawing.Size(120, 15);
            this.lblNumeroIdentidad.TabIndex = 149;
            this.lblNumeroIdentidad.Text = "Numero de Identidad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(172, 358);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(140, 23);
            this.txtEdad.TabIndex = 148;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(172, 299);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(140, 23);
            this.txtGenero.TabIndex = 147;
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(172, 235);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Size = new System.Drawing.Size(140, 23);
            this.txtRTN.TabIndex = 146;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(172, 173);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 23);
            this.txtNombre.TabIndex = 145;
            // 
            // lblNumeroPasaporte
            // 
            this.lblNumeroPasaporte.AutoSize = true;
            this.lblNumeroPasaporte.Location = new System.Drawing.Point(373, 245);
            this.lblNumeroPasaporte.Name = "lblNumeroPasaporte";
            this.lblNumeroPasaporte.Size = new System.Drawing.Size(122, 15);
            this.lblNumeroPasaporte.TabIndex = 144;
            this.lblNumeroPasaporte.Text = "Numero de Pasaporte";
            this.lblNumeroPasaporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(373, 303);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 143;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRTN
            // 
            this.lblRTN.AutoSize = true;
            this.lblRTN.Location = new System.Drawing.Point(82, 243);
            this.lblRTN.Name = "lblRTN";
            this.lblRTN.Size = new System.Drawing.Size(28, 15);
            this.lblRTN.TabIndex = 142;
            this.lblRTN.Text = "RTN";
            this.lblRTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(82, 181);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 141;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(172, 108);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(140, 23);
            this.txtId.TabIndex = 158;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(115, 116);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 157;
            this.lblId.Text = "ID";
            // 
            // frmRegistrarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 450);
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
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLecturaPersona);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnGuardarComo);
            this.Controls.Add(this.lblLlenar);
            this.Name = "frmRegistrarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblLlenar;
        private Button btnSalir;
        private Button btnLecturaPersona;
        private Button btnRegistrar;
        private Button btnGuardarComo;
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
        private TextBox txtId;
        private Label lblId;
    }
}