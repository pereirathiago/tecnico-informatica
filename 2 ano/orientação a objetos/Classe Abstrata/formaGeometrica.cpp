#include <iostream>
using namespace std;

// Classe Abstrata 
// Funciona como base para outras classes
class FormaGeometrica
{
    protected:
        // atributos da classe abstrata
        int comprimento, altura;

    public:
        // metodo construtor
        FormaGeometrica(int c, int h)
        {
            comprimento = c;
            altura = h;
        }
        // funcao virtual pura
        // se em uma classe tiver um metodo virtual a classe é abstrata
        virtual void Area() = 0;
};

// classe a partir da classe base
class Retangulo: public FormaGeometrica {
    public:
        // declarando "c" e "h" como "comprimento" e "altura" a partir da classe FormaGeometrica 
        Retangulo(int c, int h):FormaGeometrica(c, h){};
        // método da classe abstrata
        void Area() {
            cout << "Area do retangulo: " << comprimento * altura << endl;
        }
};

// classe a partir da classe base
class Triangulo: public FormaGeometrica {
    public:
        // declarando "c" e "h" como "comprimento" e "altura" a partir da classe FormaGeometrica
        Triangulo(int c, int h):FormaGeometrica(c, h){};
        // método da classe abstrata
        void Area() {
            cout << "Area do triangulo: " << (comprimento * altura) / 2 << endl;
        }
};

int main() {
    // Criação do objeto retangulo passando comprimento e altura
    Retangulo retangulo(5, 4);
    // Criação do objeto triangulo passando comprimento e altura
    Triangulo triangulo(6, 3);
    // chamando o metodo area de retangulo
    retangulo.Area();
    // chamando o metodo area de triangulo
    triangulo.Area();

    return 0;
}
