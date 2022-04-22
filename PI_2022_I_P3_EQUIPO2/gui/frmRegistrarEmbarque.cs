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
    public partial class frmRegistrarEmbarque : Form
    {
        protected int ContadorTextBox { get; set; } = 9;
        List<Embarque> registroGrid = new List<Embarque>();
        StreamWriter archivoWriter;
        StreamReader archivoReader;
        enum IndicesTextBox
        {
            Id,
            Nombre,
            Direccion,
            Costo,
            FechaActual,
            Telefono,
            TipoBoleto,
            Compañia,
            Cantidad

        }
        public frmRegistrarEmbarque()
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
                txtDireccion.Text,
                txtCosto.Text,
                txtFechaActual.Text,
                txtTelefono.Text,
                txtTipoBoleto.Text,
                txtCompañia.Text,
                txtCantidad.Text

            };
        }

        private void btnLecturaEmbarque_Click_1(object sender, EventArgs e)
        {

            frmEmbarque frmEmbarque = new frmEmbarque();
            frmEmbarque.ShowDialog(this);
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
                        var cuenta = new Embarque(
                            numero,
                            valores[(int)IndicesTextBox.Nombre],
                            valores[(int)IndicesTextBox.Direccion],
                            decimal.Parse(valores[(int)IndicesTextBox.Costo]),
                            valores[(int)IndicesTextBox.FechaActual],
                            int.Parse(valores[(int)IndicesTextBox.Telefono]),
                            valores[(int)IndicesTextBox.TipoBoleto],
                            valores[(int)IndicesTextBox.Compañia],
                            int.Parse(valores[(int)IndicesTextBox.Cantidad])
                            );
                        archivoWriter.WriteLine($"{cuenta.ID},{cuenta.Nombre},{cuenta.Direccion},{cuenta.Costo},{cuenta.FechaActual}," +
                            $"{cuenta.Telefono},{cuenta.TipoBoleto},{cuenta.Compañia},{cuenta.Cantidad}");
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
            var var = !string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtDireccion.Text) &&
            !string.IsNullOrEmpty(txtCosto.Text) && !string.IsNullOrEmpty(txtFechaActual.Text) && !string.IsNullOrEmpty(txtTelefono.Text) &&
            !string.IsNullOrEmpty(txtTipoBoleto.Text) && !string.IsNullOrEmpty(txtCantidad.Text) && !string.IsNullOrEmpty(txtCantidad.Text);
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

        private void txtDireccion_TextChanged(object sender, EventArgs e)
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

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtTipoBoleto_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtCompañia_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ValidarVacio();
        }
    }
}
