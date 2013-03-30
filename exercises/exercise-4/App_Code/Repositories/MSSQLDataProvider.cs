using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Runtime.CompilerServices;
using Model;

/// <summary>
/// This repository contains also some logic of Unit of Work which
/// implementation is not included because of simplicity.
/// </summary>
public sealed class MSSQLDataProvider<T> : IRepository<T> where T : class
{
    private System.Data.Entity.DbSet<T> data;
    private SampleEntities entities;

	public MSSQLDataProvider()
	{
        this.entities = new SampleEntities();
        this.data = entities.Set<T>();        
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
        //this.entities.SaveChanges();
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void Delete(T entity)
    {
        this.data.Remove(entity);
        //this.entities.SaveChanges();
    }

    #endregion
}
