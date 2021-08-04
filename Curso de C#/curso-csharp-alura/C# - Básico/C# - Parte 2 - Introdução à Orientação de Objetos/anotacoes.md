# CSharp Básico - Parte 2

### Orientação à objetos

### Declaração de objeto

```csharp
public class ContaCorrente {
	public string titular;
	public int agencia;
	public int numero;
	public double saldo;
}
```

### Criando e Instanciando objetos

```csharp
ContaCorrente contaDaGabriela = new ContaCorrente();
contadagabriela.agencia = 345;
```

### Tipos de Referência e Tipos de Valor

```csharp
var idade = 10;
var idade2 = 10;
idade == idade2 //True

Cliente gabi = new Conta();
Cliente pedro = new Conta();
gabi == pedro //False
```

### Funções

```csharp
public tipoDaFuncao nomeDaFuncao(tipo valor){
	this.atriburo = //codigo
}

public bool Sacar(double valor){
	if(this.saldo >= 100){
		this.saldo -= valor;
	}
}
```

### Método com vários argumentos

```csharp
public void(double valor, ContaCorrente contaDestino, *args) {
	//métodos que recebe vários argumentos..
}
```

### Namespaces

Namespaces são como o nome das classes e que são importadas utilizando o Using

### Referências Nulas

São referências nulas quando o objeto pai é criado, porém não é instanciado o objeto filho. Caso não seja atribuído nenhum valor(objeto), ele criará normalmente, porém nulo. 

```csharp
public class Pessoa {
	public string nome;
	public string cpf;
	public int idade;
	public Endereco endereco = new Endereco();
}
```

### Getters e Setters

```csharp
public tipo Var{get; set;}

//Quando há alguma lógica em alguma variável

private string _nome;

public string Nome{
	get{
		return _nome;
	}
	set{
		_nome = value;
	}
}
```

### Construtores

Construtores são executados na inicialização de um objeto.

```csharp
using System;
namespace Projeto {
	public class Classe {
		public Classe2 Atributo {get; set;}
		public Atributo2 {get; set;}
		public Atributo3 {get; set;}
		public Atributo4 {get; set;}
	}
	
	//Método Construtor
	public Classe(int atb1, int atb2) {
		Atb1 = atb1;
		Atb2 = atb2;
	}
}
```

### Membros Estáticos

Membros estáticos são métodos que pertencem a classe e não ao objeto.

```csharp
using System;
namespace Projeto {
	public class Classe {
		public Classe2 Atributo {get; set;}
		public Atributo2 {get; set;}
		public Atributo3 {get; set;}
		public Atributo4 {get; set;}
		//Pode usar um private na frente do set, caso seja de necessidade
		// public static int TotalDeAlgumaCoisa {get; private set;}
		public static int TotalDeAlgumaCoisa {get; set;}
	}

	//Método Construtor
	public Classe(int atb1, int atb2) {
		Atb1 = atb1;
		Atb2 = atb2;
		//Criando um contador para contar o total de objetos criandos
		TotalDeAlgumaCoisa++;
	}
}

//Acessando no Program Main

using System;
namespace Projeto {
	class Program {
		static void Main(string[] args) {
			//Só chama a classe, não é possivel chamar com objeto
			Console.WriteLine(Classe.TotalDeAlgumaCoisa);
		}
	}
}

```