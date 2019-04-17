using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core.Composing;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace Webb1.App_Start
{
    public class RegisterCustomRouteComposer : ComponentComposer<RegisterCustomRouteComponent>
    {

    }

    public class RegisterCustomRouteComponent : IComponent
    {
        public void Initialize()
        {
            // Custom route to MyProductController which will use a node with a specific ID as the
            // IPublishedContent for the current rendering page
            RouteTable.Routes.MapUmbracoRoute("ProfileCustomRoute", "profile/{action}/{id}", new
            {
                controller = "Profile",
                action = "Profile",
                id = UrlParameter.Optional
            }, new ProfileRouteHandler(1220));
        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }
    }

    public class ProfileRouteHandler : UmbracoVirtualNodeByIdRouteHandler
    {
        public ProfileRouteHandler(int realNodeId) : base(realNodeId)
        {
        }
    }
}