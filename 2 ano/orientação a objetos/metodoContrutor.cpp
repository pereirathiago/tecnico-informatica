#include <iostream>

using namespace std;

class Conta {
    public:
        float saldo;
    public:
        Conta(){
            cout << "Bem vindo!" << endl;
        }
};

int main(void) {
    Conta obj1, obj2;

    obj1.saldo = 200000;

    cout << "Saldo = " << obj1.saldo << endl;
}