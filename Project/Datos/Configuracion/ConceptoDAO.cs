using Entity.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Configuracion
{
    public class ConceptoDAO
    {
        public List<Concepto> dll_ConceptoList(string CodigoTabla)
        { 

            var context = new SIEPERU2Entities();

            var list = context.dll_ConceptoList(CodigoTabla).ToList().
                Select(obj => new Concepto
                {
                    Codigo = obj.Codigo,
                    Descripcion = obj.Descripcion,

                }).ToList<Concepto>();

            return list;
        }
    }
}
