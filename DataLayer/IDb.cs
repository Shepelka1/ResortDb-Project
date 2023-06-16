using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal interface IDb<T,K>
    {
        void Create(T item);
        void Update(T item);
        T Read(K key);
        ICollection<T> ReadAll();
        void Delete(T item);
    }
}
