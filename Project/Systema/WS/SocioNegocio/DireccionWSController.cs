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
    public class DireccionWSController : ApiController
    {

 
        public List<Direcciones> Get(int ID_Socio)
        {
            DireccionBL bl = new DireccionBL();
            return bl.DireccionList(ID_Socio);
        }
        public string Post(Direcciones obj)
        {
            DireccionBL bl = new DireccionBL();
            return bl.DireccionCreate(obj);
        }

        public string Delete(int ID_Direccion)
        {
            DireccionBL bl = new DireccionBL();
            return bl.DireccionDelete(ID_Direccion);
        }


    }
}
