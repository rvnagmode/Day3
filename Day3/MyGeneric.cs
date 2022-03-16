using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class MyGeneric<T>
    {
        private T Data;
        public MyGeneric(T Data)
        {
            this.Data = Data;
        }
        public T GetData()
        {
            return Data;
        }
    }
}
