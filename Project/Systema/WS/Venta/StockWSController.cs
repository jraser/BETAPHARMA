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
    public class StockWSController : ApiController
    {

        public string Post(int Id_Producto, string Codigo_Producto, string CodigoDif, string Lote, int Cantidad)
        {
            StockBL bl = new StockBL();
            return bl.StockCreate(Id_Producto, Codigo_Producto, CodigoDif, Lote, Cantidad);

        }

        public string Delete(int Id_Producto, string Codigo_Producto, string CodigoDif, string Lote, int Cantidad)
        {
            StockBL bl = new StockBL();
            return bl.StockUpdate(Id_Producto, Codigo_Producto, CodigoDif, Lote, Cantidad);

        }

        public List<StockView> Get(string Descripcion)
        {
            StockBL bl = new StockBL();
            return bl.StockAdd(Descripcion);
        }

    }
}