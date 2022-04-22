using PI_2022_I_P3_EQUIPO2.Objetos;
using PI_2022_I_P3_EQUIPO2.Properties;
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
    public partial class frmRegistrarMantenimiento : Form
    {
        protected int ContadorTextBox { get; set; } = 9;
        List<Mantenimiento> registroGrid = new List<Mantenimiento>();
        StreamWriter archivoWriter;
        StreamReader archivoReader;
        enum IndicesTextBox
        {
            Id,
            Nombre,
            Maerial,
            Costo,
            Empresa,
            NumeroSerie,
            Problema,
            HoraIngreso,
            HoraSalida

        }
        public frmRegistrarMantenimiento()
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
                txtMaterial.Text,
                txtCosto.Text,
                txtEmpresa.Text,
                txtNumeroSerie.Text,
                txtProblema.Text,
                txtHoraIngreso.Text,
                txtHoraSalida.Text

            };
        }
        private void btnLecturaMantenimiento_Click(object sender, EventArgs e)
        {
            frmMantenimiento frmMantenimiento = new frmMantenimiento();
            frmMantenimiento.ShowDialog();
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
                        var cuenta = new Mantenimiento(
                            numero,
                            valores[(int)IndicesTextBox.Nombre],
                            valores[(int)IndicesTextBox.Maerial],
                            decimal.Parse(valores[(int)IndicesTextBox.Costo]),
                            valores[(int)IndicesTextBox.Empresa],
                            int.Parse(valores[(int)IndicesTextBox.NumeroSerie]),
                            valores[(int)IndicesTextBox.Problema],
                            valores[(int)IndicesTextBox.HoraIngreso],
                            valores[(int)IndicesTextBox.HoraSalida]
                            );
                        archivoWriter.WriteLine($"{cuenta.ID},{cuenta.Nombre},{cuenta.Material},{cuenta.Costo},{cuenta.Empresa}," +
                            $"{cuenta.NumeroSerie},{cuenta.Problema},{cuenta.HoraIngreso},{cuenta.HoraSalida}");
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
            var var = !string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtMaterial.Text) &&
            !string.IsNullOrEmpty(txtCosto.Text) && !string.IsNullOrEmpty(txtEmpresa.Text) && !string.IsNullOrEmpty(txtNumeroSerie.Text) &&
            !string.IsNullOrEmpty(txtHoraIngreso.Text) && !string.IsNullOrEmpty(txtHoraIngreso.Text) && !string.IsNullOrEmpty(txtHoraSalida.Text);
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

        private void txtMaterial_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtNumeroSerie_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtProblema_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtHoraIngreso_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtHoraSalida_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }
    }
}
