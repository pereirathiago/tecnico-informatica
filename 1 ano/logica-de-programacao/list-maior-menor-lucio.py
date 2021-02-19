n = [0,0,0,0,0,0,0,0,0,0]
c=0
menor=0
maior=0
while(c<10):
    n[c]=float(input("Digite um número: "))
    if(n[c]<n[menor]):
        menor=c
    if(n[c]>n[maior]):
        maior=c
    c+=1
print(f"O maior está na posição {maior} e é {n[maior]}")
print(f"O menor está na posição {menor} e é {n[menor]}")
