#Recebendo os valores

v1=float(input("Digite o valor de um dos lados "))
v2=float(input("Digite o valor de outrpo lados "))
v3=float(input("Digite o valor do ultimo lado lados "))

#comparando os valores e mostraando na tela se é ou não um triangulo
if v3+v2 > v1 and v3+v1 > v2 and v2+v1 > v1:
    print(f"Pode ser formado um triangulo com os valores {v1}, {v2}, {v3}.")
else:
    print(f"Com os valores {v1}, {v2}, {v3} medidas não pode ser feito um triangulo")
