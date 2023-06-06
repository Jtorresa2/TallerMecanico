-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: taller
-- ------------------------------------------------------
-- Server version	8.0.29

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
-- Table structure for table `auto`
--

DROP TABLE IF EXISTS `auto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `auto` (
  `idCliente` int NOT NULL AUTO_INCREMENT,
  `idServicio` varchar(30) NOT NULL,
  `Propietario` varchar(50) NOT NULL,
  `Marca` varchar(20) NOT NULL,
  `Color` varchar(20) NOT NULL,
  `Placa` varchar(10) NOT NULL,
  PRIMARY KEY (`idCliente`),
  KEY `idServicio_idx` (`idServicio`),
  KEY `idCliente_idx` (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `auto`
--

LOCK TABLES `auto` WRITE;
/*!40000 ALTER TABLE `auto` DISABLE KEYS */;
INSERT INTO `auto` VALUES (6,'271122-S1','1 1','1M','1C','1P'),(7,'271122-S2','Junior Santiago','2M','2C','2P'),(8,'271122-S3','SantiagoNombre JuniorApellido','3M','3C','3P'),(9,'271122-S4','1N 1A','4M','4C','4P'),(10,'271122-S5','Nombre APellido','5M','5C','5P'),(11,'271122-S6','2B 3C','6M','6C','6P'),(12,'271122-S7','2B 3C','7M','7C','7P'),(13,'271122-S8','B2 B3','8M','8C','8P'),(14,'271122-S9','NO AP','9M','9C','9P'),(17,'281122-S1','Junior Santiago Rodriguez Alvarez','Toyota','Gris','JSR-A03'),(23,'291122-S5','1 1','2','2','2'),(24,'291122-S6','1 1','PruebaM','PruebaC','PruebaP'),(25,'291122-S1','Juliana Torres Aaron','Chevrolet','Blanco','JSR-A03'),(27,'291122-S1','Luis Daniel Castellar Agamez','Toyota Blech','Negro','JSR-A03'),(28,'291122-S1','2 3','5','6','7');
/*!40000 ALTER TABLE `auto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bicicleta`
--

DROP TABLE IF EXISTS `bicicleta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bicicleta` (
  `idCliente` int NOT NULL AUTO_INCREMENT,
  `idServicio` varchar(30) NOT NULL,
  `Propietario` varchar(50) NOT NULL,
  `Marca` varchar(20) NOT NULL,
  `Color` varchar(20) NOT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bicicleta`
--

