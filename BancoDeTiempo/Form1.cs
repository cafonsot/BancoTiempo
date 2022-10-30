using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDeTiempo.Forms;

namespace BancoDeTiempo
{
    public partial class Form1 : Form
    {
        BancoDeTiempoDBEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new BancoDeTiempoDBEntities();

            // Mostrar datos en los datagridview de usuario y anuncio

            usuarioBindingSource.DataSource = db.Usuario.ToList();
            anuncioBindingSource.DataSource = db.Anuncio.ToList();
        }

        // Boton de agreagar usuario

        private void btnUsrAñadir_Click(object sender, EventArgs e)
        {
            using(UsrAddEdit frm = new UsrAddEdit(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    usuarioBindingSource.DataSource = db.Usuario.ToList();
                }
            }
        }

        // Boton de editar usuario seleccionado

        private void button2_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource == null)
                return;
            using (UsrAddEdit frm = new UsrAddEdit(usuarioBindingSource.Current as Usuario))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    usuarioBindingSource.DataSource = db.Usuario.ToList();
                }
            }
        }

        // Boton de eliminar usuario seleccionado

        private void btnUsrEliminar_Click(object sender, EventArgs e)
        {
            if(usuarioBindingSource.Current != null)
            {
                if (MessageBox.Show("¿Quieres eliminar esta fila?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Usuario.Remove(usuarioBindingSource.Current as Usuario);
                    usuarioBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }

        // Boton de añadir anuncio

        private void btnAnuAñadir_Click(object sender, EventArgs e)
        {
            using (AnuAddEdit frm = new AnuAddEdit(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    anuncioBindingSource.DataSource = db.Anuncio.ToList();
                }
            }
        }

        // Boton de editar anuncio seleccionado

        private void btnAnuEditar_Click(object sender, EventArgs e)
        {
            if (anuncioBindingSource == null)
                return;
            using (AnuAddEdit frm = new AnuAddEdit(anuncioBindingSource.Current as Anuncio))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    anuncioBindingSource.DataSource = db.Anuncio.ToList();
                }
            }
        }

        // Boton de borrar anuncio seleccionado

        private void btnAnuEliminar_Click(object sender, EventArgs e)
        {
            if (anuncioBindingSource.Current != null)
            {
                if (MessageBox.Show("¿Quieres eliminar esta fila?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Anuncio.Remove(anuncioBindingSource.Current as Anuncio);
                    anuncioBindingSource.RemoveCurrent();
                    db.SaveChanges();
                }
            }
        }

        //
        // Metodos autogenerados a partir de aquí
        //

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
