using System;

namespace dinero
{
    class Program
    {
        static void Main(string[] args)
        {

            const string EQUILATERAL = "equilateral";
            const string ISOSELES = "isoseles";
            const string SCALENE = "scalene";

            string result;

            Start:

            Console.WriteLine("Please enter the triangles three sides, seperated by \"Enter\"");
            var sideA = Console.ReadLine();
            var sideB = Console.ReadLine();
            var sideC = Console.ReadLine();
            Console.WriteLine("Thank you");

            if (sideA == sideB && sideB == sideC) {
                result = EQUILATERAL;
            } else if (sideA == sideB || sideA == sideC || sideB == sideC) {
                result = ISOSELES;
            } else {
                result = SCALENE;
            }
            Console.WriteLine("You triangle is " + result);

            goto Start;
        }
    }
}
