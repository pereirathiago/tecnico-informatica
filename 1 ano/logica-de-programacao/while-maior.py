maior=0
c=0
while(c<10):
    num=int(input("Digite um valor inteiro"))
    c+=1
    if(num>maior):
        maior=num
print(f"O maior valor foi {maior}")