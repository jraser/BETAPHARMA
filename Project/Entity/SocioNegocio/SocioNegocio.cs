using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.SocioNegocio
{
    public class Socio
    {
        public int ID_Socio { get; set; }
        public string Tipo_Socio { get; set; }
        public string Regimen_Socio { get; set; }
        public string Tipo_Documento { get; set; }
        public string Num_Documento { get; set; }
        public string Nombres_Socio { get; set; }
        public string NombreComercial_Socio { get; set; }
        public string Telefono { get; set; }
        public string Origen_Socio { get; set; }
        public string Direccion_Socio { get; set; }
        public string Estado { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioEliminacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
       
    }

    public class Direcciones
    {
        public int ID_Direccion { get; set; }
        public string Direccion { get; set; }
        public string Referencia_Domicilio { get; set; }
        public int? ID_Ubigeo { get; set; }
        public int? ID_Socio { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioEliminacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }
    }

    public class SocioView
    {
        public int ID_Socio { get; set; }
        public string Tipo_Socio { get; set; }
        public string Tipo_Regimen { get; set; }
        public string Tipo_Documento { get; set; }
        public string Num_Documento { get; set; }
        public string Nombre { get; set; }
        public string DIRECCION { get; set; }
        public string Telefono { get; set; }

    }
}
