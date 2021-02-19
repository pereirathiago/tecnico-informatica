v = [0,0,0,0,0,0,0,0,0,0]
c = maior = menor= pmenor = pmaior = 0

while (c < 10): 
    v[c] = float(input("Digite um valor: "))
    if(c == 0):
        maior = menor = v[c]
        pmenor = pmaior = c
    else:
        if(v[c]>maior):
            maior = v[c]
            pmaior = c
        if(v[c]<menor):
            menor = v[c]
            pmenor =c
    c += 1
print(f'O menor número é {menor} e está na psoição {pmenor}')
print(f'O maior número é {maior} e está na psoição {pmaior}')
