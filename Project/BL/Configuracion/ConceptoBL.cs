using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Configuracion;
using Entity.Configuracion;

namespace BL.Configuracion
{
    public class ConceptoBL
    {
        ConceptoDAO Dao = new ConceptoDAO();
        public List<Concepto> dll_ConceptoList(string CodigoTabla)
        {
            return Dao.dll_ConceptoList(CodigoTabla);
        } 

    }
}
