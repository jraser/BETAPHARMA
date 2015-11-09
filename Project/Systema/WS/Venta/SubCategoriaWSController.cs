using BL.Venta;
using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Systema.WS.Venta
{
    public class SubCategoriaWSController : ApiController
    {
        public List<SubCategoria> Get(int ID_Categoria)
        {
            SubCategoriaBL bl = new SubCategoriaBL();
            return bl.dll_SubCategoriaList(ID_Categoria);
        }

        public string Post(SubCategoria obj)
        {
            SubCategoriaBL bl = new SubCategoriaBL();
            return bl.SubCategoriaCreate(obj);
        }

        public SubCategoria GetSub(int ID_SubCategoria)
        {
            SubCategoriaBL bl = new SubCategoriaBL();
            return bl.SubCategoriaGet(ID_SubCategoria);
        } 
        public string Delete(int ID_SubCategoria)
        {
            SubCategoriaBL bl = new SubCategoriaBL();
            return bl.SubCategoriaDelete(ID_SubCategoria);
        } 
    }
}
