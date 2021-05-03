def equacao(a,b,c):
    delta = b**2-4*a*c
    if delta < 0:
        return('Não possui raizes')
    else:
        x1= (-(b) + delta**0.5)/(2*a)
        x2= (-(b) - delta**0.5)/2*a
        return x1, x2
print(equacao(1,2,3))
print(equacao(1,3,2))
