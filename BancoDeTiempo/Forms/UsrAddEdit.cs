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
    public partial class UsrAddEdit : Form
    {
        BancoDeTiempoDBEntities db;

        public UsrAddEdit(Usuario obj)
        {
            InitializeComponent();
            db = new BancoDeTiempoDBEntities();

            if (obj == null) 
            {
                usuarioBindingSource.DataSource = new Usuario();
                db.Usuario.Add(usuarioBindingSource.Current as Usuario);
            }
            else 
            {
                usuarioBindingSource.DataSource = obj;
                db.Usuario.Attach(usuarioBindingSource.Current as Usuario);
            }
        }

        // Metodo que previene aplicar si no hay datos para ello, el cual comprueba todos los datos a introducir

        private void UsrAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(textNombre.Text))
                {
                    MessageBox.Show("Agrege un nombre.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textNombre.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(textApellido1.Text) || string.IsNullOrEmpty(textApellido2.Text))
                {
                    MessageBox.Show("Agrege los apellidos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textApellido1.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(textEmail.Text))
                {
                    MessageBox.Show("Agrege un email.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textEmail.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(textEmail.Text))
                {
                    MessageBox.Show("Agrege un email.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textEmail.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(textTelefono.Text))
                {
                    MessageBox.Show("Agrege un teléfono.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textTelefono.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(textHorasAcumuladas.Text))
                {
                    MessageBox.Show("Agrege las horas acumuladas.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textHorasAcumuladas.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(textContraseña.Text))
                {
                    MessageBox.Show("Agrege una contraseña.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textContraseña.Focus();
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

        private void UsrAddEdit_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textApellido1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textApellido2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textHorasAcumuladas_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
