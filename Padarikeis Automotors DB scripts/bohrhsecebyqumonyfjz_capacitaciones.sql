CREATE DATABASE  IF NOT EXISTS `bohrhsecebyqumonyfjz` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `bohrhsecebyqumonyfjz`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: bohrhsecebyqumonyfjz-mysql.services.clever-cloud.com    Database: bohrhsecebyqumonyfjz
-- ------------------------------------------------------
-- Server version	8.0.15-5

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
SET @MYSQLDUMP_TEMP_LOG_BIN = @@SESSION.SQL_LOG_BIN;
SET @@SESSION.SQL_LOG_BIN= 0;

--
-- GTID state at the beginning of the backup 
--

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ 'f41d366d-91e5-11e9-8525-cecd028ee826:1-126056988';

--
-- Table structure for table `capacitaciones`
--

DROP TABLE IF EXISTS `capacitaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `capacitaciones` (
  `capacitacion_id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `imagen` varchar(255) NOT NULL,
  `texto` varchar(500) NOT NULL,
  PRIMARY KEY (`capacitacion_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `capacitaciones`
--

LOCK TABLES `capacitaciones` WRITE;
/*!40000 ALTER TABLE `capacitaciones` DISABLE KEYS */;
INSERT INTO `capacitaciones` VALUES (1,'Capacitación sobre lubricantes','/assets/img/Lubricante1.jpeg','Charla que para una formación fundamental en lubricantes industriales y maquinaria de toma de muestras de aceite. Dirigido en definir el marco de competencia de la lubricación en planta, diseño de prácticas adecuadas, así como el control de las tareas y mejoras aplicadas. Trata temas como el análisis de partículas de desgaste, los fundamentos de desgaste de la máquina, de lubricación, análisis de la degradación del lubricante y el desarrollo y gestión de programas de análisis de aceite.'),(2,'Charla de salud ocupacional','/assets/img/charlaocupacional.jpg','Un taller de reparación de automóviles es un espacio de trabajo donde la naturaleza de la actividad y el manejo de herramientas y maquinaria pesada, entre otros, puede exponer al trabajador a riesgos para su seguridad. Algunos de los más frecuentes son golpes, cortes, caídas, quemaduras, contacto con sustancias peligrosas e incluso sobreesfuerzos.'),(3,'Charla sobre la importancia de los lubricantes','/assets/img/Lubricantes.jpg','Siempre debemos tomar en cuenta que en las charla de importacia de lubricantes tomamos como primer punto la contaminación que hay en las calles, el lubricante actúa como un agente limpiador, removiendo contaminantes que pueden limitar el desempeño de tu motor si llegan a acumularse en grandes cantidades. El sistema de lubricación de tu vehículo lo mantiene refrigerado.'),(4,'Charla sobre la seguridad laboral','/assets/img/seguridad.jpg','La seguridad y salud laboral es un área multidisciplinar relacionada con la seguridad, salud y la calidad de vida de las personas en la ocupación. La seguridad y salud ocupacionales también protege toda persona que pueda verse afectada por el ambiente ocupacional.');
/*!40000 ALTER TABLE `capacitaciones` ENABLE KEYS */;
UNLOCK TABLES;
SET @@SESSION.SQL_LOG_BIN = @MYSQLDUMP_TEMP_LOG_BIN;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-02-22 21:34:08
