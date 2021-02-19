# Valores iniciais
m = 0.5
g = 10
h = e = 0 

# recebendo H
h = float(input("Digite a altura: "))

# 1° quicada
e = m*g*h-(0.2*m*g*h)
# 2° Quicada
e = e - (0.2*e)
# 3° Quicada
e = e - (0.2*e)
# calculando novo h
h = e/(m*10)

# exibindo resultado
print(f'A altura é de {h} após as 3 quicadas')
