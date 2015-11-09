using Entity.Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Datos.Contabilidad
{
    public class CuentaDAO
    {
        public List<Cuenta> CuentaList(string Codigo)
        {

            var context = new SIEPERU2Entities();

            var list = context.CuentaList(Codigo!="%"?Codigo:"-1").ToList().
                Select(obj => new Cuenta
                {
                    ID_PlanCuenta = obj.ID_PlanCuenta,
                    CodigoCuenta = obj.CodigoCuenta,
                    DescripcionCuenta = obj.DescripcionCuenta,
                    CodigoCuentaPadre = obj.CodigoCuentaPadre,
                    Nivel = obj.Nivel,
                    Estado = obj.Estado,
                    Origen=obj.Origen
                }).ToList<Cuenta>();

            return list;
        }


        public string CuentaCreate(Cuenta obj)
        { 
            var context = new SIEPERU2Entities();
            context.CuentaCreate(
                obj.ID_PlanCuenta,
                obj.CodigoCuenta,
                obj.DescripcionCuenta,
                obj.CodigoCuentaPadre,
                obj.Nivel,
                "",
                null,
                null,
                null);
            return "";
        }

        public string CuentaDelete(Cuenta obj)
        { 
            var context = new SIEPERU2Entities();
            context.CuentaDelete(
                obj.ID_PlanCuenta
               );
            return "";
        }


    }
}
