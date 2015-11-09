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
    public class RequerimientosWSController :ApiController
    {
        public string Post(Requerimientos obj)
        {
            RequerimientoBL bl = new RequerimientoBL();
            return bl.RequerimientosCreate(obj);
        }

        public List<RequerimientosView> Get(string Nombres_Socio, DateTime FechaInI, DateTime FechaFin)
        {
            RequerimientoBL bl = new RequerimientoBL();
            return bl.RequerimientoList(Nombres_Socio, FechaInI, FechaFin);
        }

        public Requerimientos Get(int ID_Requerimientos)
        {
            RequerimientoBL bl = new RequerimientoBL();
            return bl.RequerimientoGet(ID_Requerimientos);

        }

  
    }
}