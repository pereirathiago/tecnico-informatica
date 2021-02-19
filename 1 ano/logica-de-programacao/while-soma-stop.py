c=0
s=0
n=1

while(n!=0):
    n=float(input("Digite algum número (ou 0 para parar)"))
    s+=n
    if (n!=0):
        c+=1
print(f"A soma dentre os {c} números é {s}")