soma = 0
# recebendo os valores
p1 = float(input("Digite quantos celulares você já teve... "))
soma+=p1
p2 = float(input("Digite quantos celulares você já teve... "))
soma+=p2
p3 = float(input("Digite quantos celulares você já teve... "))
soma+=p3

# FR
fr1 = (p1/soma)*100
fr2 = (p2/soma)*100
fr3 = (p3/soma)*100

# FAR
far1 = fr1
far2 = far1 + fr2
far3 = far2 + fr3

# graus
grau1 = fr1 * 3.6
grau2 = fr2 * 3.6
grau3 = fr3 * 3.6

print(f"Preenchendo os dados da primeira pessoa. FR: {fr1:.2f}, FAR: {far1:.2f}, Grau: {grau1:.0f}")
print(f"Preenchendo os dados da segunda pessoa. FR: {fr2:.2f}, FAR: {far2:.2f}, Grau: {grau2:.0f}")
print(f"Preenchendo os dados da terceira pessoa. FR: {fr3:.2f}, FAR: {far3:.2f}, Grau: {grau3:.0f}")
