using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var number = int.Parse("abc");


            int number;
            var result = int.TryParse("abc", out number);
            Console.WriteLine(result);


        }

        static void UsePoints()
        {
            try
            {

                var point = new Point(10, 20);
                point.Move(new Point(30, 40));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            }
            catch (Exception)
            {

            }
        }

        static void UseParams()
        {

            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3));
        }
    }
}
