import PySimpleGUI as sg
from PySimpleGUI.PySimpleGUI import WIN_CLOSED

class Tela:
    sg.theme('DarkPurple6')

    def __init__(self):
        layout = [
            [sg.Button(image_filename='../images/papel.png', key="papel"),
             sg.Button(image_filename='../images/tesoura.png', key="tesoura"),
             sg.Button(image_filename='../images/pedra.png', key="pedra")]
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