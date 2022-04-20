namespace PI_2022_I_P3_EQUIPO2.gui
{
    partial class frmRegistrarMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarMantenimiento));
            this.lblLlenar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLecturaMantenimiento = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnGuardarComo = new System.Windows.Forms.Button();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.txtHoraIngreso = new System.Windows.Forms.TextBox();
            this.txtProblema = new System.Windows.Forms.TextBox();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblProblema = new System.Windows.Forms.Label();
            this.lblHoraIngreso = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
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
            this.lblLlenar.Location = new System.Drawing.Point(287, 30);
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
            this.btnSalir.Location = new System.Drawing.Point(677, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(166, 31);
            this.btnSalir.TabIndex = 123;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLecturaMantenimiento
            // 
            this.btnLecturaMantenimiento.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLecturaMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnLecturaMantenimiento.Image")));
            this.btnLecturaMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLecturaMantenimiento.Location = new System.Drawing.Point(677, 294);
            this.btnLecturaMantenimiento.Name = "btnLecturaMantenimiento";
            this.btnLecturaMantenimiento.Size = new System.Drawing.Size(166, 31);
            this.btnLecturaMantenimiento.TabIndex = 122;
            this.btnLecturaMantenimiento.Text = "Lectura Mantenimiento";
            this.btnLecturaMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLecturaMantenimiento.UseVisualStyleBackColor = true;
            this.btnLecturaMantenimiento.Click += new System.EventHandler(this.btnLecturaMantenimiento_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(677, 230);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(166, 31);
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
            this.btnGuardarComo.Location = new System.Drawing.Point(677, 168);
            this.btnGuardarComo.Name = "btnGuardarComo";
            this.btnGuardarComo.Size = new System.Drawing.Size(166, 31);
            this.btnGuardarComo.TabIndex = 120;
            this.btnGuardarComo.Text = "Guardar Como";
            this.btnGuardarComo.UseVisualStyleBackColor = true;
            this.btnGuardarComo.Click += new System.EventHandler(this.btnGuardarComo_Click);
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Location = new System.Drawing.Point(486, 359);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(140, 23);
            this.txtHoraSalida.TabIndex = 140;
            // 
            // txtHoraIngreso
            // 
            this.txtHoraIngreso.Location = new System.Drawing.Point(486, 300);
            this.txtHoraIngreso.Name = "txtHoraIngreso";
            this.txtHoraIngreso.Size = new System.Drawing.Size(140, 23);
            this.txtHoraIngreso.TabIndex = 139;
            // 
            // txtProblema
            // 
            this.txtProblema.Location = new System.Drawing.Point(486, 236);
            this.txtProblema.Name = "txtProblema";
            this.txtProblema.Size = new System.Drawing.Size(140, 23);
            this.txtProblema.TabIndex = 138;
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.Location = new System.Drawing.Point(486, 174);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(140, 23);
            this.txtNumeroSerie.TabIndex = 137;
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Location = new System.Drawing.Point(360, 366);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(83, 15);
            this.lblHoraSalida.TabIndex = 136;
            this.lblHoraSalida.Text = "Hora de Salida";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(69, 302);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(38, 15);
            this.lblCosto.TabIndex = 135;
            this.lblCosto.Text = "Costo";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(69, 366);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(52, 15);
            this.lblEmpresa.TabIndex = 134;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Location = new System.Drawing.Point(360, 179);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(95, 15);
            this.lblNumeroSerie.TabIndex = 133;
            this.lblNumeroSerie.Text = "Numero de Serie";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(159, 358);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(140, 23);
            this.txtEmpresa.TabIndex = 132;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(159, 299);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(140, 23);
            this.txtCosto.TabIndex = 131;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(159, 235);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(140, 23);
            this.txtMaterial.TabIndex = 130;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(159, 173);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 23);
            this.txtNombre.TabIndex = 129;
            // 
            // lblProblema
            // 
            this.lblProblema.AutoSize = true;
            this.lblProblema.Location = new System.Drawing.Point(360, 245);
            this.lblProblema.Name = "lblProblema";
            this.lblProblema.Size = new System.Drawing.Size(58, 15);
            this.lblProblema.TabIndex = 128;
            this.lblProblema.Text = "Problema";
            this.lblProblema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoraIngreso
            // 
            this.lblHoraIngreso.AutoSize = true;
            this.lblHoraIngreso.Location = new System.Drawing.Point(360, 303);
            this.lblHoraIngreso.Name = "lblHoraIngreso";
            this.lblHoraIngreso.Size = new System.Drawing.Size(91, 15);
            this.lblHoraIngreso.TabIndex = 127;
            this.lblHoraIngreso.Text = "Hora de Ingreso";
            this.lblHoraIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(69, 243);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(50, 15);
            this.lblMaterial.TabIndex = 126;
            this.lblMaterial.Text = "Material";
            this.lblMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(69, 181);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 125;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(159, 116);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(140, 23);
            this.txtId.TabIndex = 142;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(102, 124);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 141;
            this.lblId.Text = "ID";
            // 
            // frmRegistrarMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtHoraSalida);
            this.Controls.Add(this.txtHoraIngreso);
            this.Controls.Add(this.txtProblema);
            this.Controls.Add(this.txtNumeroSerie);
            this.Controls.Add(this.lblHoraSalida);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblNumeroSerie);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblProblema);
            this.Controls.Add(this.lblHoraIngreso);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLecturaMantenimiento);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnGuardarComo);
            this.Controls.Add(this.lblLlenar);
            this.Name = "frmRegistrarMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarMantenimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblLlenar;
        private Button btnSalir;
        private Button btnLecturaMantenimiento;
        private Button btnRegistrar;
        private Button btnGuardarComo;
        private TextBox txtHoraSalida;
        private TextBox txtHoraIngreso;
        private TextBox txtProblema;
        private TextBox txtNumeroSerie;
        private Label lblHoraSalida;
        private Label lblCosto;
        private Label lblEmpresa;
        private Label lblNumeroSerie;
        private TextBox txtEmpresa;
        private TextBox txtCosto;
        private TextBox txtMaterial;
        private TextBox txtNombre;
        private Label lblProblema;
        private Label lblHoraIngreso;
        private Label lblMaterial;
        private Label lblNombre;
        private TextBox txtId;
        private Label lblId;
    }
}