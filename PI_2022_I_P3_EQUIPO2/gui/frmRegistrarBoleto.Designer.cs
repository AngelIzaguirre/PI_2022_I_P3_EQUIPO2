namespace PI_2022_I_P3_EQUIPO2.gui
{
    partial class frmRegistrarBoleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarBoleto));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLecturaBoleto = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnGuardarComo = new System.Windows.Forms.Button();
            this.lblLlenar = new System.Windows.Forms.Label();
            this.txtCiudadSalida = new System.Windows.Forms.TextBox();
            this.txtCiudadActual = new System.Windows.Forms.TextBox();
            this.txtTipoBoleto = new System.Windows.Forms.TextBox();
            this.txtNumeroBoleto = new System.Windows.Forms.TextBox();
            this.lblCiudadSalida = new System.Windows.Forms.Label();
            this.lblCiudadActual = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.lblNumeroBoleto = new System.Windows.Forms.Label();
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtAerolinea = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipoBoleto = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblAerolinea = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(681, 332);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 31);
            this.btnSalir.TabIndex = 82;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLecturaBoleto
            // 
            this.btnLecturaBoleto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLecturaBoleto.Image = ((System.Drawing.Image)(resources.GetObject("btnLecturaBoleto.Image")));
            this.btnLecturaBoleto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLecturaBoleto.Location = new System.Drawing.Point(681, 276);
            this.btnLecturaBoleto.Name = "btnLecturaBoleto";
            this.btnLecturaBoleto.Size = new System.Drawing.Size(130, 31);
            this.btnLecturaBoleto.TabIndex = 81;
            this.btnLecturaBoleto.Text = "Lectura Boleto";
            this.btnLecturaBoleto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLecturaBoleto.UseVisualStyleBackColor = true;
            this.btnLecturaBoleto.Click += new System.EventHandler(this.btnLecturaBoleto_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(681, 212);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(130, 31);
            this.btnRegistrar.TabIndex = 80;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnGuardarComo
            // 
            this.btnGuardarComo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarComo.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarComo.Image")));
            this.btnGuardarComo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarComo.Location = new System.Drawing.Point(681, 150);
            this.btnGuardarComo.Name = "btnGuardarComo";
            this.btnGuardarComo.Size = new System.Drawing.Size(130, 31);
            this.btnGuardarComo.TabIndex = 79;
            this.btnGuardarComo.Text = "Guardar Como";
            this.btnGuardarComo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarComo.UseVisualStyleBackColor = true;
            this.btnGuardarComo.Click += new System.EventHandler(this.btnGuardarComo_Click);
            // 
            // lblLlenar
            // 
            this.lblLlenar.AutoSize = true;
            this.lblLlenar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLlenar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLlenar.Location = new System.Drawing.Point(220, 25);
            this.lblLlenar.Name = "lblLlenar";
            this.lblLlenar.Size = new System.Drawing.Size(231, 22);
            this.lblLlenar.TabIndex = 78;
            this.lblLlenar.Text = "Llenar los siguientes datos ";
            // 
            // txtCiudadSalida
            // 
            this.txtCiudadSalida.Location = new System.Drawing.Point(469, 343);
            this.txtCiudadSalida.Name = "txtCiudadSalida";
            this.txtCiudadSalida.Size = new System.Drawing.Size(140, 23);
            this.txtCiudadSalida.TabIndex = 98;
            // 
            // txtCiudadActual
            // 
            this.txtCiudadActual.Location = new System.Drawing.Point(469, 284);
            this.txtCiudadActual.Name = "txtCiudadActual";
            this.txtCiudadActual.Size = new System.Drawing.Size(140, 23);
            this.txtCiudadActual.TabIndex = 97;
            // 
            // txtTipoBoleto
            // 
            this.txtTipoBoleto.Location = new System.Drawing.Point(469, 220);
            this.txtTipoBoleto.Name = "txtTipoBoleto";
            this.txtTipoBoleto.Size = new System.Drawing.Size(140, 23);
            this.txtTipoBoleto.TabIndex = 96;
            // 
            // txtNumeroBoleto
            // 
            this.txtNumeroBoleto.Location = new System.Drawing.Point(469, 158);
            this.txtNumeroBoleto.Name = "txtNumeroBoleto";
            this.txtNumeroBoleto.Size = new System.Drawing.Size(140, 23);
            this.txtNumeroBoleto.TabIndex = 95;
            // 
            // lblCiudadSalida
            // 
            this.lblCiudadSalida.AutoSize = true;
            this.lblCiudadSalida.Location = new System.Drawing.Point(356, 351);
            this.lblCiudadSalida.Name = "lblCiudadSalida";
            this.lblCiudadSalida.Size = new System.Drawing.Size(95, 15);
            this.lblCiudadSalida.TabIndex = 94;
            this.lblCiudadSalida.Text = "Ciudad de Salida";
            // 
            // lblCiudadActual
            // 
            this.lblCiudadActual.AutoSize = true;
            this.lblCiudadActual.Location = new System.Drawing.Point(356, 292);
            this.lblCiudadActual.Name = "lblCiudadActual";
            this.lblCiudadActual.Size = new System.Drawing.Size(82, 15);
            this.lblCiudadActual.TabIndex = 93;
            this.lblCiudadActual.Text = "Ciudad Actual";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Location = new System.Drawing.Point(65, 351);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(75, 15);
            this.lblFechaActual.TabIndex = 92;
            this.lblFechaActual.Text = "Fecha Actual";
            // 
            // lblNumeroBoleto
            // 
            this.lblNumeroBoleto.AutoSize = true;
            this.lblNumeroBoleto.Location = new System.Drawing.Point(356, 164);
            this.lblNumeroBoleto.Name = "lblNumeroBoleto";
            this.lblNumeroBoleto.Size = new System.Drawing.Size(107, 15);
            this.lblNumeroBoleto.TabIndex = 91;
            this.lblNumeroBoleto.Text = "Numero del Boleto";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Location = new System.Drawing.Point(155, 343);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(140, 23);
            this.txtFechaActual.TabIndex = 90;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(155, 284);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(140, 23);
            this.txtCosto.TabIndex = 89;
            // 
            // txtAerolinea
            // 
            this.txtAerolinea.Location = new System.Drawing.Point(155, 220);
            this.txtAerolinea.Name = "txtAerolinea";
            this.txtAerolinea.Size = new System.Drawing.Size(140, 23);
            this.txtAerolinea.TabIndex = 88;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 158);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 23);
            this.txtNombre.TabIndex = 87;
            // 
            // lblTipoBoleto
            // 
            this.lblTipoBoleto.AutoSize = true;
            this.lblTipoBoleto.Location = new System.Drawing.Point(356, 228);
            this.lblTipoBoleto.Name = "lblTipoBoleto";
            this.lblTipoBoleto.Size = new System.Drawing.Size(83, 15);
            this.lblTipoBoleto.TabIndex = 86;
            this.lblTipoBoleto.Text = "Tipo de Boleto";
            this.lblTipoBoleto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(65, 292);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(38, 15);
            this.lblCosto.TabIndex = 85;
            this.lblCosto.Text = "Costo";
            this.lblCosto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAerolinea
            // 
            this.lblAerolinea.AutoSize = true;
            this.lblAerolinea.Location = new System.Drawing.Point(65, 228);
            this.lblAerolinea.Name = "lblAerolinea";
            this.lblAerolinea.Size = new System.Drawing.Size(57, 15);
            this.lblAerolinea.TabIndex = 84;
            this.lblAerolinea.Text = "Aerolinea";
            this.lblAerolinea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(65, 166);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 83;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(98, 105);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 99;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(155, 97);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(140, 23);
            this.txtId.TabIndex = 100;
            // 
            // frmRegistrarBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtCiudadSalida);
            this.Controls.Add(this.txtCiudadActual);
            this.Controls.Add(this.txtTipoBoleto);
            this.Controls.Add(this.txtNumeroBoleto);
            this.Controls.Add(this.lblCiudadSalida);
            this.Controls.Add(this.lblCiudadActual);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.lblNumeroBoleto);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtAerolinea);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTipoBoleto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblAerolinea);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLecturaBoleto);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnGuardarComo);
            this.Controls.Add(this.lblLlenar);
            this.Name = "frmRegistrarBoleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrarBoleto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSalir;
        private Button btnLecturaBoleto;
        private Button btnRegistrar;
        private Button btnGuardarComo;
        private Label lblLlenar;
        private TextBox txtCiudadSalida;
        private TextBox txtCiudadActual;
        private TextBox txtTipoBoleto;
        private TextBox txtNumeroBoleto;
        private Label lblCiudadSalida;
        private Label lblCiudadActual;
        private Label lblFechaActual;
        private Label lblNumeroBoleto;
        private TextBox txtFechaActual;
        private TextBox txtCosto;
        private TextBox txtAerolinea;
        private TextBox txtNombre;
        private Label lblTipoBoleto;
        private Label lblCosto;
        private Label lblAerolinea;
        private Label lblNombre;
        private Label lblId;
        private TextBox txtId;
    }
}