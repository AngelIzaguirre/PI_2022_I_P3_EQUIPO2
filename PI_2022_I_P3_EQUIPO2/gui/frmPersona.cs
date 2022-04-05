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
    public partial class frmPersona : Form
    {
        public frmPersona()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
        }

        private void menuPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarPersona frmAgregarPersona = new frmAgregarPersona();
            frmAgregarPersona.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarPersona frmEliminarPersona=new frmEliminarPersona();
            frmEliminarPersona.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarPersona frmActualizarPersona = new frmActualizarPersona();
            frmActualizarPersona.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarPersona frmBuscarPersona = new frmBuscarPersona();
            frmBuscarPersona.Show();
        }
    }
}
