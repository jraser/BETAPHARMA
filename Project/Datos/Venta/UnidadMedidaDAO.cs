using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class UnidadMedidaDAO
    {
        public List<UnidadMedida> dll_UnidadList()
        {

            var context = new SIEPERU2Entities();

            var list = context.dll_UnidadList().ToList().
                Select(obj => new UnidadMedida
                {
                    Codigo_UMedida = obj.Codigo_UMedida,
                    Nombre = obj.Nombre,

                }).ToList<UnidadMedida>();

            return list;
        }
    }
}
