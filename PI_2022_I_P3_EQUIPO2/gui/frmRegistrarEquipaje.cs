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
    public partial class frmRegistrarEquipaje : Form
    {
        protected int ContadorTextBox { get; set; } = 9;
        List<Equipaje> registroGrid = new List<Equipaje>();
        StreamWriter archivoWriter;
        StreamReader archivoReader;
        enum IndicesTextBox
        {
            Id,
            Nombre,
            Cantidad,
            Hora,
            Peso,
            ClaseBoleto,
            Aerolinea,
            NumeroBoleto,
            Destino

        }
        public frmRegistrarEquipaje()
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
                txtCantidad.Text,
                txtHora.Text,
                txtPeso.Text,
                txtClaseBoleto.Text,
                txtAerolinea.Text,
                txtNumeroBoleto.Text,
                txtDestino.Text

            };
        }
        private void btnLecturaEquipaje_Click(object sender, EventArgs e)
        {
            frmEquipaje frmEquipaje = new frmEquipaje();
            frmEquipaje.ShowDialog();
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
                        var cuenta = new Equipaje(
                            numero,
                            valores[(int)IndicesTextBox.Nombre],
                            int.Parse(valores[(int)IndicesTextBox.Cantidad]),
                            valores[(int)IndicesTextBox.Hora],
                            decimal.Parse(valores[(int)IndicesTextBox.Peso]),
                            valores[(int)IndicesTextBox.ClaseBoleto],
                            valores[(int)IndicesTextBox.Aerolinea],
                            int.Parse(valores[(int)IndicesTextBox.NumeroBoleto]),
                            valores[(int)IndicesTextBox.Destino]
                            );
                        archivoWriter.WriteLine($"{cuenta.ID},{cuenta.Nombre},{cuenta.Cantidad},{cuenta.Hora},{cuenta.Peso}," +
                            $"{cuenta.ClaseBoleto},{cuenta.Aerolinea},{cuenta.NumeroBoleto},{cuenta.Destino}");
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
            var var = !string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtCantidad.Text) &&
            !string.IsNullOrEmpty(txtHora.Text) && !string.IsNullOrEmpty(txtPeso.Text) && !string.IsNullOrEmpty(txtClaseBoleto.Text) &&
            !string.IsNullOrEmpty(txtAerolinea.Text) && !string.IsNullOrEmpty(txtNumeroBoleto.Text) && !string.IsNullOrEmpty(txtDestino.Text);
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

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtHora_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtClaseBoleto_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtAerolinea_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtNumeroBoleto_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }
    }
}
