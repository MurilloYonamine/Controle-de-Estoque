CREATE DATABASE  IF NOT EXISTS `bd_controle` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `bd_controle`;
-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bd_controle
-- ------------------------------------------------------
-- Server version	8.0.33

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tb_categoria`
--

DROP TABLE IF EXISTS `tb_categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_categoria` (
  `categoria_id` int NOT NULL AUTO_INCREMENT,
  `categoria_nome` varchar(30) NOT NULL,
  `categoria_descricao` varchar(100) NOT NULL,
  PRIMARY KEY (`categoria_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_categoria`
--

LOCK TABLES `tb_categoria` WRITE;
/*!40000 ALTER TABLE `tb_categoria` DISABLE KEYS */;
INSERT INTO `tb_categoria` VALUES (1,'Smartphones','Dispositivos móveis inteligentes.'),(2,'Computadores','Computadores de mesa, laptops e notebooks.'),(3,'Periféricos','Acessórios e dispositivos periféricos para computadores.'),(4,'TVs e Monitores','Televisões e monitores de alta definição.'),(5,'Áudio e Vídeo','Equipamentos de áudio e vídeo para entretenimento.'),(6,'Gadgets','Dispositivos eletrônicos e gadgets inovadores.'),(7,'Componentes Eletrônicos','Peças e componentes para montagem e reparo.'),(8,'Acessórios','Acessórios eletrônicos e tecnológicos.'),(9,'Câmeras','Câmeras fotográficas e de vídeo.'),(10,'Jogos Eletrônicos','Jogos e consoles de videogame.');
/*!40000 ALTER TABLE `tb_categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cliente`
--

DROP TABLE IF EXISTS `tb_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_cliente` (
  `cliente_id` int NOT NULL AUTO_INCREMENT,
  `cliente_nome` varchar(30) NOT NULL,
  `cliente_email` varchar(30) NOT NULL,
  `cliente_telefone` varchar(9) NOT NULL,
  `cliente_endereco` varchar(30) NOT NULL,
  PRIMARY KEY (`cliente_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cliente`
--

LOCK TABLES `tb_cliente` WRITE;
/*!40000 ALTER TABLE `tb_cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_fornecedor`
--

DROP TABLE IF EXISTS `tb_fornecedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_fornecedor` (
  `fornecedor_id` int NOT NULL AUTO_INCREMENT,
  `fornecedor_nome` varchar(50) NOT NULL,
  `fornecedor_contato` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`fornecedor_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_fornecedor`
--

LOCK TABLES `tb_fornecedor` WRITE;
/*!40000 ALTER TABLE `tb_fornecedor` DISABLE KEYS */;
INSERT INTO `tb_fornecedor` VALUES (1,'Tech Supplies','(123) 456-7890'),(2,'ElectroTech','(987) 654-3210'),(3,'Gadget World','(555) 123-4567'),(4,'Digital Solutions','(222) 333-4444'),(5,'E-Tech Enterprises','(777) 888-9999'),(6,'Tech Innovators','(111) 222-3333'),(7,'Cybertronics','(444) 555-6666'),(8,'ElecTech Solutions','(888) 999-0000'),(9,'Smart Devices Inc.','(777) 111-2222'),(10,'ElectroGizmos','(333) 444-5555');
/*!40000 ALTER TABLE `tb_fornecedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_historico`
--

DROP TABLE IF EXISTS `tb_historico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_historico` (
  `historico_id` int NOT NULL AUTO_INCREMENT,
  `historico_movimentacao` int NOT NULL,
  `historico_usuario` int NOT NULL,
  `historico_data` date NOT NULL,
  PRIMARY KEY (`historico_id`),
  KEY `historico_movimentacao` (`historico_movimentacao`),
  KEY `historico_usuario` (`historico_usuario`),
  CONSTRAINT `tb_historico_ibfk_1` FOREIGN KEY (`historico_movimentacao`) REFERENCES `tb_movimentacao_estoque` (`movimentacao_id`),
  CONSTRAINT `tb_historico_ibfk_2` FOREIGN KEY (`historico_usuario`) REFERENCES `tb_usuario` (`usuario_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_historico`
--

LOCK TABLES `tb_historico` WRITE;
/*!40000 ALTER TABLE `tb_historico` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_historico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_item_pedido`
--

