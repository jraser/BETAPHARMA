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
    public class DetalleMovimientoWSController : ApiController
    {

        public string Post(DetalleMovimiento obj)
        {
            DetalleMovimientoBL bl = new DetalleMovimientoBL();
            return bl.DetalleMovimientoCreate(obj);

        }
        public string Delete(int Atendido, int Faltante, int ID_DetalleOrden)
        {
            DetalleOrdenCompraBL bl = new DetalleOrdenCompraBL();
            return bl.DetalleMovimientoOrdenCompra(Atendido, Faltante, ID_DetalleOrden);
        }

    }
}