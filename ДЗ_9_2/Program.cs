namespace ДЗ_9_2
{
    internal class Program
    {
        delegate int Delegate1();

        delegate double Delegate2(Delegate1[] a);

        static Random rnd = new Random();

        static int Randomizer()
        {
            return rnd.Next(0, 100);
        }

        static void Main(string[] args)
        {

            Console.Write("Array Length: ");
            int length = Int32.Parse(Console.ReadLine());

            var array = new Delegate1[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Randomizer;
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].Invoke() + " ");
            }   

            Delegate2 delegateArray = (array) =>
                {
                    double avarage = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        avarage += array[i].Invoke();
                    }
                    return avarage / array.Length;
                };

            Console.WriteLine("\n");

            Console.WriteLine(delegateArray);

            Console.ReadKey();
        }
    }
}