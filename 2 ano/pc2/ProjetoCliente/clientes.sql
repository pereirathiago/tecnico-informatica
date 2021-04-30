-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Apr 19, 2021 at 04:16 PM
-- Server version: 5.7.25
-- PHP Version: 7.1.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cliente`
--

-- --------------------------------------------------------

--
-- Table structure for table `clientes`
--

CREATE TABLE `cliente` (
  `codigo` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `cidade` text NOT NULL,
  `uf` text NOT NULL,
  `telefone` text NOT NULL,
  `renda` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `clientes`
--

INSERT INTO `cliente` (`codigo`, `nome`, `endereco`, `cidade`, `uf`, `telefone`, `renda`) VALUES
(4564212, 'zxcz', 'zxczxc', 'zxczxc', 'PI', '(44)44444-4444', 500),
(4444, 'asdasd', 'asdasd', 'asdasd', 'asdasd', '555555', 222),
(455555, 'dfgdfg', 'fgdfg', 'dfgdfg', 'fdgdg', '646545454', 78974),
(46546, 'dsfsdf', 'sdfsdf', 'sdfsdf', 'dsfsdf', '45644564', 1000);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
