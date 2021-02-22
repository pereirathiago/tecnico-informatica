#include <stdio.h>
int main() {
    int idade, dias;
    printf("Digite sua idade: ");
    scanf("%d", &idade);
    dias = idade * 365;
    printf("Voce viveu %d dias", dias);
}