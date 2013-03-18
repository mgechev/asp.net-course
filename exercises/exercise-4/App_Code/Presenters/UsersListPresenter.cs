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
        this.view.Users = RepositoryFactory.GetFactory().GetUsersRepository().QueryRepository(u => u.username != String.Empty);
	}
}