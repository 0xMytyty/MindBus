using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Web.Mvc;
using Webb1.Models;
using System;

namespace Webb1.Controllers
{
    [Authorize]
    public class ProfileController : RenderMvcController
    {
        [HttpGet]
        public ActionResult Editname()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Editname(EditNameModel model)
        {
            if (model.Username != model.CUsername)
            {
                ModelState.AddModelError("", "Username is not the same");
            }

            else if (ModelState.IsValid)
            {
                var user = Services.MemberService.GetByUsername(User.Identity.GetUserName());
                user.Username = model.Username;
                Services.MemberService.Save(user);
                TempData.Clear();
                Session.Clear();
                FormsAuthentication.SignOut();
                return Redirect("http://localhost:52587/login/");
            }

            return View();
        }

        [HttpGet]
        public ActionResult EditPass()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditPass(EditPassModel model)
        {
            if (User.Identity.IsAuthenticated && ModelState.IsValid)
            {
                var user = Membership.GetUser();
                user.ChangePassword(model.Password, model.CNPassword);
                if (model.NPassword != model.CNPassword)
                {
                    ModelState.AddModelError("changeusernameInvalid", "As confirmacao nao esta correta.");
                }
                if (model.Password == model.NPassword || model.Password == model.CNPassword)
                {
                    ModelState.AddModelError("changeusernameInvalid", "A nova password e igual a antigua.");
                }
                if (model.Password != model.NPassword && model.CNPassword == model.NPassword)
                {
                    
                    Membership.UpdateUser(user);
                    TempData.Clear();
                    Session.Clear();
                    FormsAuthentication.SignOut();
                    return Redirect("http://localhost:52587/login/");
                }



            }
            
            return View();
        }




    }
}