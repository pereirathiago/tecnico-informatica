#include <malloc.h>
#include <stdio.h>
#include <stdlib.h>

struct fila
{
    int ini, fim; // controla quem é o proximo a sair e o ultimo a entrar
    float vet[5]; // tamanho da fila
};
typedef struct fila Fila;
Fila *cria(void)
{
    Fila *f = (Fila *)malloc(sizeof(Fila)); // aloca espaço para um ponteiro de fila
    f->ini = f->fim = 0;                    // inicio e fim da fila é 0
    return f;
}
int incr(int i) // incrementar ou passar para a proximo possição livre do vetor
{
    if (i == 4)
        return 0; // se i for 4 (ultimo elemento da fila) o proximo é 0
    else
        return i + 1;
}
void insere(Fila *f, float v) // sempre ao final
{
    /*
     verifica se o incremento do fim não é igual ao inicio,
     ou seja se o fim não é igual ao começo
     vê se a fila não ta cheia
    */
    if (incr(f->fim) == f->ini)
    {
        printf("Capacidade da fila estourou!!!\n");
        exit(1); // sai do program, stdlib.h
    }
    f->vet[f->fim] = v;    // no vetor(f->vet) na posição(f->fim) vai ser igual a v
    f->fim = incr(f->fim); // incrementa
}
float retira(Fila *f)
{
    float v;
    if (f->ini == f->fim) // f->ini é igual ao f->fim, quando for a fila ta vazia
    {
        printf("Fila vazia!!!\n");
        exit(1);
    }
    /*
     vetor(f->vet) na posição(f->ini) para a variavel v, 
     passa o elemento da vez
    */
    v = f->vet[f->ini];
    f->ini = incr(f->ini); // incrementa
    return v;
    /*
    o elemento não sai da fila
    somente altera o inicio da fila
    */
}
void libera(Fila *f)
{
    free(f);
}
// void mostrafila(Fila *f)
// {
//     int v=f->ini;
//     while (v  != f->fim)
//     {
//         if (v == f->ini)
//             printf("Inicio -> ");
//         else if (v == f->fim - 1)
//             printf("Fim -> ");
//         printf("%f\n", f->vet[v]);
//         v = incr(v);
//     }
// }
void mostrafila(Fila *f)
{
    int v = f->ini;
    printf("Inicio ");
    while (v != f->fim)
    {
        printf("-> %f\n", f->vet[v]);
        v = incr(v);
    }
    printf("Fim");
}
int main()
{
    Fila *f = cria(); // cria uma Fila *f, chama a função cria()
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