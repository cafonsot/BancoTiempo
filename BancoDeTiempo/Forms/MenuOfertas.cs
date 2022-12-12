﻿using System;
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
    public partial class MenuOfertas : Form
    {
        BancoDeTiempoDBEntities2 db = Program.db;
        int idAnuncio;
        int idUsuario;
        int horasAct;
        int horasAnu;

        public MenuOfertas()
        {
            InitializeComponent();
        }

        private void MenuOfertas_Load(object sender, EventArgs e)
        {
            // Mostrar datos del usuario logeado
            var getrecordMe = db.Usuario.Where(a => a.Email == Login.UsuarioActivo).SingleOrDefault();
            txtUser.Text = Login.UsuarioActivo;
            horasAct = (int)getrecordMe.HorasAcumuladas;
            txtHoras.Text = horasAct.ToString() + " Horas";

            // Mostrar datos del anuncio seleccionado
            ofertaBindingSource.DataSource = db.Oferta.ToList();
            anuncioBindingSource.DataSource = db.Anuncio.ToList();
            usuarioBindingSource.DataSource = db.Usuario.ToList();
            categoriaBindingSource.DataSource = db.Categoria.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int max = db.Anuncio.Count();
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                for (int i = 0; i <= max; i++)
                {
                    if ((int)row.Cells[0].Value == i)
                    {
                        var getrecordA = db.Anuncio.Where(a => a.IdAnuncio == i).SingleOrDefault();
                        var getrecordC = db.Categoria.Where(a => a.IdCategoria == getrecordA.Categoria).SingleOrDefault();
                        var getrecordU = db.Usuario.Where(a => a.IdUsuario == getrecordA.Usuario).SingleOrDefault();

                        txtCategoria.Text = getrecordC.TipoServicio;
                        txtDescripcion.Text = getrecordA.Descripcion;
                        txtFecha.Text = getrecordA.Fecha.ToString();
                        txtUsuario.Text = getrecordU.Email;

                        idAnuncio = getrecordA.IdAnuncio;
                        idUsuario = getrecordU.IdUsuario;
                        horasAnu = (int)row.Cells[1].Value;
                    }
                }
            }            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (AnuAdd frm = new AnuAdd(1))
            {
                if (frm.ShowDialog() != DialogResult.Abort)
                {
                    MenuOfertas_Load(this, null);
                }
            }
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            var getrecordMe = db.Usuario.Where(a => a.Email == Login.UsuarioActivo).SingleOrDefault();
            if (getrecordMe.IdUsuario != idUsuario)
            {
                if (horasAct >= horasAnu)
                {
                    using (MenuMensaje Mfrm = new MenuMensaje(idAnuncio, idUsuario, horasAnu, 1))
                    {
                        if (Mfrm.ShowDialog() != DialogResult.Abort)
                        {
                            MenuOfertas_Load(this, null);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No tiene suficientes horas para aceptar la oferta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No puedes contactarte a ti mismo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMisAnuncios_Click(object sender, EventArgs e)
        {
            using (MenuMiAnuncio frm = new MenuMiAnuncio())
            {
                if (frm.ShowDialog() != DialogResult.Abort)
                {
                    MenuOfertas_Load(this, null);
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.menuPrincipal.Show();
        }
    }
}