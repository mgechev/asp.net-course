using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class MasterPagePresenter
{
    private IMasterView view;

	public MasterPagePresenter(IMasterView view)
	{
        this.view = view;
        this.HandleMenuItemVisibility();
	}

    public void HandleMenuItemVisibility()
    {
        if (Authentication.IsAuthenticated())
        {
            this.view.RegisterMenuItem.Visible = false;
            this.view.LoginMenuItem.Visible = false;
            this.view.LogoutMenuItem.Visible = true;
            this.view.UsersListMenuItem.Visible = true;
            this.view.GreetingsItem.InnerText = "Здравей " + HttpContext.Current.Session["user"];
            this.view.GreetingsItem.Visible = true;
        }
        else
        {
            this.view.RegisterMenuItem.Visible = true;
            this.view.LoginMenuItem.Visible = true;
            this.view.UsersListMenuItem.Visible = false;
            this.view.LogoutMenuItem.Visible = false;
            this.view.GreetingsItem.InnerText = "";
            this.view.GreetingsItem.Visible = false;
        }
    }
}