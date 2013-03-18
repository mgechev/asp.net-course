using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

public interface IRegisterView
{
    void SetFormVisibility(bool visible);
    
    string Username
    {
        get;
    }
    
    string Password
    {
        get;
    }
    
    string Password2
    {
        get;
    }

    string Email
    {
        get;
    }

    HtmlButton RegisterButton
    {
        get;
    }

    void SetResponse(string text, bool isError);
}