using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios {
  public class GerenteDeConta : FuncionarioAutenticavel {

    public GerenteDeConta(string cpf) : base(4000, cpf) {
      Console.WriteLine("Criando Gerente de Conta");
    }

    public override double GetBonificacao() {
      return Salario * 0.25;
    }

    public override void AumentarSalario() {
      Salario *= 0.05;
    }
  }
}
