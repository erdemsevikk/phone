using EronPhoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace EronPhoneProject.Security
{
    public class CustomPrincipal : IPrincipal
    {
      
            private User User;

            public IIdentity Identity { get; set; }

            public CustomPrincipal(User user)
            {
                User = user;
                Identity = new GenericIdentity(user.Username);
            }


            public bool IsInRole(string role)
            {
                //var roles = role.Split(new char[] { ',' });
                //foreach (var r in roles)
                //{
                //    if ()
                //        return true;
                //}
                return true;
            }
        
    }
}