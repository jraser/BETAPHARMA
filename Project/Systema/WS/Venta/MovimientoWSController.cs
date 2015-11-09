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
    public class MovimientoWSController : ApiController
    {
        public string Post(Movimiento obj)
        {
            MovimientoBL bl = new MovimientoBL();
            return bl.MovimientoCreate(obj);
        }

        public List<MovimientoView> Get(string Nombres_Socio, DateTime FechaInI, DateTime FechaFin, string Tipo_Movimiento)
        {
            MovimientoBL bl = new MovimientoBL();
            return bl.MovimientoList(Nombres_Socio, FechaInI, FechaFin, Tipo_Movimiento);
        }

        public List<MovimientoView> Get(string Nombres_Socio, DateTime FechaInI, DateTime FechaFin)
        {
            MovimientoBL bl = new MovimientoBL();
            return bl.MovimientoList2(Nombres_Socio, FechaInI, FechaFin);
        }

        public Movimiento Get(int ID_Movimiento)
        {
            MovimientoBL bl = new MovimientoBL();
            return bl.MovimientoGet(ID_Movimiento);

        }
    }
}