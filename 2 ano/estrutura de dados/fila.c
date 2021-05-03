#include <malloc.h>
#include <stdio.h>
#include <stdlib.h>

struct fila
{
    int ini, fim;
    float vet[5];
};
typedef struct fila Fila;
Fila *cria(void)
{
    Fila *f = (Fila *)malloc(sizeof(Fila));
    f->ini = f->fim = 0;
    return f;
}
int incr(int i)
{
    if (i == 4)
        return 0;
    else
        return i + 1;
}
void insere(Fila *f, float v)
{
    if (incr(f->fim) == f->ini)
    {
        printf("Capacidade da fila estourou!!!\n");
        exit(1);
    }
    f->vet[f->fim] = v;
    f->fim = incr(f->fim);
}
float retira(Fila *f)
{
    float v;
    if (f->ini == f->fim)
    {
        printf("Fila vazia!!!\n");
        exit(1);
    }
    v = f->vet[f->ini];
    f->ini = incr(f->ini);
    return v;
}
void libera(Fila *f)
{
    free(f);
}
void mostrafila(Fila *f)
{
    int v=f->ini;
    while (v  != f->fim)
    {
        if (v == f->ini)
            printf("Inicio -> ");
        else if (v == f->fim - 1)
            printf("Fim -> ");
        printf("%f\n", f->vet[v]);
        v = incr(v);
    }
}
// void mostrafila(Fila *f)
// {
//     int v=f->ini;
//     printf("Inicio -> ");
//     while (v  != f->fim)
//     {
//         if (v == f->fim - 1)
//             printf("Fim -> ");
//         printf("%f\n", f->vet[v]);
//         v = incr(v);
//     }
// }
int main()
{
    Fila *f = cria();
    float elem;
    int opcao = 0;
    while (opcao != 4)
    {
        printf("\n1-Insere na fila\n2-Retira da fila\n3-Mostra fila\n4-Sair\n");
        printf("Selecione sua opcao (1-4) ");
        scanf("%d", &opcao);
        switch (opcao)
        {
        case 1:
            printf("Digite o elemento a inserir ");
            scanf("%f", &elem);
            insere(f, elem);
            break;
        case 2:
            printf("Elemento retirado: %f", retira(f));
            break;
        case 3:
            mostrafila(f);
            break;
        case 4:
            break;
        default:
            printf("Opção invalida");
        }
    }
    libera(f);
}