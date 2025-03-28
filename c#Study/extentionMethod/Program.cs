namespace extensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("100은 짝수인가?: " + 100.IsEven());    // 확장메서드의 첫번째 파라미터는 메서드를 호출한 객체 자신(this)
            Console.WriteLine("class 확장메서드: " + "ABC".AppendDash("DEF"));    // 확장메서드의 첫번째 파라미터는 메서드를 호출한 객체 자신(this)
            Calc calc = new Calc();
            Console.WriteLine("Calc class 확장메서드: " + calc.Modulo(10,3));    // 확장메서드의 첫번째 파라미터는 메서드를 호출한 객체 자신(this)

            // interface 확장메서드
            var list = new List<string>() { "Apple", "Banaan", "Orange" };
            var a = list.Where(p => p.StartsWith("A")).ToList();     // Where은 IEnumerable 인터페이스를 확장한 메서드
            Console.WriteLine(a[0]);
        }
    }
}
 