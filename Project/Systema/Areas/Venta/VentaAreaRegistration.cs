using System.Web.Mvc;

namespace Systema.Areas.Venta
{
    public class VentaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Venta";
            }
        }


        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Venta_default",
                "Venta/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute(
       name: "ProductoList",
       url: "Producto/List",
       defaults: new { controller = "Producto", action = "List" });
            context.MapRoute(
       name: "ProductoCreate",
       url: "Producto/Create",
       defaults: new { controller = "Producto", action = "Create" });

            context.MapRoute(
       name: "ProductoAdd",
       url: "Producto/ListAdd",
       defaults: new { controller = "Producto", action = "ListAdd" });


            context.MapRoute(
     name: "ALTProductoBySocioList",
     url: "ListaPrecio/List",
     defaults: new { controller = "ListaPrecio", action = "List" });



            context.MapRoute(
         name: "RequerimientosList",
         url: "Requerimientos/List",
         defaults: new { controller = "Requerimientos", action = "List" });


            context.MapRoute(
            name: "RequerimientosModific",
            url: "Requerimientos/Modific",
            defaults: new { controller = "Requerimientos", action = "Modific" });

            context.MapRoute(
            name: "RequerimientosCreate",
            url: "Requerimientos/Create",
            defaults: new { controller = "Requerimientos", action = "Create" });

            context.MapRoute(
          name: "AlmacenList",
          url: "Almacen/List",
          defaults: new { controller = "Almacen", action = "List" });

            context.MapRoute(
            name: "AlmacenCreate",
            url: "Almacen/Create",
            defaults: new { controller = "Almacen", action = "Create" });

            context.MapRoute(
            name: "AlmacenAdd",
            url: "Almacen/CreateAdd",
            defaults: new { controller = "Almacen", action = "CreateAdd" });





            context.MapRoute(
       name: "DescuentoList",
       url: "Descuento/List",
       defaults: new { controller = "Descuento", action = "List" });
            context.MapRoute(
            name: "DescuentoCreate",
            url: "Descuento/Create",
            defaults: new { controller = "Descuento", action = "Create" });

            context.MapRoute(
            name: "DescuentoAdd",
            url: "Descuento/ListAdd",
            defaults: new { controller = "Descuento", action = "ListAdd" });

            context.MapRoute(
            name: "CategoriaList",
            url: "Categoria/List",
            defaults: new { controller = "Categoria", action = "List" });
            context.MapRoute(
            name: "CategoriaCreate",
            url: "Categoria/Create",
            defaults: new { controller = "Categoria", action = "Create" });

            context.MapRoute(
            name: "CategoriaAdd",
            url: "Categoria/CreateAdd",
            defaults: new { controller = "Categoria", action = "CreateAdd" });

            context.MapRoute(
            name: "SubCategoriaList",
            url: "SubCategoria/List",
            defaults: new { controller = "SubCategoria", action = "List" });
            context.MapRoute(
            name: "SubCategoriaCreate",
            url: "SubCategoria/Create",
            defaults: new { controller = "SubCategoria", action = "Create" });
            context.MapRoute(
            name: "SubCategoriaAdd",
            url: "SubCategoria/CreateAdd",
            defaults: new { controller = "SubCategoria", action = "CreateAdd" });


            context.MapRoute(
            name: "MarcaList",
            url: "Marca/List",
            defaults: new { controller = "Marca", action = "List" });
            context.MapRoute(
            name: "MarcaCreate",
            url: "Marca/Create",
            defaults: new { controller = "Marca", action = "Create" });

            context.MapRoute(
            name: "MarcaAdd",
            url: "Marca/MarcaAdd",
            defaults: new { controller = "Marca", action = "MarcaAdd" });

            context.MapRoute(
            name: "SucursalList",
            url: "Sucursal/List",
            defaults: new { controller = "Sucursal", action = "List" });
            context.MapRoute(
            name: "SucursalCreate",
            url: "Sucursal/Create",
            defaults: new { controller = "Sucursal", action = "Create" });

           context.MapRoute(
           name: "PrecioCreate",
           url: "Precio/Create",
           defaults: new { controller = "Precio", action = "Create" });
           context.MapRoute(
           name: "PrecioAdd",
           url: "Precio/ListAdd",
           defaults: new { controller = "Precio", action = "ListAdd" });

           context.MapRoute(
           name: "OCList",
           url: "OC/List",
           defaults: new { controller = "OC", action = "List" });

           context.MapRoute(
           name: "OCCreate",
           url: "OC/Create",
           defaults: new { controller = "OC", action = "Create" });

           context.MapRoute(
           name: "OCModific",
           url: "OC/Modific",
           defaults: new { controller = "OC", action = "Modific" });


           context.MapRoute(
           name: "OCListAdd",
           url: "OC/ListAdd",
           defaults: new { controller = "OC", action = "ListAdd" });

           context.MapRoute(
           name: "MovimientoList",
           url: "Movimiento/List",
           defaults: new { controller = "Movimiento", action = "List" });


           context.MapRoute(
           name: "MovimientoCreate",
           url: "Movimiento/Create",
           defaults: new { controller = "Movimiento", action = "Create" });


           context.MapRoute(
           name: "DetalleOCModific",
           url: "DetalleOC/Modific",
           defaults: new { controller = "DetalleOC", action = "Modific" });

           context.MapRoute(
          name: "DetalleOCCreate",
          url: "DetalleOC/Create",
          defaults: new { controller = "DetalleOC", action = "Create" });


          context.MapRoute(
          name: "OCAddListAdd",
          url: "OCAdd/ListAdd",
          defaults: new { controller = "OCAdd", action = "ListAdd" });




          context.MapRoute(
          name: "OVCreate",
          url: "OV/Create",
          defaults: new { controller = "OV", action = "Create" });

          context.MapRoute(
          name: "OVList",
          url: "OV/List",
          defaults: new { controller = "OV", action = "List" });

          context.MapRoute(
          name: "StockListAdd",
          url: "Stock/ListAdd",
          defaults: new { controller = "Stock", action = "ListAdd" });

          context.MapRoute(
            name: "StockAddStock",
            url: "Stock/AddStock",
            defaults: new { controller = "Stock", action = "AddStock" });

          context.MapRoute(
          name: "OVModific",
          url: "OV/Modific",
          defaults: new { controller = "OV", action = "Modific" });
          
          context.MapRoute(
          name: "DetalleOVCreate",
          url: "DetalleOV/Create",
          defaults: new { controller = "DetalleOV", action = "Create" });

          context.MapRoute(
            name: "DetalleOVModific",
            url: "DetalleOV/Modific",
            defaults: new { controller = "DetalleOV", action = "Modific" });

          context.MapRoute(
          name: "MovimientoList2",
          url: "Movimiento/List2",
          defaults: new { controller = "Movimiento", action = "List2" });


          context.MapRoute(
          name: "MovimientoCreate2",
          url: "Movimiento/Create2",
          defaults: new { controller = "Movimiento", action = "Create2" });

          context.MapRoute(
         name: "OVAddListAdd",
         url: "OVAdd/ListAdd",
         defaults: new { controller = "OVAdd", action = "ListAdd" });       
        
        
        
        
        
        }

       

    }
}