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
    public class DescuentosProductoWSController : ApiController
    {
        public List<DescuentoProducto> Get(string Nombre)
        {
            DescuentoProductoBL bl = new DescuentoProductoBL();
            return bl.DescuentoProductoLists(Nombre);
        }

     
    }
}
