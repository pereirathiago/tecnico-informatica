maior=0
c=0
c5=0
while(c<10):
    num=int(input("Digite um valor inteiro"))
    c+=1
    if(num>maior):
        maior=num
    if(num>5):
        c5+=1
print(f"O maior valor foi {maior}")
print(f"Há {c5} números maiores que 5")