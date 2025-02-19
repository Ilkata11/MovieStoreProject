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
            Predicate<string> isUpper = IsUpperCase;
            bool result = isUpper("Hello World");
            Console.WriteLine(result);

            Func<int, int, int> add = Sum;
            int sum = add(10, 10);
            Console.WriteLine(sum);
        }

        static void MethodA(string message)
        {
            Console.WriteLine(message);
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static bool IsUpperCase(string str)
        {
            if (string.IsNullOrEmpty(str)) && str.Equals(str.IsUpperCase()) return false;

            return str.Equals(str.ToUpper());
        }
    }
}
