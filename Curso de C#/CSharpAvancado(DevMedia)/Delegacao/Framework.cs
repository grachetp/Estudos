using System;
using System.Collections.Generic;
using System.Text;

namespace Delegacao
{

    public class Boleto
    {
        public void Pagar(double valor)
        {
            Console.WriteLine("Foi pago " + valor);
        }
    }

    public class Pedido
    {
        private Boleto _boleto = new Boleto();
        public void Fechar(double valor)
        {
            this._boleto.Pagar(valor);
        }
    }
}
