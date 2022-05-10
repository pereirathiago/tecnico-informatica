-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: 10-Maio-2022 às 00:59
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
-- Database: `salarios`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `matricula` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `vt` varchar(50) NOT NULL,
  `dep14` int(11) NOT NULL,
  `depir` int(11) NOT NULL,
  `salario` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `funcionario`
--

INSERT INTO `funcionario` (`matricula`, `nome`, `vt`, `dep14`, `depir`, `salario`) VALUES
(10, 'Vinicius', 'S', 2, 3, 1300),
(11, 'Giovanne', 'N', 0, 0, 1300),
(12, 'João Pedro', 'S', 1, 2, 2000),
(13, 'Thiago', 'N', 0, 0, 3000),
(14, 'Tiago', 'N', 1, 1, 4500),
(15, 'Gustavo', 'N', 1, 1, 6400),
(16, 'Danilo', 'N', 1, 1, 15000),
(17, 'Matheus', 'N', 0, 0, 15000),
(18, 'Lucio', 'N', 0, 1, 20000);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tabela`
--

CREATE TABLE `tabela` (
  `id` int(11) NOT NULL,
  `tinss1` double NOT NULL,
  `tinss2` double NOT NULL,
  `tinss3` double NOT NULL,
  `tinss4` double NOT NULL,
  `ainss1` double NOT NULL,
  `ainss2` double NOT NULL,
  `ainss3` double NOT NULL,
  `ainss4` double NOT NULL,
  `tsf` double NOT NULL,
  `vsf` double NOT NULL,
  `tirrf1` double NOT NULL,
  `tirrf2` double NOT NULL,
  `airrf2` double NOT NULL,
  `dirrf2` double NOT NULL,
  `tirrf3` double NOT NULL,
  `airrf3` double NOT NULL,
  `dirrf3` double NOT NULL,
  `tirrf4` double NOT NULL,
  `airrf4` double NOT NULL,
  `dirrf4` double NOT NULL,
  `airrf5` double NOT NULL,
  `dirrf5` double NOT NULL,
  `dedpdep` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tabela`
--

INSERT INTO `tabela` (`id`, `tinss1`, `tinss2`, `tinss3`, `tinss4`, `ainss1`, `ainss2`, `ainss3`, `ainss4`, `tsf`, `vsf`, `tirrf1`, `tirrf2`, `airrf2`, `dirrf2`, `tirrf3`, `airrf3`, `dirrf3`, `tirrf4`, `airrf4`, `dirrf4`, `airrf5`, `dirrf5`, `dedpdep`) VALUES
(1, 1212, 2427.36, 3641.03, 7087.22, 7.5, 9, 12, 14, 1655.98, 56.47, 1903.98, 2826.65, 7.5, 142.8, 3751.05, 15, 354.8, 4664.68, 22.5, 646.13, 27.5, 869.36, 189.59);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`matricula`);

--
-- Indexes for table `tabela`
--
ALTER TABLE `tabela`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `funcionario`
--
ALTER TABLE `funcionario`
  MODIFY `matricula` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `tabela`
--
ALTER TABLE `tabela`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
