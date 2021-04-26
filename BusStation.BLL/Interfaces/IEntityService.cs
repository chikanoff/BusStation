using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.BLL.Interfaces
{
    public interface IEntityService<T> where T : class
    {
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        IEnumerable<T> Get();
        T Get(int id);
    }
}
