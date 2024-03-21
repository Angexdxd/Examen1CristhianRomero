using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Modelos
{
    public class Venta
    {
        public int IdVenta {  get; set; } 
        public int IdCliente {  get; set; }
        public string Producto { get;set }
        public decimal Precio { get; set; }
        public DateTime Fecha {  get; set; }
    }
}
