using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Venta
{
    public class Stock
    {
        public int Id_Producto { get; set; }
        public string Lote { get; set; }
        public int Cantidad { get; set; }



    }


    public class StockView : Stock
    {
        public string Codigo_Producto { get; set; }
        public string Descripcion_Producto { get; set; }
        public string Categoria { get; set; }
        public string  SubCategoria { get; set; }
        public decimal? PV { get; set; }
        public decimal? PC { get; set; }
    }

    
}
