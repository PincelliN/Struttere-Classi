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
            Console.WriteLine($" Prima {a.myInteger} {a.myString}");
            MyStruct b = new MyStruct { myString = "Luigi", myInteger = 30 };
            Console.WriteLine($" Prima {b.myInteger} {b.myString}");

            ClassMethod(a, b, 10, "Bello");

            Console.WriteLine($" Dopo {a.myInteger} {a.myString}");
            // i valori al di fuori del metodo  nell struct tornano i valori di partenza           
            Console.WriteLine($" Dopo {b.myInteger} {b.myString}");
        }
        static void ClassMethod(MyClass a, MyStruct b, int x, string y)
        {
            a.myInteger = x;
            a.myString = y;
            b.myInteger = x;
            b.myString = y;
        }
    }
}