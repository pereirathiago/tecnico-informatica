import math

media1 = (2+4+5)/3
media2 = (3+3+2)/3
media3 = (5+4+8)/3

g1 = math.sqrt(((2-media1)**2+(4-media1)**2+(5-media1)**2)/3)
g2 = math.sqrt(((3-media2)**2+(3-media2)**2+(2-media2)**2)/3)
g3 = math.sqrt(((5-media3)**2+(4-media3)**2+(8-media3)**2)/3)

print(f'O grupo um [2,4,5], o desvio padrão é {g1:.2f}')
print(f'O grupo dois [3,3,2], o desvio padrão é {g2:.2f}')
print(f'O grupo três [5,4,8], o desvio padrão é {g3:.2f}')
