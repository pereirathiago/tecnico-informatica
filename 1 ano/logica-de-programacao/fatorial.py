def fatorial(n):
    if n == 1:
        return 1
    else:
        return n * fatorial(n-1)


n = int(input("Digite o número para o fatorial: "))
print(f"Fatorial: {fatorial(n)}")
