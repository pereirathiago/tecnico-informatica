import math

# Recebendo valores
a = float(input("Digite o valor a "))
b = float(input("Digite o valor b "))
c = float(input("Digite o valor c "))

# Calculando o Delta
delta=b**2-4*a*c
if delta<0:
    print(f"O delta da operação é {delta} e com esse delta você não terá raizes")
else:
#  Calculando as raizes
    x1=(-b+math.sqrt(delta))/(2*a) 
    x2=(-b-math.sqrt(delta))/(2*a)

    # Verificando resultados
    if delta==0:
        print(f"O delta da operação é {delta} e com esse delta você terá duas raizes iguais a {x1}")
    else:
        print(f"O delta da operação é {delta} e com esse delta você terá como x¹ = {x1} e x² = {x2}") 
