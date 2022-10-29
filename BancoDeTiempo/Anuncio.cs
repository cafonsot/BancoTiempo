using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeTiempo
{
    public class Anuncio
    {

        public int Id { get; set; }
        public Categoria categoria { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }


    }
}
