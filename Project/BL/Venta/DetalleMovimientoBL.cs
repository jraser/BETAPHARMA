using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class DetalleMovimientoBL
    {
        DetalleMovimientoDAO Dao = new DetalleMovimientoDAO();

        public string DetalleMovimientoCreate(DetalleMovimiento obj)
        {

            return Dao.DetalleMovimientoCreate(obj);

        }
    }
}
