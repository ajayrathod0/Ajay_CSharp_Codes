using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Student<T1, T2>
    {
        public T1 Id { get; set; }
        public T2 Name { get; set; }

        public T2 datail()
        {
            dynamic result = $"{Id} : {Name}";
            return result;
        }
    }
}
