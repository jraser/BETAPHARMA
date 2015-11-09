using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.Venta
{
    public class StockBL
    {
        StockDAO Dao = new StockDAO();

        public string StockCreate(int Id_Producto, string Codigo_Producto, string CodigoDif, string Lote, int Cantidad)
        {

            return Dao.StockCreate(Id_Producto, Codigo_Producto, CodigoDif, Lote, Cantidad);

        }
        public string StockUpdate(int Id_Producto, string Codigo_Producto, string CodigoDif, string Lote, int Cantidad)
        {

            return Dao.StockUpdate(Id_Producto, Codigo_Producto, CodigoDif, Lote, Cantidad);

        }
        public List<StockView> StockAdd(string Descripcion)
        {

            return Dao.StockAdd(Descripcion);

        }
    }
}
