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
}
