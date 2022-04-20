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
    public partial class frmEmpleado : Form
    {
        private int ContadorTextBox { get; set; } = 9;
        private StreamReader archivoReader;
        List<Empleado> registroGrid = new List<Empleado>();
        List<ComboBoxItem> registrosCombo = new List<ComboBoxItem>();
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
        public frmEmpleado()
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

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
        }

        private void menuPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMenu principal = new frmMenu();
            principal.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;
            string nombreArchivo;
            using (OpenFileDialog archivoSeleccionado = new OpenFileDialog())
            {
                Resultado = archivoSeleccionado.ShowDialog();
                nombreArchivo = archivoSeleccionado.FileName;
            }
            if (Resultado == DialogResult.OK)
            {
                LimpiarTextBox();
                if (string.IsNullOrEmpty(nombreArchivo))
                {
                    MessageBox.Show("Nombre de archivo Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        FileStream entrada = new FileStream(
                           nombreArchivo, FileMode.Open, FileAccess.Read);
                        archivoReader = new StreamReader(entrada);
                        btnAbrirArchivo.Enabled = false;
                        btnSiguientRegistro.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error abriendo el Archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnSiguientRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                var registroEntrada = archivoReader.ReadLine();
                if (registroEntrada != null)
                {
                    string[] entradacampo = registroEntrada.Split(',');
                    SetearValoresTextBox(entradacampo);
                }
                else
                {
                    archivoReader.Close();
                    btnAbrirArchivo.Enabled = true;
                    btnSiguientRegistro.Enabled = false;
                    LimpiarTextBox();
                    MessageBox.Show("No  tiene mas  registro en el Archivo", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException)
            {

                MessageBox.Show("Error Leyendo el Archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetearValoresTextBox(string[] valores)
        {
            if (valores.Length != ContadorTextBox)
                throw (new ArgumentException(
                  $"Deberia de ser  {ContadorTextBox} Elementos del  Arreglo", nameof(valores)));
            else
            {
                txtId.Text = valores[(int)IndicesTextBox.Id];
                txtNombre.Text = valores[(int)IndicesTextBox.Nombre];
                txtDireccion.Text = valores[(int)IndicesTextBox.Direccion];
                txtSalario.Text = valores[(int)IndicesTextBox.Salario];
                txtGenero.Text = valores[(int)IndicesTextBox.Genero];
                txtTelefono.Text = valores[(int)IndicesTextBox.Telefono];
                txtNumeroContrato.Text = valores[(int)IndicesTextBox.NumeroContrato];
                txtEdad.Text = valores[(int)IndicesTextBox.Edad];
                txtCargo.Text = valores[(int)IndicesTextBox.Cargo];
                registroGrid.Add(new Empleado(
                    Convert.ToInt32(txtId.Text),
                txtNombre.Text,
                txtDireccion.Text,
                decimal.Parse(txtSalario.Text),
                txtGenero.Text,
                int.Parse(txtTelefono.Text),
                int.Parse(txtNumeroContrato.Text),
                int.Parse(txtEdad.Text),
                txtCargo.Text));
                registrosCombo.Add(new ComboBoxItem(
                   txtId.Text,
                   txtNombre.Text
                ));
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = registroGrid;
            cbxEmpleado.DisplayMember = "Text";
            cbxEmpleado.ValueMember = "Value";
            cbxEmpleado.DataSource = registrosCombo;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dgvMostrar.CurrentCell.RowIndex;
            MessageBox.Show($"Grid {dgvMostrar.Rows[filaSeleccionada].Cells[0].Value}");

            ComboBoxItem itemSeleccionado = (ComboBoxItem)cbxEmpleado.SelectedItem;
            int valorSeleccionado = Convert.ToInt32(itemSeleccionado.Value);
            MessageBox.Show($"ComboBox {itemSeleccionado} y {valorSeleccionado}");
        }
    }
}
