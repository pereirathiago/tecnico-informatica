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
        cin >> x;
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
        return x / y;
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