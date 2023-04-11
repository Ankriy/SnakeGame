using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SnakeGame.Domain.Repository
{
    public interface IRepository<T>
    {
        public T Get(int id);
        public T Create(T item);
    }
}
