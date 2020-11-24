using System;

namespace HelloWorld.PastaTeste
{
    public static class NovaClasseTeste
    {
        public static void escreverNaTela()
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Domingo");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Segunda");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Terça Feira");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Quarta Feira");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Quinta Feira");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Sexta Feira");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    break;
            }
        }
    }
}
