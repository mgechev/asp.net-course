using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage, IMasterView
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MasterPagePresenter presenter = new MasterPagePresenter(this);
    }


    #region IMasterView Members

    System.Web.UI.HtmlControls.HtmlGenericControl IMasterView.HomeMenuItem
    {
        get { return HomeMenuItem; }
    }

    System.Web.UI.HtmlControls.HtmlGenericControl IMasterView.LoginMenuItem
    {
        get { return LoginMenuItem; }
    }

    System.Web.UI.HtmlControls.HtmlGenericControl IMasterView.RegisterMenuItem
    {
        get { return RegisterMenuItem; }
    }

    System.Web.UI.HtmlControls.HtmlGenericControl IMasterView.UsersListMenuItem
    {
        get { return UsersListMenuItem; }
    }

    System.Web.UI.HtmlControls.HtmlGenericControl IMasterView.LogoutMenuItem
    {
        get { return LogoutMenuItem; }
    }

    System.Web.UI.HtmlControls.HtmlGenericControl IMasterView.GreetingsItem
    {
        get { return GreetingsItem; }
    }

    #endregion
}
