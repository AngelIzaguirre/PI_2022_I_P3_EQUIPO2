namespace PI_2022_I_P3_EQUIPO2.gui
{
    partial class frmRegistrarEmbarque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarEmbarque));
            this.lblLlenar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLecturaEmbarque = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnGuardarComo = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCompañia = new System.Windows.Forms.TextBox();
            this.txtTipoBoleto = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCompañia = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipoBoleto = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
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
            this.lblLlenar.Location = new System.Drawing.Point(262, 36);
            this.lblLlenar.Name = "lblLlenar";
            this.lblLlenar.Size = new System.Drawing.Size(231, 22);
            this.lblLlenar.TabIndex = 78;
            this.lblLlenar.Text = "Llenar los siguientes datos ";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(663, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 31);
            this.btnSalir.TabIndex = 102;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLecturaEmbarque
            // 
            this.btnLecturaEmbarque.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLecturaEmbarque.Image = ((System.Drawing.Image)(resources.GetObject("btnLecturaEmbarque.Image")));
            this.btnLecturaEmbarque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLecturaEmbarque.Location = new System.Drawing.Point(663, 294);
            this.btnLecturaEmbarque.Name = "btnLecturaEmbarque";
            this.btnLecturaEmbarque.Size = new System.Drawing.Size(136, 31);
            this.btnLecturaEmbarque.TabIndex = 101;
            this.btnLecturaEmbarque.Text = "Lectura Embarque";
            this.btnLecturaEmbarque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLecturaEmbarque.UseVisualStyleBackColor = true;
            this.btnLecturaEmbarque.Click += new System.EventHandler(this.btnLecturaEmbarque_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(663, 230);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(136, 31);
            this.btnRegistrar.TabIndex = 100;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnGuardarComo
            // 
            this.btnGuardarComo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarComo.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarComo.Image")));
            this.btnGuardarComo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarComo.Location = new System.Drawing.Point(663, 168);
            this.btnGuardarComo.Name = "btnGuardarComo";
            this.btnGuardarComo.Size = new System.Drawing.Size(136, 31);
            this.btnGuardarComo.TabIndex = 99;
            this.btnGuardarComo.Text = "Guardar Como";
            this.btnGuardarComo.UseVisualStyleBackColor = true;
            this.btnGuardarComo.Click += new System.EventHandler(this.btnGuardarComo_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(473, 361);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(140, 23);
            this.txtCantidad.TabIndex = 118;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtCompañia
            // 
            this.txtCompañia.Location = new System.Drawing.Point(473, 302);
            this.txtCompañia.Name = "txtCompañia";
            this.txtCompañia.Size = new System.Drawing.Size(140, 23);
            this.txtCompañia.TabIndex = 117;
            this.txtCompañia.TextChanged += new System.EventHandler(this.txtCompañia_TextChanged);
            this.txtCompañia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompañia_KeyPress);
            // 
            // txtTipoBoleto
            // 
            this.txtTipoBoleto.Location = new System.Drawing.Point(473, 238);
            this.txtTipoBoleto.Name = "txtTipoBoleto";
            this.txtTipoBoleto.Size = new System.Drawing.Size(140, 23);
            this.txtTipoBoleto.TabIndex = 116;
            this.txtTipoBoleto.TextChanged += new System.EventHandler(this.txtTipoBoleto_TextChanged);
            this.txtTipoBoleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoBoleto_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(473, 176);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(140, 23);
            this.txtTelefono.TabIndex = 115;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(360, 369);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 114;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblCompañia
            // 
            this.lblCompañia.AutoSize = true;
            this.lblCompañia.Location = new System.Drawing.Point(360, 310);
            this.lblCompañia.Name = "lblCompañia";
            this.lblCompañia.Size = new System.Drawing.Size(62, 15);
            this.lblCompañia.TabIndex = 113;
            this.lblCompañia.Text = "Compañia";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Location = new System.Drawing.Point(69, 369);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(75, 15);
            this.lblFechaActual.TabIndex = 112;
            this.lblFechaActual.Text = "Fecha Actual";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(360, 182);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 111;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Location = new System.Drawing.Point(159, 361);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(140, 23);
            this.txtFechaActual.TabIndex = 110;
            this.txtFechaActual.TextChanged += new System.EventHandler(this.txtFechaActual_TextChanged);
            this.txtFechaActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFechaActual_KeyPress);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(159, 302);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(140, 23);
            this.txtCosto.TabIndex = 109;
            this.txtCosto.TextChanged += new System.EventHandler(this.txtCosto_TextChanged);
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(159, 238);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(140, 23);
            this.txtDireccion.TabIndex = 108;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(159, 176);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 23);
            this.txtNombre.TabIndex = 107;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblTipoBoleto
            // 
            this.lblTipoBoleto.AutoSize = true;
            this.lblTipoBoleto.Location = new System.Drawing.Point(360, 246);
            this.lblTipoBoleto.Name = "lblTipoBoleto";
            this.lblTipoBoleto.Size = new System.Drawing.Size(83, 15);
            this.lblTipoBoleto.TabIndex = 106;
            this.lblTipoBoleto.Text = "Tipo de Boleto";
            this.lblTipoBoleto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(69, 310);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(38, 15);
            this.lblCosto.TabIndex = 105;
            this.lblCosto.Text = "Costo";
            this.lblCosto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(69, 246);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 104;
            this.lblDireccion.Text = "Direccion";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(69, 184);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 103;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(159, 118);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(140, 23);
            this.txtId.TabIndex = 120;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(102, 126);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 119;
            this.lblId.Text = "ID";
            // 
            // frmRegistrarEmbarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCompañia);
            this.Controls.Add(this.txtTipoBoleto);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCompañia);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTipoBoleto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLecturaEmbarque);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnGuardarComo);
            this.Controls.Add(this.lblLlenar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarEmbarque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrarEmbarque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblLlenar;
        private Button btnSalir;
        private Button btnLecturaEmbarque;
        private Button btnRegistrar;
        private Button btnGuardarComo;
        private TextBox txtCantidad;
        private TextBox txtCompañia;
        private TextBox txtTipoBoleto;
        private TextBox txtTelefono;
        private Label lblCantidad;
        private Label lblCompañia;
        private Label lblFechaActual;
        private Label lblTelefono;
        private TextBox txtFechaActual;
        private TextBox txtCosto;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label lblTipoBoleto;
        private Label lblCosto;
        private Label lblDireccion;
        private Label lblNombre;
        private TextBox txtId;
        private Label lblId;
    }
}