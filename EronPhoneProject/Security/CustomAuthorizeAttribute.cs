using EronPhoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EronPhoneProject.Security
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        private DataContext db = new DataContext();
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (string.IsNullOrEmpty(SessionPersister.Username))
            {
                filterContext.Result = new RedirectToRouteResult(new
                    RouteValueDictionary(new
                    { // Eğer HttpContext.Current.Session["email"] boş yada null ise Login sayfasına yönlendir.
                        controller = "Users",
                        action = "Login"
                    }));
            }
            else
            {
                // USER LOGGED IN BUT NOT AUTHORISED
                User user = new User();
                user = db.Users.Find(SessionPersister.Username);
                CustomPrincipal mp = new CustomPrincipal(user);
                if (!mp.IsInRole(Roles))
                    filterContext.Result = new RedirectToRouteResult(new
                        RouteValueDictionary(new
                        {
                            controller = "Users",
                            action = "Index"
                        }));
            }
        }
    }
}