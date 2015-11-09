using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class SucursalBL
    {

        SucursalDAO Dao = new SucursalDAO();
        public List<Sucursal> dll_SucursalList()
        {
            return Dao.dll_SucursalList();
        }

        public List<Sucursal> SucursalList(string Descripcion_Sucursal)
        {
            return Dao.SucursalList(Descripcion_Sucursal);
        }

        public Sucursal SucursalGet(int ID_Sucursal) 
        {
            return Dao.SucursalGet(ID_Sucursal);
        }

        public string SucursalCreate(Sucursal obj)
        {
            return Dao.SucursalCreate(obj);
        }
        public string SucursalDelete(int ID_Sucursal)
        {
            return Dao.SucursalDelete(ID_Sucursal);
        } 

    }


}
