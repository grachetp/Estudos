using System;

namespace HelloWorld.PastaTeste
{
    class NovaClasseTeste
    {
        public void escreverNaTela()
        {
            int x = 1;

            switch (x)
            {
                case 1:
                    Console.WriteLine("O valor de x é 1");
                    break;
                case 2:
                    Console.WriteLine("O valor de x é 2");
                    break;
                case 3:
                    Console.WriteLine("O valor de x é 3");
                    break;
                default:
                    Console.WriteLine("O valor não está entre 1 e 3");
                    break;
            }
        }
    }
}
