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
    public class DetalleOrdenVentaWSController : ApiController
    {
        public string Post(DetalleOrdenVenta obj)
        {
            DetalleOrdenVentaBL bl = new DetalleOrdenVentaBL();
            return bl.DetalleOrdenVentaCreate(obj);
        }

        public List<DetalleOrdenVentaView> Get(int ID_Orden)
        {
            DetalleOrdenVentaBL bl = new DetalleOrdenVentaBL();
            return bl.DetalleOrdenVentaList(ID_Orden);
        }

        public string Delete(int Atendido, int Faltante, int ID_DetalleOrden)
        {
            DetalleOrdenVentaBL bl = new DetalleOrdenVentaBL();
            return bl.DetalleMovimientoOrdenVenta(Atendido, Faltante, ID_DetalleOrden);
        }

        public string Delete(int ID_DetalleOrden)
        {
            DetalleOrdenVentaBL bl = new DetalleOrdenVentaBL();
            return bl.DetalleDelete(ID_DetalleOrden);
        }

    }
}