using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade3
{
    public class Televisao
    {
        public int Volume { get; set; }
        public int NumeroCanal { get; set; }

        public void MudarCanalCima()
        {
            NumeroCanal++;
        }

        public void MudarCanalBaixo()
        {
            NumeroCanal--;
        }

        public void AumentarVolume(int qtd)
        {
            Volume++;
        }

        public void DiminuirVolume(int qtd)
        {
            Volume--;
        }

        public void TrocarCanal(int canalDesejado)
        {
            NumeroCanal = canalDesejado;
        }

        public void ConsultarInformacoes()
        {
            Console.WriteLine($"Canal: {NumeroCanal}\nVolume: {Volume}");
        }
    }
}
