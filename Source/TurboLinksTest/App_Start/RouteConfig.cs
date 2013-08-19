﻿namespace TurboLinksTest
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new
                    {
                        controller = "Projects",
                        action = "Index",
                        id = UrlParameter.Optional
                    });
        }
    }
}