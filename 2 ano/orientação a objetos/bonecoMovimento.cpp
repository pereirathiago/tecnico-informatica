#include <iostream>
using namespace std;
class Boneco
{
private:
    int idBoneco;

public:
    int coordenadaX = 0;
    int coordenadaY = 0;
    int movimentacao(int coordenadaX, int coordenadaY)
    {
        cout << "X = " << coordenadaX << ", Y = " << coordenadaY << endl;
    }
};

int main()
{
    Boneco boneco;
    cout << "Posicao inicial: " << boneco.coordenadaX << ", " << boneco.coordenadaY << endl;
    cout << "Digite a posicao X: ";
    cin >> boneco.coordenadaX;
    cout << "Digite a posicao Y: ";
    cin >> boneco.coordenadaY;
    boneco.movimentacao(boneco.coordenadaX, boneco.coordenadaY);
    return 0;
}
