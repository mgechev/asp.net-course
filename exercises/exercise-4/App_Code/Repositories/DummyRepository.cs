using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;

public sealed class DummyRepository<T> : IRepository<T> where T : class
{
    public List<T> data;

    public DummyRepository(List<T> data)
    {
        this.data = data;
    }

    #region IRepository<T> Members

    [MethodImpl(MethodImplOptions.Synchronized)]
    public IEnumerable<T> QueryRepository(Func<T, bool> query)
    {
        return this.data.Where(query);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void Add(T entity)
    {
        this.data.Add(entity);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void Delete(T entity)
    {
        this.data.Remove(entity);
    }

    #endregion
}
