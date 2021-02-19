def soma(a):
    soma = c = 0
    # soma = sum(a) + 1
    while c<len(a):
        soma+=a[c]
        c+=1
    print(soma)    

a = []
temp = 0
while temp != -1:
    temp = int(input('Digite um numero da lista(-1 para parar): '))
    if temp != "-1":
        a.append(temp)
soma(a)
