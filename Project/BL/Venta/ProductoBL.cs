using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class ProductoBL
    {
        ProductoDAO Dao = new ProductoDAO();
        public List<ProductoView> ProductoList(string Descripcion, int ID_Categoria, int ID_SubCategoria)
        {

            return Dao.ProductoList(Descripcion, ID_Categoria, ID_SubCategoria);

        }

      public string ProductoCreate(Producto obj)
      {

         return Dao.ProductoCreate(obj);
           
      }

      public string ProductoDelete(int ID_Producto)
      {

          Dao.ProductoDelete(ID_Producto);
          return "";
      }

      public Producto ProductoGet(int ID_Producto)
      {

        return  Dao.ProductoGet(ID_Producto);
          
      }

      public List<ProductoView> ProductoBySocioList(string Descripcion, int ID_Categoria, int ID_SubCategoria, int ID_Socio)
      {

          return Dao.ProductoBySocioList(Descripcion, ID_Categoria, ID_SubCategoria, ID_Socio);

      }
    }
}
