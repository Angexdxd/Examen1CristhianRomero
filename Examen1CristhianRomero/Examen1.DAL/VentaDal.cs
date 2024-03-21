using Examen1.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.DAL
{
    public class VentaDal
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "select * from venta";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "table");
            return lista;
        }
        public void InsertarVentaDal(Venta venta)
        {
            string consulta = "insert into venta values(" + venta.IdCliente + "," +
                                                         "'" + venta.Producto + "'," +
                                                         "" + venta.Precio + "," +
                                                         "'" + venta.Fecha + "' )";
            conexion.Ejecutar(consulta);
        }
        Venta venta = new Venta();
        public Venta ObtenerVentaIdDal(int id)
        {
            string consulta = "select * from venta where idventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "table");
            if (tabla.Rows.Count > 0)
            {
                venta.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                venta.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                venta.Producto = tabla.Rows[0]["producto"].ToString();
                venta.Precio = Convert.ToDecimal(tabla.Rows[0]["precio"]);
                venta.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);

            }
            return venta;
        }
        public void EditarVentaDal(Venta c)
        {
            string consulta = "update venta set idcliente=" + c.IdCliente + "," +
                                                        "producto='" + c.Producto + "'," +
                                                        "precio=" + c.Precio + "," +
                                                        "fecha='" + c.Fecha + "' " +
                                                "where idventa=" + c.IdVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarVentaDal(int id)
        {
            string consulta = "delete from venta where idventa=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
