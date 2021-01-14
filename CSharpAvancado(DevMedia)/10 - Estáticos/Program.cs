using System;

namespace _10___Estáticos
{
    public static class ConversorStatic
    {
        public static double CelsiusToFah(double temp)
        {
            return (temp * 9 / 5) + 32;
        }

        public static double FahToCelsius(double temp)
        {
            return (temp - 32) * 5 / 9;
        }
    }

    public class ConversorInstancia
    {
        public static double temperatura;
        public double CelsiusToFah(double temp)
        {
            return (temp * 9 / 5) + 32;
        }

        public double FahToCelsius(double temp)
        {
            return (temp - 32) * 5 / 9;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var temperatura = 35.0;
            temperatura = ConversorStatic.CelsiusToFah(temperatura);
            Console.WriteLine(temperatura);
            ConversorInstancia.temperatura = 500;
        }
    }
}
