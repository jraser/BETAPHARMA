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
    public class DetalleOrdenCompraWSController : ApiController
    {
        public string Post(DetalleOrdenCompra obj)
        {
            DetalleOrdenCompraBL bl = new DetalleOrdenCompraBL();
            return bl.DetalleOrdenCompraCreate(obj);
        }

      
        public DetalleOrdenCompra Get(int ID_DetalleOrden, int ID_Orden)
        {
            DetalleOrdenCompraBL bl = new DetalleOrdenCompraBL();
            return bl.DetalleOrdenCompraGet(ID_DetalleOrden, ID_Orden);

        }

        public List<DetalleOrdenCompraView> Get(int ID_Orden)
        {
            DetalleOrdenCompraBL bl = new DetalleOrdenCompraBL();
            return bl.DetalleOrdenCompraList(ID_Orden);
        }

        public string Delete(int ID_DetalleOrden)
        {
            DetalleOrdenCompraBL bl = new DetalleOrdenCompraBL();
            return bl.DetalleDelete(ID_DetalleOrden);
        }

        //public OrdenCompra Get(int ID_Orden)
        //{
        //    OrdenCompraBL bl = new OrdenCompraBL();
        //    return bl.OrdenCompraGet(ID_Orden);
        //}
    }
}
