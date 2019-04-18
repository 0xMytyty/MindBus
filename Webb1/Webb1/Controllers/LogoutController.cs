using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Web.Mvc;
using Webb1.Models;

namespace CodeShare.Controllers
{
    public class LogoutController : SurfaceController
    {
        

        public ActionResult RenderLogout()
        {
            return PartialView("Logout", null);
        }

        public ActionResult SubmitLogout()
        {
            TempData.Clear();
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToCurrentUmbracoPage();
        }
    }
}