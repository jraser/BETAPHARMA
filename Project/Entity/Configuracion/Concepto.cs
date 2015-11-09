using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Configuracion
{
    public class Concepto
    {
        public string CodigoTabla { get; set; }
        public string Tabla { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        
        public string UsuarioCreacion             { get; set; }
        public string UsuarioEliminacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string   FechaCreacion               { get; set; }
        public DateTime FechaModificacion           { get; set; }
        public DateTime FechaEliminacion { get; set; }
    }
}
