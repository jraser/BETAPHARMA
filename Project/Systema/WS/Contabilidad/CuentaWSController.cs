using BL.Contabilidad;
using Entity.Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Systema.WS.Contabilidad
{
    public class CuentaWSController : ApiController
    {

        public string Post(Cuenta obj)
        {
            CuentaBL bl = new CuentaBL();
            return bl.CuentaCreate(obj);
        }
        public List<Cuenta> Get(string Codigo) 
        {
            CuentaBL bl = new CuentaBL();
            return bl.CuentaList(Codigo);
        }
         
        public string Delete(int Id) 
        
        {
            CuentaBL bl = new CuentaBL();
            return bl.CuentaDelete(new Cuenta() { ID_PlanCuenta=Id});
        }

    }
}
