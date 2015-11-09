using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class DetalleOrdenVentaDAO
    {
        public string DetalleOrdenVentaCreate(DetalleOrdenVenta  obj)
        {
            var context = new SIEPERU2Entities();
            var Id = context.DetalleOrdenVentaCreate(
                 obj.ID_DetalleOrden,
                 obj.ID_Orden,
                 obj.PrecioUnitario,
                 obj.Cantidad,
                 obj.Descuento,
                 obj.Monto,
                 0,
                 obj.Cantidad,
                 obj.ID_Producto,
                 obj.Lote,
                 obj.ID_Almacen,
                 obj.UsuarioCreacion,
                 obj.UsuarioModificacion,
                 obj.UsuarioEliminacion,
                 null,
                 null,
                 null,
                 obj.Estado
                 );

            return "";
        }


        public List<DetalleOrdenVentaView> DetalleOrdenVentaList(int ID_Orden)
        {

            var context = new SIEPERU2Entities();

            var list = context.DetalleOrdenVentaList(ID_Orden).ToList().
                Select(obj => new DetalleOrdenVentaView
                {
                    ID_DetalleOrden = obj.ID_DetalleOrden,
                    ID_Orden = obj.ID_Orden,
                    ID_Producto = obj.ID_Producto,
                    Lote = obj.Lote,
                    Codigo_Producto = obj.Codigo_Producto,
                    Descripcion_Producto = obj.Descripcion_Producto,
                    PrecioUnitario = obj.PrecioUnitario,
                    Cantidad = obj.Cantidad,
                    Descuento = obj.Descuento,
                    Nombre = obj.Nombre,
                    Monto = obj.Monto,
                    Atendido = obj.Atendido,
                    Faltante = obj.Faltante

                }).ToList<DetalleOrdenVentaView>();

            return list;
        }

        public string DetalleMovimientoOrdenVenta(int Atendido, int Faltante, int ID_DetalleOrden)
        {
            var context = new SIEPERU2Entities();
            context.DetalleMovimientoOrdenVenta(Atendido, Faltante, ID_DetalleOrden);

            return "";
        }

        public string DetalleDelete(int ID_DetalleOrden)
        {
            var context = new SIEPERU2Entities();
            context.DetalleOrdenVentaDelete(ID_DetalleOrden);

            return "";
        }

    }
}
