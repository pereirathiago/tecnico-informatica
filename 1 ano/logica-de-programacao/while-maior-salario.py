c=maior=menor=0

while(c<15):
    salario=int(input("Digite o valor do salário "))
    c+=1
    if(c == 1):
        maior=menor=salario
    else:
        if(salario>maior):
            maior=salario
        if(salario<menor):
            menor=salario
print(f"O maior salário é {maior} e o menor é {menor}")
