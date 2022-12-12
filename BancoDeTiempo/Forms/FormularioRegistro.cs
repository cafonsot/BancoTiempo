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
    public partial class FormularioRegistro : Form
    {
        BancoDeTiempoDBEntities2 db = Program.db;
        public FormularioRegistro()
        {
            InitializeComponent();
        }

        public bool IsEmpty()
        {
            if (txtNombre.Text.Trim() == "" || txtApellido1.Text.Trim() == "" || txtApellido2.Text.Trim() == "" ||
                txtEmail.Text.Trim() == "" || txtTelefono.Text.Trim() == "" || txtContraseña.Text.Trim() == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Usuario obj = new Usuario();

            if (!IsEmpty())
            {
                int idActual = db.Usuario.Count() + 1;


                obj.IdUsuario = idActual;
                obj.Nombre = txtNombre.Text;
                obj.Apellido1 = txtApellido1.Text;
                obj.Apellido2 = txtApellido2.Text;
                obj.Email = txtEmail.Text;
                obj.Telefono = int.Parse(txtTelefono.Text);
                obj.Contraseña = txtContraseña.Text;
                obj.HorasAcumuladas = 0;

                db.Usuario.Add(obj);

                db.SaveChanges();

                MessageBox.Show("Se ha registrado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos");
            }
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

