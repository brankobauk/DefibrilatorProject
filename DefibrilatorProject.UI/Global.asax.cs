﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DefibrilatorProject.BusinessLogic.Workers;
using DefibrilatorProject.Worker;
using Quartz;
using Quartz.Impl;

namespace DefibrilatorProject.UI
{

    public class MvcApplication : HttpApplication
    {
        private readonly InitWorker _initWorker = new InitWorker();
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("sl-SI");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("sl-SI");
            _initWorker.StartWorker();
            
        }
    }
}