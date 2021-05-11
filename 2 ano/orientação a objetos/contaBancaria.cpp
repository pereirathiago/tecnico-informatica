#include <iostream>

using namespace std;
class ContaBancaria
{
private:
    float saldo;

public:
    float creditar(float x)
    {
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
    c1.creditar(500.50);
    c2.creditar(800);
    c1.getSaldo();
    c2.getSaldo();
    cout << "Valor a creditar na conta 2: ";
    c1.creditar();
    return 0;
}
