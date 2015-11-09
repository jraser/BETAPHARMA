using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class DescuentoGrupoBL
    {
        DescuentoGrupoDAO Dao = new DescuentoGrupoDAO();
        public string DescuentoGrupoCreate(DescuentoGrupo obj)
        {
             
            return Dao.DescuentoGrupoCreate(obj);
        }
    }
}
