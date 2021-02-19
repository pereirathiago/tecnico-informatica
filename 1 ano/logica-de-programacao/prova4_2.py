def areaTriangulo(b,h):
    a = 0
    a = (b * h) / 2
    return a

b = float(input('Digite a base do triangulo: '))
h = float(input('Digite a altura do triangulo: '))
          
print(f'A area de triangulo {b} x {h} é {areaTriangulo(b,h)}')
