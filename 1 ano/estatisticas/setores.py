import statistics

a, b, c = [int(x)
           for x in input('Digite 3 valores separados por ; ').split(";")]
i = [a, b, c]

media = (a + b + c)/3
print(f'A média é  {media}')

maximo = max(i)
minimo = min(i)

print(f'O valor máximo é {maximo}')
print(f'O valor minimo é {minimo}')

delta = b ** 2 - 4 * a * c

if (delta >= 0):
    print(f'O delta é {delta}')
    x1 = (- b + delta ** 0.5) / 2 * a
    x2 = (- b - delta ** 0.5) / 2 * a
    print(f'x¹ = {x1}')
    print(f'x² = {x2}')
else:
    print(f'Não possue raizes igual pois o delta é {delta}')

moda = statistics.mode(i)

if (a != b and a != c and b != c):
    print("Não possui moda!")
else:
    print(f"Moda = {moda}")
