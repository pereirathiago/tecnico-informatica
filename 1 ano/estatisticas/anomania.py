# recebendo valores
v1 = float(input(f'Digite o primeiro valor: '))
v2 = float(input(f'Digite o segundo valor: '))
v3 = float(input(f'Digite o terceiro valor: '))
v4 = float(input(f'Digite o quarto valor: '))
v5 = float(input(f'Digite o quinto valor: '))

# calculando resultados

media = (v1 + v2 + v3 + v4 + v5)/5
anom1 = v1 - media
anom2 = v2 - media
anom3 = v3 - media
anom4 = v4 - media
anom5 = v5 - media

# mostrando os resultados

print(f"Média: {media}")
print(f"As anomalias para os valores são na ordem: {anom1}, {anom2}, {anom3}, {anom4}, {anom5}")
