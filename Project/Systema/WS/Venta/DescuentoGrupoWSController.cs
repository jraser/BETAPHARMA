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
    public class DescuentoGrupoWSController : ApiController
    {
        public string Post(DescuentoGrupo obj)
        {
            DescuentoGrupoBL bl = new DescuentoGrupoBL();
            return bl.DescuentoGrupoCreate(obj);
        }
    }
}
