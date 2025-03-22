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
            //myDelegate myDelegate1 = new myDelegate(new Program().intToString);
            //Calc(myDelegate1, 5);
            //Calc(intToString, 5); // 선언문 생략하고 메서드를 바로 Delegate 매개변수에 대입 가능.
            
            //// 무명메서드 선언
            //anonyDelegate anonyDelegate = delegate (int i)      
            //{
            //    return "무명메서드 " + i.ToString();
            //};
            //Console.WriteLine(anonyDelegate(3));

            myDelegate myDelegate2 = (x) => { return "람다 메서드: " + x.ToString(); };
            myDelegate2 += x => "람다 메서드2: " + x.ToString();

            //Console.WriteLine(myDelegate2(2));
            foreach(var del in myDelegate2.GetInvocationList())
            {
                Console.WriteLine(((myDelegate)del)(2));
            }

            Func<int, int> sqr = x => x * x;    // Func 델리케이트 : .Net 자체 제공 델리게이트

            Console.WriteLine("2의 제곱은? : "+sqr(2));

            getData(p => p.StartsWith("A"), fruits);      // Func 델리게이트를 메서드 파라미터로 전달

            var list = fruits.Where(p =>  p.StartsWith("A"));   // LINQ

            Console.WriteLine("LINQ사용: ");
            foreach(var data in  list)
                Console.WriteLine(data);

        }


        List<string> fruits = new(){ "Apple","Banana","Orange","Kiwi"};

        void getData(Func<string,bool> conditionFunc, List<string> datas)
        {
            foreach(var data in datas)
            {
                if(conditionFunc(data))
                    Console.WriteLine(data);
            }
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
