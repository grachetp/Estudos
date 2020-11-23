class ContaBancaria(object):
    def __init__(self):
        self.saldo = 0
        self.conexao = 'http://meusite.com.br:3306'

    def depositar(self, valor):
        if valor > 0:
            self.saldo += valor
            self.consultarSaldo()
            print('Depositar da classe mãe')
        else:
            print('Saldo Negativo! Tente novamente.')
            self.consultarSaldo()

    def sacar(self, valor):
        if valor > self.saldo:
            print('Saldo insuficiente! Tente novamente.')
            self.consultarSaldo()
        else:
            self.saldo -= valor
            self.consultarSaldo()

    def consultarSaldo(self):
        print('O saldo é: {}'.format(self.saldo))

    def __del__(self):
        print('Fechando conexão com o banco de dados em segurança')
        self.conexao = None


class ContaPoupanca(ContaBancaria):

    rentabilidade_total = 1.6

    def _consultaRentabilidade(self):
        return self.rentabilidade_total

    def rentabilidade(self):
        rentabilidade = self._consultaRentabilidade()
        if rentabilidade < 0.5:
            print('Consulte o seu gerente!')
        else:    
            print('A rentabilidade da conta é: {}'.format(rentabilidade))

    def depositar(self, valor):
        self.saldo += valor
        if self.saldo >= 1000:
            self.rentabilidade_total += 0.1
            print('Parabéns sua rentabilidade aumentou para:' )
            self.rentabilidade()

class ContaCorrente(ContaBancaria):
    
    def depositar(self, valor):
        '''
        Documentação da função depositar, insira um valor;
        '''
        if valor < 100:
            raise Exception('O valor mínimo é 100 reais.')
        else:
            super(ContaCorrente, self).depositar(valor)
            

conta_poupanca = ContaPoupanca()
#conta_poupanca.rentabilidade()
#conta_poupanca.depositar(10000)
#conta_poupanca.sacar(50)
conta_corrente = ContaCorrente()
conta_corrente.depositar(100)