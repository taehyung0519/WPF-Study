class Program
{
    static void Main(String[] args)
    {
        new Program().test();
    }

    delegate int Mydelegate(String s);

    int StringToInt(String s)
    {
        return int.Parse(s);
    }

    void test()
    {
        Mydelegate m = new Mydelegate(StringToInt);
        run(m);
    }

    void run(Mydelegate m)
    {
        int i = m("123");
        Console.WriteLine(i);
    }


}