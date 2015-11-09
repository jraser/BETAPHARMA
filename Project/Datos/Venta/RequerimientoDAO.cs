using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos.Venta
{
   public class RequerimientoDAO
    {
       public string RequerimientosCreate(Requerimientos obj)
        {
            var context = new SIEPERU2Entities();
           var Id= context.RequerimientosCreate(
                 obj.ID_Requerimientos,
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
                 obj.Estado
                 ).ToList();

           return Id[0].ToString();

        }

       public List<RequerimientosView> RequerimientoList(string Nombres_Socio, DateTime FechaInI, DateTime FechaFin)
        {

            var context = new SIEPERU2Entities();

            var list = context.RequerimintoList(Nombres_Socio,FechaInI,FechaFin).ToList().
                Select(obj => new RequerimientosView
                {
                    ID_Requerimientos = obj.ID_Requerimientos,
                    ID_Orden = obj.ID_Orden,
                    FechaEmision = obj.FechaEmision,
                    FechaEntrega = obj.FechaEntrega,
                    FechaContabilidad = obj.FechaContabilidad,
                    Nombres_Socio = obj.Nombres_Socio,



                }).ToList<RequerimientosView>();

            return list;
        }

       public Requerimientos RequerimientoGet(int ID_Requerimientos)
        {
            var context = new SIEPERU2Entities();

            var list = context.RequerimientoGet(ID_Requerimientos).ToList().
                Select(obj => new Requerimientos
                {
                   ID_Requerimientos= obj.ID_Requerimientos,
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


                }).ToList<Requerimientos>()[0];

            return list;
        }
    }
}
