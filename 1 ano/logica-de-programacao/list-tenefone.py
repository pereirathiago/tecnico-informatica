v = [0,0,0,0,0,0,0,0,0,0]
t = [0,0,0,0,0,0,0,0,0,0]
c = 0

while(c < 10):
    v[c] = str(input('Digite um nome: '))
    t[c] = int(input('Agora seu número de telefone: '))
    c+=1
n = str(input(f'Digite o nome da pessoa que deseja saber o número de telefone: '))
r = v.index(n)
print(f'O número de telefone de {n} é {t[r]}')
