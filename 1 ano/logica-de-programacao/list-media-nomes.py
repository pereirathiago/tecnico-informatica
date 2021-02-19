# valores iniciais
n = []
nota = []
nome = ""
soma = media = c = 0

# recebendo valores nas listas
while (nome != "fim"):
    nome = input("Digite um nome: ")
    if(nome != "fim"):
        n.append(nome)
        nota.append(float(input("Diite a nota dessa pessoa: ")))
        soma += nota[c]
        c += 1
# Calculando média
media = soma/c
print("--------")
# zerando valores
c = 0 
const = ""
# iniciando loop para consulta
while (const!="fim"):
    const = input("Digite o nome a consultar: ")  
    if (const!="fim"):
        while (const != n[c]):
                c+=1
        # mostrando notas
        if (n[c] == const):
            print(f"Nota: {nota[c]}")
            if (media<nota[c]):
                print(f"Com essa nota o aluno {const} está acima da média, sendo média {media}")
            elif (media == nota[c]):
                print(f"Com essa nota o aluno {const} está na média, sendo média {media}")
            else:
                print(f"Com essa nota o aluno {const} está abaixo da média, sendo média {media}")
    c = 0
# finalizando
print("Acabou")