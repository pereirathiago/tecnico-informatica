#include <iostream>

using namespace std;

class Boneco
{
public:
    int idBoneco;
    int coordenadaX;
    int coordenadaY;

public:
    void getCoordenadas(void)
    {
        cout << "Digite o valor de X: ";
        cin >> coordenadaX;
        cout << "Digite o valor de Y: ";
        cin >> coordenadaY;
    }

    int movimentacao(void)
    {
        
    }
};

int main(void)
{
    Boneco boneco;
    
    boneco.getCoordenadas();

    return 0;
}
