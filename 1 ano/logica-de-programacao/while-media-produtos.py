p=0
c=0

while(c<10):
    n=float(input("Digite o valor do produto "))
    p+=n
    c+=1
p/=10
print(f"O valor médio dos {c} produtos é {p}")
