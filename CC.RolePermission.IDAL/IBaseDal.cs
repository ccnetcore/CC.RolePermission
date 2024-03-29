﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CC.RolePermission.IDAL
{
    public interface IBaseDal<T> where T : class, new()
    {
        IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLambda);
        IQueryable<T> GetPageEntities<S>(int PageSize, int PageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderByLambda, bool isAsc);
        T Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Delete(int id);
        int DeleteListByLogical(List<int> ids);
    }
}
