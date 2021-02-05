﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint -- Generic kısıtlama
    // : class >>> referans tip olabilir demek.
    //: IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //interfaceler newlenemezler. o yüzden filtreleriz iyice
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
