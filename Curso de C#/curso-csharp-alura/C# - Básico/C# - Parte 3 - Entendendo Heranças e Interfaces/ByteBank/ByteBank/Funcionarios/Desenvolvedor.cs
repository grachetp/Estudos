﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios {
  public class Desenvolvedor : Funcionario{
    public Desenvolvedor(string cpf) : base(3000, cpf) {
      Console.WriteLine("Criando um desenvolvedor!");
    }

    public override void AumentarSalario() {
      Salario *= 1.15;
    }

    public override double GetBonificacao() {
      return Salario * 0.1;
    }
  }
}
