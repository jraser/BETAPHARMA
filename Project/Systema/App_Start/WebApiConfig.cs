using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Systema
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            //config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

             config.Routes.MapHttpRoute(
         name: "ApiGrupoList",
         routeTemplate: "api/{controller}/{Nombre}",
         defaults: new
         { 
             controller = "GrupoClienteWS",
             Nombre = RouteParameter.Optional,
         });
             config.Routes.MapHttpRoute(
          name: "ApiCuentaList",
          routeTemplate: "api/{controller}/{Codigo}",
          defaults: new
          {
              controller = "CuentaWS",
              Codigo = RouteParameter.Optional,
          });
             config.Routes.MapHttpRoute(
             name: "ApiProductoList",
             routeTemplate: "api/{controller}/{Descripcion}",
             defaults: new
             {
                 controller = "ProductoWS",
                 Descripcion = RouteParameter.Optional,
             });
         
           
        }
    }
}
