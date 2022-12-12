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
    public partial class MenuMensaje : Form
    {
        BancoDeTiempoDBEntities2 db = Program.db;
        int idAnuncio;
        int idUsuario;
        int tipoAnuncio;
        int horasActMe;
        int horasActOt;
        int horasAnu;
        int horasFinMe;
        int horasFinOt;

        public MenuMensaje(int IdAnuncio, int IdUsuario, int HorasAnu, int TipoAnuncio)
        {
            InitializeComponent();
            idAnuncio = IdAnuncio;
            idUsuario = IdUsuario;
            tipoAnuncio = TipoAnuncio;
            horasAnu = HorasAnu;
        }

        private void Mensaje_Load(object sender, EventArgs e)
        {
            // Mostrar datos del usuario logeado
            var getrecordMe = db.Usuario.Where(a => a.Email == Login.UsuarioActivo).SingleOrDefault();
            var getrecordA = db.Anuncio.Where(a => a.IdAnuncio == idAnuncio).SingleOrDefault();
            txtUser.Text = Login.UsuarioActivo;
            horasActMe = (int)getrecordMe.HorasAcumuladas;
            txtHoras.Text = horasActMe.ToString() + " Horas";
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!ComprobarNull())
            {
                int idActual = db.Mensaje.Count() + 1;

                var getrecordA = db.Anuncio.Where(a => a.IdAnuncio == idAnuncio).SingleOrDefault();
                var getrecordU = db.Usuario.Where(a => a.IdUsuario == idUsuario).SingleOrDefault();
                var getrecordMe = db.Usuario.Where(a => a.Email == Login.UsuarioActivo).SingleOrDefault();

                horasActOt = (int)getrecordU.HorasAcumuladas;

                Mensaje m = new Mensaje();
                m.IdMensaje = idActual;
                m.Anuncio = getrecordA.Descripcion;
                m.Texto = textMensaje.Text;
                m.UsuarioEnv = getrecordMe.IdUsuario;
                m.UsuarioRec = getrecordU.Email;
                db.Mensaje.Add(m);

                switch (tipoAnuncio)
                {
                    //En caso de que sea una Oferta
                    case 1:

                        // Restar Horas a usuario logeado
                        horasFinMe = horasActMe - horasAnu;

                        // Sumar Horas a usuario destino
                        horasFinOt = horasActOt + horasAnu;

                        break;

                    //En caso de que sea una Demanda
                    case 2:

                        // Restar Horas a usuario destino
                        horasFinOt = horasActOt - horasAnu;

                        // Sumar Horas a usuario logeado
                        horasFinMe = horasActMe + horasAnu;

                        break;

                    default:
                        break;
                }
                // Actualizamos con las nuevas horas del usuario logeado
                getrecordMe.HorasAcumuladas = horasFinMe;

                // Actualizamos con las nuevas horas del usuario destino
                getrecordU.HorasAcumuladas = horasFinOt;

                db.SaveChanges();
                MessageBox.Show("Mensaje enviado, se han actualizado las bolsas de horas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private bool ComprobarNull()
        {
            if (string.IsNullOrEmpty(textMensaje.Text))
            {
                MessageBox.Show("Agrege un mensaje para el anunciante.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textMensaje.Focus();
                return true;
            }
            return false;
        }

            private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
