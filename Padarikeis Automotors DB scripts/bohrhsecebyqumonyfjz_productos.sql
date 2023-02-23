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

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ 'f41d366d-91e5-11e9-8525-cecd028ee826:1-126056987';

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `producto_id` int(11) NOT NULL AUTO_INCREMENT,
  `imagen` varchar(255) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `precio` double(5,2) NOT NULL,
  `categoria_producto_id` int(11) NOT NULL,
  PRIMARY KEY (`producto_id`),
  KEY `fk_productos_categoria_productos` (`categoria_producto_id`),
  CONSTRAINT `fk_productos_categoria_productos` FOREIGN KEY (`categoria_producto_id`) REFERENCES `categoria_productos` (`categoria_producto_id`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'/assets/img/Sor1.webp','Cilindro Hidráulico',89.95,1),(2,'/assets/img/Sor2.png','Tapa de Airbag HG270',25.15,1),(3,'/assets/img/Sor3.webp','Cinta Airbag Nissan Tiida',20.55,1),(4,'/assets/img/Sor4.webp','Aros de Pistón ISUZU',79.95,1),(5,'/assets/img/Sor5.webp','Bujía Spark Plug RC12YC',79.99,1),(6,'/assets/img/Sor6.webp','Anillos de Motor GB25RC',54.93,1),(7,'/assets/img/Sor7.jpg','Cigueñal de Motor',91.50,1),(8,'/assets/img/Sor8.webp','Mandos IA para Volante Kia',18.20,1),(9,'/assets/img/Sor9.jpg','Sensor Maf Lambda',27.95,1),(10,'/assets/img/Sor10.webp','Termostato Refrigerante Ford 2017',45.78,1),(11,'/assets/img/Sor11.webp','Cinta de Bocina Espiral',31.65,1),(12,'/assets/img/Sor12.webp','Perilla de Palanca de Cambios',14.00,1),(13,'/assets/img/imgCompontMoto/asientoMoto.jpg','Asiento para motocicleta',17.00,2),(14,'/assets/img/imgCompontMoto/bateriaMoto.jpg','Bateria para motocicleta',89.95,2),(15,'/assets/img/imgCompontMoto/cajaCambioMoto.jpg','Caja de cambio',250.99,2),(16,'/assets/img/imgCompontMoto/chasisMoto.jpg','Chasis',75.00,2),(17,'/assets/img/imgCompontMoto/cupulaMoto.jpg','Cilindro Hidráulico',22.50,2),(18,'/assets/img/imgCompontMoto/DepocitoMoto.webp','Depocito de gasolina rc200',32.99,2),(19,'/assets/img/imgCompontMoto/discosMoto.jpg','Iglobalbuy Motorcycle',35.99,2),(20,'/assets/img/imgCompontMoto/embrageMoto.jpeg','7/8\" -Black -Acouto embrague',8.00,2),(21,'/assets/img/imgCompontMoto/tuboEscapeMoto.jpg','Tubo de escape',50.00,2),(22,'/assets/img/accesorios/asientoBebes.jpg','Asientos para niños menores a 5 años',80.99,3),(23,'/assets/img/accesorios/asientoBebes2.jpg','Asientos para niños menores a 5 años',121.89,3),(24,'/assets/img/accesorios/cascoMoto.jpg','Casco para motociclistas',45.00,3),(25,'/assets/img/accesorios/cepillo.jpg','Cepillo de limpieza',14.00,3),(26,'/assets/img/accesorios/coginesAutos.jpg','Cogines para automovil',25.00,3),(27,'/assets/img/accesorios/guantesMoto.jpg','Guantes para motociclistas',15.88,3),(28,'/assets/img/accesorios/quickMantenimiento.jpg','Quick de limpieza',38.99,3),(29,'/assets/img/accesorios/quickMantenimiento2.jpg','Quick de limpieza',45.50,3),(30,'/assets/img/accesorios/radio.jpg','Radio manual',12.00,3),(31,'/assets/img/accesorios/radio2.jpg','Radio Inteligente',99.99,3),(32,'/assets/img/accesorios/soporteCell.jpg','Soporte de celular',12.00,3),(33,'/assets/img/accesorios/soporteCell2.jpg','Soporte de celular',15.00,3);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
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

-- Dump completed on 2023-02-22 21:34:05
