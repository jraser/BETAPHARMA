using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Contabilidad
{
    public class Cuenta
    {

        public int ID_PlanCuenta { get; set; } 
        public string CodigoCuenta { get; set; } 
        public string DescripcionCuenta { get; set; } 
        public string CodigoCuentaPadre { get; set; } 
        public int? Nivel { get; set; } 
        public string Estado { get; set; } 
        public string UsuarioCreacion { get; set; } 
        public string UsuarioModificacion { get; set; } 
        public string UsuarioEliminacion { get; set; } 
        public DateTime FechaCreacion { get; set; } 
        public DateTime FechaModificacion { get; set; } 
        public DateTime FechaEliminacion { get; set; }
        public List<Cuenta> List { get; set; }
        public int? Origen { get; set; }
    }
}
