CREATE TABLE av (
  cod INT primary key,
  nome TEXT
);

CREATE TABLE codTreinamento (
  cod INT primary key,
  nome TEXT
);

CREATE TABLE diasSemana (
  domingo BOOL,
  segunda BOOL,
  terca BOOL,
  quarta BOOL,
  quinta BOOL,
  sexta BOOL,
  sabado BOOL
);

CREATE TABLE infoGeral (
  idTreinamento INT,
  periodo INT,
  nomeInstrutor TEXT,
  nomeParticipante TEXT
);

CREATE TABLE instrutor (
  dominioSeguranca INT,
  teoriaPratica INT,
  pontual INT,
  cargaHoraria INT,
  organizado INT,
  entusiasmo INT,
  obs TEXT
);

CREATE TABLE material (
  objetivos INT,
  cargaHoraria INT,
  conteudo INT,
  teoriaPratica INT,
  obs TEXT
);

CREATE TABLE participante (
  tarefasPropostas INT,
  pontualIni INT,
  pontualInterv INT,
  permanecimento INT,
  participacao INT,
  obs TEXT
);

CREATE TABLE treinamento (
  expectativa INT,
  cargaHoraria INT,
  conteudo INT,
  teoriaPratica INT,
  obs TEXT
);


