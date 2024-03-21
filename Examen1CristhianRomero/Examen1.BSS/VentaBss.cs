using Examen1.DAL;
using Examen1.Modelos;
using System.Data;

namespace Examen1.BSS
{
    public class VentaBss
    {
        VentaDal dal = new VentaDal();
        public DataTable ListarVentaBss()
        {
            return dal.ListarVentaDal();
        }
        public void InsertarVentaBss(Venta venta)
        {
            dal.InsertarVentaDal(venta);
        }
        public Venta ObtenerVentaIdBss(int idc)
        {
            return dal.ObtenerVentaIdDal(idc);
        }
        public void EditarVentaBss(Venta c)
        {
            dal.EditarVentaDal(c);
        }
        public void EliminarVentaBss(int idc)
        {
            dal.EliminarVentaDal(idc);
        }
    }
}
