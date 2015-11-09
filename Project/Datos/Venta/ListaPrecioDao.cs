using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class ListaPrecioDao
    {

        public List<ListaPrecioView> ALTProductoBySocioList(string Descripcion_Producto, string Nombre, string Nombres_Socio)
        {

            var context = new SIEPERU2Entities();

            var list = context.ALTProductoBySocioList(Descripcion_Producto, Nombre, Nombres_Socio).ToList().
                Select(obj => new ListaPrecioView
                {
                    ID_Producto = obj.ID_Producto,
                    Codigo_Producto = obj.Codigo_Producto,
                    Descripcion_Producto = obj.Descripcion_Producto,
                    ID_Marca = obj.ID_Marca,
                    ID_Categoria = obj.ID_Categoria,
                    ID_SubCategoria = obj.ID_SubCategoria,
                    Categoria = obj.Categoria,
                    SubCategoria = obj.SubCategoria,
                    Estado = obj.Estado,
                    NombreEstado = obj.NombreEstado,
                    //ID_Precio = obj.ID_Precio,
                    PV = obj.PV,
                    PC = obj.PC
                }).ToList<ListaPrecioView>();

            return list;
        }


    }
}
