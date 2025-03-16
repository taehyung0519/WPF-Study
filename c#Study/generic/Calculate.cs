using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    internal class Calculate<T>
    {
        public T Add(T a, T b)
        {
            dynamic da = a;     // dynamic 변수는 런타임시 동작 (컴파일시 동작 X)
            dynamic db = b;
            T result = da + db;
            return result;
        }

        public T Sub(T a, T b)
        {
            dynamic da = a;     // dynamic 변수는 런타임시 동작 (컴파일시 동작 X)
            dynamic db = b;
            T result = da - db;
            return result;
        }

        public T Multi(T a, T b)
        {
            dynamic da = a;     // dynamic 변수는 런타임시 동작 (컴파일시 동작 X)
            dynamic db = b;
            T result = da * db;
            return result;
        }

        public T Divide(T a, T b)
        {
            dynamic da = a;     // dynamic 변수는 런타임시 동작 (컴파일시 동작 X)
            dynamic db = b;
            T result = da / db;
            return result;
        }
    }
}
