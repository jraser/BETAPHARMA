using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Venta
{

    public class Descuento
    {
        public int ID_Descuento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PorcDscto { get; set; }
         
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioEliminacion { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaModificacion { get; set; }
        public string FechaEliminacion { get; set; }
        public string Estado { get; set; }
    }
    public class DescuentoProducto
    {
        public int? ID_Descuento { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioEliminacion { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaModificacion { get; set; }
        public string FechaEliminacion { get; set; }
        public string Estado { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal? PorcDscto { get; set; }
    }

    public class DescuentoProductoView :DescuentoProducto
    {
        public int? ID_Grupo { get; set; } 
        
    }

    public class DescuentoGrupo  
    {
        public int? ID_Descuento { get; set; }
        public int? ID_Grupo { get; set; } 
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioEliminacion { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaModificacion { get; set; }
        public string FechaEliminacion { get; set; }
        public string Estado { get; set; }

    }
 
}
