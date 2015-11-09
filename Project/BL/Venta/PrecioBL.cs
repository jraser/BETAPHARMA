using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class PrecioBL
    {

        PrecioDAO Dao = new PrecioDAO();
        public List<PrecioView> PrecioList(int ID_Producto)
        {
            return Dao.PrecioList(ID_Producto);
        }

        public string PrecioCreate(Precio obj)
        {
            return Dao.PrecioCreate(obj);

        }

        //public Precio PrecioGet(int ID_Precio)
        //{
        //    return Dao.PrecioGet(ID_Precio);
        //}
    }
}
