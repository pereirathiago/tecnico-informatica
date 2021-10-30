import tela.Tela as Tela

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