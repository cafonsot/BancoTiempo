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
    public partial class AnuAdd : Form
    {
        BancoDeTiempoDBEntities2 db = Program.db;
        private static int TipoAnuncio;

        public AnuAdd(int tipo)
        {
            InitializeComponent();
            anuncioBindingSource.DataSource = db.Anuncio.ToList();
            categoriaBindingSource.DataSource = db.Categoria.ToList();
            usuarioBindingSource.DataSource = db.Usuario.ToList();

            TipoAnuncio = tipo;
        }
        private void AnuAddEdit_Load(object sender, EventArgs e)
        {
            txtUser.Text = Login.UsuarioActivo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var getrecordMe = db.Usuario.Where(a => a.Email == Login.UsuarioActivo).SingleOrDefault();

            if (!ComprobarNull())
            {
                int idActual = db.Anuncio.Count() + 1;
                int tipo = TipoAnuncio;

                Anuncio a = new Anuncio();

                a.IdAnuncio = idActual;
                a.Categoria = int.Parse(textCategoria.Text);
                a.Usuario = getrecordMe.IdUsuario;
                a.Descripcion = textDescripcion.Text;
                a.Fecha = dtFecha.Value;
                db.Anuncio.Add(a);

                switch (tipo)
                {
                    //En caso de que sea una Oferta
                    case 1:
                        Oferta o = new Oferta();
                        o.IdOferta = idActual;
                        o.Horas = int.Parse(textHoras.Text);
                        db.Oferta.Add(o);
                        break;

                    //En caso de que sea una Demanda
                    case 2:
                        Demanda d = new Demanda();
                        d.IdDemanda = idActual;
                        d.Horas = int.Parse(textHoras.Text);
                        db.Demanda.Add(d);
                        break;

                    default:
                        break;
                }
                db.SaveChanges();
                MessageBox.Show("Anuncio agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool ComprobarNull()
        { 
            if (string.IsNullOrEmpty(textCategoria.Text))
            {
                MessageBox.Show("Agrege una categoria.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCategoria.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textDescripcion.Text))
            {
                MessageBox.Show("Agrege una descripción.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textDescripcion.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(dtFecha.Text))
            {
                MessageBox.Show("Agrege una fecha.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtFecha.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textHoras.Text))
            {
                MessageBox.Show("Agrege las horas de cambio del anuncio.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textHoras.Focus();
                return true;
            }
            return false;
        }

        //
        // Metodos autogenerados a partir de aqui
        //

        private void textCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFecha_TextChanged(object sender, EventArgs e)
        {

        }


        private void AnuAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
