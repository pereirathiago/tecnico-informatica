import math
sd = []
c = 0
while(c<5):
    c+=1
    v = float(input(f"Digiti o {c}° valor... "))
    sd.append(v)
c = len(sd)
media = (sd[0]+ sd[1]+ sd[2]+ sd[3]+ sd[4])/c
v = (((sd[0] - media)**2) + ((sd[1] - media)**2) + ((sd[2] - media)**2) + ((sd[3] - media)**2) + ((sd[4] - media)**2)) /len(sd)
sd = math.sqrt(v)
print(f"O valor aproximado do desvio padrão é {sd:.2f} e a media é {media}")
