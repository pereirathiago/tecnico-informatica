v  = [0,0,0,0,0,0,0,0,0,0]
s = c = 0

while(c<10):
    v[c] = float(input("Digite um valor: "))
    s+=v[c]
    c+=1
media = s/10
print(f'media={media}')
c=0
cm=0
while(c<10):
    if(v[c]<media):
        cm+=1
    c+=1
# print(v)
print(f"Número de valores menores que {media} é {cm}")
