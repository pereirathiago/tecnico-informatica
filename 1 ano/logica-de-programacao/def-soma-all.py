def somaAll(x,y):
    s = c = 0
    l = [x]
    while x < y:
        s = x + 1
        l.append(s)
        x+=1
    s=0
    while c <len(l):
        s += l[c]
        c+=1
    return s

def somaintervalo(ini,fim):
    c=ini
    s=0
    while(c<=fim):
        s+=c
        c+=1
    return s
print(somaAll(1,3))
