#recebendo os valores
v1=float(input("Digite o primeiro valor "))
v2=float(input("Digite o segundo valor "))

#Verificando igualdade
if v1>v2:
    print(f'O primeiro valor {v1} é maior que {v2}')
elif v1==v2:
    print(f'O primeiro valor {v1} é igual ao segundo {v2}')
else:
    print(f'O segundo valor {v2} é maior que {v1}')