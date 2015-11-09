using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class ListaPrecioBL
    {

        ListaPrecioDao Dao = new ListaPrecioDao();
        public List<ListaPrecioView> ALTProductoBySocioList(string Descripcion_Producto, string Nombre, string Nombres_Socio)
      {

          return Dao.ALTProductoBySocioList(Descripcion_Producto, Nombre, Nombres_Socio);

      }
    }
}
