using System;
using NUnit.Framework;
using System.Linq;

namespace dinero
{
    enum TriangleType
    {
        Equilateral,
        Isosceles,
        Scalene    
    }

    class Program
    {

        public static TriangleType GetTriangleType(int a, int b, int c) {

            int[] values = new int[3] {a, b, c};

            switch (values.Distinct().Count()) {
                case 1:
                    return TriangleType.Equilateral;
                case 2:
                    return TriangleType.Isosceles;
                default:
                    return TriangleType.Scalene;
            }
        }

        static void Main(string[] args)
        {
            Start:

            Console.WriteLine("Please enter the triangles three sides, seperated by \"Enter\"");

            var sideA = Console.ReadLine();
            var sideB = Console.ReadLine();
            var sideC = Console.ReadLine();
            
            if (!int.TryParse(sideA, out var a ) || !int.TryParse(sideB, out var b) || !int.TryParse(sideC, out var c)) {
                Console.WriteLine("One of the entered values are not an interger, please try again");
                goto Start;
            }

            TriangleType result = GetTriangleType(a, b, c);

            Console.WriteLine("You triangle is " + result);

            goto Start;
        }

    }

    [TestFixture]
    public class Tester {
        
        [Test]
        public void TestGetTriangleType() {
            Assert.AreEqual(TriangleType.Equilateral, Program.GetTriangleType(1, 1, 1), "GetTriangleType(1, 1, 1) did not return equilaterel");
            
            Assert.AreEqual(TriangleType.Isosceles, Program.GetTriangleType(1, 1, 2), "GetTriangleType(1, 1, 2) did not return Isoseles");
            
            Assert.AreEqual(TriangleType.Isosceles, Program.GetTriangleType(1, 2, 2), "GetTriangleType(1, 2, 2) did not return Isoseles");
            
            Assert.AreEqual(TriangleType.Isosceles, Program.GetTriangleType(2, 2, 1), "GetTriangleType(2, 2, 1) did not return Isoseles");

            Assert.AreEqual(TriangleType.Scalene, Program.GetTriangleType(1, 2, 3), "GetTriangleType(1, 2, 3) did not return Scalene");
        }
    }
}
