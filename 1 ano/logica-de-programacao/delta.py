# Recebendo valores
a=int(input("Digite o valor a "))
b=int(input("Digite o valor b "))
c=int(input("Digite o valor c "))

# Calculando o Delta
delta=b**2-4*a*c
# Verificando resultados
if delta>0:
    print(f"O delta da operação é {delta} e com esse delta você terá duas raizes diferentes")
elif delta<0:
    print(f"O delta da operação é {delta} e com esse delta você não terá raizes")
else:
    print(f"O delta da operação é {delta} e com esse delta vocêterá raizes iguais")
