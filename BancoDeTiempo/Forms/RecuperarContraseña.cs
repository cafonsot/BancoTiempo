using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BancoDeTiempo.Forms
{
    public partial class RecuperarContraseña : Form
    {
        BancoDeTiempoDBEntities2 db = Program.db;
        string contraseña;

        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;

            var rec = db.Usuario.Where(a => a.Email == Email).FirstOrDefault();

            if (rec != null)
            {
                CambiarContraseña(txtEmail.Text);
                MessageBox.Show("Se ha cambiado la contraseña");

                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha encontrado el email");
            }
            

        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {

            string Email = txtEmail.Text;

            var rec = db.Usuario.Where(a => a.Email == Email).FirstOrDefault();

            if (rec != null)
            {
                GenerarContraseña(txtEmail.Text);
                MessageBox.Show("Se ha enviado la nueva contraseña al email indicado, la nueva contraseña es: " + contraseña);

                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha encontrado el email");
            }
        }

        private void CambiarContraseña(string Email)
        {
            var obj = db.Usuario.Where(a => a.Email == Email).FirstOrDefault();
            obj.Contraseña = txtContraseña.Text;
            db.SaveChanges();
        }

        public void GenerarContraseña (string Email)
        {
            var obj = db.Usuario.Where(a => a.Email == Email).FirstOrDefault();

            var caracteres = "ABDCEFGHIJKLMNOPQRSTUVWXYZabcdefghyjklmnopqrstuvwxyz1234567890";
            var crearContraseña = new char[8];
            Random rd = new Random();

            for (int i =0; i < crearContraseña.Length; i++)
            {
                crearContraseña[i] = caracteres[rd.Next(caracteres.Length)];
            }

            var nuevaContraseña = new String(crearContraseña);   
            
            {
                obj.Contraseña = nuevaContraseña;
                contraseña = nuevaContraseña;

                db.Usuario.Attach(obj);
                db.Entry(obj).State = EntityState.Modified;
            }
            
            db.SaveChanges();

            EnviarEmail(nuevaContraseña, Email);
        }

        public void EnviarEmail(string nuevaContraseña, string Email)
        {
           
        }

        private void RecuperarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
