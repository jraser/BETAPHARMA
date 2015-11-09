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
    public class CategoriaWSController : ApiController
    {


        public List<Categoria> Get()
        {
            CategoriaBL bl = new CategoriaBL();
            return bl.dll_CategoriaList();
        }

        public List<Categoria> Get(string Nombre)
        {
            CategoriaBL bl = new CategoriaBL();
            return bl.CategoriaList(Nombre);
        }

        public Categoria Get(int ID_Categoria)
        {
            CategoriaBL bl = new CategoriaBL();
            return bl.CategoriaGet(ID_Categoria);
        }
        public string Post(Categoria obj)
        {
            CategoriaBL bl = new CategoriaBL();
            return bl.CategoriaCreate(obj);
        }
        public string Delete(int ID_Categoria)
        {
            CategoriaBL bl = new CategoriaBL();
            return bl.CategoriaDelete(ID_Categoria);
        } 
    }
}
