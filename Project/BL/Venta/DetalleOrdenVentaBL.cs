using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class DetalleOrdenVentaBL
    {
        DetalleOrdenVentaDAO Dao = new DetalleOrdenVentaDAO();

        public List<DetalleOrdenVentaView> DetalleOrdenVentaList(int ID_Orden)
        {

            return Dao.DetalleOrdenVentaList(ID_Orden);

        }
        public string DetalleOrdenVentaCreate(DetalleOrdenVenta obj)
        {

            return Dao.DetalleOrdenVentaCreate(obj);

        }

        public string DetalleMovimientoOrdenVenta(int Atendido, int Faltante, int ID_DetalleOrden)
        {

            return Dao.DetalleMovimientoOrdenVenta(Atendido, Faltante, ID_DetalleOrden);

        }

        public string DetalleDelete(int ID_DetalleOrden)
        {

            Dao.DetalleDelete(ID_DetalleOrden);
            return "";
        }

    }
}