LOCK TABLES `bicicleta` WRITE;
/*!40000 ALTER TABLE `bicicleta` DISABLE KEYS */;
INSERT INTO `bicicleta` VALUES (1,'291122-S1','Nombre Apellido','Marca','Color'),(2,'291122-S1','Nombre1 APellido1','Renault','Gris'),(3,'291122-S2','1 1','1','1'),(4,'291122-S2','2 2','1','1'),(5,'291122-S3','Junior Santiago','1','1'),(6,'291122-S3','Junior Santiago','1','1'),(7,'291122-S4','Junior Santiago','1','1'),(8,'291122-S5','Junior Santiago','1','1'),(9,'291122-S5','Junior Santiago','1','1'),(10,'291122-S1','8 7','5','6');
/*!40000 ALTER TABLE `bicicleta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `idCliente` int NOT NULL AUTO_INCREMENT,
  `Cedula` varchar(10) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (6,'1','1','1','1'),(7,'1003','Junior','Santiago','301'),(8,'987CC','SantiagoNombre','JuniorApellido','301Tel'),(9,'1C','1N','1A','1T'),(10,'Cedula','Nombre','Apellido','Telefono'),(11,'1A','2B','3C','4D'),(12,'1A','2B','3C','4D'),(13,'B1','B2','B3','B4'),(14,'1234567890','NO','AP','3102345678'),(17,'1003379696','Junior Santiago','Rodriguez Alvarez','3015159004'),(24,'1|11','1','1','1'),(25,'1065576890','Juliana','Torres Aaron','3015159005'),(27,'1003567890','Luis Daniel','Castellar Agamez','3012345678'),(28,'1','2','3','4');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientebicicleta`
--

DROP TABLE IF EXISTS `clientebicicleta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientebicicleta` (
  `idCliente` int NOT NULL AUTO_INCREMENT,
  `Cedula` varchar(10) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Apellido` varchar(50) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientebicicleta`
--

LOCK TABLES `clientebicicleta` WRITE;
/*!40000 ALTER TABLE `clientebicicleta` DISABLE KEYS */;
INSERT INTO `clientebicicleta` VALUES (1,'Cedula','Nombre','Apellido','Telefono'),(2,'Cedula1','Nombre1','Apellido1','Telefono1'),(3,'1','1','1','1'),(4,'2','2','2','2'),(5,'1003','Junior','Santiago','301'),(6,'1003','Junior','Santiago','301'),(7,'1003','Junior','Santiago','301'),(8,'1003','Junior','Santiago','301'),(9,'1003','Junior','Santiago','301'),(10,'9','8','7','6');
/*!40000 ALTER TABLE `clientebicicleta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientemoto`
--

DROP TABLE IF EXISTS `clientemoto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientemoto` (
  `idCliente` int NOT NULL AUTO_INCREMENT,
  `cedula` varchar(45) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `apellido` varchar(45) NOT NULL,
  `telefono` varchar(45) NOT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientemoto`
--

LOCK TABLES `clientemoto` WRITE;
/*!40000 ALTER TABLE `clientemoto` DISABLE KEYS */;
INSERT INTO `clientemoto` VALUES (1,'CedulaMoto','NombreMoto','ApellidoMoto','TelefonoMoto'),(2,'1','1','1','1'),(3,'1003','Juliana','Torre','301'),(4,'A','B','C','D');
/*!40000 ALTER TABLE `clientemoto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mecanico`
--

DROP TABLE IF EXISTS `mecanico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mecanico` (
  `idMecanico` varchar(10) NOT NULL,
  `CedulaMecanico` varchar(10) NOT NULL,
  `NombreMecanico` varchar(45) NOT NULL,
  `ApellidoMecanico` varchar(45) NOT NULL,
  PRIMARY KEY (`idMecanico`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mecanico`
--

LOCK TABLES `mecanico` WRITE;
/*!40000 ALTER TABLE `mecanico` DISABLE KEYS */;
INSERT INTO `mecanico` VALUES ('M1','1003123456','Junior','Rodriguez'),('M2','1015123789','Juliana','Torres'),('M3','1015123444','Luis','Pinto'),('M4','1065789456','Nayid','Castellar'),('M5','79865789	','Steven','Molina');
/*!40000 ALTER TABLE `mecanico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `moto`
--

DROP TABLE IF EXISTS `moto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `moto` (
  `idCliente` int NOT NULL AUTO_INCREMENT,
  `idServicio` varchar(30) NOT NULL,
  `Propietario` varchar(50) NOT NULL,
  `Marca` varchar(30) NOT NULL,
  `Color` varchar(20) NOT NULL,
  `Placa` varchar(10) NOT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `moto`
--

LOCK TABLES `moto` WRITE;
/*!40000 ALTER TABLE `moto` DISABLE KEYS */;
INSERT INTO `moto` VALUES (1,'291122-S1','1 1','1','1','1'),(2,'291122-S1','1 1','2','2','2'),(3,'291122-S2','Juliana Torre','Chevrolet','Negro','123-ABC'),(4,'291122-S1','B C','E','F','G');
/*!40000 ALTER TABLE `moto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servicio`
--

DROP TABLE IF EXISTS `servicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `servicio` (
  `NumSubServicio` int NOT NULL AUTO_INCREMENT,
  `IdServicio` varchar(30) NOT NULL,
  `IdMecanico` varchar(10) NOT NULL,
  `NombreServicio` varchar(50) NOT NULL,
  `Precio` double NOT NULL,
  PRIMARY KEY (`NumSubServicio`)
) ENGINE=InnoDB AUTO_INCREMENT=176 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicio`
--

LOCK TABLES `servicio` WRITE;
/*!40000 ALTER TABLE `servicio` DISABLE KEYS */;
INSERT INTO `servicio` VALUES (134,'271122-S1','M1','Ajustes del Borner',530540),(135,'271122-S1','M1','Ajustes del Borner',530540),(136,'271122-S1','M1','Ajustes del Borner',530540),(137,'271122-S2','M1','Ajustes del Borner',530540),(138,'271122-S2','M1','Ajustes del Borner',530540),(139,'271122-S3','M1','Ajustes del Borner',530540),(140,'271122-S4','M1','Ajustes del Borner',530540),(141,'271122-S5','M1','Ajustes del Borner',530540),(142,'271122-S6','M2','Ajuste del Moto',140),(143,'271122-S7','M1','Limpieza',1200000),(144,'271122-S8','M3','Pintar',567099),(145,'271122-S9','M4','Ajuste del Motor',120),(149,'281122-S1','M1','Ajustes del Borner',530540),(150,'281122-S1','M2','Ajustes del Motor',150000),(151,'281122-S1','M3','Ajuste del tiempo de encendido',25000),(152,'281122-S1','M4','Cambio de Aceite y Filtro',13000),(153,'281122-S1','M5','Limpieza o Cambio del filtro de aire',152000),(154,'291122-S1','M1','Ajustes del Borner',530540),(155,'291122-S1','M2','Ajustes del Motor',150000),(156,'291122-S1','M3','Ajuste del tiempo de encendido',25000),(157,'291122-S1','M2','Ajustes del Motor',150000),(158,'291122-S2','M1','Ajustes del Borner',530540),(159,'291122-S3','M1','Ajustes del Borner',530540),(160,'291122-S4','M1','Ajustes del Borner',530540),(161,'291122-S5','M1','Ajustes del Borner',530540),(162,'291122-S6','M1','Ajustes del Borner',530540),(163,'291122-S1','M1','Ajustes del Borner',530540),(164,'291122-S1','M2','Ajustes del Motor',150000),(165,'291122-S1','M3','Ajuste del tiempo de encendido',25000),(171,'291122-S1','M1','Lavado',15000),(172,'291122-S1','M2','Mantenimiento',150000),(173,'291122-S1','M1','Ajustes del Borner',530540),(174,'291122-S1','M2','Ajustes del Motor',150000),(175,'291122-S1','M1','Ajustes del Borner',530540);
/*!40000 ALTER TABLE `servicio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `serviciobicicleta`
--

DROP TABLE IF EXISTS `serviciobicicleta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `serviciobicicleta` (
  `NumSubServicio` int NOT NULL AUTO_INCREMENT,
  `idServicio` varchar(30) NOT NULL,
  `idMecanico` varchar(10) NOT NULL,
  `NombreServicio` varchar(50) NOT NULL,
  `Precio` double NOT NULL,
  PRIMARY KEY (`NumSubServicio`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `serviciobicicleta`
--

LOCK TABLES `serviciobicicleta` WRITE;
/*!40000 ALTER TABLE `serviciobicicleta` DISABLE KEYS */;
INSERT INTO `serviciobicicleta` VALUES (1,'291122-S1','M1','Lavado',15000),(2,'291122-S1','M1','Lavado',15000),(3,'291122-S1','M2','Mantenimiento',150000),(4,'291122-S2','M5','Pinchazo',1300),(5,'291122-S3','M3','Revisión General',211000),(6,'291122-S4','M1','Lavado',15000),(7,'291122-S5','M1','Lavado',15000),(8,'291122-S5','M2','Mantenimiento',150000),(9,'291122-S1','M2','Cambio de Aceite',23000),(10,'291122-S1','M2','Mantenimiento',150000);
/*!40000 ALTER TABLE `serviciobicicleta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `serviciomoto`
--

DROP TABLE IF EXISTS `serviciomoto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `serviciomoto` (
  `NumSubServicio` int NOT NULL AUTO_INCREMENT,
  `idServicio` varchar(45) NOT NULL,
  `idMecanico` varchar(45) NOT NULL,
  `NombreServicio` varchar(45) NOT NULL,
  `Precio` double NOT NULL,
  PRIMARY KEY (`NumSubServicio`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `serviciomoto`
--

LOCK TABLES `serviciomoto` WRITE;
/*!40000 ALTER TABLE `serviciomoto` DISABLE KEYS */;
INSERT INTO `serviciomoto` VALUES (1,'291122-S1','M5','Revisión de los neumáticos',38000),(2,'291122-S1','M1','Ajuste del Nivel de la suspensión',15700),(3,'291122-S1','M2','Cambio de Aceite',23000),(4,'291122-S1','M4','Lavado General',530000),(5,'291122-S1','M3','Limpieza de filtros',152000),(6,'291122-S1','M5','Mantenimiento de frenos',150000),(7,'291122-S2','M1','Ajuste del Nivel de la suspensión',15700),(8,'291122-S1','M1','Ajuste del Nivel de la suspensión',15700);
/*!40000 ALTER TABLE `serviciomoto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-29 17:00:05
