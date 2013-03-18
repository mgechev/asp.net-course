using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;

public interface IRepository<T> where T: class
{
    [MethodImpl(MethodImplOptions.Synchronized)]
    IEnumerable<T> QueryRepository(Func<T, bool> query);

    [MethodImpl(MethodImplOptions.Synchronized)]
    void Add(T entity);

    [MethodImpl(MethodImplOptions.Synchronized)]
    void Delete(T entity);
}