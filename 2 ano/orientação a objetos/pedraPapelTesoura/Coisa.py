class Coisa:
    def __init__(self, nome):
        self.nome = nome
        
    @property
    def nome(self):
        return self._nome

    @nome.setter
    def nome(self, value):
        self._nome = value