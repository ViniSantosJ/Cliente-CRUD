using System;
using System.Data.Entity;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using TDSA.Models;

namespace TDSA
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            //// Código que é executado na inicialização do aplicativo
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Inicializa o "cliente database".
            Database.SetInitializer(new ClienteDatabaseInitializer());

            using (var context = new ClienteContext())
            {
                context.Database.Initialize(force: true);
            }
        }
    }
}