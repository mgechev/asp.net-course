using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class LoginPresenter
{
    private ILoginView view;
    private IRepository<User> repository;

	public LoginPresenter(ILoginView view)
	{
        this.repository = RepositoryFactory.GetFactory().GetUsersRepository();
        this.view = view;
        this.view.LoginButton.ServerClick += LoginButton_Click;
	}

    private void LoginButton_Click(object sender, EventArgs e)
    {

        if (IsLoginSuccessfull())
        {
            view.SetResponse("Успешно влезнахте в акаунта си!", false);
            view.SetFormVisibility(false);
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