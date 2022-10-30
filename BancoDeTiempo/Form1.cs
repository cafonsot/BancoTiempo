using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeTiempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (BancoDeTiempoDBEntities db = new BancoDeTiempoDBEntities())
            {
                dataGridView1.DataSource = db.Usuario.ToList();
                dataGridView2.DataSource = db.Anuncio.ToList();
            }
        }

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnUsrAñadir_Click(object sender, EventArgs e)
        {
            using(UsrAddEdit frm )
        }
    }
}
