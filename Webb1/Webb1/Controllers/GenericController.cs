using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;

namespace Webb1.Controllers
{
    public class GenericController: SurfaceController
    {
        private const string Partial_Views_Path = "~/Views/Partials/Generic/";

        public ActionResult RenderGenericM()
        {
            return PartialView(string.Format("{0}GenericM.cshtml", Partial_Views_Path));
        }
    }
}