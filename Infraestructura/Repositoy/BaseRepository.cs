using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositoy
{
    public abstract class BaseRepository<T> : IModel<T>
    {
        public List<T> data;
        protected BaseRepository()
        {
            data = new List<T>();
        }
        public void ADD(T t)
        {
            data.Add(t);
        }

        public void Delete(T t)
        {
            data.Remove(t);
        }

        public List<T> Read()
        {
            return data;

        }
    }
}
