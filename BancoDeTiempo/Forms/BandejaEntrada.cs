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
    public partial class BandejaEntrada : Form
    {
        BancoDeTiempoDBEntities2 db = Program.db;
        int idUsuario;
        string email;
        public BandejaEntrada()
        {
            InitializeComponent();
        }

        private void BandejaEntrada_Load(object sender, EventArgs e)
        {
            email = Login.UsuarioActivo;
            txtUser.Text = email;
            var getrecordMe = db.Usuario.Where(a => a.Email == email).SingleOrDefault();
            idUsuario = getrecordMe.IdUsuario;
            mensajeBindingSource.DataSource = db.Mensaje.Where(a => a.UsuarioEnv != idUsuario && a.UsuarioRec == email).ToList();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.menuPrincipal.Show();
        }
    }
}
