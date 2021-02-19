produtos = []
media = 0
c = s = 0

while(c < 20):
    produtos.append(float(input('Digite o preço de um produto: ')))
    s += produtos[c]
    c += 1

c = cm = 0
media = s/20

while (c < 20):
    if(produtos[c]<media):
        cm+=1
    c+=1
print(f"A média é {media} e a quantidade de preços a baixo da média é {cm}")
