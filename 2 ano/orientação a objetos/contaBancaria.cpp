#include <iostream>

using namespace std;

class ContaBancaria
{
private:
    float saldo;
    float x;

public:
    float creditar()
    {
        cout << "Digite o valor a creditar ";
        cin >> x;
        saldo += x;
    }
    float getSaldo()
    {
        cout << "Saldo: " << saldo << endl;
    }
};

int main(void)
{
    ContaBancaria c1, c2;
    while (1)
    {
        c1.creditar();
        c1.getSaldo();
        c2.creditar();
        c2.getSaldo();
    }
    return 0;
}
