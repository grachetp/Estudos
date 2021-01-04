using ExampleDecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleDecoratorPattern
{
    public class Pizza : IPizza
    {
        public string BuscarTipoPizza()
        {
            var pizza = "Está é uma pizza normal!";
            return pizza;
        }
    }
}
