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
    public partial class frmRegistrarBoleto : Form
    {
        protected int ContadorTextBox { get; set; } = 7;
        List<Boleto> registroGrid = new List<Boleto>();
        StreamWriter archivoWriter;
        StreamReader archivoReader;
        enum IndicesTextBox
        {
            Nombre,
            Id,
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

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
           this.Close();
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
        public void LimpiarTextBox()
        {
            foreach (Control ControlGUI in Controls)
            {
                (ControlGUI as TextBox)?.Clear();
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string[] valores = ObtenerValoresTextBox();
            if (!string.IsNullOrEmpty(valores[(int)IndicesTextBox.Id]))
            {
                try
                {
                    int NumeroId = int.Parse(valores[(int)IndicesTextBox.Id]);
                    if (NumeroId > 0)
                    {
                        var cuenta = new Boleto(
                            NumeroId,
                            valores[(int)IndicesTextBox.Cliente],
                            valores[(int)IndicesTextBox.RTN],
                            valores[(int)IndicesTextBox.Comida],
                            valores[(int)IndicesTextBox.Refrescos],
                            valores[(int)IndicesTextBox.Postre],
                            valores[(int)IndicesTextBox.Fundacion]
                            );
                        archivoWriter.WriteLine(
                            $"{cuenta.ID}, {cuenta.NombreCliente},{cuenta.RTN},{cuenta.Comida},{cuenta.Fresco}," +
                            $"{cuenta.Postre},{cuenta.Fundacion}"
                            );
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
