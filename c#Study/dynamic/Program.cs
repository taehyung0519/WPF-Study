using System.Dynamic;

namespace dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ExpandoTest();
        }
        static void ExpandoTest()
        {
            dynamic person = new ExpandoObject();   //ExpandoObject는 다른 어셈블리로 전달 가능.
            person.Name = "Kim";
            person.Age = 10;

            person.DisplayData = (Action)(() =>
            {
                Console.WriteLine($"{person.Name}: {person.Age}");
             });

            person.AgeChanged = null;   // 이벤트 정의

            person.ChangeAge = (Action<int>)((age) =>
            {
                person.Age = age;
                if (person.AgeChanged != null)
                {
                    person.AgeChanged(new Program(), EventArgs.Empty);
                }
            });

            new Class1().Run(person);
        }
    }
    class Class1
    {
        public void Run(dynamic o)
        {
            Console.WriteLine(o.Name);
            Console.WriteLine(o.Age);
        }
    }
}
