using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeTiempo
{
    public class Usuario
    {

        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string email { get; set; }
        public long telefono { get; set; }
        public int horasAcumuladas { get; set; }
        public string contraseña { get; set; }


    }
}
