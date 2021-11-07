import PySimpleGUI as sg
from random import randint

class Jogo:
    def __init__(self, ponto_j=0, ponto_pc=0):
        self.ponto_j = ponto_j
        self.ponto_pc = ponto_pc

    def verifica_vencedor(self, escolha, pedra, papel, tesoura):
        self._escolha_pc = randint(1, 3)
        # print(self._escolha_pc)
        if(self._escolha_pc == pedra.id):
            if(escolha == pedra.id):
                sg.popup("empate, o PC jogou pedra")
            elif(escolha == papel.id):
                sg.popup("voce ganhou, o PC jogou pedra")
            else:
                sg.popup("voce perdeu, o PC jogou pedra")
        elif(self._escolha_pc == papel.id):
            if(escolha == pedra.id):
                sg.popup("voce perdeu, o PC jogou papel")
            elif(escolha == papel.id):
                sg.popup("empate, o PC jogou papel")
            else:
                sg.popup("voce ganhou, o PC jogou papel")
        elif(self._escolha_pc == tesoura.id):
            if(escolha == pedra.id):
                sg.popup("voce ganhou, o PC jogou tesoura")
            elif(escolha == papel.id):
                sg.popup("voce perdeu, o PC jogou tesoura")
            else:
                sg.popup("empate, o PC jogou tesoura")

    @property
    def ponto_j(self):
        return self._ponto_j

    @ponto_j.setter
    def ponto_j(self, value):
        self._ponto_j = value

    @property
    def ponto_pc(self):
        return self._ponto_pc

    @ponto_pc.setter
    def ponto_pc(self, value):
        self._ponto_pc = value

    def main(self, pedra, papel, tesoura):
        tela = Tela()
        tela.iniciar(self, pedra, papel, tesoura)


class Tela:
    sg.theme('DarkPurple6')

    def __init__(self):
        layout = [
            [sg.Button(image_filename='images/pedra.png', key="pedra"),
             sg.Button(image_filename='images/papel.png', key="papel"),
             sg.Button(image_filename='images/tesoura.png', key="tesoura")]
        ]
        self.janela = sg.Window("Joguinho massa").layout(layout)

    def iniciar(self, jogo, pedra, papel, tesoura):
        while True:
            event, value = self.janela.read()
            if event == sg.WIN_CLOSED or event == 'Cancel':
                break
            if event == 'papel':
                jogo.verifica_vencedor(papel.id, pedra, papel, tesoura)
            if event == 'tesoura':
                jogo.verifica_vencedor(tesoura.id, pedra, papel, tesoura)
            if event == 'pedra':
                jogo.verifica_vencedor(pedra.id, pedra, papel, tesoura)


class Coisa:
    def __init__(self, nome):
        self.nome = nome

    @property
    def nome(self):
        return self._nome

    @nome.setter
    def nome(self, value):
        self._nome = value


class Pedra(Coisa):
    id = 1


class Papel(Coisa):
    id = 2


class Tesoura(Coisa):
    id = 3


pedra = Pedra('pedra')
papel = Papel('papel')
tesoura = Tesoura('tesoura')
j = Jogo()

j.main(pedra, papel, tesoura)
