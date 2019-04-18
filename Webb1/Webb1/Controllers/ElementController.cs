using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;

namespace Webb1.Controllers
{
    public class ElementController: SurfaceController
    {
        private const string Partial_Views_Path = "~/Views/Partials/Element/";

        public ActionResult RenderElementM()
        {
            return PartialView(string.Format("{0}ElementM.cshtml", Partial_Views_Path));
        }
    }
}