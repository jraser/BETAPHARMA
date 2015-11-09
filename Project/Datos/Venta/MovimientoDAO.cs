using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos.Venta
{
    public class MovimientoDAO
    {
        public string MovimientoCreate(Movimiento obj)
        {
            var context = new SIEPERU2Entities();
            var Id = context.MovimientoCreate(
                 obj.ID_Movimiento,
                 obj.ID_Orden,
                 obj.TipoDocumento,
                 obj.NroDocumento,
                 obj.FechaEmision,
                 obj.FechaEntrega,
                 obj.FechaContabilidad,
                 obj.ID_Almacen,
                 null,
                 null,
                 null,
                 null,
                 null,
                 null,
                 obj.Estado,
                 obj.Tipo_Movimiento 
                 ).ToList();

            return Id[0].ToString();
        }

        public List<MovimientoView> MovimientoList(string Nombres_Socio, DateTime FechaInI, DateTime FechaFin, string Tipo_Movimiento)
        {

            var context = new SIEPERU2Entities();

            var list = context.MovimientoList(Nombres_Socio, FechaInI, FechaFin, Tipo_Movimiento).ToList().
                Select(obj => new MovimientoView
                {
                    ID_Movimiento = obj.ID_Movimiento,
                    ID_Orden = obj.ID_Orden,
                    FechaEmision = obj.FechaEmision,
                    FechaEntrega = obj.FechaEntrega,
                    FechaContabilidad = obj.FechaContabilidad,
                    Nombres_Socio = obj.Nombres_Socio,
                    //Descripcion_Almacen = obj.Descripcion_Almacen,


                }).ToList<MovimientoView>();

            return list;
        }

        public List<MovimientoView> MovimientoList2(string Nombres_Socio, DateTime FechaInI, DateTime FechaFin)
        {

            var context = new SIEPERU2Entities();

            var list = context.MovimientoList2(Nombres_Socio, FechaInI, FechaFin).ToList().
                Select(obj => new MovimientoView
                {
                    ID_Movimiento = obj.ID_Movimiento,
                    ID_Orden = obj.ID_Orden,
                    FechaEmision = obj.FechaEmision,
                    FechaEntrega = obj.FechaEntrega,
                    FechaContabilidad = obj.FechaContabilidad,
                    Nombres_Socio = obj.Nombres_Socio,
                    //Descripcion_Almacen = obj.Descripcion_Almacen,


                }).ToList<MovimientoView>();

            return list;
        }

        public Movimiento MovimientoGet(int ID_Movimiento)
        {
            var context = new SIEPERU2Entities();

            var list = context.MovimientoGet(ID_Movimiento).ToList().
                Select(obj => new Movimiento
                {
                    ID_Movimiento = obj.ID_Movimiento,
                    ID_Orden = obj.ID_Orden,
                    ID_Socio = obj.ID_Socio,
                    FechaContabilidad = obj.FechaContabilidad,
                    FechaEmision = obj.FechaEmision,
                    FechaEntrega = obj.FechaEntrega,
                    ID_Almacen = obj.ID_Almacen,
                    Descripcion_Almacen = obj.Descripcion_Almacen,
    
                    Estado = obj.Estado,
                    UsuarioCreacion = obj.UsuarioCreacion,
                    UsuarioModificacion = obj.UsuarioModificacion,
                    UsuarioEliminacion = obj.UsuarioEliminacion,
                    FechaCreacion = obj.FechaCreacion,
                    FechaModificacion = obj.FechaModificacion,
                    FechaEliminacion = obj.FechaEliminacion


                }).ToList<Movimiento>()[0];

            return list;
        }
    }
}
