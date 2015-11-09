using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Venta
{
   public class Movimiento
    {
            public int? ID_Movimiento { get; set; }
            public int? ID_Socio { get; set; }
            public string TipoDocumento { get; set; }  
            public int? NroDocumento { get; set; }  
            public  int 	ID_Orden		 { get; set; }
	        public  DateTime? FechaEmision	{ get; set; }
            public DateTime? FechaEntrega { get; set; }
            public DateTime? FechaContabilidad { get; set; }
	        public  int?   ID_Almacen	{ get; set; }
	        public  string UsuarioCreacion	 { get; set; }
	        public  string  UsuarioModificacion		 { get; set; }
	        public  string UsuarioEliminacion		 { get; set; }
	        public  DateTime? FechaCreacion	 { get; set; }
	        public  DateTime? FechaModificacion	 { get; set; }
	        public  DateTime? FechaEliminacion	 { get; set; }
	        public  string  Estado	 { get; set; }
            public string Tipo_Movimiento { get; set; }
            public string Descripcion_Almacen { get; set; }
            public string Lote_Movimiento { get; set; }
       
            public List<MovimientoView> Lista { get; set; }
	
    }

        public class MovimientoView {
        public int? ID_Movimiento { get; set; }  
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

        public class DetalleMovimiento
        {
            public int ID_MovimientoDetalle { get; set; }
            public int? ID_Movimiento { get; set; }
            public int? ID_DetalleOrden { get; set; }
            public string Lote { get; set; }
            public int? CantidadMovimiento { get; set; }
            public int? CantidadxMe { get; set; }
            public int? ID_Producto { get; set; }
            public string UsuarioCreacion { get; set; }
            public string UsuarioModificacion { get; set; }
            public string UsuarioEliminacion { get; set; }
            public DateTime? FechaCreacion { get; set; }
            public DateTime? FechaModificacion { get; set; }
            public DateTime? FechaEliminacion { get; set; }
            public string Estado { get; set; }
            public string Tipo_Movimiento { get; set; }


        }

        public class DetalleMovimientoView : DetalleMovimiento
        {
           

        } 
   
 }

