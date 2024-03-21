using Examen1.Modelos;
using Examen1.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from cliente";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "table");
            return lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values('" + cliente.Nombre + "'," +
                                                         "" + cliente.Dinero + "," +
                                                         "'" + cliente.Ci + "'," +
                                                         "'" + cliente.FechaNac + "' )";
            conexion.Ejecutar(consulta);
        }
        Cliente cliente = new Cliente();
        public Cliente ObtenerClienteIdDal(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "table");
            if (tabla.Rows.Count > 0)
            {
                cliente.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                cliente.Nombre = tabla.Rows[0]["nombre"].ToString();
                cliente.Dinero = Convert.ToDecimal(tabla.Rows[0]["dinero"]);
                cliente.FechaNac = Convert.ToDateTime(tabla.Rows[0]["fechanac"]);

            }
            return cliente;
        }
        public void EditarClienteDal(Cliente c)
        {
            string consulta = "update cliente set nombre='" + c.Nombre + "'," +
                                                        "dinero=" + c.Dinero + "," +
                                                        "fechanac='" + c.FechaNac + "' " +
                                                "where idcliente=" + c.IdCliente;
            conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
