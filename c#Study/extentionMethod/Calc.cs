using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionMethod
{
    public sealed class Calc    // sealed class: 파생클래스 생성 불가
    {
        public int Add(int x, int y) { return x + y;}
        public int Sub(int x, int y) { return x - y;}
    }
}
