f = fp = fap = frp = frap = fr = far = frr = frar = fh = fah = frh = frah = 0

print('''    Uma pesquisa para descobrir quantos alunos preferem:
    Presencial é aquele no colégio.
    Remoto é em casa.
    Híbrido é a mistura dos dois anteriores.
    -----------------------------
''')

print('''    1 - Presencial
    2 - Remoto
    3 - Híbrido
    4 - Sair
    -----------------------------
''')

while (f != 4):
    f = int(input('    Escolha sua opção: '))
    if(f == 1):
        fp += 1
    elif (f == 2):
        fr += 1
    elif(f == 3):
        fh += 1
c = 0
while (c < 3):
    fap = fp
    far = fap + fr
    fah = far + fh
    c+=1
c = 0
while (c < 3):
    frp = (fp/fah)*100
    frr = (fr/fah)*100
    frh = (fh/fah)*100
    c+=1
c = 0
while (c < 3):
    frap = frp
    frar = frap + frr
    frah = frar + frh
    c+=1
print('    -------------------------------')
print(f'    A coluna F, {fp} pessoas preferem Pressencial.')
print(f'    A coluna F, {fr} pessoas preferem Remoto.')
print(f'    A coluna F, {fh} pessoas preferem Híbrido.')
print('    -------------------------------')
print(f'    A coluna Fa -> Presencial, {fap}.')
print(f'    A coluna Fa -> Remoto, {far} .')
print(f'    A coluna Fa -> Híbrido, {fah} .')
print('    -------------------------------')
print(f'    A coluna Fr% -> Presencial, {frp:.2f}.')
print(f'    A coluna Fr% -> Remoto, {frr:.2f} .')
print(f'    A coluna Fr% -> Híbrido, {frh:.2f} .')
print('    -------------------------------')
print(f'    A coluna Fra% -> Presencial, {frap:.2f}.')
print(f'    A coluna Fra% -> Remoto, {frar:.2f} .')
print(f'    A coluna Fra% -> Híbrido, {frah:.2f} .')
