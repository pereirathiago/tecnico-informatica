def somaLista(a):
    c = s = 0
    while c < len(a):
        s += a[c]
        c += 1
    return s


def mostrarLista(a):
    c = 0
    while c < len(a):
        print(a[c])
        c += 1

def invertLista(a):
    # a.reverse()
    c = 0
    while c<len(a)/2:
        swap = a[c]
        a[c]=a[-c-1]
        a[-c-1] = swap
        c+=1
    return a

a = []
temp = ''
while temp != 0:
    temp = int(input('Digite um numero da lista(0 para parar): '))
    if temp != 0:
        a.append(temp)
print(f'A soma é {somaLista(a)}')
print('='*30)
mostrarLista(a)
print(invertLista(a))
