using System.Web.Mvc;

namespace Systema.Areas.SocioNegocio  
{
    public class SocioNegocioAreaRegistration : AreaRegistration  
    {
        public override string AreaName 
        {
            get  
            {
                return "SocioNegocio";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
        context.MapRoute(
        name: "GrupoList",
        url: "Grupo/List",
        defaults: new { controller = "Grupo", action = "List" });

        context.MapRoute(
        name: "GrupoCreate",
        url: "Grupo/Create",
        defaults: new { controller = "Grupo", action = "Create" });

        context.MapRoute(
        name: "SocioNegocioList",
        url: "SocioNegocio/List",
        defaults: new { controller = "SocioNegocio", action = "List" });
       
        context.MapRoute(
        name: "SocioNegocioCreate",
        url: "SocioNegocio/Create",
        defaults: new { controller = "SocioNegocio", action = "Create" });

       context.MapRoute(
       name: "SocioAdd",
       url: "SocioNegocio/ListAdd",
       defaults: new { controller = "SocioNegocio", action = "ListAdd" });
       
       context.MapRoute(
       name: "SocioAddCliente",
       url: "SocioNegocio/ListAddCliente",
       defaults: new { controller = "SocioNegocio", action = "ListAddCliente" });

        }

    
        
    }
}