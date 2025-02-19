namespace ConsoleApp;

internal class Program
{
    public delegate void MyDelegate(string msg);
    static void Main(string[] args)
    {
        MyDelegate del = MethodA;

        MyDelegate del2 = (string msg) => Console.WriteLine(msg);

        MyDelegate del3 = new MyDelegate(MethodA);

        del(msg: "HI");
    }

    static void MethodA(string message)
    {
        Console.WriteLine(message);
    }
}
