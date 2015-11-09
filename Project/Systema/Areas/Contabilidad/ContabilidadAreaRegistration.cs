using System.Web.Mvc;

namespace Systema.Areas.Contabilidad
{
    public class ContabilidadAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Contabilidad";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Contabilidad_default",
                "Contabilidad/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
            name: "CuentaList",
            url: "Cuenta/List",
            defaults: new { controller = "Cuenta", action = "List" });
            context.MapRoute(
            name: "CuentaCreate",
            url: "Cuenta/Create",
            defaults: new { controller = "Cuenta", action = "Create" });

        }
    }
}