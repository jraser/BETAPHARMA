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
    public class ProductoWSController : ApiController
    {


        public string Post(Producto obj)
        {
            ProductoBL bl = new ProductoBL();
            return bl.ProductoCreate(obj);
        }
        public List<ProductoView> Get(string Descripcion)
        {
            ProductoBL bl = new ProductoBL();
            return bl.ProductoList(Descripcion, 0, 0);
        }
         
        public string Delete(int ID_Producto)
        {
            ProductoBL bl = new ProductoBL();
            return bl.ProductoDelete(ID_Producto);
        }

        public Producto Get(int ID_Producto)
        {
            ProductoBL bl = new ProductoBL();
            return bl.ProductoGet(ID_Producto);
        }


        public List<ProductoView> Get(string Descripcion, int ID_Socio)
        {
            ProductoBL bl = new ProductoBL();
            return bl.ProductoBySocioList(Descripcion, 0, 0, ID_Socio);
        }

   
    }
}
