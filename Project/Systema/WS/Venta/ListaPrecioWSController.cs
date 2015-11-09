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
    public class ListaPrecioWSController :ApiController
    {


        //public Producto Get(int ID_Producto)
        //{
        //    ProductoBL bl = new ProductoBL();
        //    return bl.ProductoGet(ID_Producto);
        //}


        public List<ListaPrecioView> Get(string Descripcion_Producto, string Nombre, string Nombres_Socio)
        {
            ListaPrecioBL bl = new ListaPrecioBL();
            return bl.ALTProductoBySocioList(Descripcion_Producto, Nombre, Nombres_Socio);
        }

   
    }
}
