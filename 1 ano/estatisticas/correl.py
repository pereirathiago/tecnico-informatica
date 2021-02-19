import math
x = input('Digite os valores de X, separados por ; ')
x=x.split(";")
y = input('Digite os valores de Y, separados por ; ')
y=y.split(";")
c=0
xy=x2=y2=[]
zipped = zip(x,y)
sx = sy = sxy = sx2 = sy2 = 0 
if(len(x) and len(y) == 10):
    while(c<10):
        x[c]=float(x[c])
        y[c]=float(y[c])
        c+=1
sx = sum(x)
sy = sum(y)
for x,y in zipped:
    sxy += x*y
    sx2 += x**2
    sy2 += y**2
r = (10*sxy-sx*sy)/math.sqrt((10*sx2-(sx)**2)*(10*sy2-(sy)**2))
print(f'O correl desses valores é {r}')
