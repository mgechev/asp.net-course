using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UsersList : System.Web.UI.Page, IUsersListView
{
    private IEnumerable<User> data;

    protected void Page_Load(object sender, EventArgs e)
    {
        UsersListPresenter presenter = new UsersListPresenter(this);
    }

    #region IUsersListView Members

    public IEnumerable<User> Users
    {
        set 
        {
            this.UsersListGrid.DataSource = value;
            this.UsersListGrid.DataBind();
        }
    }

    #endregion
}