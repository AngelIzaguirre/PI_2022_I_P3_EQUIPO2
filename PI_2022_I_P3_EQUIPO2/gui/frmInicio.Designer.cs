namespace PI_2022_I_P3_EQUIPO2
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.btnComenzar = new System.Windows.Forms.Button();
            this.lblAeropuerto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComenzar
            // 
            this.btnComenzar.Image = ((System.Drawing.Image)(resources.GetObject("btnComenzar.Image")));
            this.btnComenzar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComenzar.Location = new System.Drawing.Point(423, 527);
            this.btnComenzar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(125, 34);
            this.btnComenzar.TabIndex = 0;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // lblAeropuerto
            // 
            this.lblAeropuerto.AutoSize = true;
            this.lblAeropuerto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAeropuerto.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblAeropuerto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAeropuerto.Location = new System.Drawing.Point(228, 108);
            this.lblAeropuerto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAeropuerto.Name = "lblAeropuerto";
            this.lblAeropuerto.Size = new System.Drawing.Size(558, 23);
            this.lblAeropuerto.TabIndex = 1;
            this.lblAeropuerto.Text = "Bienvenidos al Aeropuerto Internacional Bella Vista";
            // 
            // frmInicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 598);
            this.Controls.Add(this.lblAeropuerto);
            this.Controls.Add(this.btnComenzar);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnComenzar;
        private Label lblAeropuerto;
    }
}