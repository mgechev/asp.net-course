using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

public interface ILoginView
{
    string Username
    {
        get;
    }

    string Password
    {
        get;
    }

    void SetResponse(string text, bool isError);

    HtmlButton LoginButton
    {
        get;
    }

    void SetFormVisibility(bool visible);
}