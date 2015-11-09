using Datos.SocioNegocio;
using Entity.SocioNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.SocioNegocio
{
    public class SocioNegocioBL
    {
        SocioNegocioDAO Dao = new SocioNegocioDAO();


        public List<Socio> dll_SocioNegocioList()
        {
            return Dao.dll_SocioNegocioList();

        }



        public List<SocioView> SocioNegocioList(string Nombres, string Nro_Documento, string TipoSocio)
        {

            return Dao.SocioNegocioList(Nombres, Nro_Documento, TipoSocio);
        }


        public string SocioNegocioCreate(Socio obj)
        {

            return Dao.SocioNegocioCreate(obj);

        }


        public Socio SocioNegocioGet(int ID_Socio)
        {
            return Dao.SocioNegocioGet(ID_Socio);

        }

        public string SocioNegocioUpdate(Socio obj)
        {
            Dao.SocioNegocioUpdate(obj);
            return "";
        }

        public string SocioNegocioDelete(int ID_Socio)
        {
            Dao.SocioNegocioDelete(ID_Socio);

            return "";
        }



        public List<Socio> ddl_SocioNegocioList(string TipoSocio, string Nombres)
        {

            return Dao.ddl_SocioNegocioList(TipoSocio, Nombres);
        }



    }
}
