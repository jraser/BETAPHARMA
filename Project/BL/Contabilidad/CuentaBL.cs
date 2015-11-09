using Datos.Contabilidad;
using Entity.Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace BL.Contabilidad
{
    public class CuentaBL
    {
        CuentaDAO Dao = new CuentaDAO();
        public List<Cuenta> CuentaList(string Codigo)
        {
            var lista=Dao.CuentaList(Codigo);
           
            return lista;
        }

       


        public string CuentaCreate(Cuenta obj)
        {
             
            Dao.CuentaCreate(obj);
            return "";
        } 
        public string CuentaDelete(Cuenta obj)
        {

            Dao.CuentaDelete(obj);
            return "";
        }


    }
}
