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
        public UsrAddEdit()
        {
            InitializeComponent();
            using (BancoDeTiempoDBEntities db = new BancoDeTiempoDBEntities())
            {
                /*
                textNombre.
                textApellido1.
                textApellido2.
                textEmail.
                textTelefono.
                textHorasAcumuladas.
                textContraseña.
                */
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UsrAddEdit_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
