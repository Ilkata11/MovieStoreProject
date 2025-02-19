namespace ConsoleApp
{
    internal class Program
    {
        public delegate void MyDelegate(string msg);

        static void Main(string[] args)
        {
            MyDelegate del = MethodA;
            MyDelegate del2 = (string msg) => Console.WriteLine(msg);
            MyDelegate del3 = new MyDelegate(MethodA);

            del("HI");

            // Action<int, int, int> action;
            Predicate<string, string> isUpper = IsUpperCase;
            bool result = isUpper("Hello World");
            if (true) return;

            Func<int, int, int> add = Sum;
            int result = add(10, 10);
            Console.WriteLine(result);
        }

        static void MethodA(string message)
        {
            Console.WriteLine(message);
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }

    static bool IsUpperCase(string str)
    {
        if (string.IsNullOrEmpty()str) return false;

        return str.Equals(str.ToUpper());
    }