DROP TABLE IF EXISTS `tb_item_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_item_pedido` (
  `item_id` int NOT NULL AUTO_INCREMENT,
  `item_pedido` int NOT NULL,
  `item_produto` int NOT NULL,
  `item_quantidade` int NOT NULL,
  `item_preco` decimal(10,0) NOT NULL,
  PRIMARY KEY (`item_id`),
  KEY `item_pedido` (`item_pedido`),
  KEY `item_produto` (`item_produto`),
  CONSTRAINT `tb_item_pedido_ibfk_1` FOREIGN KEY (`item_pedido`) REFERENCES `tb_pedido` (`pedido_id`),
  CONSTRAINT `tb_item_pedido_ibfk_2` FOREIGN KEY (`item_produto`) REFERENCES `tb_produto` (`produto_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_item_pedido`
--

LOCK TABLES `tb_item_pedido` WRITE;
/*!40000 ALTER TABLE `tb_item_pedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_item_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_movimentacao_estoque`
--

DROP TABLE IF EXISTS `tb_movimentacao_estoque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_movimentacao_estoque` (
  `movimentacao_id` int NOT NULL AUTO_INCREMENT,
  `movimentacao_produto` int NOT NULL,
  `movimentacao_tipo` varchar(15) DEFAULT NULL,
  `movimentacao_quantidade` int NOT NULL,
  `movimentacao_data` date NOT NULL,
  PRIMARY KEY (`movimentacao_id`),
  KEY `movimentacao_produto` (`movimentacao_produto`),
  CONSTRAINT `tb_movimentacao_estoque_ibfk_1` FOREIGN KEY (`movimentacao_produto`) REFERENCES `tb_produto` (`produto_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_movimentacao_estoque`
--

LOCK TABLES `tb_movimentacao_estoque` WRITE;
/*!40000 ALTER TABLE `tb_movimentacao_estoque` DISABLE KEYS */;
INSERT INTO `tb_movimentacao_estoque` VALUES (1,5,'Saída',1,'2023-05-28'),(2,8,'Saída',-5,'2023-05-28'),(3,10,'Saída',-5,'2023-05-28'),(4,9,'Entrada',5,'2023-05-28'),(5,10,'Entrada',4,'2023-05-28');
/*!40000 ALTER TABLE `tb_movimentacao_estoque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pedido`
--

DROP TABLE IF EXISTS `tb_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_pedido` (
  `pedido_id` int NOT NULL AUTO_INCREMENT,
  `pedido_cliente` int NOT NULL,
  `pedido_data` date NOT NULL,
  `pedido_total` decimal(10,0) NOT NULL,
  PRIMARY KEY (`pedido_id`),
  KEY `pedido_cliente` (`pedido_cliente`),
  CONSTRAINT `tb_pedido_ibfk_1` FOREIGN KEY (`pedido_cliente`) REFERENCES `tb_cliente` (`cliente_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pedido`
--

LOCK TABLES `tb_pedido` WRITE;
/*!40000 ALTER TABLE `tb_pedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_produto`
--

DROP TABLE IF EXISTS `tb_produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_produto` (
  `produto_id` int NOT NULL AUTO_INCREMENT,
  `produto_nome` varchar(50) NOT NULL,
  `produto_descricao` varchar(60) DEFAULT NULL,
  `produto_preco` decimal(65,2) NOT NULL,
  `produto_codigo_barras` varchar(13) NOT NULL,
  `produto_quantidade` int DEFAULT NULL,
  `produto_fornecedor` int DEFAULT NULL,
  `produto_categoria` int NOT NULL,
  PRIMARY KEY (`produto_id`),
  KEY `produto_fornecedor` (`produto_fornecedor`),
  KEY `produto_categoria` (`produto_categoria`),
  CONSTRAINT `tb_produto_ibfk_1` FOREIGN KEY (`produto_fornecedor`) REFERENCES `tb_fornecedor` (`fornecedor_id`),
  CONSTRAINT `tb_produto_ibfk_2` FOREIGN KEY (`produto_categoria`) REFERENCES `tb_categoria` (`categoria_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_produto`
--

LOCK TABLES `tb_produto` WRITE;
/*!40000 ALTER TABLE `tb_produto` DISABLE KEYS */;
INSERT INTO `tb_produto` VALUES (1,'Laptop Dell XPS 13','Processador i7, 16GB RAM, SSD 512GB',5499.99,'7891234567890',1,1,1),(2,'Smartphone Samsung Galaxy S21','Tela AMOLED, Snapdragon 888, 128GB',3999.99,'8901234567891',5,2,1),(3,'Tablet Apple iPad Air','Chip A14 Bionic, 64GB, Tela Retina',3199.99,'9012345678902',5,3,1),(4,'Fone de Ouvido Sony WH-1000XM4','Cancelamento de ruído, Bluetooth',1499.99,'0123456789013',5,4,2),(5,'Monitor LG Ultrawide 34\"','Resolução 3440x1440, 75Hz',2199.99,'1234567890124',4,5,1),(6,'Câmera Canon EOS Rebel T7i','Sensor 24.2MP, Gravação em Full HD',2999.99,'2345678901235',5,6,1),(7,'Teclado Mecânico Corsair K70','Switches Cherry MX Red, Retroiluminado',499.99,'3456789012346',5,7,3),(8,'Roteador TP-Link Archer C9','Dual Band AC1900, Gigabit Ethernet',299.99,'4567890123457',0,8,4),(9,'Mouse Logitech G502','Sensor Hero 16K, 11 Botões Programáveis',199.99,'5678901234568',10,9,3),(10,'Headset HyperX Cloud II','Áudio 7.1 Virtual Surround, Microfone Removível',399.99,'6789012345679',4,10,2);
/*!40000 ALTER TABLE `tb_produto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_usuario`
--

DROP TABLE IF EXISTS `tb_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_usuario` (
  `usuario_id` int NOT NULL AUTO_INCREMENT,
  `usuario_nome` varchar(50) NOT NULL,
  `usuario_nome_social` varchar(50) DEFAULT NULL,
  `usuario_email` varchar(30) NOT NULL,
  `usuario_senha` varchar(20) NOT NULL,
  `usuario_tipo` varchar(20) NOT NULL,
  `usuario_registro` date DEFAULT NULL,
  PRIMARY KEY (`usuario_id`),
  UNIQUE KEY `usuario_email` (`usuario_email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_usuario`
--

LOCK TABLES `tb_usuario` WRITE;
/*!40000 ALTER TABLE `tb_usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-30  8:48:57
