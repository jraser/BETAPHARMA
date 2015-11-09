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
    public class AlmacenWSController : ApiController
    {
        public List<Almacen> Get(String Descripcion_Almacen, String Estado)
        {
            AlmacenBL bl = new AlmacenBL();
            return bl.AlmacenList(Descripcion_Almacen, Estado);
        }

        //public List<Almacen> Get(int ID_Sucursal)
        //{
        //    AlmacenBL bl = new AlmacenBL();
        //    return bl.dll_AlmacenList(ID_Sucursal);
        //}


        public List<Almacen> Get(int ID_Sucursal)
        {
            AlmacenBL bl = new AlmacenBL();
            return bl.A2lmacenList2(ID_Sucursal);

        }

        public string Post(Almacen obj)
        {
            AlmacenBL bl = new AlmacenBL();
            return bl.AlmacenCreate(obj);
        }

        public Almacen GetSub(int ID_Almacen)
        {
            AlmacenBL bl = new AlmacenBL();
            return bl.AlmacenGet(ID_Almacen);
        }

        public string Delete(int ID_Almacen)
        {
            AlmacenBL bl = new AlmacenBL();
            return bl.AlmacenDelete(ID_Almacen);
        }
    }
}
