using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class DetalleMovimientoDAO
    {
        public string DetalleMovimientoCreate(DetalleMovimiento obj)
        {
            var context = new SIEPERU2Entities();
            var Id = context.DetalleMovimientoCreate(
                 obj.ID_MovimientoDetalle,
                 obj.ID_Movimiento,
                 obj.ID_DetalleOrden,
                 obj.Lote,
                 obj.ID_Producto,
                 obj.CantidadMovimiento,
                 obj.CantidadxMe,
                 obj.UsuarioCreacion,
                 obj.UsuarioModificacion,
                 obj.UsuarioEliminacion,
                 null,
                 null,
                 null,
                 obj.Estado,
                 obj.Tipo_Movimiento
                 );

            return "";
        }
    }
}
