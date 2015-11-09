using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class CategoriaBL
    {
        CategoriaDAO Dao = new CategoriaDAO();
        public List<Categoria> dll_CategoriaList()
        { 
            return Dao.dll_CategoriaList();
        }
        public List<Categoria> CategoriaList(string Nombre)
        {
            return Dao.CategoriaList(Nombre);
        }
        public Categoria CategoriaGet(int ID_Categoria)
        {
            return Dao.CategoriaGet(ID_Categoria);
        }

        public string CategoriaCreate(Categoria obj)
        {
            return Dao.CategoriaCreate(obj);
        }

        public string CategoriaDelete(int ID_Categoria)
        {
            return Dao.CategoriaDelete(ID_Categoria);
        }

    }
}
