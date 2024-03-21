using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Modelos
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set;  }
        public decimal Dinero { get; set; }
        public string Ci { get; set; }
        public DateTime FechaNac { get; set; }
    }
}
