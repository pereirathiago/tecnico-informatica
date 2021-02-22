#include <stdio.h>
int main() {
    float lado, area;
    printf("Lado: ");
    scanf("%f", &lado);
    area = lado * lado;
    printf("A area do quadrado e %f", area);
}