-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: client_conn
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `account`
--

DROP TABLE IF EXISTS `account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `account` (
  `idaccount` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `cod_client` int(10) unsigned NOT NULL,
  `amount` float unsigned NOT NULL,
  `iban` varchar(34) NOT NULL,
  PRIMARY KEY (`idaccount`),
  UNIQUE KEY `idaccount_UNIQUE` (`idaccount`),
  UNIQUE KEY `iban_UNIQUE` (`iban`),
  KEY `idclient_idx` (`cod_client`),
  CONSTRAINT `codclient` FOREIGN KEY (`cod_client`) REFERENCES `client` (`idclient`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account`
--

LOCK TABLES `account` WRITE;
/*!40000 ALTER TABLE `account` DISABLE KEYS */;
INSERT INTO `account` VALUES (1,1,6000,'NL03ABNA6143537119'),(2,2,851,'NL61ABNA1369777396'),(3,3,13000,'NL83ABNA3154172025'),(6,6,1300,'NL18ABNA7085742275'),(7,7,85949.5,'NL20ABNA7044037380');
/*!40000 ALTER TABLE `account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `client` (
  `idclient` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `surname` varchar(50) NOT NULL,
  `telephone` varchar(20) NOT NULL,
  `mail` varchar(50) NOT NULL,
  PRIMARY KEY (`idclient`),
  UNIQUE KEY `idclient_UNIQUE` (`idclient`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Christina','Boyer','727-580-8046','trisha.cron4@yahoo.com'),(2,'Lois','Case','773-716-7107','billy_spink10@hotmail.com'),(3,'Howard','Youngman','410-895-0068','kody_swif19@yahoo.com'),(6,'Tony','Hunnicutt','862-252-8081','lesley_kutc0@gmail.com'),(7,'Kerry','Mellen','314-413-5720','haven1998@yahoo.com');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transaction`
--

DROP TABLE IF EXISTS `transaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `transaction` (
  `idtransaction` int(11) NOT NULL AUTO_INCREMENT,
  `accnum` int(10) unsigned NOT NULL,
  `accnum2` int(10) unsigned DEFAULT NULL,
  `transtype` int(4) unsigned NOT NULL,
  `transamount` double NOT NULL,
  PRIMARY KEY (`idtransaction`),
  KEY `transtype_idx` (`transtype`),
  KEY `idaccount_idx` (`accnum`),
  CONSTRAINT `idaccount` FOREIGN KEY (`accnum`) REFERENCES `account` (`idaccount`),
  CONSTRAINT `idtranstype` FOREIGN KEY (`transtype`) REFERENCES `transtype` (`idtranstype`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transaction`
--

LOCK TABLES `transaction` WRITE;
/*!40000 ALTER TABLE `transaction` DISABLE KEYS */;
INSERT INTO `transaction` VALUES (1,1,NULL,1,6000),(2,2,NULL,1,800.5),(3,3,NULL,1,13000),(4,6,NULL,1,1300),(5,7,NULL,1,86000),(6,7,2,1,50.5);
/*!40000 ALTER TABLE `transaction` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transtype`
--

DROP TABLE IF EXISTS `transtype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `transtype` (
  `idtranstype` int(4) unsigned NOT NULL,
  `description` varchar(50) NOT NULL,
  PRIMARY KEY (`idtranstype`),
  UNIQUE KEY `idtranstype_UNIQUE` (`idtranstype`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transtype`
--

LOCK TABLES `transtype` WRITE;
/*!40000 ALTER TABLE `transtype` DISABLE KEYS */;
INSERT INTO `transtype` VALUES (0,'NULL'),(1,'TRANSFER'),(2,'DEPOSIT');
/*!40000 ALTER TABLE `transtype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'client_conn'
--

--
-- Dumping routines for database 'client_conn'
--
/*!50003 DROP PROCEDURE IF EXISTS `deposit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`client`@`%` PROCEDURE `deposit`( IN ibannum VARCHAR(34), IN depmoney float, OUT result bool)
BEGIN

DECLARE idsend int;
DECLARE EXIT HANDLER FOR SQLEXCEPTION ROLLBACK;
DECLARE EXIT HANDLER FOR SQLWARNING ROLLBACK;
SET result = false;
start transaction;

SELECT idaccount
INTO idsend
FROM client_conn.account 
WHERE iban= ibannum;

UPDATE`client_conn`.`account` 
SET amount=amount + depmoney 
WHERE idaccount= idsend;

/* creating the transaction*/
INSERT INTO `client_conn`.`transaction` (`accnum`, `transtype`, `transamount`) 
VALUES (idsend, '1', depmoney);
commit;
SET result = true;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `existIBAN` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`client`@`%` PROCEDURE `existIBAN`(IN ibannum VARCHAR(34), OUT result bool)
BEGIN
SET result = 0; 
IF(EXISTS(SELECT iban FROM client_conn.account WHERE iban = ibannum)) then  
    SET result = 1; 
END IF; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `transfer` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`client`@`%` PROCEDURE `transfer`(IN ibanSend  VARCHAR(34),IN ibanRecv  VARCHAR(34), IN depmoney float, OUT result bool)
BEGIN

DECLARE idsend, idrecv int;
DECLARE EXIT HANDLER FOR SQLEXCEPTION ROLLBACK;
DECLARE EXIT HANDLER FOR SQLWARNING ROLLBACK;

SET result = false;
start transaction;
SELECT idaccount
INTO idsend
FROM client_conn.account 
WHERE iban= ibanSend;

SELECT idaccount
INTO idrecv
FROM client_conn.account 
WHERE iban= ibanRecv;

UPDATE`client_conn`.`account` 
SET amount=amount + depmoney 
WHERE idaccount= idrecv;

UPDATE`client_conn`.`account` 
SET amount=amount - depmoney 
WHERE idaccount= idsend;

/* creating the transaction*/
INSERT INTO `client_conn`.`transaction` (`accnum`, `accnum2`, `transtype`, `transamount`) 
VALUES (idsend, idrecv, '1', depmoney);
commit;
SET result = true;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `wrtclient` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`client`@`%` PROCEDURE `wrtclient`(IN namecl varchar(50),
IN surname varchar(50),IN telephone varchar(20),IN email varchar(50), IN iban varchar(34), OUT result bool)
BEGIN
DECLARE lastID INT;
/*DECLARE EXIT HANDLER FOR SQLEXCEPTION ROLLBACK;
DECLARE EXIT HANDLER FOR SQLWARNING ROLLBACK;*/

SET result = false;
start transaction;
INSERT INTO `client_conn`.`client` ( `name`, `surname`, `telephone`, `mail`) 
VALUES ( namecl, surname, telephone, email);
SET lastID = LAST_INSERT_ID();
INSERT INTO `client_conn`.`account` (`cod_client`, `amount`, `iban`) 
VALUES (lastID, 0, iban);

commit;
SET result = true;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-20 10:01:12
