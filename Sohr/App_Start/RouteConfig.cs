using System.Web.Mvc;
using System.Web.Routing;

namespace Sohr
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Customized route, before default route, generic route, regular expression
            // method 1) This example is not generic, results in tons of routes, 
            // besides, there is magic string "ByReleaseDate"

            //routes.MapRoute(
            //    name: "MoviesByReleaseDate",
            //    url: "movies/released/{year}/{month}",
            //    defaults: new { Controller = "Movies", action = "ByReleaseDate", },
            //    constraints: new { year = @"\d{4}", month = @"\d{2}" }
            //    );


            // method 2), use route attributes, attributes routes
            routes.MapMvcAttributeRoutes();
            // Apply attribute routes in controller


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



        }
    }
}
