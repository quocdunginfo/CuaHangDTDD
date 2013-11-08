using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CuaHangDTDD
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            /* begin Web Controller*/
            routes.MapRoute(
                "FrontPage", // Route name
                "Front", // URL with parameters
                new { controller = "Front", action = "Index2" } // Parameter defaults
            );

            routes.MapRoute(
                "FrontPageIndex", // Route name
                "Front/Index", // URL with parameters
                new { controller = "Front", action = "Index2" } // Parameter defaults
            );
            routes.MapRoute(
                "FrontPageIndexWithSlash", // Route name
                "Front/Index/", // URL with parameters
                new { controller = "Front", action = "Index2" } // Parameter defaults
            );
            /* end Web Controller*/

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "FrontHome", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            // Use LocalDB for Entity Framework by default
            Database.DefaultConnectionFactory = new SqlConnectionFactory(@"Data Source=(localdb)\v11.0; Integrated Security=True; MultipleActiveResultSets=True");

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}