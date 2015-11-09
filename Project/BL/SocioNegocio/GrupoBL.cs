using Datos.SocioNegocio;
using Entity.SocioNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.SocioNegocio
{

    public class GrupoBL
    {
        GrupoDAO Dao = new GrupoDAO();


        public List<Grupo> GrupoList(string Nombre, string TipoEstado)
        {

            return Dao.GrupoList(Nombre, TipoEstado);
        }


        public string GrupoCreate(Grupo obj)
        {


            return Dao.GrupoCreate(obj);
        }


        public Grupo GrupoGet(int ID_Grupo)
        {
            return Dao.GrupoGet(ID_Grupo);

        }
        public string GrupoDelete(int ID_Grupo)
        {


            return Dao.GrupoDelete(ID_Grupo);
        }



        public string GGrupoMod(int ID_Grupo)
        {
            return Dao.GGrupoMod(ID_Grupo);
        }

        public string GrupoEliminar(int ID_Grupo)
        {
            return Dao.GrupoEliminar(ID_Grupo);
        }
        
    }

}
