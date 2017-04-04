
namespace SqlDependency.Spike
{
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Configuration;

    public class MvcApplication : System.Web.HttpApplication
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["ScheduleConnection"].ConnectionString;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            System.Data.SqlClient.SqlDependency.Start(connString);
        }

        protected void Application_End()
        {
            System.Data.SqlClient.SqlDependency.Stop(connString);
        }
    }
}
