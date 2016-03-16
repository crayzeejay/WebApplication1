using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "routeOne",
                url: "routesDemo/One",
                defaults: new { controller = "RoutesDemo", action = "one" }
            );

            routes.MapRoute(
                name: "routeTwo",
                url: "routesDemo/Two/{donuts}",
                defaults: new { controller = "RoutesDemo", action = "two", donuts = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "routeThree",
                url: "routesDemo/Three",
                defaults: new { controller = "RoutesDemo", action = "three" }
            );

            routes.MapRoute(
                name: "Login",
                url: "Account/Login",
                defaults: new { controller = "Account", action = "Login" }
            );

            routes.MapRoute(
                name: "routeFour",
                url: "routesDemo/Four",
                defaults: new { controller = "RoutesDemo", action = "four" }
            );

            routes.MapRoute(
                name: "Register",
                url: "Account/Register",
                defaults: new { controller = "Account", action = "Register" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
