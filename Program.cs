using System;
using NUnit.Framework;

namespace dinero
{
    [Flags]
    enum TriangleType : int
    {
        equilateral,
        isoseles,
        scalene    
    }

    class Program
    {

        public static int getTriangleType(int a, int b, int c) {

            if (a == b && b == c) {
                return (int) TriangleType.equilateral;
            } 
            
            if (a == b || a == c || b == c) {
                return (int) TriangleType.isoseles;
            } 

            return (int) TriangleType.scalene;
        }

        static void Main(string[] args)
        {
            Start:

            Console.WriteLine("Please enter the triangles three sides, seperated by \"Enter\"");

            var sideA = Console.ReadLine();
            var sideB = Console.ReadLine();
            var sideC = Console.ReadLine();
            
            if (!int.TryParse(sideA, out var a ) || !int.TryParse(sideB, out var b) || !int.TryParse(sideC, out var c)) {
                Console.WriteLine("One of the entered values are not an interger");
                goto Start;
            }

            int result = getTriangleType(a, b, c);


            Console.WriteLine("You triangle is " + result);

            goto Start;

        }
    }
}
