sx = sy =sxy = sx2 =sy2 = c = 0

while(c<3):
    x = int(input("Digite um valor de x:"))
    sx += x
    y = int(input("Digite um valor de y:"))
    sy += y 
    sxy += x*y
    sx2 += x**2
    sy2 += y**2
    c+=1
print(f"Sx = {sx}")
print(f"Sy = {sy}")
print(f"Sxy = {sxy}")
print(f"Sx² = {sx2}")
print(f"Sy² = {sy2}")
