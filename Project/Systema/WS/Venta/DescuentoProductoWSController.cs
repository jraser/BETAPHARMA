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
    public class DescuentoProductoWSController : ApiController
    {
        public List<DescuentoProductoView> Get(int ID_Grupo, string Mode)
        {
            DescuentoProductoBL bl = new DescuentoProductoBL();
            return bl.DescuentoProductoList(ID_Grupo,Mode);
        }

        public string Post(DescuentoProducto obj)
        {
            DescuentoProductoBL bl = new DescuentoProductoBL();
            return bl.DescuentoProductoCreate(obj);
        }

        public DescuentoProducto GetDescuento(int ID_Descuento)
        { 
            DescuentoProductoBL bl = new DescuentoProductoBL();
            return bl.DescuentoProductoGet(ID_Descuento);
        }

        public string Delete(int ID_Descuento)
        {
            DescuentoProductoBL bl = new DescuentoProductoBL();
            return bl.DescuentoProductoDelete(ID_Descuento);
        }
    
    }
}
