-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: 22-Out-2020 às 17:39
-- Versão do servidor: 5.7.25
-- versão do PHP: 7.1.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `universidade`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `alunos`
--

CREATE TABLE `alunos` (
  `MAT` int(11) DEFAULT NULL,
  `nome` text,
  `endereco` text,
  `cidade` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `alunos`
--

INSERT INTO `alunos` (`MAT`, `nome`, `endereco`, `cidade`) VALUES
(2015010101, 'JOSE DE ALENCAR', 'RUA DAS ALMAS', 'NATAL'),
(2015010102, 'JOÃO JOSÉ', 'AVENIDA RUY CARNEIRO', 'JOÃO PESSOA'),
(2015010103, 'MARIA JOAQUINA', 'RUA CARROSSEL', 'RECIFE'),
(2015010104, 'MARIA DAS DORES', 'RUA DAS LADEIRAS', 'FORTALEZA'),
(2015010105, 'JOSUÉ CLAUDINO DOS SANTOS', 'CENTRO', 'NATAL'),
(2015010106, 'JOSUÉLISSON CLAUDINO DOS SANTOS', 'CENTRO', 'NATAL');

-- --------------------------------------------------------

--
-- Estrutura da tabela `disciplinas`
--

CREATE TABLE `disciplinas` (
  `COD_DISC` text,
  `nome_disc` text,
  `carga_hor` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `disciplinas`
--

INSERT INTO `disciplinas` (`COD_DISC`, `nome_disc`, `carga_hor`) VALUES
('BD', 'BANCO DE DADOS', '100'),
('POO', 'PROGRAMAÇÃO COM ACESSO A BANCO DE DADOS', '100'),
('WEB', 'AUTORIA WEB', '50'),
('ENG', 'ENGENHARIA DE SOFTWARE', '80');

-- --------------------------------------------------------

--
-- Estrutura da tabela `historico`
--

CREATE TABLE `historico` (
  `MAT` int(11) DEFAULT NULL,
  `COD_DISC` text,
  `COD_TURMA` text,
  `COD_PROF` int(11) DEFAULT NULL,
  `ANO` int(11) DEFAULT NULL,
  `FREQUENCIA` int(11) DEFAULT NULL,
  `NOTA` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `historico`
--

INSERT INTO `historico` (`MAT`, `COD_DISC`, `COD_TURMA`, `COD_PROF`, `ANO`, `FREQUENCIA`, `NOTA`) VALUES
(2015010101, 'BD', '1', 212131, 2015, 8, 10),
(2015010102, 'BD', '2', 122135, 2015, 6, 2),
(2015010103, 'POO', '1', 212131, 2015, 10, 9),
(2015010104, 'WEB', '1', 192011, 2015, 2, 1),
(2015010105, 'ENG', '1', 212131, 2015, 4, 10),
(2015010106, 'BD', '2', 122135, 2015, 10, 10);

-- --------------------------------------------------------

--
-- Estrutura da tabela `professores`
--

CREATE TABLE `professores` (
  `COD_PROF` int(11) DEFAULT NULL,
  `nome` text,
  `endereco` text,
  `cidade` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `professores`
--

INSERT INTO `professores` (`COD_PROF`, `nome`, `endereco`, `cidade`) VALUES
(212131, 'NICKERSON FERREIRA', 'RUA MANAÍRA', 'JOÃO PESSOA'),
(122135, 'ADORILSON BEZERRA', 'AVENIDA SALGADO FILHO', 'NATAL'),
(192011, 'DIEGO OLIVEIRA', 'AVENIDA ROBERTO FREIRE', 'NATAL');

-- --------------------------------------------------------

--
-- Estrutura da tabela `turma`
--

CREATE TABLE `turma` (
  `COD_DISC` text,
  `COD_TURMA` text,
  `COD_PROF` int(11) DEFAULT NULL,
  `ANO` int(11) DEFAULT NULL,
  `HORÁRIO` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `turma`
--

INSERT INTO `turma` (`COD_DISC`, `COD_TURMA`, `COD_PROF`, `ANO`, `HORÁRIO`) VALUES
('BD', '1', 212131, 2015, '11H-12H'),
('BD', '2', 212131, 2015, '13H-14H'),
('POO', '1', 192011, 2015, '08H-09H'),
('WEB', '1', 192011, 2015, '07H-08H'),
('ENG', '1', 122135, 2015, '10H-11H');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
