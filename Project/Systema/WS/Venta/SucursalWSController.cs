using BL.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Systema.WS.Venta
{
    public class SucursalWSController : ApiController
    {

        public List<Sucursal> Get()
        {
            SucursalBL bl = new SucursalBL();
            return bl.dll_SucursalList();
        }
        public List<Sucursal> Get(string Descripcion_Sucursal)
        {
            SucursalBL bl = new SucursalBL();
            return bl.SucursalList(Descripcion_Sucursal);
        }


        public Sucursal Get(int ID_Sucursal)
        {
            SucursalBL bl = new SucursalBL();
            return bl.SucursalGet(ID_Sucursal);
        }
        public string Post(Sucursal obj)
        {
            SucursalBL bl = new SucursalBL();
            return bl.SucursalCreate(obj);
        }
        public string Delete(int ID_Sucursal)
        {
            SucursalBL bl = new SucursalBL();
            return bl.SucursalDelete(ID_Sucursal);
        }
    }
}
