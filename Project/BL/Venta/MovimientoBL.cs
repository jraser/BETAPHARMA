using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.Venta
{
    public class MovimientoBL
    {
        MovimientoDAO Dao = new MovimientoDAO();

        public string MovimientoCreate(Movimiento obj)
        {

            return Dao.MovimientoCreate(obj);

        }


        public List<MovimientoView> MovimientoList(string Nombres_Socio, DateTime FechaInI, DateTime FechaFin, string Tipo_Movimiento)
        {

            return Dao.MovimientoList(Nombres_Socio, FechaInI, FechaFin, Tipo_Movimiento);

        }
        public List<MovimientoView> MovimientoList2(string Nombres_Socio, DateTime FechaInI, DateTime FechaFin)
        {

            return Dao.MovimientoList2(Nombres_Socio, FechaInI, FechaFin);

        }
        public Movimiento MovimientoGet(int ID_Movimiento)
        {
            return Dao.MovimientoGet(ID_Movimiento);

        }
    }
}
