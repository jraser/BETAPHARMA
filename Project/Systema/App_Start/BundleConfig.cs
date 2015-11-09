using System.Web;
using System.Web.Optimization;

namespace Systema
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            

            bundles.Add(new ScriptBundle("~/Content/assets/jsangular")
         .Include(
                 "~/Content/assets/global/plugins/angularjs/angular.min.js",
                 "~/Content/assets/global/plugins/angularjs/angular-sanitize.min.js",
                 "~/Content/assets/global/plugins/angularjs/angular-touch.min.js",
                 "~/Content/assets/global/plugins/angularjs/angular-cookies.min.js",
                 "~/Content/assets/global/plugins/angularjs/plugins/angular-ui-router.min.js",
                 "~/Content/assets/global/plugins/angularjs/plugins/ocLazyLoad.min.js",
                 "~/Content/assets/global/plugins/angularjs/plugins/ui-bootstrap-tpls.min.js",
                 "~/Content/assets/global/plugins/angularjs/plugins/ui-utils/ui-utils.min.js"
                 ));
            bundles.Add(new ScriptBundle("~/bundles/Systema")
            .IncludeDirectory("~/app/SocioNegocio/", "*.js")
             .IncludeDirectory("~/app/Contabilidad/", "*.js")
              .IncludeDirectory("~/app/Venta/", "*.js")
            .Include("~/app/app.js",
                     "~/app/config.js",
                   "~/app/postinit.js")
            );
        }
    }
}
