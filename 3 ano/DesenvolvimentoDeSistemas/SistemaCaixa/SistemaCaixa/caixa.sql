-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: 01-Mar-2022 às 16:24
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
-- Database: `caixa`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `movimento`
--

CREATE TABLE `movimento` (
  `id` int(11) NOT NULL,
  `data` date NOT NULL,
  `descricao` varchar(200) NOT NULL,
  `valor` double NOT NULL,
  `tipo` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `movimento`
--

INSERT INTO `movimento` (`id`, `data`, `descricao`, `valor`, `tipo`) VALUES
(1, '2022-02-27', 'venda', 5, 'E'),
(2, '2022-02-27', 'compra', 2, 'S'),
(3, '2022-02-28', 'venda', 15, 'E'),
(4, '2022-02-27', 'venda', 5, 'E'),
(5, '2022-03-01', 'venda de x', 10, 'E'),
(6, '2022-02-27', 'compra de y', 5, 'S'),
(7, '2022-03-01', 'venda de produto', 15, 'E'),
(8, '2022-02-27', 'compra', 2, 'S');

-- --------------------------------------------------------

--
-- Estrutura da tabela `saldo`
--

CREATE TABLE `saldo` (
  `id` int(11) NOT NULL,
  `data` date NOT NULL,
  `valor` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `saldo`
--

INSERT INTO `saldo` (`id`, `data`, `valor`) VALUES
(1, '2022-02-27', 1),
(2, '2022-02-28', 16),
(3, '2022-03-01', 41);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `movimento`
--
ALTER TABLE `movimento`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `saldo`
--
ALTER TABLE `saldo`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `movimento`
--
ALTER TABLE `movimento`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `saldo`
--
ALTER TABLE `saldo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
