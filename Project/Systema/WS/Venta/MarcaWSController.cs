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
    public class MarcaWSController : ApiController
    {
        public List<Marca> Get()
        {
            MarcaBL bl = new MarcaBL();
            return bl.dll_MarcaList();
        }

        public List<Marca> Get(string Descripcion)
        {
            MarcaBL bl = new MarcaBL();
            return bl.MarcaList(Descripcion);
        }

        public Marca Get(int ID_Marca)
        {
            MarcaBL bl = new MarcaBL();
            return bl.MarcaGet(ID_Marca);
        }
        public string Post(Marca obj)
        {
            MarcaBL bl = new MarcaBL();
            return bl.MarcaCreate(obj);
        }
         
        public string Delete(int ID_Marca)
        {
            MarcaBL bl = new MarcaBL(); 
            return bl.MarcaDelete(ID_Marca);
        }
       
    }
}
