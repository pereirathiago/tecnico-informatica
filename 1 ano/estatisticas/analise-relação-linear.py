# Pedindo o valor de X
x = float(input('Digite sua carga de horas de trabalhos semanais: '))

# calculando stress
y = 0.164 * x + 0.41

# verificando stress
if (y < 1):
    print(f'Seu nivel de stress é {y:.2f}, portanto é muito baixo.')
elif (y >= 1 and y < 5):
    print(f'Seu nivel de stress é {y:.2f}, portanto é baixo.')
elif (y >= 5 and y <= 7):
    print(f'Seu nivel de stress é {y:.2f}, portanto é moderado')
elif (y > 7 and y <= 10):
    print(f'Seu nivel de stress é {y:.2f}, portanto é alto')
else:
    print(f'Seu nivel de stress é {y:.2f}, portanto VAI PESCAR!!!')
