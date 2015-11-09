using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.Venta
{
   public class RequerimientoBL
    {

       RequerimientoDAO Dao = new RequerimientoDAO();

       public string RequerimientosCreate(Requerimientos obj)
       {
           return Dao.RequerimientosCreate(obj);
       }

       public List<RequerimientosView> RequerimientoList(string Nombres_Socio, DateTime FechaINI,DateTime FechaFin)
       {
           return Dao.RequerimientoList(Nombres_Socio, FechaINI, FechaFin);
       }

public Requerimientos RequerimientoGet(int ID_Requerimientos)
       {
           return Dao.RequerimientoGet(ID_Requerimientos);
       }

    }
}
