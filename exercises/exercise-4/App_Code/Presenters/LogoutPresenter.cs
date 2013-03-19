using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class LogoutPresenter
{

    private ILogoutView view;

	public LogoutPresenter(ILogoutView view)
	{
        this.view = view;
        this.LogoutUser();
        this.view.ResponseText = "Излезнахте от профила си успешно!";
	}

    public void LogoutUser()
    {
        Authentication.Logout();
    }
}