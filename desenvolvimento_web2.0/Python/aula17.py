def calcula_soma_numeros(num1, num2, **numeros):
    import pdb ; pdb.set_trace()
    return sum(numeros.values())

soma = calcula_soma_numeros(num1=5, num2=10, num4=10, num10=22)
print("O resultado da soma é: {}".format(soma))
