using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Venta
{
   public class Sucursal
    {
       public int ID_Sucursal { get; set; }
       public string Codigo_Sucursal { get; set; }
       public string Descripcion_Sucursal { get; set; } 
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioEliminacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaEliminacion { get; set; }
        public string Estado { get; set; }
        public string Direccion { get; set; }
    }


   public class Almacen
   {
       public int ID_Almacen { get; set; }
       public string Codigo_Almacen { get; set; }
       public string Descripcion_Almacen { get; set; }
       public string Direccion_Almacen { get; set; }
       public int? ID_Sucursal { get; set; }
       public string UsuarioCreacion { get; set; }
       public string UsuarioModificacion { get; set; }
       public string UsuarioEliminacion { get; set; }
       public DateTime FechaCreacion { get; set; }
       public DateTime FechaModificacion { get; set; }
       public DateTime FechaEliminacion { get; set; }
       public string Estado { get; set; }
       public string Tipo_Almacen { get; set; }
   } 
}
