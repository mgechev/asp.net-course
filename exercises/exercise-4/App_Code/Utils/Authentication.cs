using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class Authentication
{
    public static bool IsAuthenticated()
    {
        if (HttpContext.Current.Session["logged"] == null ||
            !HttpContext.Current.Session["logged"].Equals(true))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static void Authenticate(string user)
    {
        HttpContext.Current.Session.Add("logged", true);
        HttpContext.Current.Session.Add("user", user);
    }

    public static void Logout()
    {
        HttpContext.Current.Session.RemoveAll();
    }
}