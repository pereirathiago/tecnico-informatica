#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>
struct arv
{
    char info; // char = um caractere
    struct arv* esq; // arvore lado esquerdo
    struct arv* dir; // arvore lado direito
};
typedef struct arv Arv; // criamos o Arv do tipo struct arv, para não precisar escrever struct arv o tempo inteiro

/*
    a função cria recebe um caractere
    aloca espaço na memoria
    atribui c a info
    esq e dir como null
    retorna um ponteiro de arvore
    "cria uma bolinha, um nó da arvore, e dois ponteiros pra nulo"
*/
Arv* cria(char c)
{
    Arv* a = (Arv*)malloc(sizeof(Arv)); // aloca na memoria um espoço que cabe uma arvore
    a->info = c;
    a->esq = NULL;
    a->dir = NULL;
    return a;
}

/*
    objetivo desmontar a estrutura no final
    recebe uma arvore
    libera em ós-orden
*/
Arv* libera(Arv* a)
{
    if (a != NULL) 
    {
        libera(a->esq); // chama o libera pra arv da esquerda, acabando com ela
        libera(a->dir); // chama o libera pra arv da direita, acabando com ela
        free(a); // libera o nó
    }
    return NULL;
}

/*
    recebe uma arvore e o elemento a ser inserido
*/
Arv* insere(Arv* a, char elem)
{
    Arv* s; // cria um ponteiro pra arvore chamado s
    if (a != NULL) // se a arvore não estiver vazia
    {
        if (elem < a->info) // elemento é menor que o nó
        {
            s = insere(a->esq, elem);  // chama o insere na arv esquerda
            a->esq = s; // insere no nó esquerda
        }
        else
        {
            s = insere(a->dir, elem); // chama o insere na arv direita
            a->dir = s; // insere no nó direita
        }
    }
    else
        a = cria(elem); // se a arvore estiver vazia cria arvore
    return a; // retorna arvore
}

/*
    faz o caminhamento pré-ordem ned
*/
void pre(Arv* a)
{
    if (a != NULL) // se a arv nn for nula
    {
        printf(" %c", a->info); // mostra o elemento do nó
        pre(a->esq); // chama pra esquerda, ate nn poder ir pra esquerda
        pre(a->dir); // chama pra direita, ate nn poder ir pra direita
    }
}

/*
    faz o caminhamento pós-orden edn
*/
void pos(Arv* a)
{
    if (a != NULL)
    {
        pos(a->esq); // chama pra esquerda, ate nn poder ir pra esquerda
        pos(a->dir); // chama pra direita, ate nn poder ir pra direita
        printf(" %c", a->info); // mostra o elemento do nó
    }
}

/*
    faz o caminhamento in-orden end
*/
void in(Arv* a)
{
    if (a != NULL)
    {
        in(a->esq); // chama pra esquerda, ate nn poder ir pra esquerda
        printf(" %c", a->info); // mostra o elemento do nó
        in(a->dir); // chama pra direita, ate nn poder ir pra direita
    }
}

/*
    faz o caminhamento nde
*/
void nde(Arv* a)
{
    if (a != NULL)
    {
        printf(" %c", a->info); // mostra o elemento do nó
        nde(a->dir); // chama pra direita, ate nn poder ir pra direita
        nde(a->esq); // chama pra esquerda, ate nn poder ir pra esquerda
    }
    
}

/*
    faz o caminhamento dne
*/
void dne(Arv* a)
{
    if (a != NULL)
    {
        dne(a->dir); // chama pra direita, ate nn poder ir pra direita
        printf(" %c", a->info); // mostra o elemento do nó
        dne(a->esq); // chama pra esquerda, ate nn poder ir pra esqueda
    }
    
}

/*
    faz o caminhamento den
*/
void den(Arv* a)
{
    if (a != NULL)
    {
        den(a->dir); // chama pra direita, ate nn poder ir pra direita
        den(a->esq); // chama pra esqueda, ate nn poder ir pra esqueda
        printf(" %c", a->info); // mostra o elemento do nó
    }
    
}

/*
    busca o elemento na arvore
    recebe uma arvore e um elemento
*/ 
int busca(Arv* a, char elem)
{
    if (a == NULL) // se a arvore for nula, nn tem o elemento
        return NULL; // retorna null
    else 
        if (a->info > elem) // se o elemento da arvore for maior q o elemento
            return busca(a->esq, elem); // vai pra esqueda
        else 
            if (a->info < elem) // se o elemento da arvore for menor q o element
                return busca(a->dir, elem); // vai para direita
            else
                return a->info; // retorna a informação
}
int main()
{
    Arv* a = NULL; // arvore a como nulo
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
                    scanf(" %c", &elem); // gambiara pra scanf do caractere, colocar espaço antes do %c, para não contar com o enter
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
                    b = busca(a, elem); // recebe o resultado da busca
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
    libera(a); // chama a funcao libera na arvore
}