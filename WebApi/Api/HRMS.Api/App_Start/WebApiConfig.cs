using HRMS.Api.Filters;
using HRMS.Api.Unity;
using HRMS.Business;
using HRMS.IBusiness;
using HRMS.IRepository;
using HRMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;
using Unity.Lifetime;
using System.Web.Http;
using System.Web.Http.Cors;

namespace HRMS.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            //Enablecors
            config.EnableCors(new EnableCorsAttribute("*", headers: "*",methods:"*"));
            var container = GetUnityContainer();
            config.DependencyResolver = new UnityResolver(container);

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Filters.Add(new HandleExceptionAttribute());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static UnityContainer GetUnityContainer()
        {
            var container = new UnityContainer();
           

            container.RegisterType<IEshoppingBusiness, EshoppingBusiness>();
            container.RegisterType<IEshoppingRepository, EshoppingRepository>();

            return container;
        }
    }
}
