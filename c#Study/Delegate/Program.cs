using System;

namespace Delegate
{
    internal class Program
    {

        delegate string myDelegate(int i);
        delegate string anonyDelegate(int i);

        static void Main(string[] args)
        {
            new Program().run();
        }

        void run()
        {
            myDelegate myDelegate1 = new myDelegate(new Program().intToString);
            Calc(myDelegate1, 5);
            Calc(intToString, 5); // 선언문 생략하고 메서드를 바로 Delegate 매개변수에 대입 가능.
            
            // 무명메서드 선언
            anonyDelegate anonyDelegate = delegate (int i)      
            {
                return "무명메서드 " + i.ToString();
            };
            Console.WriteLine(anonyDelegate(3));
        }

        string intToString(int i)
        {
            return "string형식: "+i.ToString();
        }

        void Calc(myDelegate myDelegate, int i)
        {
            Console.WriteLine(myDelegate(i));
        }


    }
}
