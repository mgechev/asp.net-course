using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;

public class LoginPresenter
{
    private ILoginView view;
    private IRepository<User> repository;
    private HttpResponse response;

	public LoginPresenter(ILoginView view, HttpResponse response)
	{
        this.repository = RepositoryFactory.GetFactory().GetUsersRepository();
        this.response = response;
        this.view = view;
        this.view.LoginButton.ServerClick += LoginButton_Click;
        if (Authentication.IsAuthenticated())
        {
            this.view.SetFormVisibility(false);
            this.view.SetResponse("Вече сте в акаунта си", false);
        }
	}

    private void LoginButton_Click(object sender, EventArgs e)
    {

        if (IsLoginSuccessfull())
        {
            Authentication.Authenticate(this.view.Username);
            this.response.Redirect("./");
        }
        else
        {
            view.SetResponse("Грешен потребител или парола!", true);
        }
    }

    public bool IsLoginSuccessfull()
    {
        string user = view.Username,
               pass = Hashing.GetMD5Hash(view.Password, System.Security.Cryptography.MD5.Create());

        if (repository.QueryRepository(u => u.password == pass && u.username == user).Count() > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}