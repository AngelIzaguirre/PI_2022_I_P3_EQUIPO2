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
    public partial class frmRegistrarLimpieza : Form
    {
        public frmRegistrarLimpieza()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLecturaLimpieza_Click(object sender, EventArgs e)
        {
            frmLimpieza frmLimpieza = new frmLimpieza();
            frmLimpieza.Show();
        }
    }
}
