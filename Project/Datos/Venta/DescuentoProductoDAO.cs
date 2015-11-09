using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
   public  class DescuentoProductoDAO
    {
       public List<DescuentoProductoView> DescuentoProductoList(int ID_Grupo, string Mode)
       {

           var context = new SIEPERU2Entities();

           var list = context.DescuentoProductoList(ID_Grupo,Mode).ToList().
               Select(obj => new DescuentoProductoView
               {
                   ID_Descuento = obj.ID_Descuento,
                   ID_Grupo = obj.ID_Grupo,
                   Nombre = obj.Nombre,
                   Descripcion = obj.Descripcion,
                   PorcDscto = obj.PorcDscto
                  
               }).ToList<DescuentoProductoView>();

           return list;
       }

       public List<DescuentoProducto> DescuentoProductoLists(string Nombre)
       {

           var context = new SIEPERU2Entities();

           var list = context.DescuentoProductoLists(Nombre).ToList().
               Select(obj => new DescuentoProductoView
               {
                   ID_Descuento = obj.ID_Descuento,
                   Nombre = obj.Nombre,
                   Descripcion = obj.Descripcion,
                   PorcDscto = obj.PorcDscto,
                   Estado=obj.Estado

               }).ToList<DescuentoProducto>();

           return list;
       }


       public string DescuentoProductoCreate(DescuentoProducto obj)
       {
           var context = new SIEPERU2Entities();
           context.DescuentoProductoCreate(
               obj.ID_Descuento,
               obj.Nombre,
               obj.Descripcion,
               obj.PorcDscto,
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


       public DescuentoProducto DescuentoProductoGet(int ID_Descuento)
       {

           var context = new SIEPERU2Entities();

           var list = context.DescuentoProductoGet(ID_Descuento).ToList().
               Select(obj => new DescuentoProducto
               {
                   ID_Descuento = obj.ID_Descuento,
                   Nombre = obj.Nombre,
                   Descripcion = obj.Descripcion,
                   PorcDscto = obj.PorcDscto

               }).ToList<DescuentoProducto>();

           return list[0];
       }

       public string DescuentoProductoDelete(int ID_Descuento)
       {

           var context = new SIEPERU2Entities();

           context.DescuentoProductoDelete(
               ID_Descuento
               );

           return "";
       }

    }
}
