using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Configuracion;
using Entity.Configuracion;


namespace BL.Configuracion
{
    public class TabGenBL
    {
        TabGenDAO Dao = new TabGenDAO();
        //public List<TabGen> TempOrdenC(string DescripcionTab)
        //{
        //    return Dao.TempOrdenC(DescripcionTab);
        //}

        public TabGen TempOrdenC(string DescripcionTab)
        {

            return Dao.TempOrdenC(DescripcionTab);

        }

        public string TempUpdateOrdenc(string DescripcionTab)
        {

            return Dao.TempUpdateOrdenc(DescripcionTab);

        }
    }
}
