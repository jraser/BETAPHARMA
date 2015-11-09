using Datos.SocioNegocio;
using Entity.SocioNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.SocioNegocio
{
 public   class DireccionBL
    {
     DireccionDAO Dao = new DireccionDAO();
     public List<Direcciones> DireccionList(int ID_Socio)
     {
         return Dao.DireccionList(ID_Socio);
     }


     public string DireccionCreate(Direcciones obj)
     {
         return Dao.DireccionCreate(obj);
     }

     public string DireccionDelete (int ID_Direccion)
     {
       Dao.DireccionDelete(ID_Direccion);

            return "";
    }


    }
}
