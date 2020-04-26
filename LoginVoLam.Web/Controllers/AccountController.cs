using LoginVoLam.Web.Models;
using System.Linq;
using System.Web.Mvc;
using LoginVoLam.EntityFramework.Models;
using LoginVoLam.Web.ClassHelper;
using LoginVoLam.Web.Common;

namespace LoginVoLam.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            var model = new LoginViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            using (var db = new LoginVoLamDbContext())
            {
                var passwordHash = Encryptor.MD5Hash(model.Password);
                var user = db.Account_Info.FirstOrDefault(x => x.cAccName == model.UserName && x.cPassWord == passwordHash);
                if (user == null)
                {
                    model.ErrorMessage = "UserName hoặc Password không đúng!";
                    return View("Index", model);
                }
                var userSession = new UserLogin
                {
                    UserIp = user.nUserIP,
                    UserName = model.UserName
                };
                Session.Add(ConstantKey.USER_SESSION, userSession);
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            var model = new LoginViewModel();
            return View("Index", model);
        }
    }
}