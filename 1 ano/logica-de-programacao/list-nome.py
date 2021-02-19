v  = [0,0,0,0,0,0,0,0,0,0]
c = 0

while(c<10):
    v[c] = str(input("Digite um nome: "))
    c+=1

c = 0
while(c != -1):
    c = int(input("Digite um número entre 0 e 9: "))
    if (c<10 and c>-1):
        print(v[c])
print(f"Aqui estão todos os nomes {v}")
