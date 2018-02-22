using Autofac;
using Controllers;
using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace DottyBot
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //var builder = new ContainerBuilder();
            //builder.RegisterType<ActivityLogger>().AsImplementedInterfaces().InstancePerDependency();
            //builder.Update(Conversation.Container);
        }

    }
}
