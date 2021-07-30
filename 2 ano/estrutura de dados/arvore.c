#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>
struct arv
{
    char info;
    struct arv* esq;
    struct arv* dir;
};
typedef struct arv Arv;
Arv* cria(char c)
{
    Arv* a = (Arv*)malloc(sizeof(Arv));
    a->info = c;
    a->esq = NULL;
    a->dir = NULL;
    return a;
}
Arv* libera(Arv* a)
{
    if (a != NULL)
    {
        libera(a->esq);
        libera(a->dir);
        free(a);
    }
    return NULL;
}
Arv* insere(Arv* a, char elem)
{
    Arv* s;
    if (a != NULL)
    {
        if (elem < a->info)
        {
            s = insere(a->esq, elem);
            a->esq = s;
        }
        else
        {
            s = insere(a->dir, elem);
            a->dir = s;
        }
    }
    else
        a = cria(elem);
    return a;
}
void pre(Arv* a)
{
    if (a != NULL)
    {
        printf(" %c", a->info);
        pre(a->esq);
        pre(a->dir);
    }
}
void pos(Arv* a)
{
    if (a != NULL)
    {
        pos(a->esq);
        pos(a->dir);
        printf(" %c", a->info);
    }
}
void in(Arv* a)
{
    if (a != NULL)
    {
        in(a->esq);
        printf(" %c", a->info);
        in(a->dir);
    }
}
void nde(Arv* a)
{
    if (a != NULL)
    {
        printf(" %c", a->info);
        nde(a->dir);
        nde(a->esq);
    }
    
}
void dne(Arv* a)
{
    if (a != NULL)
    {
        nde(a->dir);
        printf(" %c", a->info);
        nde(a->esq);
    }
    
}
void den(Arv* a)
{
    if (a != NULL)
    {
        nde(a->dir);
        nde(a->esq);
        printf(" %c", a->info);
    }
    
}
int busca(Arv* a, char elem)
{
    if (a == NULL)
        return NULL;
    else 
        if (a->info > elem)
            return busca(a->esq, elem);
        else 
            if (a->info < elem)
                return busca(a->dir, elem);
            else
                return a->info;
}
int main()
{
    Arv* a = NULL;
    int opcao = -1;
    int b;
    char elem;
    while (opcao != 0)
    {
        printf("\n1-Insere\n2-Mostra pre-ordem");
        printf("\n3-Mostra in-ordem\n4-Mostra pos-ordem");
        printf("\n5-Mostra todos os caminhamentos");
        printf("\n6-Busca\n0-Sair");
        printf("\nDigite sua opcao: ");
        scanf("%d",&opcao);
        switch(opcao){
                case 1:
                    printf("Digite elemento a incluir ");
                    scanf(" %c", &elem);
                    a = insere(a, elem);
                    break;
                case 2:
                    pre(a);
                    break;
                case 3:
                    in(a);
                    break;
                case 4:
                    pos(a);
                    break;
                case(5):
                    printf("\nPre-ordem: ");
                    pre(a);
                    printf("\nIn-ordem: ");
                    in(a);
                    printf("\nPos-ordem: ");
                    pos(a);
                    printf("\nNDE: ");
                    den(a);
                    printf("\nDNE: ");
                    dne(a);
                    printf("\nDEN: ");
                    nde(a);
                    break;
                case 6:
                    printf("Digite elemento a buscar ");
                    scanf(" %c", &elem);
                    b = busca(a, elem);
                    if (b == NULL)
                    {
                        printf("Elemento inexistente\n");
                    } else
                    {
                        printf(" %c", b);
                    }
                    // if (b == 1)
                    //     printf("Elemento existente\n");
                    // else
                    //     printf("Elemento inexistente\n");
                    break;
                case 0:
                    break;
                default:
                    printf("\nOpcao inexistente!");
        }
    }
    libera(a);
}