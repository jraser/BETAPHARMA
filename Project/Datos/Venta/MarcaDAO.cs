using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class MarcaDAO
    {
        public List<Marca> dll_MarcaList() 
        {

            var context = new SIEPERU2Entities();

            var list = context.dll_MarcaList().ToList().
                Select(obj => new Marca
                {
                    ID_Marca = obj.ID_Marca,
                    Descripcion = obj.Descripcion,

                }).ToList<Marca>();

            return list;
        }

        public string MarcaCreate(Marca obj)
        {
             
            var context = new SIEPERU2Entities();

            var Id = context.MarcaCreate(
                 obj.ID_Marca,
                  obj.Descripcion,
                  obj.Fabricante,
                  obj.UsuarioCreacion,
                  obj.UsuarioModificacion,
                  obj.UsuarioEliminacion,
                  null,
                  null,
                  null,
                  "",
                  obj.Codigo_Marca);


            return "";
        }

        public Marca MarcaGet(int ID_Marca) 
        {
            var context = new SIEPERU2Entities();
            var list = context.MarcaGet(ID_Marca).ToList().
                Select(obj => new Marca
                {
                    ID_Marca = obj.ID_Marca, 
                    Descripcion = obj.Descripcion,
                    Fabricante= obj.Fabricante,
                    Estado = obj.Estado
                }).ToList<Marca>()[0];

            return list;
        }

        public List<Marca> MarcaList(string Descripcion)
        {

            var context = new SIEPERU2Entities();

            var list = context.MarcaList(Descripcion).ToList().
                Select(obj => new Marca
                {
                    ID_Marca = obj.ID_Marca,
                    Descripcion = obj.Descripcion,
                    Fabricante=obj.Fabricante,
                    Estado=obj.Estado
                }).ToList<Marca>();

            return list;
        }
        public string MarcaDelete(int ID_Marca)
        { 

            var context = new SIEPERU2Entities();

            var Id = context.MarcaDelete(
                  ID_Marca);


            return "";
        }

    }
}
