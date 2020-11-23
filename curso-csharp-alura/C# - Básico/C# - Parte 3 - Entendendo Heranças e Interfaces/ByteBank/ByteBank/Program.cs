using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank {
  class Program {
    static void Main(string[] args) {

      UsarSistema();

      Console.ReadLine();
    }

    public static void UsarSistema() {
      SistemaInterno sistemaInterno = new SistemaInterno();

      Diretor roberta = new Diretor("654.654.654-650");
      roberta.Nome = "Roberta Santos";
      roberta.Senha = "123";

      GerenteDeConta camila = new GerenteDeConta("123.123.123-33");
      camila.Nome = "Camila Silva";
      camila.Senha = "abc";

      ParceiroComercial parceiro = new ParceiroComercial();
      parceiro.Senha = "123456";

      sistemaInterno.Logar(parceiro, "123456");
      sistemaInterno.Logar(roberta, "123");
      sistemaInterno.Logar(camila, "abc");


    }

    public static void CalcularBonificacao() {
      GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

      Desenvolvedor guilherme = new Desenvolvedor("654.988.888-94");
      guilherme.Nome = "Guilherme Rocha";

      Designer pedro = new Designer("888.555.333-21");
      pedro.Nome = "Pedro Grachet";

      Diretor roberta = new Diretor("654.654.654-650");
      roberta.Nome = "Roberta Santos";

      Auxiliar igor = new Auxiliar("987.987.987-99");
      igor.Nome = "Igor Mattos";

      GerenteDeConta camila = new GerenteDeConta("123.123.123-33");
      camila.Nome = "Camila Silva";

      gerenciadorBonificacao.Registrar(guilherme);
      gerenciadorBonificacao.Registrar(pedro);
      gerenciadorBonificacao.Registrar(roberta);
      gerenciadorBonificacao.Registrar(igor);
      gerenciadorBonificacao.Registrar(camila);

      Console.WriteLine("Total de bonificações do mês R$" +
        gerenciadorBonificacao.GetTotalBonificacao());
    }
  }
}
