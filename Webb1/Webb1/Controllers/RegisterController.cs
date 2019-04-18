using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Web.Mvc;
using Webb1.Models;

namespace Webb1.Controllers
{
    public class RegisterController : SurfaceController
    {
        [HttpGet]
        public ActionResult RenderRegister(string hello)
        {
            ViewBag.hello = hello;
            return PartialView();
        }

        [HttpPost]

        public ActionResult RenderRegister(RegisterModel model)
        {
            var memberService = Services.MemberService;

            if (ModelState.IsValid)
            {
                var newuser = Membership.CreateUser(model.Username, model.Password, model.Email);
                Services.MemberService.AssignRole(newuser.UserName, "Registrados");
                return Redirect("http://localhost:52587/Login");

            }
            else
            {
                return PartialView("LLogin");
            }

        }

    }
}