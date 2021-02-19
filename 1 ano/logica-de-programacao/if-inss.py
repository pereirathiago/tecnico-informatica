salario=float(input("Digite o seu salario "))
if salario <= 1500:
    percentual=8
    valor_desconto=(salario*percentual)/100
    print(f"O valor do desconto a ser realizado a título de INSS é de R${valor_desconto}")
elif salario<= 2500:
    percentual=9
    valor_desconto=(salario*percentual)/100
    print(f"O valor do desconto a ser realizado a título de INSS é de R${valor_desconto}")
elif salario<= 3500:
    percentual=10
    valor_desconto=(salario*percentual)/100
    print(f"O valor do desconto a ser realizado a título de INSS é de R${valor_desconto}")
else:
    percentual=14
    valor_desconto=(salario*percentual)/100
    print(f"O valor do desconto a ser realizado a título de INSS é de R${valor_desconto}")
