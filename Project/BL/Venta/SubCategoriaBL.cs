using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
   public  class SubCategoriaBL
    {
       SubCategoriaDAO Dao = new SubCategoriaDAO();
       public List<SubCategoria> dll_SubCategoriaList(int ID_Categoria)
        {
            return Dao.dll_SubCategoriaList(ID_Categoria);
        }

       public SubCategoria SubCategoriaGet(int ID_Categoria)
       {
           return Dao.SubCategoriaGet(ID_Categoria);
       }

       public string SubCategoriaCreate(SubCategoria obj)
       {
           return Dao.SubCategoriaCreate(obj);
       }
       public string SubCategoriaDelete(int ID_SubCategoria)
       {
           return Dao.SubCategoriaDelete(ID_SubCategoria);
       }

    } 
}
