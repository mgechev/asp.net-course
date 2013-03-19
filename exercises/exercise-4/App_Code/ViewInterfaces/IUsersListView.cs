using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public interface IUsersListView
{
    IEnumerable<User> Users
    {
        set;
    }

    void SetGridVisibility(bool visible);

    string ErrorMessage
    {
        set;
    }

}