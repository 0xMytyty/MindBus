using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Web.Mvc;
using Webb1.Models;

namespace Webb1.Controllers
{
    public class LoginController : SurfaceController
    {
        [HttpGet]
        public ActionResult Login(string hello)
        {
            ViewBag.hello = hello;
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if(Membership.ValidateUser(model.Username, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Username, true);
                    var rootPrivate = Umbraco.ContentAtRoot().First(x => x.Name == "Private");
                    return Redirect(rootPrivate.Url);
                }
                else
                {
                    return Redirect("http://localhost:52587/Login");
                }
            }
            return PartialView(model);
        }
    }
}