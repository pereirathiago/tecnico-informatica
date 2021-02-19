sx = sy =sxy = sx2 =sy2 = xy = c = 0
vx = [0,0,0]
vy = [0,0,0]

while(c<3):
    vx[c] = int(input("Digite um valor de x: "))
    c+=1
for x in vx:
    sx += x

c=0
while(c<3):
    vy[c] = int(input("Digite um valor de y: "))
    c+=1
for y in vy:
    sy += y

xy = x*y