using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class CategoriaDAO
    {


        public List<Categoria> CategoriaList(string Nombre) 
        {

            var context = new SIEPERU2Entities();

            var list = context.CategoriaList(Nombre).ToList().
                Select(obj => new Categoria
                {
                    ID_Categoria = obj.ID_Categoria,
                    Nombre = obj.Nombre,
                    Estado=obj.Estado
                }).ToList<Categoria>();

            return list;
        }

        public string CategoriaCreate(Categoria obj)
        {

            var context = new SIEPERU2Entities();

            var Id = context.CategoriaCreate(
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

        public Categoria CategoriaGet(int ID_Categoria)
        {
            var context = new SIEPERU2Entities();
            var list = context.CategoriaGet(ID_Categoria).ToList().
                Select(obj => new Categoria
                {
                    ID_Categoria = obj.ID_Categoria,
                    Nombre = obj.Nombre,
                }).ToList<Categoria>()[0];

            return list;
        }


        public List<Categoria> dll_CategoriaList()
        {

            var context = new SIEPERU2Entities();

            var list = context.dll_CategoriaList().ToList().
                Select(obj => new Categoria
                {
                    ID_Categoria = obj.ID_Categoria,
                    Nombre= obj.Nombre,
               
                }).ToList<Categoria>();

            return list;
        }

        public string CategoriaDelete(int ID_Categoria)
        {
             
            var context = new SIEPERU2Entities();

            var Id = context.CategoriaDelete(
                  ID_Categoria);


            return "";
        }



    }



}
