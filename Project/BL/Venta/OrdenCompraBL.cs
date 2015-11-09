using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class OrdenCompraBL
    {
        OrdenCompraDAO Dao = new OrdenCompraDAO();
        



        public List<OrdenCompraView> OrdenCompraList(string Nombres_Socio, DateTime FechaInI, DateTime FechaFin, string Descripcion)
        {

            return Dao.OrdenCompraList(Nombres_Socio, FechaInI, FechaFin, Descripcion);

        }

        public List<OrdenCompraView> OrdenCompraList2(int ID_Socio, String Estado)
        {
            return Dao.OrdenCompraList2(ID_Socio, Estado);
        }


        public List<OrdenCompraView> OrdenCompraListPorFecha(int ID_Socio, DateTime FechaInI, DateTime FechaFin, String Estado)
        {
            return Dao.OrdenCompraListPorFecha(ID_Socio, FechaInI, FechaFin, Estado);
        }
        public OrdenCompra OrdenCompraGet(int ID_Orden)
        {
            return Dao.OrdenCompraGet(ID_Orden);
            //var obj = Dao.OrdenCompraGet(ID_Orden);

            ////obj.Lista = BL.DetalleOrdenCompraList(ID_Orden);
            ////return obj;
        }


        public string OrdenCompraCreate(OrdenCompra obj)
        {

            return Dao.OrdenCompraCreate(obj);
            //var Id = Dao.OrdenCompraCreate(obj);
            //foreach (var item in obj.Lista)
            //{
            //    item.ID_Orden = int.Parse(Id);
            //    BL.DetalleOrdenCompraCreate(item);

            //}
            //return Id;

        }

        public string OrdenCompraEstado(int ID_Orden)
        {

            return Dao.OrdenCompraEstado(ID_Orden);

        }
    }
}
