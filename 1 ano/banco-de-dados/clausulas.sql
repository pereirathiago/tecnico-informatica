--criar tabela
CREATE TABLE nomeTabela (
	nomeColuna tipo,
	nomeColuna tipo
)



--deletar tabela 
DROP TABLE nomeTabela



--inserir dados na tabela
INSERT INTO nomeTabela (nomeColuna, nomeColuna, nomeColuna)  VALUES (valorColuna, valorColuna, valorColuna);



--selecionar algo na tabela
SELECT nomeColuna, nomeColuna(ou * para todos) FROM nomeTabela



--ordenar 
SELECT nomeColuna FROM nomeTabela order by nomeColunaQueQuerOrdenar(padrão é crescente)
--para decrescente acrescente desc no final



--selecionar que contenha
SELECT nomeColuna FROM nomeTabela WHERE nomeColuna like "letra/sinal"

--se usar % pode ter qualquer coisa antes ou depois, dependendo da posição do %
SELECT * FROM `cliente` WHERE nome LIKE "A%i%"

--para contar caracteres antes utiliza _
SELECT * FROM `cliente` WHERE nome LIKE "_n%"



--selecionar igual
SELECT * FROM `cliente` WHERE nome = "ANA "



--entre tanto e tanto
SELECT * FROM cliente WHERE salario between "500" and "2000" ORDER BY salario, nome

--OPERADORES 
<= menor ou igual
= igual
>= maior ou igual
<> diferente

