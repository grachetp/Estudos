// using _05_ByteBank;

using System;

namespace ByteBank {
  public class ContaCorrente {

    public static double TaxaOperacao { get; private set; }

    public int ContadorSaquesNaoPermitidos { get; private set; }
    public int ContadorTranferenciasNaoPermitidas { get; private set; }

    public Cliente Titular { get; set; }

    public static int TotalDeContasCriadas { get; private set; }

    public int Agencia { get; }
    public int Numero { get; }
    //Debaixo do panos está assim :
    // public readonly int _numero; Deixando somente como leitura
    
    private double _saldo = 100;

    public double Saldo {
      get {
        return _saldo;
      }
      set {
        if (value < 0) {
          return;
        }
        _saldo = value;
      }
    }

    public ContaCorrente(int agencia, int numero) {
      if (agencia <= 0) {
        throw new ArgumentException("O argumento agencia deve ser maior do que zero", nameof(agencia));
      }
      if(numero <= 0) {
        throw new ArgumentException("O argumento numero deve ser maior do que zero", nameof(numero));
      }

      Agencia = agencia;
      Numero = numero;
      TotalDeContasCriadas++;
      TaxaOperacao = 30 / TotalDeContasCriadas;
    }

    public void Sacar(double valor) {
      if(valor < 0) {
        throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
      }
      if (_saldo < valor) {
        ContadorSaquesNaoPermitidos++;
        throw new SaldoInsuficienteException(Saldo, valor); 
      }

      _saldo -= valor;
      
    }

    public void Depositar(double valor) {
      _saldo += valor;
    }

    public void Transferir(double valor, ContaCorrente contaDestino) {
      if (valor < 0) {
        throw new ArgumentException("Valor inválido para tranferência.", nameof(valor));
      }

      try {
        Sacar(valor);
      }
      catch (SaldoInsuficienteException ex) {
        ContadorTranferenciasNaoPermitidas++;
        throw new OperacaoFinanceiraException("Operação não realizada", ex);
      }

      contaDestino.Depositar(valor);
    }
  }
}
