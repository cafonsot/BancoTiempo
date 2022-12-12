using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using BancoDeTiempo.Forms;


namespace BancoDeTiempo
{
    public partial class MenuPrincipal : Form
    {
        BancoDeTiempoDBEntities2 db = Program.db;
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Mostrar datos en los datagridview de usuario y anuncio
            var getrecordMe = db.Usuario.Where(a => a.Email == Login.UsuarioActivo).SingleOrDefault();
            txtUser.Text = getrecordMe.Email;
            txtWellcome.Text = "Hola " + getrecordMe.Nombre;
            usuarioBindingSource.DataSource = db.Usuario.ToList();
            anuncioBindingSource.DataSource = db.Anuncio.ToList();
        }

        // Boton de agreagar usuario
        private void btnOfertas_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuOfertas menuOfertas = new MenuOfertas();
            menuOfertas.Show();
        }

        private void btnDemandas_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDemanda menuDemanda = new MenuDemanda();
            menuDemanda.Show();
        }

        private void btnBandeja_Click(object sender, EventArgs e)
        {
            this.Hide();
            BandejaEntrada bandeja = new BandejaEntrada();
            bandeja.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.login.Show();
        }
    }
}