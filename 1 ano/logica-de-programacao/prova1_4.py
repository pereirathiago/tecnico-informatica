preco=float(input("Digite o valor do produto em reais "))
perc=float(input("Digite o percentual de desconto do produto "))
desc=(preco*perc)/100
npreco=(preco-desc)
print(f"O desconto do produto é de R${desc} e o produto fica com um preço de R${npreco}")
