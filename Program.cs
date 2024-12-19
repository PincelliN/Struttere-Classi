namespace Strutture
{
    public class MyClass
    {
        public string? myString;
        public int myInteger;

    }
    public struct MyStruct
    {
        public string myString;
        public int myInteger;
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass { myString = "Mario", myInteger = 20 };
            Console.WriteLine(a);
            MyStruct b = new MyStruct { myString = "Luigi", myInteger = 30 };
            Console.WriteLine(b);
            ClassMethod(a, b, 10, "Bello");

        }
        static void ClassMethod(MyClass a, MyStruct b, int x, string y)
        {

            a.myInteger = x;
            Console.WriteLine(a);
            b.myInteger = x;
            Console.WriteLine(b);
            a.myString = y;
            Console.WriteLine(a);
            b.myString = y;
            Console.WriteLine(b);


        }
    }
}