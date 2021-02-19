# importando pacotes
import statistics

# valores iniciais
media = 0

#  começando o while
v1 = float(input("Diite um valor "))
v2 = float(input("Diite um valor "))
v3 = float(input("Diite um valor "))
v4 = float(input("Diite um valor "))
v5 = float(input("Diite um valor "))

media = (v1+v2+v3+v4+v5)/5
sd = statistics.stdev([v1+v2+v3+v4+v5])

# mostrando resultados
print(f"A média dos valores é {media} e o desvio padrão é {sd}")
