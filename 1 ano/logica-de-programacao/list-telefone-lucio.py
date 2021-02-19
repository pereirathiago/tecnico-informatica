n = [0,0,0,0,0,0,0,0,0,0]
t = [0,0,0,0,0,0,0,0,0,0]
c=0
while(c<10):
    n[c]=input("Digite o nome")
    t[c]=input("Digite o telefone")
    c+=1
const=""
while(const!="fim"):
    cons=input("Digite nome a consultar")
    if(n[c]==const):
        print(f"TEl: {t[c]}")
    c+=1