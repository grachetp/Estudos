namespace _03_ByteBank {
  class Program {
    static void Main(string[] args) {
      ContaCorrente contaDaGabriela = new ContaCorrente();
      contaDaGabriela.titular = "Gabriela da Silva";
      contaDaGabriela.agencia = 863;
      contaDaGabriela.numero = 863452;

      ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
      contaDaGabrielaCosta.titular = "Gabriela da Costa";
      contaDaGabrielaCosta.agencia = 863;
      contaDaGabrielaCosta.numero = 863452;

      if(contaDaGabriela.saldo >= 100) {
        contaDaGabriela.saldo -= 100;
      }

    }
  }
}
