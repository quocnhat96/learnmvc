using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LearnMVC.WebView.App_Start;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;

namespace LearnMVC.WebView.API
{
    [RoutePrefix("api/account")]
    public class AccountController : ApiController
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public AccountController()
        {
        }

        public AccountController(ApplicationUserManager userManger, ApplicationSignInManager signInManager)
        {
            UserManager = userManger;
            SignInManager = signInManager;  
        }

        public ApplicationSignInManager SignInManager
        {
            get{
                return _signInManager ?? HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<HttpResponseMessage> Login(HttpRequestMessage request, string userName, string password, bool rememberMe)
        {
            if (!ModelState.IsValid)
                return request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);

            var result = await SignInManager.PasswordSignInAsync(userName, password, rememberMe, shouldLockout: true);
            return request.CreateResponse(HttpStatusCode.OK, result);

        }
    }
}
