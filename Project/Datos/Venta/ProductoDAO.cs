using Entity.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Venta
{
    public class ProductoDAO
    {

        public string ProductoCreate(Producto obj)
        {
            var context = new SIEPERU2Entities();
            var Id = context.ProductoCreate(
                 obj.ID_Producto,
                 obj.CostoProducto,
                 obj.Codigo_Producto,
                 obj.Descripcion_Producto,
                 obj.ID_Marca,
                 "",
                 obj.ID_Categoria,
                 obj.ID_SubCategoria,
                 obj.UsuarioCreacion,
                 obj.UsuarioModificacion,
                 obj.UsuarioEliminacion,
                 null,
                 null,
                 null,
                 obj.Codigo_UMedida,
                 obj.Cod_Lote,
                 obj.Precio_CompBase,
                 obj.Precio_VenBase
                 ).ToList();

            return Id[0].ToString();
        }


        public List<ProductoView> ProductoList(string Descripcion, int ID_Categoria, int ID_SubCategoria)
        {

            var context = new SIEPERU2Entities();

            var list = context.ProductoList(Descripcion, ID_Categoria, ID_SubCategoria).ToList().
                Select(obj => new ProductoView
                {
                    ID_Producto = obj.ID_Producto,
                    CostoProducto = obj.CostoProducto,
                    Codigo_Producto = obj.Codigo_Producto,
                    Descripcion_Producto = obj.Descripcion_Producto,
                    ID_Marca = obj.ID_Marca,
                    ID_Categoria = obj.ID_Categoria,
                    ID_SubCategoria = obj.ID_SubCategoria,
                    Categoria = obj.Categoria,
                    SubCategoria = obj.SubCategoria,
                    Estado = obj.Estado,
                    NombreEstado = obj.NombreEstado,
                }).ToList<ProductoView>();

            return list;
        }

        public string ProductoDelete(int ID_Producto)
        {
            var context = new SIEPERU2Entities();
            context.ProductoDelete(ID_Producto);

            return "";
        }

        public Producto ProductoGet(int ID_Producto)
        {
            var context = new SIEPERU2Entities();
            var list = context.ProductoGet(ID_Producto).ToList().
                Select(obj => new Producto
                {
                    ID_Producto = obj.ID_Producto,
                    CostoProducto = obj.CostoProducto,
                    Codigo_Producto = obj.Codigo_Producto,
                    Descripcion_Producto = obj.Descripcion_Producto,
                    ID_Marca = obj.ID_Marca,
                    Estado = obj.Estado,
                    ID_Categoria = obj.ID_Categoria,
                    ID_SubCategoria = obj.ID_SubCategoria,
                    Codigo_UMedida = obj.Codigo_UMedida,
                    Cod_Lote = obj.Cod_Lote,
                    PV=obj.PV
                }).ToList<Producto>()[0];

            return list;
        }

        public List<ProductoView> ProductoBySocioList(string Descripcion, int ID_Categoria, int ID_SubCategoria, int ID_Socio)
        {

            var context = new SIEPERU2Entities();

            var list = context.ProductoBySocioList(Descripcion, ID_Categoria, ID_SubCategoria, ID_Socio).ToList().
                Select(obj => new ProductoView
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

                    ID_Precio = obj.ID_Precio,
                    PV = obj.PV,
                    PC = obj.PC
                }).ToList<ProductoView>();

            return list;
        }


    }
}
