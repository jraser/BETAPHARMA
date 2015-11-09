using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class DescuentoGrupoDAO
    {

        public string DescuentoGrupoCreate(DescuentoGrupo obj) 
        {
            var context = new SIEPERU2Entities();
            context.DescuentoGrupoCreate(
                obj.ID_Descuento,
                obj.ID_Grupo,
                obj.UsuarioCreacion,
                obj.UsuarioModificacion,
                obj.UsuarioEliminacion,
                null,
                null,
                null,
                ""
                );

            return "";
        }
    }
}
