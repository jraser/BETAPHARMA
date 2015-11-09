using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.Venta
{
    public class OrdenVentaBL
    {
        OrdenVentaDAO Dao = new OrdenVentaDAO();

        public string OrdenVentaCreate(OrdenVenta obj)
        {

            return Dao.OrdenVentaCreate(obj);
        }

        public List<OrdenVentaView> OrdenVentaList(string Nombres_Socio, DateTime FechaInI, DateTime FechaFin, string Descripcion)
        {

            return Dao.OrdenVentaList(Nombres_Socio, FechaInI, FechaFin, Descripcion);

        }
        public OrdenVenta OrdenVentaGet(int ID_Orden)
        {
            return Dao.OrdenVentaGet(ID_Orden);
        }

        public List<OrdenVentaView> OrdenVentaListPorFecha(int ID_Socio, DateTime FechaInI, DateTime FechaFin, String Estado)
        {
            return Dao.OrdenVentaListPorFecha(ID_Socio, FechaInI, FechaFin, Estado);
        }
        public string OrdenVentaEstado(int ID_Orden)
        {

            return Dao.OrdenVentaEstado(ID_Orden);

        }
    }
}
