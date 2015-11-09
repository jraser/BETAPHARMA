using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
   public class AlmacenDAO
    {

       public List<Almacen> dll_AlmacenList(int ID_Sucursal)
       {
           var context = new SIEPERU2Entities();

           var list = context.dll_AlmacenList(ID_Sucursal).ToList().
               Select(obj => new Almacen
               {
                   ID_Almacen=obj.ID_Almacen,
                   Codigo_Almacen=obj.Codigo_Almacen,
                   Descripcion_Almacen=obj.Descripcion_Almacen,
                   Direccion_Almacen = obj.Direccion_Almacen,
                   ID_Sucursal=obj.ID_Sucursal,
                   Estado=obj.Estado,
                   Tipo_Almacen=obj.Tipo_Almacen
               }).ToList<Almacen>();
           return list;
       }




       public string AlmacenCreate(Almacen obj)
       {
           var context = new SIEPERU2Entities();
           var Id = context.AlmacenCreate(
                 obj.ID_Almacen,
                 obj.Codigo_Almacen,
                 obj.Descripcion_Almacen,
                 obj.Direccion_Almacen,
                 obj.ID_Sucursal,
                 obj.UsuarioCreacion,
                 obj.UsuarioModificacion,
                 obj.UsuarioEliminacion,
                 null,
                 null,
                 null,
                "",
                obj.Tipo_Almacen);

           return "";
       }



       public string AlmacenDelete(int ID_Almacen)
       {
           var context = new SIEPERU2Entities();

           var Id = context.AlmacenDelete(
                 ID_Almacen);
           return "";
       }




       public List<Almacen> AlmacenList(String Descripcion_Almacen, String Estado)
       {

           var context = new SIEPERU2Entities();

           var list = context.AlmacenList(Descripcion_Almacen, Estado).ToList().
               Select(obj => new Almacen
               {
                   ID_Almacen = obj.ID_Almacen,
                   Descripcion_Almacen = obj.Descripcion_Almacen,
                   Direccion_Almacen = obj.Direccion_Almacen,
                   Estado = obj.Estado
               }).ToList<Almacen>();

           return list;
       }

       public List<Almacen> A2lmacenList2(int ID_Sucursal)
       {

           var context = new SIEPERU2Entities();

           var list = context.A2lmacenList2(ID_Sucursal).ToList().
               Select(obj => new Almacen
               {
                   ID_Almacen = obj.ID_Almacen,
                   Codigo_Almacen = obj.Codigo_Almacen,
                   Descripcion_Almacen = obj.Descripcion_Almacen,
                   Direccion_Almacen = obj.Direccion_Almacen,
                   ID_Sucursal = obj.ID_Sucursal,
                   Estado = obj.Estado,
                   Tipo_Almacen = obj.Tipo_Almacen
               }).ToList<Almacen>();

           return list;
       }



       public Almacen AlmacenGet(int ID_Almacen)
       {
           var context = new SIEPERU2Entities();
           var list = context .AlmacenGet(ID_Almacen).ToList().
               Select(obj => new Almacen 
               {
                   ID_Almacen=obj.ID_Almacen,
                   Codigo_Almacen=obj.Codigo_Almacen,
                   Descripcion_Almacen=obj.Descripcion_Almacen,
                   Direccion_Almacen = obj.Direccion_Almacen,
                   ID_Sucursal=obj.ID_Sucursal,
                   Tipo_Almacen=obj.Tipo_Almacen
               }).ToList<Almacen>()[0];

           return list;

       }







    }
}
