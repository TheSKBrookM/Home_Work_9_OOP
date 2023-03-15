using System.Net;

namespace ДЗ_9_3
{
    internal class Program
    {

        delegate double Delegate1(int n1, int n2, int n3);

        static void Main(string[] args)
        {

            int n1 = 10, n2 = 20, n3 = 30;

            Delegate1 d;

            d = (n1, n2, n3) => (n1 + n2 + n3) / 3;

            Console.WriteLine(d(n1, n2, n3));


            Console.ReadLine();
        }
    }
}