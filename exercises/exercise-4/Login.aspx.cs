using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;

public partial class Login : System.Web.UI.Page, ILoginView
{
    private LoginPresenter presenter;

    protected void Page_Load(object sender, EventArgs e)
    {
        this.presenter = new LoginPresenter(this);
    }

    #region ILoginView Members

    public string Username
    {
        get 
        {
            return UsernameInput.Value;
        }
    }

    public string Password
    {
        get 
        {
            return PasswordInput.Value;
        }
    }

    public void SetResponse(string text, bool isError)
    {
        if (isError)
        {
            this.ResponseLabel.Attributes["class"] = "text-error";
        }
        else
        {
            this.ResponseLabel.Attributes["class"] = "text-success";
        }
        this.ResponseLabel.InnerText = text;
    }

    public void SetFormVisibility(bool visible)
    {
        this.LoginForm.Visible = visible;
    }

    public HtmlButton LoginButton
    {
        get
        {
            return this.LoginBtn;
        }
    }

    #endregion
}