import PySimpleGUI as sg
from random  import randint

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

    def main(self):
        tela = Tela()
        tela.iniciar()


class Tela:
    sg.theme('DarkPurple6')
    def __init__(self):
        layout = [
                #[sg.Image(r'C:\Users\fcsa\Desktop\papel.png')],
                [sg.Button(image_filename=r'C:\Users\fcsa\Desktop\ppt\papel.png'),
                sg.Button(image_filename=r'C:\Users\fcsa\Desktop\ppt\tesoura.png'),
                sg.Button(image_filename=r'C:\Users\fcsa\Desktop\ppt\pedra.png')]
            ]
        self.janela = sg.Window("Joguinho massa").layout(layout)

    def iniciar(self):
        event, values = self.janela.read()
        while True:
            if event == sg.WIN_CLOSED: # if user closes window or clicks cancel
                break
        self.janela.close()

class Coisa:
    pass

class Tesoura(Coisa):
    pass


class Papel(Coisa):
    pass
    

class Pedra(Coisa):
    pass

j = Jogo()
j.main()
