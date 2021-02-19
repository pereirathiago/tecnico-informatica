#Recebendo as notas
nota1=float(input("Digite a sua primeira nota(valores com uma casa decimal) "))
nota2=float(input("Digite sua segunda nota "))

#Verificando notas
media=(nota1+nota2)/2
if media>=7.0:
    print(f'Você foi aprovado, parabéns!')
else:
    print('Voce não foi aprovdo, ficará de recuperação')
