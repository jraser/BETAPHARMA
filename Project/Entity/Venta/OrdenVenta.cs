using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Venta
{

        public class OrdenVenta
        {
            public int ID_Orden { get; set; }
            public int? ID_Socio { get; set; }
            public decimal? IGV { get; set; }
            public decimal? Impuesto { get; set; }
            public decimal? Monto { get; set; }
            public decimal? Total { get; set; }
            public decimal? Descuento { get; set; }
            public DateTime? FechaEmision { get; set; }
            public DateTime? FechaEntrega { get; set; }
            public DateTime? FechaContabilidad { get; set; }
            public string ID_Moneda { get; set; }
            public string ID_FormaPago { get; set; }
            public string ID_CondicionPago { get; set; }
            public int? ID_Sucursal { get; set; }
            public string UsuarioCreacion { get; set; }
            public string UsuarioModificacion { get; set; }
            public string UsuarioEliminacion { get; set; }
            public DateTime? FechaCreacion { get; set; }
            public DateTime? FechaModificacion { get; set; }
            public DateTime? FechaEliminacion { get; set; }
            public string Estado { get; set; }
            public string Situacion { get; set; }

            public List<DetalleOrdenVentaView> Lista { get; set; }

        }

        public class OrdenVentaView
        {
            public int ID_Orden { get; set; }
            public int ID_Socio { get; set; }
            public DateTime? FechaEmision { get; set; }
            public DateTime? FechaEntrega { get; set; }
            public DateTime? FechaContabilidad { get; set; }
            public string Nombres_Socio { get; set; }
            public decimal? Impuesto { get; set; }
            public decimal? Monto { get; set; }
            public decimal? Total { get; set; }
            public string Descripcion { get; set; }
            public int? ID_Sucursal { get; set; }
            public string Direccion { get; set; }
            public string Situacion { get; set; }


        }
        public class DetalleOrdenVenta
        {
            public int ID_DetalleOrden { get; set; }
            public int? ID_Orden { get; set; }
            public decimal? PrecioUnitario { get; set; }

            public int? Cantidad { get; set; }
            public decimal? Descuento { get; set; }
            public decimal? Monto { get; set; }
            public int? Atendido { get; set; }
            public int? Faltante { get; set; }
            public int? ID_Producto { get; set; }
            public string Lote { get; set; }
            public int? ID_Almacen { get; set; }
            public string UsuarioCreacion { get; set; }
            public string UsuarioModificacion { get; set; }
            public string UsuarioEliminacion { get; set; }
            public DateTime? FechaCreacion { get; set; }
            public DateTime? FechaModificacion { get; set; }
            public DateTime? FechaEliminacion { get; set; }
            public string Codigo_Producto { get; set; }
            public string Descripcion_Producto { get; set; }
            public string Estado { get; set; }
            public string Nombre { get; set; }
            public decimal? Total { get; set; }

        }

        public class DetalleOrdenVentaView : DetalleOrdenVenta
        {
            public string NombreProducto { get; set; }

        } 
    
}
