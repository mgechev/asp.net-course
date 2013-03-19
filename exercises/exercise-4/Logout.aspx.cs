using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Logout : System.Web.UI.Page, ILogoutView
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var presenter = new LogoutPresenter(this);
    }

    #region ILogoutView Members

    public string ResponseText
    {
        set
        { 
            this.ResponseLabel.InnerText = value;
        }
    }

    #endregion
}