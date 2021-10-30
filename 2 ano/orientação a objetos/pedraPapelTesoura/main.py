import vo.Pedra as Pedra
import vo.Papel as Papel
import vo.Tesoura as Tesoura
import Jogo

pedra = Pedra('pedra')
papel = Papel('papel')
tesoura = Tesoura('tesoura')
j = Jogo()
j.main(pedra,papel, tesoura)