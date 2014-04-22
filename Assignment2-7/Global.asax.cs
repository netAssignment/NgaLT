using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Assignment2_7
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        int count = 0;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["CurrentUsers"] = count;
           
        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started
            Application.Lock();
            Application["CurrentUsers"] = (int)Application["CurrentUsers"] + 1;
            Session["a"] = Application["CurrentUsers"];
            Application.UnLock();

        }

        void Session_End(object sender, EventArgs e)
        {
           // Code that runs when a session ends. // Note: The Session_End event is raised only when the sessionstate mode // is set to InProc in the Web.config file. If session mode is set to StateServer // or SQLServer, the event is not raised. // Code that runs when a new session is started
            Application.Lock();
            if ((int)Application["CurrentUsers"] > 0)
            {
                Application["CurrentUsers"] = (int)Application["CurrentUsers"] - 1;
                     
            }
            Application.UnLock();
            
        }



    }
}