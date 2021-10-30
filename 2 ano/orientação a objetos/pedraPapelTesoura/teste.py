import PySimpleGUI as sg
from random import randint

from PySimpleGUI.PySimpleGUI import WIN_CLOSED


class Jogo:
    def __init__(self, pontoJ=0, pontoPC=0):
        self.pontoJ = pontoJ
        self.pontoPC = pontoPC

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
        tela.iniciar(pedra, papel, tesoura)


class Tela:
    sg.theme('DarkPurple6')

    def __init__(self):
        layout = [
            [sg.Button(image_filename='images/papel.png', key="papel"),
             sg.Button(image_filename='images/tesoura.png', key="tesoura"),
             sg.Button(image_filename='images/pedra.png', key="pedra")]
        ]
        self.janela = sg.Window("Joguinho massa").layout(layout)

    def iniciar(self, pedra, papel, tesoura):
        while True:
            event, values = self.janela.read()
            if event == sg.WIN_CLOSED or event == 'Cancel':
                break
            if event == 'papel':
                print(papel.id,papel.nome)
            if event == 'tesoura':
                print(tesoura.id,tesoura.nome)
            if event == 'pedra':
                print(pedra.id,pedra.nome)


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
