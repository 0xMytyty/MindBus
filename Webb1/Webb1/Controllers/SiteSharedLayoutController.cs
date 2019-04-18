using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;

namespace Webb1.Controllers
{
    public class SiteSharedLayoutController: SurfaceController
    {
        private const string Partial_Views_Path = "~/Views/Partials/SharedLayout/";
        public ActionResult RenderHeader()
        {
            return PartialView(string.Format("{0}Header.cshtml",Partial_Views_Path));
        }
        public ActionResult RenderFooter()
        {
            return PartialView(string.Format("{0}Footer.cshtml", Partial_Views_Path));
        }
        public ActionResult RenderHeaderHome()
        {
            return PartialView(string.Format("{0}HeaderHome.cshtml", Partial_Views_Path));
        }
    }
}