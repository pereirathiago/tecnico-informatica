res = 0

def elevado(x, y):
    res = x ** y
    print(res)
    
def potencia(n,x):
    p=n
    c=1
    while(c<x):
        p=p*n
        c+=1
    return p

x = int(input('Digite o valor da base: '))
y = int(input('Digite o valor do expoente: '))

elevado(x, y)
