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
    public partial class frmRegistrarPersona : Form
    {
        protected int ContadorTextBox { get; set; } = 9;
        List<Persona> registroGrid = new List<Persona>();
        StreamWriter archivoWriter;
        StreamReader archivoReader;
        enum IndicesTextBox
        {
            Id,
            Nombre,
            RTN,
            Genero,
            Edad,
            NumeroIdentidad,
            NumeroPasaporte,
            Telefono,
            Nacionalidad

        }
        public frmRegistrarPersona()
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
                txtRTN.Text,
                txtGenero.Text,
                txtEdad.Text,
                txtNumeroIdentidad.Text,
                txtNumeroPasaporte.Text,
                txtTelefono.Text,
                txtNacionalidad.Text

            };
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLecturaPersona_Click_1(object sender, EventArgs e)
        {

            frmPersona persona = new frmPersona();
            persona.ShowDialog();
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
                        var cuenta = new Persona(
                            numero,
                            valores[(int)IndicesTextBox.Nombre],
                            int.Parse(valores[(int)IndicesTextBox.RTN]),
                            valores[(int)IndicesTextBox.Genero],
                            int.Parse(valores[(int)IndicesTextBox.Edad]),
                            valores[(int)IndicesTextBox.NumeroIdentidad],
                            valores[(int)IndicesTextBox.NumeroPasaporte],
                            int.Parse(valores[(int)IndicesTextBox.Telefono]),
                            valores[(int)IndicesTextBox.Nacionalidad]
                            );
                        archivoWriter.WriteLine($"{cuenta.ID},{cuenta.Nombre},{cuenta.RTN},{cuenta.Genero},{cuenta.Edad}," +
                            $"{cuenta.NumeroIdentidad},{cuenta.NumeroPasaporte},{cuenta.Telefono},{cuenta.Nacionalidad}");
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
    }
}
