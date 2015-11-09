using Entity.SocioNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.SocioNegocio
{


    public class SocioNegocioDAO
    {
        public List<SocioView> SocioNegocioList(string Nombres, string Nro_Documento, string TipoSocio)
        {

            var context = new SIEPERU2Entities();


            var list = context.SocioNegocioList(Nombres, Nro_Documento, TipoSocio).ToList().
                Select(obj => new SocioView
                {
                    ID_Socio = obj.ID_Socio,
                    Tipo_Socio = obj.Tipo_Socio,
                    Tipo_Regimen = obj.Tipo_Regimen,
                    Tipo_Documento = obj.Tipo_Documento,
                    Num_Documento = obj.Num_Documento,
                    Nombre = obj.Nombre,
                    DIRECCION = obj.DIRECCION,
                    Telefono = obj.Telefono,
                }).ToList<SocioView>();

            return list;
        }

        public string SocioNegocioCreate(Socio obj)
        {
            var context = new SIEPERU2Entities();

            var ID = context.SocioNegocioCreate(
                    obj.ID_Socio,
                    obj.Tipo_Socio,
		            obj.Regimen_Socio,
		            obj.Tipo_Documento,
		            obj.Num_Documento,
		            obj.Nombres_Socio,
		            obj.NombreComercial_Socio,
		            obj.Telefono,
		            obj.Origen_Socio,
		            obj.Direccion_Socio,
		            obj.Estado,
		            obj.UsuarioCreacion,
		            obj.UsuarioModificacion,
		            obj.UsuarioEliminacion,
		            obj.FechaCreacion,
		            obj.FechaModificacion,
		            obj.FechaEliminacion).ToList();

                 

            return ID[0].ToString();

        }


        public List<Socio> dll_SocioNegocioList()
        {
            var context = new SIEPERU2Entities();
            var list = context.dll_SocioNegocioList().ToList().
                Select(obj => new Socio
            {
                ID_Socio = obj.ID_Socio,
                Nombres_Socio = obj.Nombres_Socio

            }).ToList<Socio>();
            return list;

        }



        public string SocioNegocioUpdate(Socio obj)
        {
            var context = new SIEPERU2Entities();

            context.SocioNegocioUpdate(
                obj.ID_Socio,
                    obj.Tipo_Socio,
                    obj.Regimen_Socio,
                    obj.Tipo_Documento,
                    obj.Num_Documento,
                    obj.Nombres_Socio,
                    obj.NombreComercial_Socio,
                    obj.Telefono,
                    obj.Origen_Socio,
                    obj.Direccion_Socio,
                    obj.Estado,
                    obj.UsuarioModificacion,
                    obj.FechaModificacion);
            return "";
        }

        public Socio SocioNegocioGet(int ID_Socio)
        {
            var context = new SIEPERU2Entities();

            var list = context.SocioNegocioGet(ID_Socio).ToList().
                Select(obj => new Socio
                {

                    ID_Socio = obj.ID_Socio,
                    Tipo_Socio = obj.Tipo_Socio,
                    Regimen_Socio = obj.Regimen_Socio,
                    Tipo_Documento = obj.Tipo_Documento,
                    Num_Documento = obj.Num_Documento,
                    Nombres_Socio = obj.Nombres_Socio,
                    NombreComercial_Socio = obj.NombreComercial_Socio,
                    Telefono= obj.Telefono,
                    Origen_Socio = obj.Origen_Socio,
                    Direccion_Socio = obj.Direccion_Socio,
                    Estado = obj.Estado,
                    UsuarioCreacion= obj.UsuarioCreacion,
                    UsuarioModificacion = obj.UsuarioModificacion,
                    UsuarioEliminacion= obj.UsuarioEliminacion,
                    FechaCreacion = obj.FechaCreacion,
                    FechaModificacion = obj.FechaModificacion,
                    FechaEliminacion = obj.FechaEliminacion
                    

                }).ToList<Socio>()[0];

            return list;
        }

        public string SocioNegocioDelete(int ID_Socio)
        {
            var context = new SIEPERU2Entities();
            context.SocioNegocioDelete(ID_Socio);

            return "";
        }
        public List<Socio> ddl_SocioNegocioList(string TipoSocio, string Nombres)
        {

            var context = new SIEPERU2Entities();

            var list = context.ddl_SocioNegocioList(TipoSocio, Nombres).ToList().
                Select(obj => new Socio
                {
                    ID_Socio = obj.ID_Socio,
                    Nombres_Socio = obj.Nombres_Socio
                }).ToList<Socio>();

            return list;
        }




    }
}




