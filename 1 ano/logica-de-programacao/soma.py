def somaEntre(x, y):
    if(x == y):
        return x
    else:
        return y + somaEntre(x, y-1)

print(somaEntre(3, 9))
