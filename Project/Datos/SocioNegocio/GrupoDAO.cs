using Entity.SocioNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.SocioNegocio
{
    public class GrupoDAO
    {


        public List<Grupo> GrupoList(string Nombre, string TipoEstado)
        {

            var context = new SIEPERU2Entities();

            var list = context.GrupoList(Nombre, TipoEstado).ToList().
                Select(obj => new Grupo
                {
                    ID_Grupo = obj.ID_Grupo,
                    Nombre = obj.Nombre,
                    Estado = obj.Estado,
                }).ToList<Grupo>();

            return list;
        }

        public string GrupoCreate(Grupo obj)
        {

            var context = new SIEPERU2Entities();

            var Id = context.GrupoCreate(
                  obj.ID_Grupo,
                  obj.Nombre,
                  obj.UsuarioCreacion,
                  obj.UsuarioModificacion,
                  obj.UsuarioEliminacion,
                  null,
                  null,
                  null,
                  "").ToList();


            return Id[0].ToString();
        }

        public Grupo GrupoGet(int ID_Grupo)
        {

            var context = new SIEPERU2Entities();

            var list = context.GrupoGet(ID_Grupo).ToList().
                Select(obj => new Grupo
                {
                    ID_Grupo = obj.ID_Grupo,
                    Nombre = obj.Nombre,
                    Estado = obj.Estado,
                }).ToList<Grupo>()[0];

            return list;
        }

        public string GrupoDelete(int ID_Grupo) 
        {

            var context = new SIEPERU2Entities();

            var Id = context.GrupoDelete(
                  ID_Grupo);


            return "";
        }

        public string GGrupoMod(int ID_Grupo)
        {

            var context = new SIEPERU2Entities();
            var Id = context.GGrupoMod(ID_Grupo);
            return "";
        }

        public string GrupoEliminar(int ID_Grupo)
        {

            var context = new SIEPERU2Entities();

            var Id = context.GrupoEliminar(
                  ID_Grupo);

            return "";
        }
    }
}
