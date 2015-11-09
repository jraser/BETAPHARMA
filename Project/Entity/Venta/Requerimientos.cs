using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Venta
{
   public class Requerimientos
    {
 
       public int? ID_Requerimientos { get; set; }
        public int? ID_Socio { get; set; }
        public string TipoDocumento { get; set; }
        public int? NroDocumento { get; set; }
        public int ID_Orden { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime? FechaContabilidad { get; set; }
        public int? ID_Almacen { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioEliminacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }
        public string Descripcion_Almacen { get; set; }
        public string Lote_Requermientos { get; set; }

        public List<RequerimientosView> Lista { get; set; }

    }

   public class RequerimientosView
   {
       public int? ID_Requerimientos { get; set; }
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
       public string Descripcion_Almacen { get; set; }


   }

  public class DetalleRequerimiento
   {
      public int ID_RequerimientoDetalle { get; set; }
      public int? ID_Requerimientos { get; set; }
       public int? ID_DetalleOrden { get; set; }
       public string Lote_Requermientos { get; set; }
       public int? CantidadRequisito { get; set; }
       public int? CantidadxMe { get; set; }
       public int? ID_Producto { get; set; }
       public string UsuarioCreacion { get; set; }
       public string UsuarioModificacion { get; set; }
       public string UsuarioEliminacion { get; set; }
       public DateTime? FechaCreacion { get; set; }
       public DateTime? FechaModificacion { get; set; }
       public DateTime? FechaEliminacion { get; set; }
       public string Estado { get; set; }
       public string Descripcion_Producto { get; set; }



   }

public class DetalleRequerimientoView :DetalleRequerimiento
    { }
 }

