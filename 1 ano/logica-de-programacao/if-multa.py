velocidade=float(input("Digite a velocidade do automóvel "))
if velocidade>110:
    if velocidade<=132:
        print("Você foi multado por excesso de velocidade em R$100,00")
    else:
        print("Você foi multado por excesso de velocidade em R$500,00")
else:
    print("Pode seguir viagem com segurança")
