using System;
using System.Windows.Forms;

namespace TacosControl.GUIs
{
    public partial class Frm_Login : Form
    {
        public bool Valido;

        public Frm_Login()
        {
            InitializeComponent();
            Valido = false;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Validar();
        }
        private void Validar()
        {
            bool bUser = false, bPass = false;

            if (txbUser.Text.ToUpper() == "ADMIN") bUser = true;
            if (txbPass.Text.ToUpper() == "TACOS.CORRALES") bPass = true;

            if (bUser == true && bPass == true)
            {
                Valido = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("El nombre de usuario o la contraseña son incorrectos....", 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Validar();
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
