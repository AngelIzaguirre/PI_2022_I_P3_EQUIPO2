﻿using System;
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
    public partial class frmMantenimiento : Form
    {
        private int ContadorTextBox { get; set; } = 9;
        private StreamReader archivoReader;
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
        public frmMantenimiento()
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
            frmInicio frm = new frmInicio();
            frm.Show();
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
                txtMaterial.Text = valores[(int)IndicesTextBox.Maerial];
                txtCosto.Text = valores[(int)IndicesTextBox.Costo];
                txtEmpresa.Text = valores[(int)IndicesTextBox.Empresa];
                txtNumeroSerie.Text = valores[(int)IndicesTextBox.NumeroSerie];
                txtProblema.Text = valores[(int)IndicesTextBox.Problema];
                txtHoraIngreso.Text = valores[(int)IndicesTextBox.HoraIngreso];
                txtHoraSalida.Text = valores[(int)IndicesTextBox.HoraSalida];

            }
        }

    }
}
