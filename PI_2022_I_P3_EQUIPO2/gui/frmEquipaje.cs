﻿using PI_2022_I_P3_EQUIPO2.Objetos;
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
    public partial class frmEquipaje : Form
    {
        private int ContadorTextBox { get; set; } = 9;
        private StreamReader archivoReader;
        List<Equipaje> registroGrid = new List<Equipaje>();
        List<ComboBoxItem> registrosCombo = new List<ComboBoxItem>();
        public string? ValorRetorno1 { get; set; }
        public string? ValorRetorno2 { get; set; }

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
        public frmEquipaje()
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
            frmMenu frmMenu= new frmMenu();
            frmMenu.Show();
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
                txtCantidad.Text = valores[(int)IndicesTextBox.Cantidad];
                txtHora.Text = valores[(int)IndicesTextBox.Hora];
                txtPeso.Text = valores[(int)IndicesTextBox.Peso];
                txtClaseBoleto.Text = valores[(int)IndicesTextBox.ClaseBoleto];
                txtAerolinea.Text = valores[(int)IndicesTextBox.Aerolinea];
                txtNumeroBoleto.Text = valores[(int)IndicesTextBox.NumeroBoleto];
                txtDestino.Text = valores[(int)IndicesTextBox.Destino];
                registroGrid.Add(new Equipaje(
                    Convert.ToInt32(txtId.Text),
                    txtNombre.Text,
                int.Parse(txtCantidad.Text),
                txtHora.Text,
                decimal.Parse(txtPeso.Text),
                txtClaseBoleto.Text,
                txtAerolinea.Text,
                int.Parse(txtNumeroBoleto.Text),
                txtDestino.Text));
                registrosCombo.Add(new ComboBoxItem(
                  txtId.Text,
                  txtNombre.Text
                ));
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = registroGrid;
            cboEquipaje.DisplayMember = "Text";
            cboEquipaje.ValueMember = "Value";
            cboEquipaje.DataSource = registrosCombo;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dgvMostrar.CurrentCell.RowIndex;
            MessageBox.Show($"Grid {dgvMostrar.Rows[filaSeleccionada].Cells[0].Value}");

            ComboBoxItem itemSeleccionado = (ComboBoxItem)cboEquipaje.SelectedItem;
            int valorSeleccionado = Convert.ToInt32(itemSeleccionado.Value);
            MessageBox.Show($"ComboBox {itemSeleccionado} y {valorSeleccionado}");
            this.ValorRetorno1 = valorSeleccionado.ToString();
            this.ValorRetorno2 = itemSeleccionado.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

    