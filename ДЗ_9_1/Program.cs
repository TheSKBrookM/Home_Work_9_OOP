namespace ДЗ_9_1
{
    internal class Program
    {
        static double Add(double n1, double n2) => n1 + n2;

        static double Sub(double n1, double n2) => n1 - n2;

        static double Mul(double n1, double n2) => n1 * n2;

        static double Div(double n1, double n2) => n1 / n2;

        delegate double CalcDeleagate(double n1, double n2);

        static void Main(string[] args)
        {
            double n1, n2;
            string math;

            CalcDeleagate calc = null;

            while (true)
            {
                Console.Write("Перша цифра: ");
                n1 = Int32.Parse(Console.ReadLine());

                Console.Write("Математична дiя (+,-,*,/): ");
                math = Console.ReadLine();

                Console.Write("Друга цифра: ");
                n2 = Int32.Parse(Console.ReadLine());


                switch (math)
                {
                    case "+":
                        calc = Add;
                        break;
                    case "-":
                        calc = Sub;
                        break;
                    case "*":
                        calc = Mul;
                        break;
                    case "/":
                        if (n2 == 0)
                        {
                            Console.WriteLine("На 0 ділити не можна!");
                            break;
                        }
                        calc = Div;
                        break;
                    default:
                        Console.WriteLine("Не вірно вказаний символ!");
                        return;
                }
                if (calc != null)
                    Console.WriteLine(calc(n1, n2));
            }

            Console.ReadKey();
        }
    }
}