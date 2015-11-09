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
    public class ConceptoWSController : ApiController
    {
        public List<Concepto> Get(string CodigoTabla)
        {
            ConceptoBL bl = new ConceptoBL();
            return bl.dll_ConceptoList(CodigoTabla);
        } 
    }
}
