using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Venta
{

    public class Categoria
    {
       public int ID_Categoria { get; set; }  
       public string Nombre { get; set; }  
       public string UsuarioCreacion { get; set; }  
       public string UsuarioModificacion { get; set; }  
       public string UsuarioEliminacion { get; set; }  
       public DateTime FechaCreacion { get; set; }  
       public DateTime FechaModificacion { get; set; }  
       public DateTime FechaEliminacion { get; set; }
       public string Estado { get; set; } 
    }



    public class SubCategoria { 
        public int ID_SubCategoria { get; set; }
        public int? ID_Categoria { get; set; }
        public string Nombre { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioEliminacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaEliminacion { get; set; }
        public string Estado { get; set; }
    }

    public class Marca
    {
        public int? ID_Marca { get; set; }
        public string Descripcion { get; set; }
        public string Fabricante { get; set; }
        public string Codigo_Marca { get; set; }  
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioEliminacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaEliminacion { get; set; }
        public string Estado { get; set; }
    }


    public class UnidadMedida
    {
        public string Codigo_UMedida { get; set; }
        public string Nombre { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioEliminacion { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaModificacion { get; set; }
        public string FechaEliminacion { get; set; }
        public string Tbl_UnidadMedida { get; set; }
    }


}
