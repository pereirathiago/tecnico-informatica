#include <iostream>
using namespace std;

class Multiplica {
    private:
        float metodoUm;
        float metodoDois;
    public:
        Multiplica(){
            metodoUm = 70;
            metodoDois = 7;
            cout << metodoUm << " X " << metodoDois << " = " << metodoUm*metodoDois << endl;
        }

};

int main(void){
    Multiplica res;
    return 0;
}