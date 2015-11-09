using Datos.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Venta
{
    public class MarcaBL
    {
        MarcaDAO Dao = new MarcaDAO();
        public List<Marca> dll_MarcaList()
        {
            return Dao.dll_MarcaList();
        }

        public List<Marca> MarcaList(string Descripcion)
        {
            return Dao.MarcaList(Descripcion);
        }

        public Marca MarcaGet(int ID_Marca)
        {
            return Dao.MarcaGet(ID_Marca);
        }
         
        public string MarcaCreate(Marca obj)
        {
            return Dao.MarcaCreate(obj);
        }
        public string MarcaDelete(int ID_Marca)
        {
            return Dao.MarcaDelete(ID_Marca);
        }

    }
}
