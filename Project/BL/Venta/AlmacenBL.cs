using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class AlmacenBL
    {
        AlmacenDAO Dao = new AlmacenDAO();
        public List<Almacen> dll_AlmacenList(int ID_Sucursal)
        {
            return Dao.dll_AlmacenList(ID_Sucursal);
        }

        public Almacen AlmacenGet(int ID_Almacen)
        {
            return Dao.AlmacenGet(ID_Almacen);
        }

        public string AlmacenCreate(Almacen obj)
        {
            return Dao.AlmacenCreate(obj);
        }

        public string AlmacenDelete(int ID_Almacen)
        {
            return Dao.AlmacenDelete(ID_Almacen);
        }

        public List<Almacen> AlmacenList(String Descripcion_Almacen, String Estado)
        {
            return Dao.AlmacenList(Descripcion_Almacen, Estado);
        }

        public List<Almacen> A2lmacenList2(int ID_Sucursal)
        {
            return Dao.A2lmacenList2(ID_Sucursal);
        }
    }
}
