using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionMethod
{
    /// <summary>
    /// 확장 메서드는 static 클래스에 정의 되어야 한다.
    /// 확장 메서드는 static 메서드여야 한다.
    /// </summary>
    public static class MyExtension        
    {
        // 구조체 확장메서드 
        public static bool IsEven(this int a)       // 첫번째 파라미터 this 필수 : int 타입에 메서드를 추가하겠다
        {
            return a % 2 == 0;
        }
        
        // 클래스 확장 메서드
        public static string AppendDash(this string a, string b)
        {
            return a + "-" + b;
        }

        // 상속 받을 수 없는 클래스에 확장 메서드 추가시
        public static int Modulo(this Calc calc, int a, int b)
        {
            return a % b;
        }

    }
}
