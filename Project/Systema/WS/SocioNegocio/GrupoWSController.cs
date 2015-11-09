using BL.SocioNegocio;
using Entity.SocioNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Systema.WS.SocioNegocio
{
    public class GrupoWSController : ApiController
    {

        public string Post(Grupo obj)
        {
            GrupoBL bl = new GrupoBL();
            return bl.GrupoCreate(obj);
        }

        public List<Grupo> Get(string Nombre, string TipoEstado)
        {
            GrupoBL bl = new GrupoBL();
            return bl.GrupoList(Nombre, TipoEstado);
        }



        public string EstadoModificado(int ID_Grupo)
        {
            GrupoBL lb = new GrupoBL();
            return lb.GrupoDelete(ID_Grupo);

        }

        public string PUT(int ID_Grupo)
        {
            GrupoBL bl = new GrupoBL();
            return bl.GGrupoMod(ID_Grupo);

        }

        public string Delete(int ID_Grupo)
        {
            GrupoBL bl = new GrupoBL();
            return bl.GrupoEliminar(ID_Grupo);
        }

    }
}
