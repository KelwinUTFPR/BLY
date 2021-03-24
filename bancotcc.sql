-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.1.36-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para tcc
CREATE DATABASE IF NOT EXISTS `tcc` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `tcc`;

-- Copiando estrutura para tabela tcc.corpo
CREATE TABLE IF NOT EXISTS `corpo` (
  `codigo_corpo` int(11) NOT NULL AUTO_INCREMENT,
  `titulo_corpo` varchar(50) DEFAULT NULL,
  `texto_corpo` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`codigo_corpo`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela tcc.corpo: ~12 rows (aproximadamente)
/*!40000 ALTER TABLE `corpo` DISABLE KEYS */;
INSERT INTO `corpo` (`codigo_corpo`, `titulo_corpo`, `texto_corpo`) VALUES
	(2, 'Consulta de horários', 'Consulte horários disponíveis e compre passagens online aqui!'),
	(3, 'Horários', 'Consulte todos os horários disponiveis.'),
	(4, 'Monitoramento em tempo real', 'Permite que o usuário acompanhe o trajeto em tempo real de seu transporte, vendo os pontos por quais o onibûs passou. '),
	(5, 'QRcode', 'O usuário só precisa abrir o aplicativo, ler o código na catraca e o saldo será descontado da conta. Sem o uso do cartão.'),
	(6, 'Compra de passagens online', 'Permite que o usuário compre sua passsagem sem ter que sair de casa, só escolher o destino, horário e embarcar.'),
	(7, 'Consulta de itinerários', 'Exibe todos os preços de passagens em relação as rotas, com todos os valores 100% atualizados e confiáveis.'),
	(8, 'Consulta de horários', 'Exibe todos os horários disponiveis em qualquer outro dia da semana, mostrando as excessões de domingos e feriados. '),
	(9, 'Recarga online', 'Permite que o usuário insira saldo em sua conta sem precisar sair de casa, através de cartões de crédito ou boleto.'),
	(10, 'Qual a situação atual dos usuários de onibûs?', 'Uma pesquisa feita na ETEC de Registro (instituição que abrange alunos de vários municípios do Vale do Ribeira), contou com a participação de 216 pessoas resultou nos seguintes percentuais:'),
	(11, 'Usuários frequentes (135 pessoas)', ' <blockquote>Cerca de 105 (79.3%) dos entrevistados relataram já ter perdido o horário de seu ônibus uma ou mais de uma vez.</blockquote>\r\n<blockquote>Cerca de 118 (87.4%) dos entrevistados já passaram, ou presenciaram alguém com problemas, no cartão ou na hora de passar na catraca.</blockquote>\r\n<blockquote>Cerca de 91 (67.4%) dos entrevistados relataram ter chego no ponto na hora exata e seu ônibus já tinha passado.</blockquote>'),
	(12, 'Usuários não frequentes (81 pessoas)', '<blockquote>Cerca de 65 (80.2%) dos entrevistados já ouviram algúem dizer que chegou no ponto na hora exata e o ônibus já tinha passado.</blockquote>\r\n<blockquote>Cerca de 55(67.9%) dos entrevistados conhecem pessoas que perdem o horário de ônibus com frequência.</blockquote>\r\n<blockquote>Cerca de 46 (56.8%) dos entrevistados já ouviram algúem reclamando do sistema de pagamento utilizado nos ônibus.</blockquote>'),
	(13, 'Conheça o Bly ', 'O aplicativo consiste em fazer com que os usuários do transporte viário observem em tempo real o trajeto do ônibus desejado, recarregue sua conta, consulte rotas, horários e preços. Além de permitir ao usuário passar pela catraca utilizando seu smartphone, através de um QRcode.\r\nComo melhorar o transporte público viário através da tecnologia?\r\n           A correria da rotina das pessoas diariamente resulta em atrasos, seja por jovens, adultos, idosos etc... Um simples atraso pode resultar na perda de uma prova importante, de uma consulta que demorou meses para ser marcada ou até mesmo em um dia de trabalho. O projeto foi pensado para evitar percas de horários, permitir ao usuário (a distância) e inovar a forma de pagamento nas catracas, que atualmente é via cartão, o projeto sugere um QRcode, que seria mais eficiente, rápido e prático. \r\n');
/*!40000 ALTER TABLE `corpo` ENABLE KEYS */;

-- Copiando estrutura para tabela tcc.login
CREATE TABLE IF NOT EXISTS `login` (
  `Login_Email` varchar(150) NOT NULL,
  `Login_Senha` varchar(150) DEFAULT NULL,
  `Saldo_Cod` int(11) NOT NULL AUTO_INCREMENT,
  `Usu_Cod` int(11) DEFAULT NULL,
  PRIMARY KEY (`Login_Email`),
  KEY `FK_login_saldo` (`Saldo_Cod`),
  KEY `FK_login_usuario` (`Usu_Cod`),
  CONSTRAINT `FK_login_usuario` FOREIGN KEY (`Usu_Cod`) REFERENCES `usuario` (`Usuario_Codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela tcc.login: ~15 rows (aproximadamente)
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` (`Login_Email`, `Login_Senha`, `Saldo_Cod`, `Usu_Cod`) VALUES
	('123', '123', 26, 5),
	('@machaves', '12345', 22, 3),
	('Admin', 'Admin', 19, 4),
	('bly', '123', 1, 5),
	('Igo', '123', 23, 2),
	('igor.ferraz99@gmail.com', '123@mudar', 17, 5),
	('kelwin@gmail.com', '123', 21, 5),
	('kw', 'kw', 15, 5),
	('kw3', '123', 20, 5),
	('lolo', '123', 25, 5),
	('matheus@gmail.com', '1234', 18, 1),
	('qwe', 'qwe', 14, 5),
	('qwee', 'qwee', 13, 5),
	('ramon', '123', 16, 5),
	('seila', '12354', 24, 5);
/*!40000 ALTER TABLE `login` ENABLE KEYS */;

-- Copiando estrutura para tabela tcc.rota
CREATE TABLE IF NOT EXISTS `rota` (
  `codigo_rota` int(11) NOT NULL AUTO_INCREMENT,
  `local_saida` varchar(50) NOT NULL DEFAULT '0',
  `local_destino` varchar(50) NOT NULL DEFAULT '0',
  `horario_saida` varchar(50) NOT NULL,
  `horario_chegada` varchar(50) NOT NULL,
  `preco` double NOT NULL DEFAULT '0',
  `empresa` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codigo_rota`)
) ENGINE=InnoDB AUTO_INCREMENT=94 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela tcc.rota: ~93 rows (aproximadamente)
/*!40000 ALTER TABLE `rota` DISABLE KEYS */;
INSERT INTO `rota` (`codigo_rota`, `local_saida`, `local_destino`, `horario_saida`, `horario_chegada`, `preco`, `empresa`) VALUES
	(1, 'Pariquera-Açu', 'Jacupiranga', '05:40', '06:10', 6, 'Valle Sul'),
	(2, 'Pariquera-Açu', 'Jacupiranga', '06:45', '07:15', 6, 'Valle Sul'),
	(3, 'Pariquera-Açu', 'Jacupiranga', '08:35', '09:45', 6, 'Princesa dos Campos'),
	(4, 'Pariquera-Açu', 'Jacupiranga', '08:50', '09:20', 6, 'Valle Sul'),
	(5, 'Pariquera-Açu', 'Jacupiranga', '11:00', '11:20', 6, 'Valle Sul'),
	(6, 'Pariquera-Açu', 'Jacupiranga', '13:00', '13:30', 6, 'Valle Sul'),
	(7, 'Pariquera-Açu', 'Jacupiranga', '15:10', '15:40', 6, 'Valle Sul'),
	(8, 'Pariquera-Açu', 'Jacupiranga', '17:30', '18:00', 6, 'Valle Sul'),
	(9, 'Jacupiranga', 'Cajati', '06:25', '06:45', 3.1, 'Princesa dos Campos'),
	(10, 'Jacupiranga', 'Cajati', '07:05', '07:25', 3.3, 'Valle Sul'),
	(11, 'Jacupiranga', 'Cajati', '09:20', '09:40', 3.3, 'Valle Sul'),
	(12, 'Jacupiranga', 'Cajati', '11:20', '11:45', 3.3, 'Valle Sul'),
	(13, 'Jacupiranga', 'Cajati', '13:30', '13:50', 3.3, 'Valle Sul'),
	(14, 'Jacupiranga', 'Cajati', '13:30', '13:50', 3.1, 'Princesa dos Campos'),
	(15, 'Jacupiranga', 'Cajati', '17:50', '18:10', 3.3, 'Valle Sul'),
	(16, 'Jacupiranga', 'Cajati', '22:40', '23:00', 3.3, 'Valle Sul'),
	(17, 'Cajati', 'Jacupiranga', '05:55', '06:15', 3.3, 'Valle Sul'),
	(18, 'Cajati', 'Jacupiranga', '07:30', '07:50', 3.3, 'Valle Sul'),
	(19, 'Cajati', 'Jacupiranga', '09:45', '10:05', 3.3, 'Valle Sul'),
	(20, 'Cajati', 'Jacupiranga', '10:00', '10:20', 3.1, 'Princesa dos Campos'),
	(21, 'Cajati', 'Jacupiranga', '12:00', '12:20', 3.3, 'Valle Sul'),
	(22, 'Cajati', 'Jacupiranga', '15:00', '15:20', 3.1, 'Princesa dos Campos'),
	(23, 'Cajati', 'Jacupiranga', '15:45', '16:00', 3.3, 'Valle Sul'),
	(24, 'Cajati', 'Jacupiranga', '20:05', '20:25', 3.1, 'Princesa dos Campos'),
	(25, 'Cajati', 'Jacupiranga', '21:30', '21:50', 3.1, 'Princesa dos Campos'),
	(26, 'Cajati', 'Jacupiranga', '10:00', '11:00', 7.1, 'Valle Sul'),
	(27, 'Cajati', 'Jacupiranga', '15:00', '16:00', 7.1, 'Valle Sul'),
	(28, 'Registro', 'Pariquera-Açu', '06:00', '06:40', 6, 'Valle Sul'),
	(29, 'Registro', 'Pariquera-Açu', '14:00', '14:40', 6, 'Valle Sul'),
	(30, 'Registro', 'Pariquera-Açu', '08:00', '09:00', 6, 'Valle Sul'),
	(31, 'Registro', 'Registro', '08:20', '09:00', 6, 'Valle Sul'),
	(32, 'Registro', 'Pariquera-Açu', '08:35', '09:15', 6, 'Princesa dos Campos'),
	(33, 'Registro', 'Pariquera-Açu', '13:00', '13:30', 6, 'Valle Sul'),
	(34, 'Registro', 'Pariquera-Açu', '12:00', '12:40', 6, 'Valle Sul'),
	(35, 'Registro', 'Pariquera-Açu', '20:05', '21:05', 6, 'Valle Sul'),
	(36, 'Registro', 'Pariquera-Açu', '11:00', '11:40', 6, 'Valle Sul'),
	(37, 'Registro', 'Pariquera-Açu', '20:05', '21:05', 6, 'Valle Sul'),
	(38, 'Registro', 'Pariquera-Açu', '09:50', '10:40', 6, 'Valle Sul'),
	(39, 'Registro', 'Pariquera-Açu', '11:35', '12:15', 6, 'Valle Sul'),
	(40, 'Registro', 'Pariquera-Açu', '09:30', '10:00', 6, 'Valle Sul'),
	(41, 'Registro', 'Pariquera-Açu', '09:00', '09:40 ', 6, 'Valle Sul'),
	(42, 'Registro', 'Pariquera-Açu', '06:30', '07:10', 6, 'Valle Sul'),
	(43, 'Registro', 'Pariquera-Açu', '08:00', '08:40', 6, 'Valle Sul'),
	(44, 'Registro', 'Pariquera-Açu', '10:00', '10:40', 6, 'Valle Sul'),
	(45, 'Registro', 'Eldorado', '07:45', '08:45', 7.2, 'Valle Sul'),
	(46, 'Registro', 'Eldorado', '08:20', '09:20', 7.2, 'Valle Sul'),
	(47, 'Registro', 'Eldorado', '11:15', '12:15', 7.2, 'Valle Sul'),
	(48, 'Registro', 'Eldorado', '12:20', '13:20', 7.2, 'Valle Sul'),
	(49, 'Registro', 'Eldorado', '14:30', '15:40', 7.2, 'Valle Sul'),
	(50, 'Registro', 'Eldorado', '16:45', '17:50', 7.2, 'Valle Sul'),
	(51, 'Registro', 'Eldorado', '18:10', '19:30', 7.2, 'Valle Sul'),
	(52, 'Registro', 'Eldorado', '19:00', '20:00', 7.2, 'Valle Sul'),
	(53, 'Registro', 'Eldorado', '20:10', '21:10', 7.2, 'Valle Sul'),
	(54, 'Registro', 'Juquiá', '05:00', '05:30', 9.65, 'Valle Sul'),
	(55, 'Registro', 'Juquiá', '05:00', '05:30', 9.65, 'Valle Sul'),
	(56, 'Registro', 'Juquiá', '07:00', '07:30', 9.65, 'Valle Sul'),
	(57, 'Registro', 'Juquiá', '07:15', '07:45', 9.65, 'Valle Sul'),
	(58, 'Registro', 'Juquiá', '08:00', '08:30', 9.65, 'Valle Sul'),
	(59, 'Registro', 'Juquiá', '09:00', '09:30', 9.65, 'Valle Sul'),
	(60, 'Registro', 'Juquiá', '10:00', '10:30', 9.65, 'Valle Sul'),
	(61, 'Registro', 'Juquiá', '11:00', '11:30', 9.65, 'Valle Sul'),
	(62, 'Registro', 'Juquiá', '13:00', '13:30', 9.65, 'Valle Sul'),
	(63, 'Registro', 'Juquiá', '13:30', '14:00', 9.65, 'Valle Sul'),
	(64, 'Registro', 'Juquiá', '15:00', '15:30', 9.65, 'Valle Sul'),
	(65, 'Registro', 'Juquiá', '15:00', '15:30', 9.65, 'Valle Sul'),
	(66, 'Registro', 'Juquiá', '17:30', '18:00', 9.65, 'Valle Sul'),
	(67, 'Registro', 'Juquiá', '18:00', '18:30', 9.65, 'Valle Sul'),
	(68, 'Juquiá', 'Registro', '09:00', '09:30', 9, 'Valle Sul'),
	(69, 'Juquiá', 'Registro', '09:00', '09:30', 9, 'Valle Sul'),
	(70, 'Juquiá', 'Registro', '11:15', '11:45', 9, 'Valle Sul'),
	(71, 'Juquiá', 'Registro', '14:50', '15:20', 9, 'Valle Sul'),
	(72, 'Juquiá', 'Registro', '15:30', '16:00', 9, 'Valle Sul'),
	(73, 'Juquiá', 'Registro', '13:00', '13:30', 9, 'Valle Sul'),
	(74, 'Juquiá', 'Registro', '12:50', '13:20', 9, 'Valle Sul'),
	(75, 'Juquiá', 'Registro', '09:05', '09:35', 9, 'Valle Sul'),
	(76, 'Juquiá', 'Registro', '11:20', '11:50', 9, 'Valle Sul'),
	(77, 'Juquiá', 'Registro', '18:00', '18:30', 9, 'Valle Sul'),
	(78, 'Juquiá', 'Registro', '16:30', '17:00', 9, 'Valle Sul'),
	(79, 'Juquiá', 'Registro', '22:30', '23:00', 9, 'Valle Sul'),
	(80, 'Juquiá', 'Registro', '19:30', '20:00', 9, 'Valle Sul'),
	(81, 'Juquiá', 'Registro', '19:40', '20:10', 9, 'Valle Sul'),
	(82, 'Jacupiranga', 'Registro', '05:50', '06:45', 6, 'Valle Sul'),
	(83, 'Jacupiranga', 'Registro', '07:00', '07:45', 5.2, 'Princesa dos Campos'),
	(84, 'Jacupiranga', 'Registro', '07:05', '07:50', 5.2, 'Princesa dos Campos'),
	(85, 'Jacupiranga', 'Registro', '07:20', '08:05', 6, 'Valle Sul'),
	(86, 'Jacupiranga', 'Registro', '07:50', '08:35', 5.2, 'Princesa dos Campos'),
	(87, 'Jacupiranga', 'Registro', '08:30', '09:15', 5.2, 'Valle Sul'),
	(88, 'Jacupiranga', 'Registro', '10:00', '10:45', 5.2, 'Princesa dos Campos'),
	(89, 'Jacupiranga', 'Registro', '11:00', '11:45', 5.2, 'Princesa dos Campos'),
	(90, 'Jacupiranga', 'Registro', '13:30', '14:15', 5.2, 'Princesa dos Campos'),
	(91, 'Jacupiranga', 'Registro', '14:30', '15:15', 6, 'Valle Sul'),
	(92, 'Jacupiranga', 'Registro', '16:00', '16:45', 5.2, 'Princesa dos Campos'),
	(93, 'Cajati', 'Jacupiranga', '08:00', '08:20', 5, 'Valle Sul');
/*!40000 ALTER TABLE `rota` ENABLE KEYS */;

-- Copiando estrutura para tabela tcc.saldo
CREATE TABLE IF NOT EXISTS `saldo` (
  `Saldo_Codigo` int(11) NOT NULL AUTO_INCREMENT,
  `Saldo_Valor` double DEFAULT NULL,
  `Saldo_Passar` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Saldo_Codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela tcc.saldo: ~15 rows (aproximadamente)
/*!40000 ALTER TABLE `saldo` DISABLE KEYS */;
INSERT INTO `saldo` (`Saldo_Codigo`, `Saldo_Valor`, `Saldo_Passar`) VALUES
	(1, 150, '0'),
	(13, 10, '0'),
	(14, 55, '0'),
	(15, 21, '0'),
	(16, 50, '0'),
	(17, 0, '0'),
	(18, 0, '0'),
	(19, 10, '0'),
	(20, 10, '0'),
	(21, 10, '0'),
	(22, 0, '0'),
	(23, 0, '0'),
	(24, 15, '0'),
	(25, 0, '0'),
	(26, 0, '0');
/*!40000 ALTER TABLE `saldo` ENABLE KEYS */;

-- Copiando estrutura para tabela tcc.suporte
CREATE TABLE IF NOT EXISTS `suporte` (
  `Suporte_Codigo` int(11) NOT NULL AUTO_INCREMENT,
  `Suporte_Nome_Usuario` varchar(50) DEFAULT NULL,
  `Suporte_Mensagem` varchar(50) DEFAULT NULL,
  `Suporte_Email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Suporte_Codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela tcc.suporte: ~6 rows (aproximadamente)
/*!40000 ALTER TABLE `suporte` DISABLE KEYS */;
INSERT INTO `suporte` (`Suporte_Codigo`, `Suporte_Nome_Usuario`, `Suporte_Mensagem`, `Suporte_Email`) VALUES
	(1, 'sad', 'afaags', 'matheus@gmail.com'),
	(2, 'sad', 'asfhgfsqa', 'matheus@gmail.com'),
	(3, 'sad', 'afgagfa', 'mazinho.matheus72@gmail.com'),
	(4, 'sad', 'afbtyju', 'mazinho.matheus72@gmail.com'),
	(5, 'asddsa', 'hiudhfahiu', 'matheus@gmail.com'),
	(6, 'sasa', 'asohiufgiueahf', 'matheus72@gmail.com');
/*!40000 ALTER TABLE `suporte` ENABLE KEYS */;

-- Copiando estrutura para tabela tcc.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `Usuario_Codigo` int(11) NOT NULL AUTO_INCREMENT,
  `Usuario_Nome` varchar(50) DEFAULT NULL,
  `Usuario_Nascimento` date DEFAULT NULL,
  `Usuario_Tipo` varchar(50) DEFAULT NULL,
  `Usuario_CPF` varchar(50) DEFAULT NULL,
  `Usuario_Foto` varchar(50) NOT NULL DEFAULT '0',
  `Usuario_CodLogin` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Usuario_Codigo`),
  KEY `Usuario_CodLogin` (`Usuario_CodLogin`),
  CONSTRAINT `CodLogin` FOREIGN KEY (`Usuario_CodLogin`) REFERENCES `login` (`Login_Email`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela tcc.usuario: ~5 rows (aproximadamente)
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` (`Usuario_Codigo`, `Usuario_Nome`, `Usuario_Nascimento`, `Usuario_Tipo`, `Usuario_CPF`, `Usuario_Foto`, `Usuario_CodLogin`) VALUES
	(1, 'Matheus Chaves', '2019-06-05', 'Estudante', '415151', 'avatar', 'matheus@gmail.com'),
	(2, 'Igor Ferraz', '2019-06-05', 'Estudante', '1651621651', 'avatar', 'Igo'),
	(3, 'Matheus Alves Chaves', '2019-10-06', 'Empresa', '1889498', 'bostahahahahahah', '@machaves'),
	(4, 'Administrador', '2019-10-06', 'Suporte', 'Admin', 'avatar', 'Admin'),
	(5, 'bly', '2019-10-09', 'bly', 'bly', 'bly', 'bly');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
