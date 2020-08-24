using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;
            Console.WriteLine($"{a}/{b} is {div} with a remainder of {mod}");

            Console.WriteLine("Give the radius of a cirlce in cm, please");

            double Radius;
            var rad = double.TryParse(Console.ReadLine(), out Radius);
            var areaOfCirc = CalculateAreaCirc(Radius);

            Console.WriteLine($"The radius of this cirlce is {Radius} and has an area of {areaOfCirc}cm^2");

            Console.WriteLine("Ok now lets convert celcius to fahrenheit. Give me a value of Celcius to convert");

            Double Celcius;
            var c = double.TryParse(Console.ReadLine(), out Celcius);
            var celciusToFar = CelciusToFar(Celcius);
            Console.WriteLine($"Ok so the value of celcius you gave was {Celcius} and that changes to {celciusToFar} in terms of fahrenheit.");





        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        public static int Mult(int x, int y)
        {
            return x * y;
        }
        public static int Div(int x, int y)
        {
            return x / y;
        }
        public static double CalculateAreaCirc(double rad)
        {
            return Math.PI * (rad * rad);
        }
        public static double CelciusToFar(double c)
        {
            return ((c / 5) * 9) + 32;
        }
       
    }
    }

