using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeTiempo.Forms
{
    public partial class Login : Form
    {

        public static string UsuarioActivo;

        BancoDeTiempoDBEntities2 db = Program.db;
        public static MenuPrincipal menuPrincipal;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            txtEmail.Text = "";
            txtContraseña.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Contraseña = txtContraseña.Text;
            UsuarioActivo = Email;

            var rec = db.Usuario.Where(a => a.Email == Email && a.Contraseña == Contraseña).FirstOrDefault();

            if (rec != null)
            {
                MessageBox.Show("Sesión iniciada correctametne");

                this.Hide();
                Clear();
                menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
            }
            else
            {
                MessageBox.Show("No se ha podido iniciar la sesión");
            }

           
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            using (FormularioRegistro frm = new FormularioRegistro())
            {
                if (frm.ShowDialog() != DialogResult.Abort)
                {
                    Login_Load(this, null);
                }
            }
        }

        private void linkLabelContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (RecuperarContraseña frm = new RecuperarContraseña())
            {
                if (frm.ShowDialog() != DialogResult.Abort)
                {
                    Login_Load(this, null);
                }
            }
        }
    }
}
