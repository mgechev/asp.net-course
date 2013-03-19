using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

/// <summary>
/// Contains the current data source.
/// This class is used instead of DI in the presenter.
/// This implementation can bring great overhead with large data sets.
/// Probable optimization could be creating repositories per request.
/// </summary>
public class RepositoryFactory
{
    private static RepositoryFactory INSTANCE;
    private Dictionary<string, object> options;

    private RepositoryFactory()
	{
        this.options = new Dictionary<string, object>();
        var data = new List<User>();
        data.Add(new User
        {
            username = "foo",
            password = Hashing.GetMD5Hash("bar", MD5.Create()),
            id = 0,
            email = "foo@bar.com"
        });
        data.Add(new User
        {
            username = "bar",
            password = Hashing.GetMD5Hash("foo", MD5.Create()),
            id = 1,
            email = "bar@foo.com"
        });
        var repo = new DummyRepository<User>(data);
        var repo2 = new MSSQLDataProvider<User>();

        this.options.Add("UsersRepository", repo);
        //       this.options.Add("UsersRepository", repo2);
	}

    public static RepositoryFactory GetFactory()
    {
        if (INSTANCE == null)
        {
            INSTANCE = new RepositoryFactory();
        }
        return INSTANCE;
    }

    public IRepository<User> GetUsersRepository()
    {
        return (IRepository<User>)this.options["UsersRepository"];
    }

}