using Examen1.DAL;
using Examen1.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.BSS
{
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClienteDal();
        }
        public void InsertarComputadoraBss(Cliente cliente)
        {
            dal.InsertarClienteDal(cliente);
        }
        public Cliente ObtenerComputadoraIdBss(int idc)
        {
            return dal.ObtenerClienteIdDal(idc);
        }
        public void EditarComputadoraBss(Cliente c)
        {
            dal.EditarClienteDal(c);
        }
        public void EliminarClienteBss(int idc)
        {
            dal.EliminarClienteDal(idc);
        }
    }
}
