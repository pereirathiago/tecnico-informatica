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
while temp != '0':
    temp = input('Digite um numero da lista(0 para parar): ')
    if temp != '0':
        a.append(temp)
print(f'''A lista invertida é:
      {invertLista(a)}''')
