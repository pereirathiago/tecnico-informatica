-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: 05-Nov-2020 às 20:02
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
-- Database: `formulario`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `av`
--

CREATE TABLE `av` (
  `cod` int(11) NOT NULL,
  `nome` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `codtreinamento`
--

CREATE TABLE `codtreinamento` (
  `cod` int(11) NOT NULL,
  `nome` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `diassemana`
--

CREATE TABLE `diassemana` (
  `domingo` tinyint(1) DEFAULT NULL,
  `segunda` tinyint(1) DEFAULT NULL,
  `terca` tinyint(1) DEFAULT NULL,
  `quarta` tinyint(1) DEFAULT NULL,
  `quinta` tinyint(1) DEFAULT NULL,
  `sexta` tinyint(1) DEFAULT NULL,
  `sabado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `infogeral`
--

CREATE TABLE `infogeral` (
  `idTreinamento` int(11) DEFAULT NULL,
  `periodo` int(11) DEFAULT NULL,
  `nomeInstrutor` text,
  `nomeParticipante` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `instrutor`
--

CREATE TABLE `instrutor` (
  `dominioSeguranca` int(11) DEFAULT NULL,
  `teoriaPratica` int(11) DEFAULT NULL,
  `pontual` int(11) DEFAULT NULL,
  `cargaHoraria` int(11) DEFAULT NULL,
  `organizado` int(11) DEFAULT NULL,
  `entusiasmo` int(11) DEFAULT NULL,
  `obs` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `material`
--

CREATE TABLE `material` (
  `objetivos` int(11) DEFAULT NULL,
  `cargaHoraria` int(11) DEFAULT NULL,
  `conteudo` int(11) DEFAULT NULL,
  `teoriaPratica` int(11) DEFAULT NULL,
  `obs` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `participante`
--

CREATE TABLE `participante` (
  `tarefasPropostas` int(11) DEFAULT NULL,
  `pontualIni` int(11) DEFAULT NULL,
  `pontualInterv` int(11) DEFAULT NULL,
  `permanecimento` int(11) DEFAULT NULL,
  `participacao` int(11) DEFAULT NULL,
  `obs` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `treinamento`
--

CREATE TABLE `treinamento` (
  `expectativa` int(11) DEFAULT NULL,
  `cargaHoraria` int(11) DEFAULT NULL,
  `conteudo` int(11) DEFAULT NULL,
  `teoriaPratica` int(11) DEFAULT NULL,
  `obs` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `av`
--
ALTER TABLE `av`
  ADD PRIMARY KEY (`cod`);

--
-- Indexes for table `codtreinamento`
--
ALTER TABLE `codtreinamento`
  ADD PRIMARY KEY (`cod`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
