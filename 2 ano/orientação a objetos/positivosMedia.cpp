#include <iostream>

using namespace std;

class PositivosMedia
{
private:
    int pos;
    float media, soma;

public:
    PositivosMedia()
    {
        pos = 0;
        media = 0;
        soma = 0;
    }
    void receberNumeros(){
        float x;
        for (int i = 0; i < 6; i++)
        {
            cin >> x;
            pos = verificaPositivos(x);
        }
        media = calculaMedia(soma, pos);
        mostraResultados(media, pos);
    }
    int verificaPositivos(float x) {
        if (x >= 0)
        {
            pos += 1;
            soma += x;
        }
        return pos;
    }
    float calculaMedia(float soma, int pos) {
        return media = soma / pos;
    }
    void mostraResultados(float media, int pos){
        cout << pos << " valores positivos" << endl;
        cout << media << endl;
    }
};

int main()
{
    PositivosMedia obj1;
    obj1.receberNumeros();
    return 0;
}
