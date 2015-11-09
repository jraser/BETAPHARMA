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
    public class UnidadMedidaWSController : ApiController
    {

        public List<UnidadMedida> Get()
        {
            UnidadMedidaBL bl = new UnidadMedidaBL();
            return bl.dll_UnidadList();
        }
    }
}
