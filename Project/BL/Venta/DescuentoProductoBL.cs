using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class DescuentoProductoBL
    {
        DescuentoProductoDAO Dao = new DescuentoProductoDAO();
        public List<DescuentoProductoView> DescuentoProductoList(int ID_Grupo, string Mode) 
        {

            return Dao.DescuentoProductoList(ID_Grupo,Mode);
        }
        public List<DescuentoProducto> DescuentoProductoLists(string Nombre)
        { 

            return Dao.DescuentoProductoLists(Nombre);
        }
        public string DescuentoProductoCreate(DescuentoProducto obj)
        {

            Dao.DescuentoProductoCreate(obj);
            return "";
        }

        public DescuentoProducto DescuentoProductoGet(int ID_Descuento)
        {

            return Dao.DescuentoProductoGet(ID_Descuento);
        }

        public string DescuentoProductoDelete(int ID_Descuento)
        {

            Dao.DescuentoProductoDelete(ID_Descuento);
            return "";
        }
    }
}
