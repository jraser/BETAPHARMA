using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Venta;


namespace Datos.Venta
{
    public class PrecioDAO
    {

        public string PrecioCreate(Precio obj)
        { 
            var context = new SIEPERU2Entities();
            var Id = context.PrecioCreate(
                 obj.ID_Precio,
                 obj.ID_Producto,
                 obj.PV,
                 obj.PC,
                 obj.ID_Socio,
                 obj.UsuarioCreacion,
                 obj.UsuarioModificacion,
                 obj.UsuarioEliminacion,
                 null,
                 null,
                 null
                 );

            return "";
        }

        public List<PrecioView> PrecioList(int ID_Producto)
        {

            var context = new SIEPERU2Entities();

            var list = context.PrecioList(ID_Producto).ToList().
                Select(obj => new PrecioView
                {
                    ID_Precio = obj.ID_Precio,
                    ID_Producto = obj.ID_Producto,
                    PC = obj.PC,
                    PV = obj.PV,
                    ID_Socio = obj.ID_Socio,
                    NombreSocio = obj.Nombres_Socio
                }).ToList<PrecioView>();

            return list;
        }


        //public Precio PrecioGet(int ID_Precio) 
        //{

        //    var context = new SIEPERU2Entities();

        //    var list = context.PrecioGet(ID_Precio).ToList().
        //        Select(obj => new Precio
        //        {
        //            ID_Precio = obj.ID_Precio,
        //            ID_Producto = obj.ID_Producto,
        //            PC = obj.PC,
        //            PV = obj.PV,
        //            ID_Socio=obj.ID_Socio
        //        }).ToList<Precio>();

        //    return list[0];
        //}

    }
}
