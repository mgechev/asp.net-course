using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class UsersListPresenter
{
    private IUsersListView view;

	public UsersListPresenter(IUsersListView view)
	{
        this.view = view;
        if (Authentication.IsAuthenticated())
        {
            this.view.Users = RepositoryFactory.GetFactory().GetUsersRepository().QueryRepository(u => u.username != String.Empty);
            this.view.SetGridVisibility(true);
        }
        else
        {
            this.view.SetGridVisibility(false);
            this.view.ErrorMessage = "Тази информация е достъпна само за потребители, които са се логнали в профила си.";
        }
	}
}