import PySimpleGUI as sg
from random import randint

from PySimpleGUI.PySimpleGUI import WIN_CLOSED


class Jogo:
    def __init__(self, pontoJ=0, pontoPC=0):
        self.pontoJ = pontoJ
        self.pontoPC = pontoPC
    
    def verificaVencedor(self, escolha, pedra, papel, tesoura):
        self._escolhaPc = randint(1,3)
        print(self._escolhaPc)
        if(self._escolhaPc == pedra.id):
            if(escolha == pedra.id):
                print("empate, 2 pedra")
            elif(escolha == papel.id):
                print("voce ganhou")
            else:
                print("voce perdeu")
        elif(self._escolhaPc == papel.id):
            if(escolha == pedra.id):
                print("voce perdeu")
            elif(escolha == papel.id):
                print("empate") 
            else:
                print("voce ganhou")
        elif(self._escolhaPc == tesoura.id):
            if(escolha == pedra.id):
                print("voce ganhou")
            elif(escolha == papel.id):
                print("voce perdeu")
            else:
                print("empate")
            

    @property
    def pontoJ(self):
        return self._pontoJ

    @pontoJ.setter
    def pontoJ(self, value):
        self._pontoJ = value

    @property
    def pontoPC(self):
        return self._pontoPC

    @pontoPC.setter
    def pontoPC(self, value):
        self._pontoPC = value

    def main(self, pedra, papel, tesoura):
        tela = Tela()
        tela.iniciar(self, pedra, papel, tesoura)


class Tela:
    sg.theme('DarkPurple6')

    def __init__(self):
        layout = [
            [sg.Button(image_filename='images/papel.png', key="papel"),
             sg.Button(image_filename='images/tesoura.png', key="tesoura"),
             sg.Button(image_filename='images/pedra.png', key="pedra")]
        ]
        self.janela = sg.Window("Joguinho massa").layout(layout)

    def iniciar(self, jogo, pedra, papel, tesoura, tela):
        while True:
            event, values = self.janela.read()
            if event == sg.WIN_CLOSED or event == 'Cancel':
                break
            if event == 'papel':
                print(papel.id,papel.nome)
                jogo.verificaVencedor(papel.id, pedra, papel, tesoura)
            if event == 'tesoura':
                print(tesoura.id,tesoura.nome)
                jogo.verificaVencedor(tesoura.id, pedra, papel, tesoura)
            if event == 'pedra':
                print(pedra.id,pedra.nome)
                jogo.verificaVencedor(pedra.id, pedra, papel, tesoura)

class TelaResultado:
    sg.theme('DarkPurple6')
    def __init__(self,escolhaJ, escolhaPc):
        layout = [
            [sg.Button(image_filename=escolhaPc, key="escolhaPc")],
            [sg.Button(image_filename=escolhaJ, key="escolhaJ")],
            [sg.Text(key="resultado")],
            [sg.Button(key="Cancel")]
        ]
        self.janela = sg.Window("Joguinho massa").layout(layout)

    def iniciar(self, jogo, pedra, papel, tesoura):
        while True:
            event, values = self.janela.read()
            if event == sg.WIN_CLOSED or event == 'Cancel':
                break

class Coisa:
    def __init__(self, nome):
        self.nome = nome
        
    @property
    def nome(self):
        return self._nome

    @nome.setter
    def nome(self, value):
        self._nome = value


class Tesoura(Coisa):
    id = 1


class Papel(Coisa):
    id = 2


class Pedra(Coisa):
    id = 3

pedra = Pedra('pedra')
papel = Papel('papel')
tesoura = Tesoura('tesoura')
j = Jogo()

j.main(pedra,papel, tesoura)
