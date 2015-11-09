using BL.SocioNegocio;
using Entity.SocioNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Systema.WS.SocioNegocio
{
    public class GruposWSController : ApiController
    {
        
        public Grupo Get(int ID_Grupo)
        {
            GrupoBL bl = new GrupoBL();
            return bl.GrupoGet(ID_Grupo);
        }
    }
}
