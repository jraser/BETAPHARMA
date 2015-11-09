using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class UnidadMedidaBL
    {
        UnidadMedidaDAO Dao = new UnidadMedidaDAO();
        public List<UnidadMedida> dll_UnidadList()
        {
            return Dao.dll_UnidadList();
        }
    }
}
