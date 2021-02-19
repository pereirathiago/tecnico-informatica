c=0
maior=0
menor=0
while(c<20):
    c+=1
    altura=float(input(f"Digite a altura do {c}° atleta: "))
    if(altura>1.80):
        maior+=1
    if(altura<1.60):
        menor+=1
print(f"Tem {maior} atletas maiores que 1.80")
print(f"Tem {menor} atletas menores que 1.60")
