using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Venta
{

    public class ListaPrecioView
   {
       public int ID_Producto { get; set; }
       public string Codigo_Producto { get; set; }
       public string Descripcion_Producto { get; set; }

       public int? ID_Marca { get; set; }
       public int? ID_Categoria { get; set; }
       public int? ID_SubCategoria { get; set; }
       public string Categoria { get; set; }
       public string SubCategoria { get; set; }
       public string Estado { get; set; }
       public string NombreEstado { get; set; }
       public int ID_Precio { get; set; }
       public decimal? PV { get; set; }
       public decimal? PC { get; set; }

       public int ID_Socio { get; set; }

   }  


}
