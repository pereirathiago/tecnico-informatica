# Classe
package PositivosEMedia;

# metodo construtor
sub new
{
	my ($class) = shift;
	# cria um objeto com as variaveis
	my $self = { 
	    # _ variaveis privadas
		_pos => shift,
		_soma => shift,
		_media => shift
	};
	# bless = transforma a variavel $self em um objeto dentro de $class
	bless $self, $class;
	return $self;
}

# metodos

sub getSomarValorPositivos
{
    my $self = shift; # declaração do objeto
    for(my $i=0; $i<6; $i++)
    {
        my $entrada = <STDIN>; # input
        chomp $entrada; # remove coisas desnecessarias na variavel
        if($entrada >= 0)
        {
            $self->{ _pos } += 1;
            $self->{ _soma } += $entrada;
        }
    }
    return $self;
}

sub calculaMedia
{
    my $self = shift; # declaração do objeto
    $self -> { _media } = $self -> { _soma } / $self -> { _pos };
    return $self -> { _media };
}

sub mostrarResultados
{
    my $self = shift; # declaração do objeto
    print $self -> { _pos } ." valores positivos\n";
    print $self -> { _media };
}

# indispensavel no código, final da classe
1;

# main

my $obj=PositivosEMedia;  # declaração do objeto
$obj -> getSomarValorPositivos;
$obj -> calculaMedia;
$obj -> mostrarResultados;

print "\n\nAperte enter para fechar...";
my $enter = <STDIN>;

# finaliza o código
exit 0;