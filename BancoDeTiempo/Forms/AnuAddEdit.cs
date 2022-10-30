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
    public partial class AnuAddEdit : Form
    {
        BancoDeTiempoDBEntities db;

        public AnuAddEdit(Anuncio obj)
        {
            InitializeComponent();
            db = new BancoDeTiempoDBEntities();

            if (obj == null)
            {
                anuncioBindingSource.DataSource = new Anuncio();
                db.Anuncio.Add(anuncioBindingSource.Current as Anuncio);
            }
            else
            {
                anuncioBindingSource.DataSource = obj;
                db.Anuncio.Attach(anuncioBindingSource.Current as Anuncio);
            }
        }

        // Metodo que previene aplicar si no hay datos para ello, el cual comprueba todos los datos a introducir

        private void AnuAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(textCategoria.Text))
                {
                    MessageBox.Show("Agrege una categoria.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textCategoria.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(textDescripcion.Text))
                {
                    MessageBox.Show("Agrege una descripción.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textDescripcion.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(textFecha.Text))
                {
                    MessageBox.Show("Agrege una fecha en formato dd/mm/aaaa hh/mm/ss.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textFecha.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
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
    }
}
