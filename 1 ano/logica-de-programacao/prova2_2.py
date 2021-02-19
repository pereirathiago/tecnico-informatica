# Recebendo valores
a= float(input("Digite o peso do primeiro animal "))
b= float(input("Digite o peso do segundo animal "))

# COmparando valores
if a>b:
    print(f"O primeiro animal(peso={a}) é mais pesado que o segundo animal")
elif a<b:
    print(f"O segundo animal(peso={b}) é mais pesado que o primeiro animal")
else:
    print(f"Os dois animais tem o mesmo peso de {a}")
