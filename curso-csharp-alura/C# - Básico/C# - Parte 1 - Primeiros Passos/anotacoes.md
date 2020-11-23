# CSharp Básico - Parte 1

MSIL - Microsoft Intermediate Language

## Comandos

```csharp
Console.WriteLine(); //Saída de Dados
Console.ReadLine(); //Entrada de Dados
"\n" //Quebra de linha
```

**Compilar na mão(Line Command):**

```powershell
c:\Windows\Microsoft.NET\Framework\v4.x.x\css.exe Programa.txt Programa.exe
```

### Estrutura Básica

```csharp
using System;

namespace _projeto_ {
  class Program {
    static void Main(string[] args){
      Console.WrinteLine("Hello Wolrd");
    }
  }
}
```

## Variáveis

```csharp
int var = 0; //32 bits
char var = 'a'; //8 bits
string var = "Pão com ovo";
float var = 10.556f;
double var = 10.65546544;
bool var = true;
short var = 15; //16 bits
long var = 15351351531; //64 bits
```

### Conversão por Casting

```csharp
double salario = 1550.77;
int salarioEmInteiro = (int)1550.77;
```

### Caracteres e Textos

```csharp
char letra = 'a';
letra = char(65); //Type Casting com ASCII - A
string titulo = "Alura Cursos de Tecnologia";
string titulo = "Alura Cursos de Tecnologia" + 2020; //Converte pra texto e concatena
```

### Condicionais

```csharp
if(condicao) {
	//Executa este bloco de código
}else {
	//Executa este bloco de código
}

switch(var){
	case opcao1:
		//bloco de código
		break;
	case opcao2;
		//bloco de código
		break;
	default:
		//bloco de código
}
```

### Operadores Relacionais e Lógicos

```csharp
//Lógicos
&& //e
|| //ou
! //não
& // e(testa as duas expressões)
| // ou(testa as duas expressões)

//Relacionais
> //Maior
< //Menor
>= //Maior Igual
<= //Menor Igual
!= //Diferente
++ //Incremento
-- //Decremento
a++ //pós-incremento
++a //pré-incremento
a-- //pós-decremento
--a //pré-decremento
```

### Laços de Repetições

```csharp
while(condicao){
	//bloco de código
}

for(int i=0; i<10; i++){
	//bloco de codigo
}

```