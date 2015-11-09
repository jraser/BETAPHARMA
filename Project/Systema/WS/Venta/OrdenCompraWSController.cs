using BL.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Systema.WS.Venta
{
    public class OrdenCompraWSController : ApiController
    {
        public string Post(OrdenCompra obj)
        {
            OrdenCompraBL bl = new OrdenCompraBL();
            return bl.OrdenCompraCreate(obj);
        }
        public OrdenCompra Get(int ID_Orden)
        {
            OrdenCompraBL bl = new OrdenCompraBL();
            return bl.OrdenCompraGet(ID_Orden);
        }

        public List<OrdenCompraView> Get(string Nombres_Socio, DateTime FechaInI, DateTime FechaFin, string Descripcion)
        {
            OrdenCompraBL bl = new OrdenCompraBL();
            return bl.OrdenCompraList(Nombres_Socio, FechaInI,  FechaFin, Descripcion);
        }


        public List<OrdenCompraView> Get(int ID_Socio, String Estado)
        {
            OrdenCompraBL bl = new OrdenCompraBL();
            return bl.OrdenCompraList2(ID_Socio, Estado);
        }


        public List<OrdenCompraView> Get(int ID_Socio, DateTime FechaInI, DateTime FechaFin, String Estado)
        {
            OrdenCompraBL bl = new OrdenCompraBL();
            return bl.OrdenCompraListPorFecha(ID_Socio, FechaInI, FechaFin, Estado);
        }

        public string Delete(int ID_Orden)
        {
            OrdenCompraBL bl = new OrdenCompraBL();
            return bl.OrdenCompraEstado(ID_Orden);
        }

    }
}
