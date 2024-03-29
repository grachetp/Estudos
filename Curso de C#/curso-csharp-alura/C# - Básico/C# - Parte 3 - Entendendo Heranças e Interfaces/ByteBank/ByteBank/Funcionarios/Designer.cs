﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios {
  public class Designer : Funcionario {
    public Designer(string cpf) : base(3000, cpf) {
      Console.WriteLine("Criando um Designer!");
    }

    public override double GetBonificacao() {
      return Salario * 0.17;
    }

    public override void AumentarSalario() {
      Salario *= 1.11;
    }
  }
}
