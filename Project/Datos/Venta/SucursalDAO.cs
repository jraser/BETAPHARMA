using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class SucursalDAO
    {


        public List<Sucursal> SucursalList(string Descripcion_Sucursal)
        {

            var context = new SIEPERU2Entities();

            var list = context.SucursalList(Descripcion_Sucursal).ToList().
                Select(obj => new Sucursal
                {
                    ID_Sucursal = obj.ID_Sucursal,
                    Codigo_Sucursal = obj.Codigo_Sucursal,
                    Descripcion_Sucursal = obj.Descripcion_Sucursal,
                    Estado = obj.Estado,
                    Direccion=obj.Direccion
                }).ToList<Sucursal>();

            return list;
        }

        public string SucursalCreate(Sucursal obj)
        {

            var context = new SIEPERU2Entities();

            var Id = context.SucursalCreate(
                  obj.ID_Sucursal,
                  obj.Codigo_Sucursal,
                  obj.Descripcion_Sucursal,
                  "",
                  obj.UsuarioCreacion,
                  obj.UsuarioModificacion,
                  obj.UsuarioEliminacion,
                  null,
                  null,
                  null,
                  obj.Direccion
                  );


            return "";
        }

        public Sucursal SucursalGet(int ID_Sucursal)
        {
            var context = new SIEPERU2Entities();
            var list = context.SucursalGet(ID_Sucursal).ToList().
                Select(obj => new Sucursal
                {
                    ID_Sucursal = obj.ID_Sucursal,
                    Codigo_Sucursal = obj.Codigo_Sucursal,
                    Descripcion_Sucursal = obj.Descripcion_Sucursal,
                    Estado = obj.Estado,
                    Direccion = obj.Direccion
                }).ToList<Sucursal>()[0];

            return list;
        }

        public List<Sucursal> dll_SucursalList()
        {
            var context = new SIEPERU2Entities();
            var list = context.dll_SucursalList().ToList().
                Select(obj => new Sucursal
                {
                    ID_Sucursal = obj.ID_Sucursal,
                    Descripcion_Sucursal = obj.Descripcion_Sucursal,
                    Estado = obj.Estado,
                    Direccion = obj.Direccion
                }).ToList<Sucursal>();
            return list;
        }



        public string SucursalDelete(int ID_Sucursal)
        {

            var context = new SIEPERU2Entities();

            var Id = context.SucursalDelete(
                  ID_Sucursal);


            return "";
        }

    }
}
