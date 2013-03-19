using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

public interface IMasterView
{
    HtmlGenericControl HomeMenuItem
    {
        get;
    }

    HtmlGenericControl LoginMenuItem
    {
        get;
    }

    HtmlGenericControl RegisterMenuItem
    {
        get;
    }

    HtmlGenericControl UsersListMenuItem
    {
        get;
    }

    HtmlGenericControl LogoutMenuItem
    {
        get;
    }

    HtmlGenericControl GreetingsItem
    {
        get;
    }
}