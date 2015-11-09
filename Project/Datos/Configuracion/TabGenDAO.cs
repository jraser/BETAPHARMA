using Entity.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Configuracion
{
    public class TabGenDAO
    {

        //public List<TabGen> TempOrdenC(string DescripcionTab)
        //{

        //    var context = new SIEPERU2Entities();

        //    var list = context.TempOrdenC(DescripcionTab).ToList().
        //        Select(obj => new TabGen
        //        {
        //            Id_TabGen = obj.Id_TabGen,
        //            NumCor = obj.NumCor,
        //            DescripcionTab = obj.DescripcionTab,

        //        }).ToList<TabGen>();

        //    return list;
        //}


        public TabGen TempOrdenC(string DescripcionTab)
        {
            var context = new SIEPERU2Entities();
            var list = context.TempOrdenC(DescripcionTab).ToList().
                Select(obj => new TabGen
                {
                    NumCor = obj.NumCor,
                }).ToList<TabGen>()[0];

            return list;
        }

        public string TempUpdateOrdenc(string DescripcionTab)
        {
            var context = new SIEPERU2Entities();
            context.TempUpdateOrdenc(DescripcionTab);

            return "";
        }

    }
}
