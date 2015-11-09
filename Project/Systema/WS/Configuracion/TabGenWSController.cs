using BL.Configuracion;
using Entity.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Systema.WS.Configuracion
{
    public class TabGenWSController : ApiController
    {
        //public List<TabGen> Get(string DescripcionTab)
        //{
        //    TabGenBL bl = new TabGenBL();
        //    return bl.TempOrdenC(DescripcionTab);
        //}

        public TabGen Get(string DescripcionTab)
        {
            TabGenBL bl = new TabGenBL();
            return bl.TempOrdenC(DescripcionTab);
        }

        public string Delete(string DescripcionTab)
        {
            TabGenBL bl = new TabGenBL();
            return bl.TempUpdateOrdenc(DescripcionTab);
        }
    }
}