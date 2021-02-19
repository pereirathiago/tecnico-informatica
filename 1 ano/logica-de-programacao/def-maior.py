maior = 0

def maior(x, y):
    if x != y:
        if x > y:
            maior = x
        else:
            maior = y
        print(maior)
    else:
        print(f'Os dois valores são iguais: {x}')

x = int(input('Digite o primeiro valor: '))
y = int(input('Digite o segundo valor: '))
maior(x, y)