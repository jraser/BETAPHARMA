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
    public class OrdenVentaWSController : ApiController
    {
        public string Post(OrdenVenta  obj)
        {
            OrdenVentaBL bl = new OrdenVentaBL();
            return bl.OrdenVentaCreate(obj);
        }
        public List<OrdenVentaView > Get(string Nombres_Socio, DateTime FechaInI, DateTime FechaFin, string Descripcion)
        {
            OrdenVentaBL bl = new OrdenVentaBL();
            return bl.OrdenVentaList(Nombres_Socio, FechaInI, FechaFin, Descripcion);
        }

        public OrdenVenta Get(int ID_Orden)
        {
            OrdenVentaBL bl = new OrdenVentaBL();
            return bl.OrdenVentaGet(ID_Orden);
        }

        public List<OrdenVentaView > Get(int ID_Socio, DateTime FechaInI, DateTime FechaFin, String Estado)
        {
            OrdenVentaBL bl = new OrdenVentaBL();
            return bl.OrdenVentaListPorFecha(ID_Socio, FechaInI, FechaFin, Estado);
        }

        public string Delete(int ID_Orden)
        {
            OrdenVentaBL bl = new OrdenVentaBL();
            return bl.OrdenVentaEstado(ID_Orden);
        }


    }
}