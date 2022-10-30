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
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
