using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class DetalleOrdenCompraDAO
    {
        public string DetalleOrdenCompraCreate(DetalleOrdenCompra obj)
        {
            var context = new SIEPERU2Entities();
            var Id = context.DetalleOrdenCompraCreate(
                 obj.ID_DetalleOrden,
                 obj.ID_Orden,
                 obj.PrecioUnitario,
                 obj.Cantidad, 
                 obj.Monto,
                 0,
                 obj.Cantidad,
                 obj.ID_Producto,
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

        public DetalleOrdenCompra DetalleOrdenCompraGet(int ID_DetalleOrden, int ID_Orden)
        {
            var context = new SIEPERU2Entities();

            var list = context.DetalleOrdenCompraGet(ID_DetalleOrden, ID_Orden).ToList().
                Select(obj => new DetalleOrdenCompra
                {

                    ID_DetalleOrden = obj.ID_DetalleOrden,
                    ID_Orden = obj.ID_Orden,
                    PrecioUnitario = obj.PrecioUnitario,
                    Cantidad = obj.Cantidad,
                    Monto = obj.Monto,
                    Atendido = obj.Atendido,
                    Faltante=obj.Faltante,
                    ID_Producto = obj.ID_Producto,
                    ID_Almacen = obj.ID_Almacen,
                    Estado = obj.Estado,
                    UsuarioCreacion = obj.UsuarioCreacion,
                    UsuarioModificacion = obj.UsuarioModificacion,
                    UsuarioEliminacion = obj.UsuarioEliminacion,
                    FechaCreacion = obj.FechaCreacion,
                    FechaModificacion = obj.FechaModificacion,
                    FechaEliminacion = obj.FechaEliminacion


                }).ToList<DetalleOrdenCompra>()[0];

            return list;
        }

        public string DetalleDelete(int ID_DetalleOrden)
        {
            var context = new SIEPERU2Entities();
            context.DetalleOrdenCompraDelete(ID_DetalleOrden);

            return "";
        }

        public string DetalleMovimientoOrdenCompra(int Atendido, int Faltante, int ID_DetalleOrden)
        {
            var context = new SIEPERU2Entities();
            context.DetalleMovimientoOrdenCompra(Atendido, Faltante, ID_DetalleOrden);

            return "";
        }


        public List<DetalleOrdenCompraView> DetalleOrdenCompraList(int ID_Orden)
        {

            var context = new SIEPERU2Entities();

            var list = context.DetalleOrdenCompraList(ID_Orden).ToList().
                Select(obj => new DetalleOrdenCompraView
                {
                    ID_DetalleOrden = obj.ID_DetalleOrden,
                    ID_Orden = obj.ID_Orden,
                    ID_Producto = obj.ID_Producto,
                    Codigo_Producto = obj.Codigo_Producto,
                    Descripcion_Producto = obj.Descripcion_Producto,
                    PrecioUnitario = obj.PrecioUnitario,
                    Cantidad = obj.Cantidad,
                    Nombre = obj.Nombre,
                    Monto = obj.Monto,
                    Atendido=obj.Atendido,
                    Faltante = obj.Faltante

                }).ToList<DetalleOrdenCompraView>();

            return list;
        }



    }
}
