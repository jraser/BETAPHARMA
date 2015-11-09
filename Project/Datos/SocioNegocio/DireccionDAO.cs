using Entity.SocioNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.SocioNegocio
{
   public class DireccionDAO
    {
       public List<Direcciones> DireccionList(int ID_Socio)
       {
           var context = new SIEPERU2Entities();
           var list = context.DireccionList(ID_Socio).ToList().
                Select(obj => new Direcciones
                {
                    ID_Direccion = obj.ID_Direccion,
                    Direccion = obj.Direccion,
                    Referencia_Domicilio = obj.Referencia_Domicilio,
                    ID_Socio = obj.ID_Socio,
                    Estado = obj.Estado,
                    Tipo=obj.Tipo

                }).ToList<Direcciones>();

           return list;
       }
       public string DireccionCreate(Direcciones obj)
       {
           var context = new SIEPERU2Entities();

           var Id = context.DireccionCreate(
               obj.ID_Direccion,
               obj.Direccion,
               obj.Referencia_Domicilio,
               obj.ID_Socio,
               obj.UsuarioCreacion,
               obj.UsuarioModificacion,
               obj.UsuarioEliminacion,
               null,
               null,
               null,
               "",
               obj.Tipo);

           return "";
       }

       public string DireccionDelete(int ID_Direccion)
       {

           var context = new SIEPERU2Entities();

           var Id = context.DireccionDelete(
                 ID_Direccion);


           return "";
       }
       }
    }

