using System.Diagnostics;

namespace W_2_L_8_7
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Program Diamands");

            Console.WriteLine("Give me a number more then 1");
            int rzad = int.Parse(Console.ReadLine());

            {
                for (int i = 0; i <= rzad; i++)
                {

                    for (int j = 1; j <= rzad - i; j++)

                        Console.Write(" ");

                    for (int j = 1; j <= 2 * i - 1; j++)

                        Console.Write("*");

                    Console.WriteLine(" ");
                }
                for (int i = rzad -1; i >0; i--)
                {

                    for (int j = 1; j <= rzad - i; j++)

                        Console.Write(" ");

                    for (int j = 1; j <= 2 * i - 1; j++)

                        Console.Write("*");

                    Console.WriteLine(" ");
                }
            }
        }
    }
}
