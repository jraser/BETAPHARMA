using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class SubCategoriaDAO
    {
        public List<SubCategoria> dll_SubCategoriaList(int ID_Categoria)
        {

            var context = new SIEPERU2Entities();

            var list = context.dll_SubCategoriaList(ID_Categoria).ToList().
                Select(obj => new SubCategoria
                {   
                    ID_Categoria=obj.ID_Categoria,
                    ID_SubCategoria = obj.ID_SubCategoria,
                    Nombre = obj.Nombre,
                    Estado=obj.Estado,
                }).ToList<SubCategoria>();

            return list;
        }


        public string SubCategoriaCreate(SubCategoria obj)
        {
             
            var context = new SIEPERU2Entities();

            var Id = context.SubCategoriaCreate(
                 obj.ID_SubCategoria,
                  obj.ID_Categoria,
                  obj.Nombre,
                  obj.UsuarioCreacion,
                  obj.UsuarioModificacion,
                  obj.UsuarioEliminacion,
                  null,
                  null,
                  null,
                  "");


            return "";
        }

        public SubCategoria SubCategoriaGet(int ID_SubCategoria) 
        {
            var context = new SIEPERU2Entities();
            var list = context.SubCategoriaGet(ID_SubCategoria).ToList().
                Select(obj => new SubCategoria
                {
                    ID_Categoria = obj.ID_Categoria,
                    ID_SubCategoria=obj.ID_SubCategoria,
                    Nombre = obj.Nombre,
                }).ToList<SubCategoria>()[0];

            return list;
        }

        public string SubCategoriaDelete(int ID_SubCategoria)
        {
             
            var context = new SIEPERU2Entities();
             
            var Id = context.SubCategoriaDelete(
                  ID_SubCategoria);


            return "";
        }


    }
}
