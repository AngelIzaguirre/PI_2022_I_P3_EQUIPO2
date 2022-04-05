namespace PI_2022_I_P3_EQUIPO2.gui
{
    partial class frmEliminarEquipaje
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblIngrese = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(332, 169);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 17);
            this.lblId.TabIndex = 35;
            this.lblId.Text = "Id";
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.BackColor = System.Drawing.Color.Gainsboro;
            this.lblIngrese.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIngrese.Location = new System.Drawing.Point(277, 84);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(250, 22);
            this.lblIngrese.TabIndex = 34;
            this.lblIngrese.Text = "Ingrese Id que desea eliminar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(360, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 33;
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(148, 343);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 32;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.Location = new System.Drawing.Point(578, 343);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.Text = "Eliminar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // frmEliminarEquipaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblIngrese);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "frmEliminarEquipaje";
            this.Text = "frmEliminarEquipaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblId;
        private Label lblIngrese;
        private TextBox textBox1;
        private Button btnAtras;
        private Button btnRegistrar;
    }
}