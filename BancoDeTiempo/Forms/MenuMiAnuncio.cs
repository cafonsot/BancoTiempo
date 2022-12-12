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
    public partial class MenuMiAnuncio : Form
    {
        BancoDeTiempoDBEntities2 db = Program.db;
        int idUsuario;

        public MenuMiAnuncio()
        {
            InitializeComponent();
        }

        private void MenuMiAnuncio_Load(object sender, EventArgs e)
        {
            var getrecordMe = db.Usuario.Where(a => a.Email == Login.UsuarioActivo).SingleOrDefault();
            idUsuario = getrecordMe.IdUsuario;
            txtUser.Text = getrecordMe.Email;
            dataGridView1.DataSource = db.Anuncio.Where(a => a.Usuario == idUsuario).ToList();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
