c=maior=menor=soma=quantidade=media=0

while(c<20):
    peso=float(input("Digite o peso de algum animal: "))
    c+=1
    soma+=peso
    quantidade+=1
    if(c == 1):
        menor=maior=peso
    else:
        if(peso>maior):
            maior=peso
        if(peso<menor):
            menor=peso
media = soma / quantidade
print(f"O maior peso é {maior}, o menor peso é {menor} e a média é {media}")
