using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EronPhoneProject.Security
{
    public class SessionPersister
    {
        static string IDSessionVar = "ID";
        static string usernameSessionVar = "Username";

        public static int ID
        {
            get
            {
                if (HttpContext.Current == null)
                {
                    return -1; // return "";
                }
                int sessionVar = Convert.ToInt32(HttpContext.Current.Session[IDSessionVar]);
                if (sessionVar != -1)
                    return sessionVar;
                return -1;
            }
            set
            {
                HttpContext.Current.Session[IDSessionVar] = value;
            }

        }

       
  
        public static string Username
        {
            get
            {
                if (HttpContext.Current == null)
                {
                    return string.Empty; // return "";
                }
                var sessionVar = HttpContext.Current.Session[usernameSessionVar];
                if (sessionVar != null)
                    return sessionVar as string;
                return null;
            }
            set
            {
                HttpContext.Current.Session[usernameSessionVar] = value;
            }
        }
    }
}