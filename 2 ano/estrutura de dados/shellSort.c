#include <stdio.h>
int v[10];

void shellSort(int *v, int n)
{
    int i, j, value;

    int h = n/2;
    while (h > 0)
    {
        for (i = h; i < n; i++)
        {
            value = v[i];
            j = i;
            while (j > h - 1 && value <= v[j - h])
            {
                v[j] = v[j - h];
                j = j - h;
            }
            v[j] = value;
        }
        h = h/2;
    }
};

int main()
{
    int i;
    for (i = 0; i < 10; i++)
    {
        printf("Digite o valor");
        scanf("%d", &v[i]);
    }
    shellSort(v, 10);
    for (i = 0; i < 10; i++)
    {
        printf("%d\n", v[i]);
    }
}