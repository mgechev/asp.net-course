using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class UsersList : System.Web.UI.Page, IUsersListView
{

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

    public void SetGridVisibility(bool visible)
    {
        this.UsersListGrid.Visible = visible;
    }

    public string ErrorMessage
    {
        set 
        { 
            this.ErrorMessageLabel.InnerText = value;
        }
    }

    #endregion
}