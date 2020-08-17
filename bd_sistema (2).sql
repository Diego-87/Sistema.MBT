-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 24-Jul-2020 às 04:09
-- Versão do servidor: 10.4.10-MariaDB
-- versão do PHP: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bd_sistema`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cliente`
--

CREATE TABLE `tb_cliente` (
  `cod` int(11) NOT NULL,
  `nome_fantasia` varchar(200) NOT NULL,
  `razao_social` varchar(200) NOT NULL,
  `endereco` varchar(200) NOT NULL,
  `municipio` varchar(200) DEFAULT NULL,
  `uf` char(2) NOT NULL,
  `bairro` varchar(200) NOT NULL,
  `telefone` varchar(12) NOT NULL,
  `cel` varchar(12) NOT NULL,
  `email` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_cliente`
--

INSERT INTO `tb_cliente` (`cod`, `nome_fantasia`, `razao_social`, `endereco`, `municipio`, `uf`, `bairro`, `telefone`, `cel`, `email`) VALUES
(6, 'ggggggggg', 'ggggggggg', 'gggggggg', 'ggggggg', 'AL', 'ggggggggg', '33238695', '991986181', 'ggggggggggg'),
(7, 'RRRRRRRRRRRR', 'GGGGGGGGG', 'GGGGGGGGG', 'GGGGGGG', 'AL', 'GGGGGGGGGG', '33238695', '9999999', 'GGGGGGG@'),
(8, 'aaaaaaaaaaaaaaa', 'aaaaaaaaaaaa', 'aaaaaaaaaaa', 'aaaaaaaaaaaaa', 'AL', 'aaaaaaaaaaaaaa', '3333333', '33333333', 'aaaaaaaaaaaaaa');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_compras`
--

CREATE TABLE `tb_compras` (
  `cod` int(11) NOT NULL,
  `descricao` varchar(200) NOT NULL,
  `data` varchar(20) NOT NULL DEFAULT current_timestamp(),
  `fornecedor` varchar(200) NOT NULL,
  `unidade` varchar(50) NOT NULL,
  `valor_unitario` decimal(10,2) NOT NULL,
  `quantidade` float NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `total_compras` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_compras`
--

INSERT INTO `tb_compras` (`cod`, `descricao`, `data`, `fornecedor`, `unidade`, `valor_unitario`, `quantidade`, `total`, `total_compras`) VALUES
(73, 'manga', '23/07/2020', 'DANI ', 'CX', '10.00', 20, '200.00', 0),
(74, 'maça', '23/07/2020', 'DANI ', 'KG', '20.00', 10, '200.00', 0),
(75, 'MELANCIA', '23/07/2020', 'diego ltda', 'CX', '20.00', 30, '600.00', 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_fornecedores`
--

CREATE TABLE `tb_fornecedores` (
  `id_fornecedor` int(11) NOT NULL,
  `nome_fantasia` varchar(200) NOT NULL,
  `razao_social` varchar(200) NOT NULL,
  `CNPJ` varchar(30) NOT NULL,
  `endereço` varchar(200) NOT NULL,
  `bairro` varchar(200) NOT NULL,
  `município` varchar(200) NOT NULL,
  `uf` char(2) NOT NULL,
  `telefone` varchar(12) NOT NULL,
  `cel` varchar(12) NOT NULL,
  `email` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_fornecedores`
--

INSERT INTO `tb_fornecedores` (`id_fornecedor`, `nome_fantasia`, `razao_social`, `CNPJ`, `endereço`, `bairro`, `município`, `uf`, `telefone`, `cel`, `email`) VALUES
(10, 'DANI ', 'LTDA', '25555', 'RUA SAO JOAO', 'GGGGGG', 'GGGG', 'AP', '2222222', '2222222222', 'DANI@'),
(11, 'diego ltda', ' diego alimenticias', '3256589', 'rua  12', 'los angeles', 'barretos', 'SP', '33238695', '99198-6181', 'diegoribeirodematos@gmail.com'),
(12, 'kkkkkkkkkkkkk', 'kkkkkkkkkkkk', '888888888888', '8888888888', 'kkkkkkkkkkk', 'kkkkkkkkk', 'AC', '8888888888', '8888888888', 'kkkkkkkkkkkkkkkk'),
(13, 'mmmmmmmmmm', 'mmmmmmmmmm', '66666666', 'hhhhhhh', 'gggggggggg', 'gggggggggg', 'AP', '11111111111', '33333333', 'SSSSSSSSSSSSSS'),
(14, 'SSSSSSSSSSS', 'AAAAAAAAAA', 'AAAAAAAAAA', 'AAAAAA', 'AAAAAAAA', 'AAAAAAAA', 'AC', '3333333333', '4444444444', 'EEEEEEEEEEEEE');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_frete`
--

CREATE TABLE `tb_frete` (
  `cod` int(11) NOT NULL,
  `produto` varchar(200) NOT NULL,
  `unidade` varchar(50) NOT NULL,
  `quantidade` float NOT NULL,
  `data` varchar(20) NOT NULL DEFAULT current_timestamp(),
  `cliente` varchar(200) NOT NULL,
  `municipio` varchar(200) NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  `valor_total` decimal(10,2) NOT NULL,
  `local_entrega` varchar(200) NOT NULL,
  `observacao` varchar(200) NOT NULL,
  `total_fretes` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_frete`
--

INSERT INTO `tb_frete` (`cod`, `produto`, `unidade`, `quantidade`, `data`, `cliente`, `municipio`, `valor`, `valor_total`, `local_entrega`, `observacao`, `total_fretes`) VALUES
(11, 'cajamanga', '', 8, '10/10/2020', 'ddddddddddd', 'guaira', '50.00', '0.00', '', '', 0),
(12, 'abacate', '', 0, '10-10-2020', 'diego', 'colina', '100.00', '0.00', '', '', 0),
(13, 'goiaba', '10', 0, '10/17/2020', 'diego', 'guaira', '100.00', '0.00', '', '', 0),
(14, 'uva', 'CAIXA', 10, '12/12/2020', 'diego', 'colina', '200.00', '0.00', '', '', 0),
(15, 'morango', 'CAIXA', 30, '20-20-2020', 'ggggggggg', 'ddddddddd', '100.00', '0.00', '', '', 0),
(16, 'mamao', 'CAIXA', 10, '05-02-2020', 'ggggggggg', 'colina', '5.00', '50.00', 'rua sao salvador n 100', '', 0),
(17, 'caqui', 'CX', 20, '20-02-2020', 'ggggggggg', 'colombia', '5.00', '100.00', 'rua sao paulo n 10', '', 0),
(18, 'morango', 'CX', 10, '10-02-2020', 'ggggggggg', 'guaira', '5.00', '50.00', 'rua sao paulo', '', 0),
(19, 'ggggggggg', 'CX', 10, '10-10-2020', 'ggggggggg', 'colina', '12.00', '120.00', 'rua sao joao n 10', '', 0),
(20, 'caqui', 'CX', 30, '11/03/2020', 'RRRRRRRRRRRR', 'colombia', '20.00', '600.00', 'rua manaus n 200', '', 0),
(21, 'cebola', 'KG', 10, '15/03/2020', 'ggggggggg', 'colombia', '10.00', '100.00', 'rua sao joao', '', 0),
(22, 'qqqq', 'KG', 10, '19/03/2020', 'RRRRRRRRRRRR', 'qqqqqqqqq', '20.00', '200.00', 'jjjjjjjjjjjjj', '', 0),
(23, 'MANGA', 'CX', 100, '23/07/2020', 'ggggggggg', 'COLINA', '20.00', '2000.00', 'RUA COLINA 1000', '', 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_produto`
--

CREATE TABLE `tb_produto` (
  `cod` int(11) NOT NULL,
  `descricao` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_produto`
--

INSERT INTO `tb_produto` (`cod`, `descricao`) VALUES
(32, 'MORANGO'),
(35, 'manga'),
(36, 'mamao');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_vendas`
--

CREATE TABLE `tb_vendas` (
  `cod` int(11) NOT NULL,
  `nome_cliente` varchar(200) NOT NULL,
  `nome_produto` varchar(200) NOT NULL,
  `unidade` varchar(200) NOT NULL,
  `data` varchar(50) NOT NULL DEFAULT current_timestamp(),
  `valorunitario` decimal(10,0) NOT NULL,
  `quantidade` float NOT NULL,
  `preco` decimal(10,2) NOT NULL,
  `pagamento` varchar(50) NOT NULL,
  `observacao` varchar(100) NOT NULL,
  `total_vendas` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_vendas`
--

INSERT INTO `tb_vendas` (`cod`, `nome_cliente`, `nome_produto`, `unidade`, `data`, `valorunitario`, `quantidade`, `preco`, `pagamento`, `observacao`, `total_vendas`) VALUES
(67, 'ggggggggg', 'manga', 'CX', '23/07/2020', '10', 30, '900.00', 'À PRAZO', '', '0.00'),
(68, 'RRRRRRRRRRRR', 'MELANCIA', 'UN', '23/07/2020', '10', 2, '20.00', 'À PRAZO', '', '0.00');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD PRIMARY KEY (`cod`);

--
-- Índices para tabela `tb_compras`
--
ALTER TABLE `tb_compras`
  ADD PRIMARY KEY (`cod`);

--
-- Índices para tabela `tb_fornecedores`
--
ALTER TABLE `tb_fornecedores`
  ADD PRIMARY KEY (`id_fornecedor`);

--
-- Índices para tabela `tb_frete`
--
ALTER TABLE `tb_frete`
  ADD PRIMARY KEY (`cod`);

--
-- Índices para tabela `tb_produto`
--
ALTER TABLE `tb_produto`
  ADD PRIMARY KEY (`cod`);

--
-- Índices para tabela `tb_vendas`
--
ALTER TABLE `tb_vendas`
  ADD PRIMARY KEY (`cod`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_cliente`
--
ALTER TABLE `tb_cliente`
  MODIFY `cod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `tb_compras`
--
ALTER TABLE `tb_compras`
  MODIFY `cod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=76;

--
-- AUTO_INCREMENT de tabela `tb_fornecedores`
--
ALTER TABLE `tb_fornecedores`
  MODIFY `id_fornecedor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT de tabela `tb_frete`
--
ALTER TABLE `tb_frete`
  MODIFY `cod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT de tabela `tb_produto`
--
ALTER TABLE `tb_produto`
  MODIFY `cod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT de tabela `tb_vendas`
--
ALTER TABLE `tb_vendas`
  MODIFY `cod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=69;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
