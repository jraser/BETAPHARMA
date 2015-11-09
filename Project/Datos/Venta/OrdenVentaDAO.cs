using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class OrdenVentaDAO
    {
        public string OrdenVentaCreate(OrdenVenta  obj)
        {
            var context = new SIEPERU2Entities();
            var Id = context.OrdenVentaCreate(
                 obj.ID_Orden,
                 obj.ID_Socio,
                 obj.IGV,
                 obj.Monto,
                 obj.Impuesto,
                 obj.Total,
                 obj.Descuento,
                 obj.FechaEmision,
                 obj.FechaEntrega,
                 obj.FechaContabilidad,
                 obj.ID_Moneda,
                 obj.ID_FormaPago,
                 obj.ID_CondicionPago,
                 obj.ID_Sucursal,
                 null,
                 null,
                 null,
                 null,
                 null,
                 null,
                 obj.Estado,
                 obj.Situacion
                 ).ToList();

            return Id[0].ToString();
        }


        public List<OrdenVentaView> OrdenVentaList(string Nombres_Socio, DateTime FechaInI, DateTime FechaFin, string Descripcion)
        {

            var context = new SIEPERU2Entities();

            var list = context.OrdenVentaList(Nombres_Socio, FechaInI, FechaFin, Descripcion).ToList().
                Select(obj => new OrdenVentaView
                {
                    ID_Orden = obj.ID_Orden,
                    FechaEmision = obj.FechaEmision,
                    FechaEntrega = obj.FechaEntrega,
                    FechaContabilidad = obj.FechaContabilidad,
                    Nombres_Socio = obj.Nombres_Socio,
                    Monto = obj.Monto,
                    Impuesto = obj.Impuesto,
                    Total = obj.Total,
                    Descripcion = obj.Estado,
                    Situacion = obj.Situacion,
                    ID_Sucursal = obj.ID_Sucursal,
                    Direccion = obj.Direccion,

                }).ToList<OrdenVentaView>();

            return list;
        }

        public OrdenVenta OrdenVentaGet(int ID_Orden)
        {
            var context = new SIEPERU2Entities();
            var list = context.OrdenVentaGet(ID_Orden).ToList().
                Select(obj => new OrdenVenta

                {
                    ID_Orden = obj.ID_Orden,
                    ID_Socio = obj.ID_Socio,
                    IGV = obj.IGV,
                    Monto = obj.Monto,
                    Impuesto = obj.Impuesto,
                    Total = obj.Total,
                    FechaEmision = obj.FechaEmision,
                    FechaEntrega = obj.FechaEntrega,
                    FechaContabilidad = obj.FechaContabilidad,
                    ID_FormaPago = obj.ID_FormaPago,
                    ID_CondicionPago = obj.ID_CondicionPago,
                    ID_Sucursal = obj.ID_Sucursal,
                    Estado = obj.Estado,
                }).ToList<OrdenVenta>()[0];

            return list;
        }

        public List<OrdenVentaView> OrdenVentaListPorFecha(int ID_Socio, DateTime FechaInI, DateTime FechaFin, String Estado)
        {

            var context = new SIEPERU2Entities();

            var list = context.OrdenVentaListPorFecha(ID_Socio, FechaInI, FechaFin, Estado).ToList().
                Select(obj => new OrdenVentaView
                {
                    ID_Orden = obj.ID_Orden,
                    FechaEmision = obj.FechaEmision,
                    FechaEntrega = obj.FechaEntrega,
                    FechaContabilidad = obj.FechaContabilidad,
                    Nombres_Socio = obj.Nombres_Socio,
                    Monto = obj.Monto,
                    Impuesto = obj.Impuesto,
                    Total = obj.Total,
                    Descripcion = obj.Descripcion,
                    ID_Sucursal = obj.ID_Sucursal,
                    Direccion = obj.Direccion,

                }).ToList<OrdenVentaView>();

            return list;
        }

        public string OrdenVentaEstado(int ID_Orden)
        {
            var context = new SIEPERU2Entities();
            context.OrdenVentaEstado(ID_Orden);

            return "";
        }

    }
}
