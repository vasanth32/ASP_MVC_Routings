using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routings
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Enabling attribute routing 
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }          
            );
            routes.MapRoute(
                name: "Student",
                url: "{controller}/{action}/{id}",
                defaults:
                new
                {
                    controller = "Students",
                    action = "GetAllStudents",
                    id = UrlParameter.Optional
                }
            //new { controller = "^H.*", action = "^Details$|^About$" } //Restriction for controller and action
            );
        }
    }
}
