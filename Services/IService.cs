using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IService<T> where T : class
    {
        ICollection<T> Get();
        T GetById(int Id);
        T Save(T t);
        T Update(T t);
        bool Delete(int Id);
        bool Exist(int Id);
    }
}
