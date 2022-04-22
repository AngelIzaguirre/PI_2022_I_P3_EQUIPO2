﻿using PI_2022_I_P3_EQUIPO2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_2022_I_P3_EQUIPO2.gui
{
    public partial class frmRegistrarBoleto : Form
    {
        protected int ContadorTextBox { get; set; } = 9;
        List<Boleto> registroGrid = new List<Boleto>();
        StreamWriter archivoWriter;
        StreamReader archivoReader;

        ErrorProvider errorProvider = new ErrorProvider();
        enum IndicesTextBox
        {
            Id,
            Nombre,
            Aerolinea,
            Costo,
            FechaActual,
            NumeroBoleto,
            TipoBoleto,
            CiudadActual,
            CiudadSalida

        }
        public frmRegistrarBoleto()
        {
            InitializeComponent();
        }

        public void LimpiarTextBox()
        {
            foreach (Control ControlGUI in Controls)
            {
                (ControlGUI as TextBox)?.Clear();
            }
        }
        public string[] ObtenerValoresTextBox()
        {
            return new string[]
            {
                txtId.Text,
                txtNombre.Text,
                txtAerolinea.Text,
                txtCosto.Text,
                txtFechaActual.Text,
                txtNumeroBoleto.Text,
                txtTipoBoleto.Text,
                txtCiudadActual.Text,
                txtCiudadSalida.Text
            
            };
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                archivoWriter?.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("No se puede cerrar el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Application.Exit();
        }
        private void btnLecturaBoleto_Click(object sender, EventArgs e)
        {
            frmBoleto frmBoleto = new frmBoleto();
            frmBoleto.ShowDialog();
        }

        private void btnGuardarComo_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string nombrearchivo;
            using (var archivoSeleccionado = new SaveFileDialog())
            {
                archivoSeleccionado.CheckFileExists = false;
                result = archivoSeleccionado.ShowDialog();
                nombrearchivo = archivoSeleccionado.FileName;
            }
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(nombrearchivo))
                {
                    MessageBox.Show("Nombre de Archivo invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var salir = new FileStream(nombrearchivo, FileMode.OpenOrCreate, FileAccess.Write);
                        archivoWriter = new StreamWriter(salir);
                        btnGuardarComo.Enabled = false;
                        btnRegistrar.Enabled = true;

                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error abriendo el Archivo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string[] valores = ObtenerValoresTextBox();
            if (!string.IsNullOrEmpty(valores[(int)IndicesTextBox.Id]))
            {
                
                try
                {
                    int numero = int.Parse(valores[(int)IndicesTextBox.Id]);
                    if (numero > 0)
                    {
                        var cuenta = new Boleto(
                            numero,
                            valores[(int)IndicesTextBox.Nombre],      
                            valores[(int)IndicesTextBox.Aerolinea],
                            decimal.Parse(valores[(int)IndicesTextBox.Costo]),
                            valores[(int)IndicesTextBox.FechaActual],
                            int.Parse(valores[(int)IndicesTextBox.NumeroBoleto]),
                            valores[(int)IndicesTextBox.TipoBoleto],
                            valores[(int)IndicesTextBox.CiudadActual],
                            valores[(int)IndicesTextBox.CiudadSalida]
                            );
                        archivoWriter.WriteLine($"{cuenta.Id},{cuenta.Nombre},{cuenta.Aerolinea},{cuenta.Costo},{cuenta.FechaActual}," +
                            $"{cuenta.NumeroBoleto},{cuenta.TipoBoleto},{cuenta.CiudadActual},{cuenta.CiudadSalida}");
                         MessageBox.Show("Datos ingresados correctamente");
                        
                    }
                    else
                    {
                        MessageBox.Show("Numero de ID invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (IOException)
                {

                    MessageBox.Show("Error Escribiendo el Archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato Invalido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LimpiarTextBox();
        }

        
        private void ValidarVacio()
        {
            var var = !string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtAerolinea.Text) &&
            !string.IsNullOrEmpty(txtCosto.Text) && !string.IsNullOrEmpty(txtFechaActual.Text) && !string.IsNullOrEmpty(txtNumeroBoleto.Text) &&
            !string.IsNullOrEmpty(txtTipoBoleto.Text) && !string.IsNullOrEmpty(txtCiudadActual.Text) && !string.IsNullOrEmpty(txtCiudadSalida.Text);
            btnRegistrar.Enabled = var;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();

        }

        private void txtAerolinea_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtFechaActual_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtNumeroBoleto_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtTipoBoleto_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtCiudadActual_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtCiudadSalida_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Solo letras");
                e.Handled = true;
                return;
            }
        }

        private void txtAerolinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Solo letras");
                e.Handled = true;
                return;
            }
        }

        private void txtTipoBoleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Solo letras");
                e.Handled = true;
                return;
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo Numeros");
                e.Handled = true;
                return;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo Numeros");
                e.Handled = true;
                return;
            }
        }

        private void txtFechaActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo Numeros");
                e.Handled = true;
                return;
            }
        }

        private void txtNumeroBoleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo Numeros");
                e.Handled = true;
                return;
            }
        }
    }
}
