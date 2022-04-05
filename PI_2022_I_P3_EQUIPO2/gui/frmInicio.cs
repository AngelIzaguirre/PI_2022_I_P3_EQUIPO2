using PI_2022_I_P3_EQUIPO2.gui;

namespace PI_2022_I_P3_EQUIPO2
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();

        }
    }
}