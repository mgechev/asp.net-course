using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Security.Cryptography;
using Model;

public class RegisterPresenter
{

    private IRegisterView view;
    private IRepository<User> repository;

	public RegisterPresenter(IRegisterView view)
	{
        this.repository = RepositoryFactory.GetFactory().GetUsersRepository();
        this.view = view;
        this.view.RegisterButton.ServerClick += RegisterUser;
	}

    private void RegisterUser(object sender, EventArgs e)
    {
        var valid = HandleRegistration();

        if (valid.Key)
        {
            this.repository.Add(new User
            {
                username = view.Username,
                password = Hashing.GetMD5Hash(view.Password, MD5.Create()),
                email = view.Email
            });
            view.SetResponse("Успешна регистрация", false);
            view.SetFormVisibility(false);
        }
        else
        {
            view.SetResponse(valid.Value, true);
        }
    }

    public KeyValuePair<bool, string> HandleRegistration()
    {
        if (!this.ValidateUser(view.Username))
        {
            return new KeyValuePair<bool, string>(false, "Невалидно потребителско име");
        }
        if (!this.ValidatePassword(view.Password))
        {
            return new KeyValuePair<bool, string>(false, "Невалидна парола");
        }
        if (view.Password != view.Password2)
        {
            return new KeyValuePair<bool, string>(false, "Паролите не съвпадат");
        }
        if (!ValidateEmail(view.Email))
        {
            return new KeyValuePair<bool, string>(false, "Невалиден e-mail");
        }
        if (UserExists(view.Username))
        {
            return new KeyValuePair<bool, string>(false, "Потребителското име е вече заето");
        }
        if (EmailExists(view.Email))
        {
            return new KeyValuePair<bool, string>(false, "Въведеният e-mail е вече зает");
        }
        return new KeyValuePair<bool, string>(true, String.Empty);
    }

    protected bool UserExists(string username)
    {
        return this.repository.QueryRepository(u => u.username == username).Count() > 0;
    }

    protected bool EmailExists(string email)
    {
        return this.repository.QueryRepository(u => u.email == email).Count() > 0;
    }

    protected bool ValidateUser(string username)
    {
        return Regex.IsMatch(username, @"^[a-zA-Z0-9_]{3,15}$");
    }

    protected bool ValidatePassword(string password)
    {
        return Regex.IsMatch(password, @"^[a-zA-Z0-9_\-]{3,15}$");
    }

    protected bool ValidateEmail(string email)
    {
        try
        {
            MailAddress address = new MailAddress(view.Email);
        }
        catch (Exception e)
        {
            return false;
        }
        return true;
    }

}