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
    public partial class frmRegistrarEmpleado : Form
    {
        protected int ContadorTextBox { get; set; } = 9;
        List<Empleado> registroGrid = new List<Empleado>();
        StreamWriter archivoWriter;
        StreamReader archivoReader;
        enum IndicesTextBox
        {
            Id,
            Nombre,
            Direccion,
            Salario,
            Genero,
            Telefono,
            NumeroContrato,
            Edad,
            Cargo

        }
        public frmRegistrarEmpleado()
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
                txtSalario.Text,
                txtGenero.Text,
                txtTelefono.Text,
                txtNumeroContrato.Text,
                txtEdad.Text,
                txtCargo.Text

            };
        }
        private void btnLecturaEmpleado_Click_1(object sender, EventArgs e)
        {

            frmEmpleado frmEmpleado = new frmEmpleado();
            frmEmpleado.ShowDialog();
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
                        var cuenta = new Empleado(
                            numero,
                            valores[(int)IndicesTextBox.Nombre],
                            valores[(int)IndicesTextBox.Direccion],
                            decimal.Parse(valores[(int)IndicesTextBox.Salario]),
                            valores[(int)IndicesTextBox.Genero],
                            int.Parse(valores[(int)IndicesTextBox.Telefono]),
                            int.Parse(valores[(int)IndicesTextBox.NumeroContrato]),
                            int.Parse(valores[(int)IndicesTextBox.Edad]),
                            valores[(int)IndicesTextBox.Cargo]
                            );
                        archivoWriter.WriteLine($"{cuenta.ID},{cuenta.Nombre},{cuenta.Direccion},{cuenta.Salario},{cuenta.Genero}," +
                            $"{cuenta.Telefono},{cuenta.NumeroContrato},{cuenta.Edad},{cuenta.Cargo}");
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
