# CSharp Básico - Parte 3

### Herança

```csharp
//Objeto 1 herda atributos do objeto 2

public class objeto1 : objeto2 {

}
```

### Sobrescrever Métodos

```csharp
//Classe Base

public class Funcionario {
	private Nome {get; set;}
	private Salario {get; set;}

	//Virtual: método padrão, que da permissão para sobrescrever
	public virtual void Bonificacao(){
		return Salario * 0.1;
	}
}

//Classe Derivada
public class Gerente : Funcionario {
	//Override: palavra reservada pra sobrescrever método virtual
	public override void Bonificacao(){
		return Salario * 0.5;
	}
}
```

### Sobrescrever Atributos

```csharp
//Classe Base
public class Base
{
    public virtual int Numero{get; set;}
}

//Classe Derivada
public class Derivada : Base
{
    public override int Numero{
			get{
			   //bloco de código
			}
			set{
				//bloco de código
			}
		}
}

```

### Base

```csharp
// usar métodos da classe anterior
public class Diretor : Funcionario {

    public override double GetBonificacao() {
      return Salario + base.GetBonificacao();
    }
  }
```

### Classes Abstratas

```csharp

```