#include <iostream>

    using namespace std;

class Calculadora
{
public:
    int x;
    int y;

public:
    void getValores(void)
    {
        cout << "Digite o valor de X: ";
        cin >> x;
        cout << "Digite o valor de Y: ";
        cin >> y;
    }
    int somaValores(void)
    {
        return x + y;
    }
    int subtraiValores(void)
    {
        return x - y;
    }
    int multiplicaValores(void)
    {
        return x * y;
    }
    int divideValores(void)
    {
        if (y != 0)
        {
            return x / y;
        }
        cout << "Erro -1, nao foi possivel divir por zero!" << endl;
        return -1;
    }
};

int main(void)
{
    Calculadora res;
    res.getValores();

    cout << res.x << " + " << res.y << " = " << res.somaValores() << endl;
    cout << res.x << " - " << res.y << " = " << res.subtraiValores() << endl;
    cout << res.x << " * " << res.y << " = " << res.multiplicaValores() << endl;
    cout << res.x << " / " << res.y << " = " << res.divideValores() << endl;

    return 0;
}