using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class DetalleOrdenCompraBL
    {
        DetalleOrdenCompraDAO Dao = new DetalleOrdenCompraDAO();

        public List<DetalleOrdenCompraView> DetalleOrdenCompraList(int ID_Orden)
        {

            return Dao.DetalleOrdenCompraList(ID_Orden);

        }


        public string DetalleOrdenCompraCreate(DetalleOrdenCompra obj)
        {

            return Dao.DetalleOrdenCompraCreate(obj);

        }

        public DetalleOrdenCompra DetalleOrdenCompraGet(int ID_DetalleOrden, int ID_Orden)
        {
            return Dao.DetalleOrdenCompraGet(ID_DetalleOrden, ID_Orden);

        }

        public string DetalleDelete(int ID_DetalleOrden)
        {

            Dao.DetalleDelete(ID_DetalleOrden);
            return "";
        }

        public string DetalleMovimientoOrdenCompra(int Atendido, int Faltante, int ID_DetalleOrden)
        {

            return Dao.DetalleMovimientoOrdenCompra(Atendido, Faltante, ID_DetalleOrden);
             
        }

    }
}
