using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class StockDAO
    {

        //public string StockCreate(int Id_Producto, string Lote, int Cantidad)
        //{
        //    var context = new SIEPERU2Entities();

        //    var Id = context.StockCreate(
        //         obj.Id_Producto,
        //         obj.Lote,
        //         obj.Cantidad);


        //    return "";
        //}


        public string StockCreate(int Id_Producto, string Codigo_Producto, string CodigoDif, string Lote, int Cantidad)
        {
            var context = new SIEPERU2Entities();
            context.StockCreate(Id_Producto, Codigo_Producto, CodigoDif, Lote, Cantidad);

            return "";

        }
        public string StockUpdate(int Id_Producto, string Codigo_Producto, string CodigoDif, string Lote, int Cantidad)
        {
            var context = new SIEPERU2Entities();
            context.StockUpdate(Id_Producto, Codigo_Producto, CodigoDif, Lote, Cantidad);

            return "";

        }
        public List<StockView> StockAdd(string Descripcion)
        {

            var context = new SIEPERU2Entities();

            var list = context.StockAdd(Descripcion).ToList().
                Select(obj => new StockView
                {
                    Id_Producto = obj.Id_Producto,
                    Lote = obj.Lote,
                    Codigo_Producto = obj.Codigo_Producto,
                    Descripcion_Producto = obj.Descripcion_Producto,
                    Categoria = obj.categoria,
                    SubCategoria = obj.subcategoria,
                    PV = obj.PV,
                    PC = obj.PC
                }).ToList<StockView>();

            return list;
        }

    }
}
