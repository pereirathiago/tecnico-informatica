n=[]
t=[]
nome=""
while(nome!="fim"):
    nome=input("Digite um nome: ")
    if(nome!="fim"):   
        n.append(nome)
        t.append(input("Digite o telefone: "))
tamanhoDaLista=len(n)
print(n)
print(t)
print(tamanhoDaLista)
print(n[-1]) #de tras pra frente