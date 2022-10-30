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
        public AnuAddEdit()
        {
            InitializeComponent();
            InitializeComponent();
            using (BancoDeTiempoDBEntities db = new BancoDeTiempoDBEntities())
            {
                /*
                textCategoria.
                textDescripcion.
                textFecha.
                */
            }
        }

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
