using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page, IRegisterView
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RegisterPresenter presenter = new RegisterPresenter(this);
    }

    #region IRegisterView Members

    public void SetFormVisibility(bool visible)
    {
        this.RegisterForm.Visible = visible;
    }

    public string Username
    {
        get { return UsernameInput.Value; }
    }

    public string Password
    {
        get { return PasswordInput.Value; }
    }

    public string Password2
    {
        get { return Password2Input.Value; }
    }

    public string Email
    {
        get { return EmailInput.Value; }
    }

    System.Web.UI.HtmlControls.HtmlButton IRegisterView.RegisterButton
    {
        get { return RegisterButton; }
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

    #endregion
}