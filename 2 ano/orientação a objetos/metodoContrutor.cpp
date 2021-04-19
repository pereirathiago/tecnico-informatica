#include <iostream>

using namespace std;

class Conta {
    private:
        float saldo;
    public:
        Conta(){
            cout << "Bem vindo!" << endl;
            saldo = 0;
            cout << "O seu saldo: " << saldo << endl;
        }
};

int main(void) {
    Conta obj1;

    return 0;
}