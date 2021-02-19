maior = menor = mediaTurma = c = menor6 = soma = 0
while(c<10):
    c+=1
    nota = float(input(f"Digite a nota do {c} aluno: "))
    soma+= nota
    if(c == 1):
        menor=maior=nota
    else:
        if(nota>maior):
            maior = nota
        if(nota<menor):
            nota = menor
    if(nota<60):
                menor6+=1
mediaTurma = (soma)/10
print(f"A menor nota é {menor}, a maior nota é {maior}, {menor6} estão abaixo de 6,0")
print(f"A média da turma é {mediaTurma}")
