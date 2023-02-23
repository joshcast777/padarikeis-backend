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

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ 'f41d366d-91e5-11e9-8525-cecd028ee826:1-126056990';

--
-- Table structure for table `servicios`
--

DROP TABLE IF EXISTS `servicios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `servicios` (
  `servicio_id` int(11) NOT NULL AUTO_INCREMENT,
  `imagen` varchar(255) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `precio` double(5,2) NOT NULL,
  `texto` varchar(500) NOT NULL,
  PRIMARY KEY (`servicio_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicios`
--

LOCK TABLES `servicios` WRITE;
/*!40000 ALTER TABLE `servicios` DISABLE KEYS */;
INSERT INTO `servicios` VALUES (1,'/assets/img/AC.jpg','Aire Acondicionado',25.00,'Reparamos todo tipo de aire acondicionado, problemas tales como: equipo no enfría, equipo no enciende, equipo gotea, código de errores que indica el split, reparación de tarjeta de equipos inverter, recarga de gas, etc.'),(2,'/assets/img/Acce.jpg','Venta de Accesorios',25.15,'Venta de accesorios para toda clase de vehículos, comprometidos al servicio de nuestros clientes brindando la mejor atención y confianza, para poner en marcha su vehículo.'),(3,'/assets/img/Balan.jpg','Balanceo',25.15,'El balanceo es el proceso mediante el que se equilibra el peso de las llantas y de los rines. Si bien a primera vista todos los neumáticos lucen iguales, existen pequeñas diferencias en el peso de cada lado de la llanta.'),(4,'/assets/img/Electro.jpg','Electrónica',25.15,'El sistema electrónico de nuestro carro es el encargado del encendido del motor, así como de su control y monitorización, además carga la batería durante el funcionamiento del motor y suministra la energía necesaria para las luces, el aire acondicionado, las ventanas y otros elementos.'),(5,'/assets/img/Frenos.jpg','Frenos',25.15,'El sistema de frenos cumple una función importante en cuanto a seguridad vial se refiere, la decisión de su mantenimiento depende del uso del vehículo, sin embargo se recomienda realizar un mantenimiento preventivo cada 5.000 Km o en cada cambio de aceite.'),(6,'/assets/img/Inyec.jpg','Inyectores',25.15,'Los inyectores, sean diésel o gasolina, son elementos imprescindibles para el buen funcionamiento del motor de nuestro vehículo puesto que se encargan de dosificar la cantidad exacta de carburante que accede a la cámara, siendo así los principales responsables de que se produzca una combustión adecuada.'),(7,'/assets/img/Limp.jpg','Limpieza',25.15,'El vehículo se expone cada día a situaciones extremas de ambiente y temperatura, por lo que debemos cuidarlo para así conservarlo como el primer día. Si no mantenemos nuestro auto limpio, la acumulación de polvo y suciedad acelerará el proceso de envejecimiento de los elementos internos y externos.'),(8,'/assets/img/Lubri.jpg','Lubricación',25.15,'El uso de los lubricantes en la mecánica en general, y en concreto en el mundo de la automoción, es de vital importancia por la presencia de elementos en movimiento, como por ejemplo, los órganos que forman el motor de un vehículo (pistones, bielas, cigüeñal, etc.)'),(9,'/assets/img/Motor.jpg','Motores',25.15,'Contamos con mecanicos especialistas en arreglo de perdida de potencia de arranque. Te damos un detalle exacto de los fallos con el diagnostico de tu motor, diagnostico de encendido y ruido de motor.'),(10,'/assets/img/Pint.jpg','Latonería y Pintura',25.15,'El precio para poder pintar un auto en Ecuador va desde los $800. ¿Pero hay lugares que cobran mas barato? Desde luego pero para la pregunta en mención se está tomando en consideración el uso de productos de calidad como Sherwin Williams y Glasurit que son usados en los mejores talleres de pintura automotriz del mundo para garantizar un trabajo con un acabado de lujo.'),(11,'/assets/img/SuspDir.jpg','Suspensión y Dirección',25.15,'Todo sistema de suspensión en los vehículos automóviles debe tener dos cualidades fundamentales: la elasticidad, para evitar golpes secos en el chasis debidos a las irregularidades del terreno; y la amortiguación, que impida un excesivo balanceo de los elementos de la suspensión que se transmita al resto del vehículo.'),(12,'/assets/img/Transmi.jpg','Transmisión',25.15,'Si escuchamos un ruido metálico cuando giramos para cambiar de dirección, es probable que la junta de ese lado esté desgastada y ahora el anclaje tenga holguras por lo que debería ser reemplazada.');
/*!40000 ALTER TABLE `servicios` ENABLE KEYS */;
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

-- Dump completed on 2023-02-22 21:34:15
