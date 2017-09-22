-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.1.34-community


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema mi
--

CREATE DATABASE IF NOT EXISTS mi;
USE mi;

--
-- Definition of table `mi_setting`
--

DROP TABLE IF EXISTS `mi_setting`;
CREATE TABLE `mi_setting` (
  `ID` varchar(50) NOT NULL,
  `Parameter1` varchar(150) NOT NULL,
  `Parameter2` varchar(45) DEFAULT NULL,
  `Parameter3` varchar(45) DEFAULT NULL,
  `Parameter4` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mi_setting`
--

/*!40000 ALTER TABLE `mi_setting` DISABLE KEYS */;
INSERT INTO `mi_setting` (`ID`,`Parameter1`,`Parameter2`,`Parameter3`,`Parameter4`) VALUES 
 ('CreateFile','N','','','25'),
 ('EmailInfo','SarimHaleem@yahoo.com','11','82.165.187.167','25'),
 ('LogFilePath','C:\\Documents and Settings\\Administrator\\Desktop','','','25'),
 ('Read','3','','','25'),
 ('Refresh','2','','','25'),
 ('Retention','6','','','25'),
 ('Send','5','','','25'),
 ('Upload','4','','','25');
/*!40000 ALTER TABLE `mi_setting` ENABLE KEYS */;


--
-- Definition of table `mi_tbooking`
--

DROP TABLE IF EXISTS `mi_tbooking`;
CREATE TABLE `mi_tbooking` (
  `BookingID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `LabID` varchar(20) DEFAULT NULL,
  `PatientID` int(10) unsigned DEFAULT NULL,
  `Patient_name` varchar(150) DEFAULT NULL,
  `Test_Code` varchar(50) NOT NULL,
  `Machine_TestID` varchar(50) NOT NULL,
  `Test_Name` varchar(100) NOT NULL,
  `InstrumentID` int(10) unsigned NOT NULL,
  `Machine_Time` datetime DEFAULT NULL,
  `SeqID` varchar(50) DEFAULT NULL,
  `BatchNo` varchar(50) DEFAULT NULL,
  `Sample_Type` varchar(50) DEFAULT NULL,
  `EnteredBy` int(10) unsigned NOT NULL,
  `EnteredOn` datetime NOT NULL,
  `ClientID` char(4) NOT NULL,
  `Active` char(1) NOT NULL,
  `SendOn` datetime DEFAULT NULL,
  `ReceivedOn` datetime DEFAULT NULL,
  PRIMARY KEY (`BookingID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=438 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mi_tbooking`
--

/*!40000 ALTER TABLE `mi_tbooking` DISABLE KEYS */;
INSERT INTO `mi_tbooking` (`BookingID`,`LabID`,`PatientID`,`Patient_name`,`Test_Code`,`Machine_TestID`,`Test_Name`,`InstrumentID`,`Machine_Time`,`SeqID`,`BatchNo`,`Sample_Type`,`EnteredBy`,`EnteredOn`,`ClientID`,`Active`,`SendOn`,`ReceivedOn`) VALUES 
 (344,'146924',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 10:49:00','0001','Y','2010-11-04 01:41:00','2010-11-08 10:49:00'),
 (345,'146981',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 10:49:00','0001','Y','2010-11-04 07:36:00','2010-11-08 10:49:00'),
 (346,'146981',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 10:49:00','0001','Y','2010-11-04 07:36:00','2010-11-08 10:49:00'),
 (347,'146981',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 10:49:00','0001','Y','2010-11-04 07:37:00','2010-11-08 10:49:00'),
 (348,'146987',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 10:49:00','0001','Y','2010-11-04 07:38:00','2010-11-08 10:49:00'),
 (349,'146987',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 07:38:00','2010-11-08 11:44:00'),
 (350,'146987',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 07:39:00','2010-11-08 11:44:00'),
 (351,'147019',NULL,NULL,'291','80','Anti-HBe',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 13:00:00','2010-11-08 11:44:00'),
 (352,'147019',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 13:02:00','2010-11-08 11:44:00'),
 (353,'147019',NULL,NULL,'301','58','CEA',5,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 13:03:00','2010-11-08 11:44:00'),
 (354,'147019',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 13:03:00','2010-11-08 11:44:00'),
 (355,'147045',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 13:04:00','2010-11-08 11:44:00'),
 (356,'5027',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 11:03:00','2010-11-08 11:44:00'),
 (357,'5027',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 11:04:00','2010-11-08 11:44:00'),
 (358,'5027',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 11:04:00','2010-11-08 11:44:00'),
 (359,'5027',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 11:05:00','2010-11-08 11:44:00'),
 (360,'5031',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 11:13:00','2010-11-08 11:44:00'),
 (361,'5031',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 11:13:00','2010-11-08 11:44:00'),
 (362,'5031',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 11:14:00','2010-11-08 11:44:00'),
 (363,'5031',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 11:15:00','2010-11-08 11:44:00'),
 (364,'5032',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 11:15:00','2010-11-08 11:44:00'),
 (365,'5032',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 11:16:00','2010-11-08 11:44:00'),
 (366,'5032',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 11:16:00','2010-11-08 11:44:00'),
 (367,'5032',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 11:38:00','2010-11-08 11:44:00'),
 (368,'5033',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 11:38:00','2010-11-08 11:44:00'),
 (369,'5033',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 11:39:00','2010-11-08 11:44:00'),
 (370,'5033',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:44:00','0001','Y','2010-11-04 11:39:00','2010-11-08 11:44:00'),
 (371,'5033',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:40:00','2010-11-08 11:45:00'),
 (372,'5034',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:41:00','2010-11-08 11:45:00'),
 (373,'5034',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:41:00','2010-11-08 11:45:00'),
 (374,'5034',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:42:00','2010-11-08 11:45:00'),
 (375,'5034',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:42:00','2010-11-08 11:45:00'),
 (376,'5035',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:43:00','2010-11-08 11:45:00'),
 (377,'5035',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:44:00','2010-11-08 11:45:00'),
 (378,'5035',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:44:00','2010-11-08 11:45:00'),
 (379,'5035',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:45:00','2010-11-08 11:45:00'),
 (380,'5036',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:45:00','2010-11-08 11:45:00'),
 (381,'5036',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:46:00','2010-11-08 11:45:00'),
 (382,'5036',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:47:00','2010-11-08 11:45:00'),
 (383,'5036',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:47:00','2010-11-08 11:45:00'),
 (384,'5037',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:48:00','2010-11-08 11:45:00'),
 (385,'5037',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:48:00','2010-11-08 11:45:00'),
 (386,'5037',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:49:00','2010-11-08 11:45:00'),
 (387,'5037',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:50:00','2010-11-08 11:45:00'),
 (388,'5038',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:50:00','2010-11-08 11:45:00'),
 (389,'5038',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 11:51:00','2010-11-08 11:45:00'),
 (390,'5038',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:12:00','2010-11-08 11:45:00'),
 (391,'5038',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:13:00','2010-11-08 11:45:00'),
 (392,'5039',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:13:00','2010-11-08 11:45:00'),
 (393,'5039',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:14:00','2010-11-08 11:45:00'),
 (394,'5039',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:15:00','2010-11-08 11:45:00'),
 (395,'5039',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:15:00','2010-11-08 11:45:00'),
 (396,'5040',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:16:00','2010-11-08 11:45:00'),
 (397,'5040',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:16:00','2010-11-08 11:45:00'),
 (398,'5040',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:17:00','2010-11-08 11:45:00'),
 (399,'5040',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:18:00','2010-11-08 11:45:00'),
 (400,'5041',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:18:00','2010-11-08 11:45:00'),
 (401,'5041',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:19:00','2010-11-08 11:45:00'),
 (402,'5041',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:19:00','2010-11-08 11:45:00'),
 (403,'5041',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:20:00','2010-11-08 11:45:00'),
 (404,'5042',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:21:00','2010-11-08 11:45:00'),
 (405,'5042',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:21:00','2010-11-08 11:45:00'),
 (406,'5042',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:22:00','2010-11-08 11:45:00'),
 (407,'5042',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:22:00','2010-11-08 11:45:00'),
 (408,'5043',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:23:00','2010-11-08 11:45:00'),
 (409,'5043',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:24:00','2010-11-08 11:45:00'),
 (410,'5043',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:24:00','2010-11-08 11:45:00'),
 (411,'5043',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:25:00','2010-11-08 11:45:00'),
 (412,'5044',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:25:00','2010-11-08 11:45:00'),
 (413,'5044',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:47:00','2010-11-08 11:45:00'),
 (414,'5044',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:47:00','2010-11-08 11:45:00'),
 (415,'5044',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:48:00','2010-11-08 11:45:00'),
 (416,'5045',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:48:00','2010-11-08 11:45:00'),
 (417,'5045',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:49:00','2010-11-08 11:45:00'),
 (418,'5045',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:50:00','2010-11-08 11:45:00'),
 (419,'5045',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:50:00','2010-11-08 11:45:00'),
 (420,'5046',NULL,NULL,'161','87','Anti-HCV',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:51:00','2010-11-08 11:45:00'),
 (421,'5046',NULL,NULL,'149','76','HBsAg',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:51:00','2010-11-08 11:45:00'),
 (422,'5046',NULL,NULL,'721','83','HIV AG/AB',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:52:00','2010-11-08 11:45:00'),
 (423,'5046',NULL,NULL,'561','74','Syphilis',4,NULL,NULL,NULL,NULL,1,'2010-11-08 11:45:00','0001','Y','2010-11-04 12:53:00','2010-11-08 11:45:00'),
 (424,'162201',NULL,NULL,'017','142','HBsAg',17,NULL,NULL,NULL,NULL,1,'2010-12-11 12:32:00','0001','Y','2010-12-08 13:28:00','2010-12-11 12:32:00'),
 (425,'5735',NULL,NULL,'017','142','HBsAg',17,NULL,NULL,NULL,NULL,1,'2010-12-23 18:23:00','0001','Y','2010-12-23 08:46:00','2010-12-23 18:23:00'),
 (426,'5736',NULL,NULL,'017','142','HBsAg',17,NULL,NULL,NULL,NULL,1,'2010-12-23 18:26:00','0001','Y','2010-12-23 08:48:00','2010-12-23 18:26:00'),
 (427,'5739',NULL,NULL,'017','142','HBsAg',17,NULL,NULL,NULL,NULL,1,'2010-12-23 18:26:00','0001','Y','2010-12-23 08:51:00','2010-12-23 18:26:00'),
 (428,'5741',NULL,NULL,'017','142','HBsAg',17,NULL,NULL,NULL,NULL,1,'2010-12-23 18:30:00','0001','Y','2010-12-23 08:53:00','2010-12-23 18:30:00'),
 (429,'5742',NULL,NULL,'017','142','HBsAg',17,NULL,NULL,NULL,NULL,1,'2010-12-23 18:30:00','0001','Y','2010-12-23 08:57:00','2010-12-23 18:30:00'),
 (430,'5744',NULL,NULL,'017','142','HBsAg',17,NULL,NULL,NULL,NULL,1,'2010-12-23 18:30:00','0001','Y','2010-12-23 09:02:00','2010-12-23 18:30:00'),
 (431,'5745',NULL,NULL,'017','142','HBsAg',17,NULL,NULL,NULL,NULL,1,'2010-12-23 18:30:00','0001','Y','2010-12-23 09:04:00','2010-12-23 18:30:00'),
 (432,'5745',NULL,NULL,'024','147','aHIV',17,NULL,NULL,NULL,NULL,1,'2010-12-23 18:42:00','0001','Y','2010-12-23 09:04:00','2010-12-23 18:42:00'),
 (433,'5745',NULL,NULL,'023','128','aHCV',17,NULL,NULL,NULL,NULL,1,'2010-12-23 18:42:00','0001','Y','2010-12-23 09:04:00','2010-12-23 18:42:00'),
 (434,'5745',NULL,NULL,'017','142','HBsAg',17,NULL,NULL,NULL,NULL,1,'2010-12-23 18:42:00','0001','Y','2010-12-23 09:04:00','2010-12-23 18:42:00'),
 (435,'5746',NULL,NULL,'024','147','aHIV',17,NULL,NULL,NULL,NULL,1,'2010-12-23 18:42:00','0001','Y','2010-12-23 09:07:00','2010-12-23 18:42:00'),
 (436,'5746',NULL,NULL,'023','128','aHCV',17,NULL,NULL,NULL,NULL,1,'2010-12-23 18:42:00','0001','Y','2010-12-23 09:07:00','2010-12-23 18:42:00'),
 (437,'5746',NULL,NULL,'017','142','HBsAg',17,NULL,NULL,NULL,NULL,1,'2010-12-23 18:42:00','0001','Y','2010-12-23 09:07:00','2010-12-23 18:42:00');
/*!40000 ALTER TABLE `mi_tbooking` ENABLE KEYS */;


--
-- Definition of table `mi_tinstruments`
--

DROP TABLE IF EXISTS `mi_tinstruments`;
CREATE TABLE `mi_tinstruments` (
  `InstrumentID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Supplierid` int(10) unsigned NOT NULL,
  `Instrument_Name` varchar(150) NOT NULL,
  `Model` varchar(50) NOT NULL,
  `I_Release` varchar(50) DEFAULT NULL,
  `Description` varchar(1000) DEFAULT NULL,
  `Manual` varchar(150) DEFAULT NULL,
  `Patient_no_format` varchar(50) DEFAULT NULL,
  `BarCode_Standard` varchar(100) DEFAULT NULL,
  `Bidirectional` char(1) NOT NULL,
  `Communication_Stnadard` varchar(50) NOT NULL,
  `Communication_method` varchar(50) NOT NULL,
  `PORT` varchar(10) NOT NULL,
  `BaudRate` int(10) unsigned NOT NULL,
  `Parity` varchar(10) NOT NULL,
  `Stopbit` varchar(10) NOT NULL,
  `DataBit` varchar(10) NOT NULL,
  `FlowControl` varchar(10) NOT NULL,
  `Acknowledgement_code` int(10) unsigned DEFAULT NULL,
  `EnteredBy` int(10) unsigned NOT NULL,
  `EnteredOn` datetime NOT NULL,
  `ClientID` varchar(45) NOT NULL,
  `Active` char(1) NOT NULL,
  PRIMARY KEY (`InstrumentID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mi_tinstruments`
--

/*!40000 ALTER TABLE `mi_tinstruments` DISABLE KEYS */;
INSERT INTO `mi_tinstruments` (`InstrumentID`,`Supplierid`,`Instrument_Name`,`Model`,`I_Release`,`Description`,`Manual`,`Patient_no_format`,`BarCode_Standard`,`Bidirectional`,`Communication_Stnadard`,`Communication_method`,`PORT`,`BaudRate`,`Parity`,`Stopbit`,`DataBit`,`FlowControl`,`Acknowledgement_code`,`EnteredBy`,`EnteredOn`,`ClientID`,`Active`) VALUES 
 (3,5,'AxSYM Plus','AxSYM Plus','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2010-10-13 00:00:00','0001','Y'),
 (4,5,'Architect i 1000 SR System','i1000 SR','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2010-10-13 00:00:00','0001','Y'),
 (5,6,'Elecsys2010','2010','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2010-10-13 00:00:00','0001','Y'),
 (6,6,'Cobas b121','b121','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2010-10-13 00:00:00','0001','Y'),
 (7,6,'Hitachi902','902','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2010-10-13 00:00:00','0001','Y'),
 (8,6,'Hitachi912','912','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2010-10-13 00:00:00','0001','Y'),
 (9,7,'Immulite2000','2000','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2010-10-13 00:00:00','0001','Y'),
 (10,7,'Dimension RxL','RxL','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2010-10-13 00:00:00','0001','Y'),
 (11,8,'Sysmex XT-2000i','XT-2000i','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2010-10-13 00:00:00','0001','Y'),
 (12,8,'Sysmex KX-21','KX-21','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2010-10-13 00:00:00','0001','Y'),
 (13,9,'Nova pHOX Plus','pHOX Plus','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2010-10-13 00:00:00','0001','Y'),
 (14,9,'Start4 Coagulation Analyzer','Start4','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2010-10-13 00:00:00','0001','Y'),
 (15,9,'Clinitek Status Bayer','Clinitek','','','','','','Y','','PORT','COM1',4800,'None','One','8','None',NULL,1,'2010-10-13 00:00:00','0001','Y'),
 (16,10,'BD Bactec9050','9050','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2010-10-13 00:00:00','0001','Y'),
 (17,12,'Vitros ECi','ECI','','','','','','Y','','PORT','COM1',19200,'None','One','8','None',NULL,1,'2010-11-04 00:00:00','0001','Y');
/*!40000 ALTER TABLE `mi_tinstruments` ENABLE KEYS */;


--
-- Definition of table `mi_tpersonnel`
--

DROP TABLE IF EXISTS `mi_tpersonnel`;
CREATE TABLE `mi_tpersonnel` (
  `PersonId` int(10) unsigned NOT NULL,
  `OrgId` char(3) NOT NULL,
  `DepartmentId` int(10) unsigned NOT NULL,
  `SubdepartmentId` int(10) unsigned NOT NULL,
  `DesignationId` int(10) unsigned NOT NULL,
  `Active` char(1) NOT NULL,
  `ServiceNo` varchar(20) DEFAULT NULL,
  `Salutation` varchar(6) NOT NULL,
  `FName` varchar(30) NOT NULL,
  `MName` varchar(30) DEFAULT NULL,
  `LName` varchar(30) DEFAULT NULL,
  `Acronym` varchar(10) NOT NULL,
  `FHName` varchar(30) DEFAULT NULL,
  `Sex` char(1) NOT NULL,
  `DOB` datetime DEFAULT NULL,
  `BloodGroup` varchar(3) DEFAULT NULL,
  `MS` char(1) DEFAULT NULL,
  `NIC` varchar(15) DEFAULT NULL,
  `NICValidUpto` datetime DEFAULT NULL,
  `Passport` varchar(20) DEFAULT NULL,
  `PassportValidUpto` datetime DEFAULT NULL,
  `HPhoneNo1` varchar(15) DEFAULT NULL,
  `HPhoneNo2` varchar(15) DEFAULT NULL,
  `OPhoneNo1` varchar(15) DEFAULT NULL,
  `OPhoneNo2` varchar(15) DEFAULT NULL,
  `CPhoneNo` varchar(15) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `CurrentAddress` varchar(250) DEFAULT NULL,
  `PermanentAddress` varchar(250) DEFAULT NULL,
  `PictureRef` varchar(255) DEFAULT NULL,
  `LoginId` varchar(15) DEFAULT NULL,
  `Pasword` varchar(15) DEFAULT NULL,
  `JoiningDate` datetime DEFAULT NULL,
  `LeavingDate` datetime DEFAULT NULL,
  `Education` varchar(255) DEFAULT NULL,
  `Nature` char(1) DEFAULT NULL,
  `ContractExpiry` datetime DEFAULT NULL,
  `ReferenceCode` varchar(15) DEFAULT NULL,
  `Salary` int(10) unsigned DEFAULT NULL,
  `FaxNo` varchar(15) DEFAULT NULL,
  `Enteredby` int(10) unsigned NOT NULL,
  `Enteredon` datetime NOT NULL,
  `clientid` char(3) NOT NULL,
  `crossdept` char(1) NOT NULL,
  PRIMARY KEY (`PersonId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mi_tpersonnel`
--

/*!40000 ALTER TABLE `mi_tpersonnel` DISABLE KEYS */;
INSERT INTO `mi_tpersonnel` (`PersonId`,`OrgId`,`DepartmentId`,`SubdepartmentId`,`DesignationId`,`Active`,`ServiceNo`,`Salutation`,`FName`,`MName`,`LName`,`Acronym`,`FHName`,`Sex`,`DOB`,`BloodGroup`,`MS`,`NIC`,`NICValidUpto`,`Passport`,`PassportValidUpto`,`HPhoneNo1`,`HPhoneNo2`,`OPhoneNo1`,`OPhoneNo2`,`CPhoneNo`,`Email`,`CurrentAddress`,`PermanentAddress`,`PictureRef`,`LoginId`,`Pasword`,`JoiningDate`,`LeavingDate`,`Education`,`Nature`,`ContractExpiry`,`ReferenceCode`,`Salary`,`FaxNo`,`Enteredby`,`Enteredon`,`clientid`,`crossdept`) VALUES 
 (1,'007',3,13,1,'Y','00001','Mr.','Trees','Technologies','','trs','software','M','1991-01-01 00:00:00',NULL,'S','',NULL,'',NULL,'','','','','','','','',NULL,'trees','kdc1234',NULL,NULL,'','P',NULL,'',0,'',1,'2010-02-25 16:22:56','007','Y');
/*!40000 ALTER TABLE `mi_tpersonnel` ENABLE KEYS */;


--
-- Definition of table `mi_tresult`
--

DROP TABLE IF EXISTS `mi_tresult`;
CREATE TABLE `mi_tresult` (
  `ResultID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `BookingID` int(10) unsigned NOT NULL,
  `AttributeID` int(10) unsigned NOT NULL,
  `Result` varchar(100) NOT NULL,
  `EnteredBy` int(10) unsigned NOT NULL,
  `EnteredOn` datetime NOT NULL,
  `ClientID` char(4) NOT NULL,
  `Status` char(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ResultID`)
) ENGINE=InnoDB AUTO_INCREMENT=438 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mi_tresult`
--

/*!40000 ALTER TABLE `mi_tresult` DISABLE KEYS */;
INSERT INTO `mi_tresult` (`ResultID`,`BookingID`,`AttributeID`,`Result`,`EnteredBy`,`EnteredOn`,`ClientID`,`Status`) VALUES 
 (344,344,78,'0.12',1,'2010-11-08 10:49:00','0001','0'),
 (345,345,82,'0.05',1,'2010-11-08 10:49:00','0001','0'),
 (346,346,69,'0.45',1,'2010-11-08 10:49:00','0001','0'),
 (347,347,78,'0.16',1,'2010-11-08 10:49:00','0001','0'),
 (348,348,82,'0.06',1,'2010-11-08 10:49:00','0001','0'),
 (349,349,69,'0.39',1,'2010-11-08 11:44:00','0001','0'),
 (350,350,78,'0.20',1,'2010-11-08 11:44:00','0001','0'),
 (351,351,73,'0.03',1,'2010-11-08 11:44:00','0001','0'),
 (352,352,82,'0.05',1,'2010-11-08 11:44:00','0001','0'),
 (353,353,51,'0.429',1,'2010-11-08 11:44:00','0001','0'),
 (354,354,69,'1935.95',1,'2010-11-08 11:44:00','0001','0'),
 (355,355,78,'0.22',1,'2010-11-08 11:44:00','0001','0'),
 (356,356,82,'0.05',1,'2010-11-08 11:44:00','0001','0'),
 (357,357,69,'0.44',1,'2010-11-08 11:44:00','0001','0'),
 (358,358,78,'0.26',1,'2010-11-08 11:44:00','0001','0'),
 (359,359,67,'0.05',1,'2010-11-08 11:44:00','0001','0'),
 (360,360,82,'0.06',1,'2010-11-08 11:44:00','0001','0'),
 (361,361,69,'0.40',1,'2010-11-08 11:44:00','0001','0'),
 (362,362,78,'0.15',1,'2010-11-08 11:44:00','0001','0'),
 (363,363,67,'0.05',1,'2010-11-08 11:44:00','0001','0'),
 (364,364,82,'0.10',1,'2010-11-08 11:44:00','0001','0'),
 (365,365,69,'0.45',1,'2010-11-08 11:44:00','0001','0'),
 (366,366,78,'0.14',1,'2010-11-08 11:44:00','0001','0'),
 (367,367,67,'0.06',1,'2010-11-08 11:44:00','0001','0'),
 (368,368,82,'0.06',1,'2010-11-08 11:44:00','0001','0'),
 (369,369,69,'0.41',1,'2010-11-08 11:44:00','0001','0'),
 (370,370,78,'0.13',1,'2010-11-08 11:44:00','0001','0'),
 (371,371,67,'0.06',1,'2010-11-08 11:45:00','0001','0'),
 (372,372,82,'0.07',1,'2010-11-08 11:45:00','0001','0'),
 (373,373,69,'0.44',1,'2010-11-08 11:45:00','0001','0'),
 (374,374,78,'0.27',1,'2010-11-08 11:45:00','0001','0'),
 (375,375,67,'0.08',1,'2010-11-08 11:45:00','0001','0'),
 (376,376,82,'0.08',1,'2010-11-08 11:45:00','0001','0'),
 (377,377,69,'0.42',1,'2010-11-08 11:45:00','0001','0'),
 (378,378,78,'0.28',1,'2010-11-08 11:45:00','0001','0'),
 (379,379,67,'0.05',1,'2010-11-08 11:45:00','0001','0'),
 (380,380,82,'0.05',1,'2010-11-08 11:45:00','0001','0'),
 (381,381,69,'0.39',1,'2010-11-08 11:45:00','0001','0'),
 (382,382,78,'0.12',1,'2010-11-08 11:45:00','0001','0'),
 (383,383,67,'0.05',1,'2010-11-08 11:45:00','0001','0'),
 (384,384,82,'0.08',1,'2010-11-08 11:45:00','0001','0'),
 (385,385,69,'0.45',1,'2010-11-08 11:45:00','0001','0'),
 (386,386,78,'0.13',1,'2010-11-08 11:45:00','0001','0'),
 (387,387,67,'0.07',1,'2010-11-08 11:45:00','0001','0'),
 (388,388,82,'0.05',1,'2010-11-08 11:45:00','0001','0'),
 (389,389,69,'0.39',1,'2010-11-08 11:45:00','0001','0'),
 (390,390,78,'0.15',1,'2010-11-08 11:45:00','0001','0'),
 (391,391,67,'0.04',1,'2010-11-08 11:45:00','0001','0'),
 (392,392,82,'0.07',1,'2010-11-08 11:45:00','0001','0'),
 (393,393,69,'0.44',1,'2010-11-08 11:45:00','0001','0'),
 (394,394,78,'0.16',1,'2010-11-08 11:45:00','0001','0'),
 (395,395,67,'0.07',1,'2010-11-08 11:45:00','0001','0'),
 (396,396,82,'0.08',1,'2010-11-08 11:45:00','0001','0'),
 (397,397,69,'0.46',1,'2010-11-08 11:45:00','0001','0'),
 (398,398,78,'0.26',1,'2010-11-08 11:45:00','0001','0'),
 (399,399,67,'0.08',1,'2010-11-08 11:45:00','0001','0'),
 (400,400,82,'0.11',1,'2010-11-08 11:45:00','0001','0'),
 (401,401,69,'0.44',1,'2010-11-08 11:45:00','0001','0'),
 (402,402,78,'0.14',1,'2010-11-08 11:45:00','0001','0'),
 (403,403,67,'0.05',1,'2010-11-08 11:45:00','0001','0'),
 (404,404,82,'0.06',1,'2010-11-08 11:45:00','0001','0'),
 (405,405,69,'0.40',1,'2010-11-08 11:45:00','0001','0'),
 (406,406,78,'0.14',1,'2010-11-08 11:45:00','0001','0'),
 (407,407,67,'0.06',1,'2010-11-08 11:45:00','0001','0'),
 (408,408,82,'0.06',1,'2010-11-08 11:45:00','0001','0'),
 (409,409,69,'0.40',1,'2010-11-08 11:45:00','0001','0'),
 (410,410,78,'0.16',1,'2010-11-08 11:45:00','0001','0'),
 (411,411,67,'0.06',1,'2010-11-08 11:45:00','0001','0'),
 (412,412,82,'0.11',1,'2010-11-08 11:45:00','0001','0'),
 (413,413,69,'0.43',1,'2010-11-08 11:45:00','0001','0'),
 (414,414,78,'0.26',1,'2010-11-08 11:45:00','0001','0'),
 (415,415,67,'0.10',1,'2010-11-08 11:45:00','0001','0'),
 (416,416,82,'0.17',1,'2010-11-08 11:45:00','0001','0'),
 (417,417,69,'0.41',1,'2010-11-08 11:45:00','0001','0'),
 (418,418,78,'0.15',1,'2010-11-08 11:45:00','0001','0'),
 (419,419,67,'0.08',1,'2010-11-08 11:45:00','0001','0'),
 (420,420,82,'0.06',1,'2010-11-08 11:45:00','0001','0'),
 (421,421,69,'0.39',1,'2010-11-08 11:45:00','0001','0'),
 (422,422,78,'0.25',1,'2010-11-08 11:45:00','0001','0'),
 (423,423,67,'0.05',1,'2010-11-08 11:45:00','0001','0'),
 (424,424,149,'0.13',1,'2010-12-11 12:32:00','0001','0'),
 (425,425,149,'0.37',1,'2010-12-23 18:23:00','0001','0'),
 (426,426,149,'0.27',1,'2010-12-23 18:26:00','0001','0'),
 (427,427,149,'0.24',1,'2010-12-23 18:26:00','0001','0'),
 (428,428,149,'0.33',1,'2010-12-23 18:30:00','0001','0'),
 (429,429,149,'0.34',1,'2010-12-23 18:30:00','0001','0'),
 (430,430,149,'0.30',1,'2010-12-23 18:30:00','0001','0'),
 (431,431,149,'0.30',1,'2010-12-23 18:30:00','0001','0'),
 (432,432,154,'0.05',1,'2010-12-23 18:42:00','0001','0'),
 (433,433,135,'0.12',1,'2010-12-23 18:42:00','0001','0'),
 (434,434,149,'0.30',1,'2010-12-23 18:42:00','0001','0'),
 (435,435,154,'0.25',1,'2010-12-23 18:42:00','0001','0'),
 (436,436,135,'0.12',1,'2010-12-23 18:42:00','0001','0'),
 (437,437,149,'0.25',1,'2010-12-23 18:42:00','0001','0');
/*!40000 ALTER TABLE `mi_tresult` ENABLE KEYS */;


--
-- Definition of table `mi_tsuppliers`
--

DROP TABLE IF EXISTS `mi_tsuppliers`;
CREATE TABLE `mi_tsuppliers` (
  `SupplierID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Supplier_Name` varchar(150) NOT NULL,
  `Address` varchar(500) DEFAULT NULL,
  `Phone_1` varchar(20) DEFAULT NULL,
  `Phone_2` varchar(20) DEFAULT NULL,
  `Fax_1` varchar(20) DEFAULT NULL,
  `Fax_2` varchar(20) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `CellNo` varchar(20) DEFAULT NULL,
  `WebAddress` varchar(50) DEFAULT NULL,
  `Linkedin_ID` varchar(50) DEFAULT NULL,
  `CP_Name` varchar(50) NOT NULL,
  `CP_Designation` varchar(50) DEFAULT NULL,
  `CP_Office_Phone` varchar(20) DEFAULT NULL,
  `CP_Cell_no` varchar(20) DEFAULT NULL,
  `CP_Email` varchar(50) DEFAULT NULL,
  `City` varchar(50) DEFAULT NULL,
  `Country` varchar(45) DEFAULT NULL,
  `EnteredBy` int(10) unsigned NOT NULL,
  `EnteredOn` datetime NOT NULL,
  `Clientid` char(4) NOT NULL,
  `Active` char(1) NOT NULL,
  `Ref_SupplierID` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`SupplierID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mi_tsuppliers`
--

/*!40000 ALTER TABLE `mi_tsuppliers` DISABLE KEYS */;
INSERT INTO `mi_tsuppliers` (`SupplierID`,`Supplier_Name`,`Address`,`Phone_1`,`Phone_2`,`Fax_1`,`Fax_2`,`Email`,`CellNo`,`WebAddress`,`Linkedin_ID`,`CP_Name`,`CP_Designation`,`CP_Office_Phone`,`CP_Cell_no`,`CP_Email`,`City`,`Country`,`EnteredBy`,`EnteredOn`,`Clientid`,`Active`,`Ref_SupplierID`) VALUES 
 (5,'Abbott Diagnostic Division','House no. 663/9, old bara road, University Town, Peshawar','0915840252','','0915840252','','muhammad.jan@abbott.com','03005983709','http://www.abbott.com','Abbott','Muhammad Akif Jan','Field Manager','0915840252','03005983709','muhammad.jan@abbott.com','Peshawar','Pakistan',1,'2010-10-13 00:00:00','0001','Y',NULL),
 (6,'Roche Diagnostic Division','31 Street 63, F-7/3, Islamabad','0512270639','0512823374','0512823375','','','03005122723','','','Faizuddin Minhaji','','0512270639','03005122723','','','',1,'2010-10-13 00:00:00','0001','Y',NULL),
 (7,'Hoora Pharma','','0515598267','','0515598268','','','03008263759','http://www.hoorapharma.com','','Abdul Rasheed Chohan','CEO/President','02134305031-5','03008263759','rasheed@hoorapharma.com','','',1,'2010-10-13 00:00:00','0001','Y',NULL),
 (8,'S. Ejaz Uddin & Co.','13, Khayban-e-Johur, I-8/3, Islamabad','0514430267','0514430267','0514443245','','','','www.sejazuddin.com','','Farrukh Iqbal','Manager Technical Services','0514430267','03008543010','secodiag@comsats.net.pk','','',1,'2010-10-13 00:00:00','0001','Y',NULL),
 (9,'Burhani Enterprises','21/A, Krachi Market, Khyber Bazar, Peshawar','0912571193','','0912591340','','burhanient@gmail.com','','','','Tablib Hussain','','0912571193','03008595221','burhani52ent@yahoo.com','','',1,'2010-10-13 00:00:00','0001','Y',NULL),
 (10,'Vantage Technologies','251 (125/B), Street no. 11-B, Phase-1, Ghauri Town, Kaha East, Islmabad Highway, Islamabad','0512615152','0512615157','0512615153','','vntage@brain.net.pk','','http://www.vtpak.com','','Mohsin Ur Raza','Product Specialist','0512615152','','mail@vtpak.com','','',1,'2010-10-13 00:00:00','0001','Y',NULL),
 (11,'Chemical House','Qamar Mansion opp. UBL Bank, Sadar Road, Peshawar (Cantt)','915277858','427351690','915277858','','zia_haq@chemical-house.com','03339158685','','','Zia Ul Haq','Branch Manager KPK','915277858','03339158685','zia_haq@chemical-house.com','Peshawar','',1,'2010-10-13 00:00:00','0001','Y',NULL),
 (12,'Seico Scientific','104, Muhammadia Plaza. college Road, Rawalpindi','515532115','515555313','515540314','','seico@seico.com.pk','03008558297','www.seico.com.pk','','Rana Muhammad Asif','Product Manager','515532115','03008558297','seico@seico.com.pk','Rawalpindi','',1,'2010-10-13 00:00:00','0001','Y',NULL);
/*!40000 ALTER TABLE `mi_tsuppliers` ENABLE KEYS */;


--
-- Definition of table `mi_ttestattribute`
--

DROP TABLE IF EXISTS `mi_ttestattribute`;
CREATE TABLE `mi_ttestattribute` (
  `AttributeID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Machine_testid` int(10) unsigned NOT NULL,
  `LIMSAttributeID` char(6) NOT NULL,
  `LIMSAttributeName` varchar(150) NOT NULL,
  `MachineAttributeName` varchar(150) NOT NULL,
  `EnteredBy` int(10) unsigned NOT NULL,
  `EnteredOn` datetime NOT NULL,
  `ClientId` char(4) NOT NULL,
  `Active` char(1) NOT NULL,
  `MachineAttributeCode` varchar(20) NOT NULL,
  PRIMARY KEY (`AttributeID`)
) ENGINE=InnoDB AUTO_INCREMENT=169 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mi_ttestattribute`
--

/*!40000 ALTER TABLE `mi_ttestattribute` DISABLE KEYS */;
INSERT INTO `mi_ttestattribute` (`AttributeID`,`Machine_testid`,`LIMSAttributeID`,`LIMSAttributeName`,`MachineAttributeName`,`EnteredBy`,`EnteredOn`,`ClientId`,`Active`,`MachineAttributeCode`) VALUES 
 (4,9,'001691','Albumin','ALB',1,'2010-10-13 00:00:00','0001','Y','ALB'),
 (5,11,'003164','Plasma Ammonia','Plasma Ammonia',1,'2010-10-13 00:00:00','0001','Y','AMON'),
 (6,13,'001714','AST (GOT)','Aspartate transaminase (AST)',1,'2010-10-13 00:00:00','0001','Y','AST'),
 (7,12,'001855','Serum Amylase','Serum Amylase',1,'2010-10-13 00:00:00','0001','Y','AMY'),
 (8,14,'001682','Blood Urea','Blood Urea',1,'2010-10-13 00:00:00','0001','Y','BUN'),
 (9,15,'001679','Calcium Total','Calcium Total',1,'2010-10-13 00:00:00','0001','Y','CA'),
 (10,16,'001688','Total Cholesterol','Total Cholesterol',1,'2010-10-13 00:00:00','0001','Y','CHOL'),
 (11,17,'001667','CPK','CPK',1,'2010-10-13 00:00:00','0001','Y','CK'),
 (12,18,'001684','Serum Creatinine','Serum Creatinine',1,'2010-10-13 00:00:00','0001','Y','CREA'),
 (13,19,'001842','Bilirubin Direct','Bilirubin Direct',1,'2010-10-13 00:00:00','0001','Y','DBIL'),
 (14,20,'001770','Plasma Glucose (R)','Glucose (R)',1,'2010-10-13 00:00:00','0001','Y','GLU'),
 (15,21,'001716','LDH','LDH',1,'2010-10-13 00:00:00','0001','Y','LDH'),
 (16,22,'001680','Magnesium','Magnesium',1,'2010-10-13 00:00:00','0001','Y','MG'),
 (17,23,'001681','Phosphorous','Phosphorous (PO4```)',1,'2010-10-13 00:00:00','0001','Y','PHOS'),
 (18,24,'001693','Bilrubin Total','Bilirubin Total',1,'2010-10-13 00:00:00','0001','Y','TBIL'),
 (19,25,'001689','Triglyceride','Triglyceride',1,'2010-10-13 00:00:00','0001','Y','TGL'),
 (20,26,'001685','Uric Acid','Uric Acid',1,'2010-10-13 00:00:00','0001','Y','URCA'),
 (21,27,'001698','CEA (Carcinoemberyonic Antigen)','CEA (Carcinoemberyonic Antigen)',1,'2010-10-13 00:00:00','0001','Y','CEA'),
 (22,28,'003349','Cytomegalovirus (CMV) IgG','Cytomegalovirus (CMV) IgG',1,'2010-10-13 00:00:00','0001','Y','CVG'),
 (23,29,'003351','Cytomegalovirus (CMV) IgM','Cytomegalovirus (CMV) IgM',1,'2010-10-13 00:00:00','0001','Y','CMM A'),
 (24,30,'003483','Plasma Cortisol (morning)','Plasma Cortisol',1,'2010-10-13 00:00:00','0001','Y','COR'),
 (25,31,'003421','Estradiol','Estradiol',1,'2010-10-13 00:00:00','0001','Y','E2'),
 (26,32,'001722','fT4','fT4',1,'2010-10-13 00:00:00','0001','Y','F4'),
 (27,33,'001674','Serum Ferritin','Serum Ferritin',1,'2010-10-13 00:00:00','0001','Y','FER'),
 (28,34,'003423','FSH','FSH',1,'2010-10-13 00:00:00','0001','Y','FSH'),
 (29,35,'003123','ß-hCG','ß-hCG',1,'2010-10-13 00:00:00','0001','Y','HCG'),
 (30,36,'003540','H.pylori lgG antibodies','H.pylori lgG antibodies',1,'2010-10-13 00:00:00','0001','Y','HPG'),
 (31,37,'003426','Parathormone','Plasma Parathyroid Hormone (PTH) intact',1,'2010-10-13 00:00:00','0001','Y','iPT'),
 (32,38,'003422','LH','LH',1,'2010-10-13 00:00:00','0001','Y','LH'),
 (33,39,'001697','CA -125','CA-125',1,'2010-10-13 00:00:00','0001','Y','OV'),
 (34,40,'001699','Prostate Specific Antigen ','Prostate Specific Antigen (PSA)',1,'2010-10-13 00:00:00','0001','Y','PSA'),
 (35,41,'001721','TSH','TSH',1,'2010-10-13 00:00:00','0001','Y','TSH'),
 (36,42,'001720','T3 Total','T3 Total',1,'2010-10-13 00:00:00','0001','Y','T3'),
 (37,43,'003412','Testosterone (ARC)','Testosterone',1,'2010-10-13 00:00:00','0001','Y','TES'),
 (38,44,'003537','Thyroglobulin','Thyroglobulin',1,'2010-10-13 00:00:00','0001','Y','TG'),
 (39,45,'003357','Troponin-I','Troponin I',1,'2010-10-13 00:00:00','0001','Y','TPI'),
 (40,46,'001799','Toxoplasma IgG Antibodies','Toxoplasma IgG Antibodies',1,'2010-10-13 00:00:00','0001','Y','TXP'),
 (41,47,'001800','Toxplasma IgM Antibodies','Toxoplasma IgM Antibodies',1,'2010-10-13 00:00:00','0001','Y','TXU'),
 (42,48,'003536','Valproic Acid','Plasma Valproic Acid',1,'2010-10-13 00:00:00','0001','Y','VAL'),
 (43,50,'001721','TSH','TSH',1,'2010-11-02 00:00:00','0001','Y','10'),
 (44,51,'003412','Testosterone (ARC)','Testo',1,'2010-11-02 00:00:00','0001','Y','110'),
 (45,52,'003424','Progesterone','Prog',1,'2010-11-02 00:00:00','0001','Y','120'),
 (46,53,'001727','Prolactin','PRL',1,'2010-11-02 00:00:00','0001','Y','130'),
 (47,54,'003422','LH','LH',1,'2010-11-02 00:00:00','0001','Y','140'),
 (48,55,'003423','FSH','FSH',1,'2010-11-02 00:00:00','0001','Y','150'),
 (49,56,'003123','ß-hCG','HCG-BETA',1,'2010-11-02 00:00:00','0001','Y','761'),
 (50,57,'001722','fT4','FT4',1,'2010-11-02 00:00:00','0001','Y','30'),
 (51,58,'001698','CEA (Carcinoemberyonic Antigen)','CEA',1,'2010-11-02 00:00:00','0001','Y','301'),
 (52,59,'003125','Alpha -fetoprotiens (AFP)','AFP',1,'2010-11-02 00:00:00','0001','Y','311'),
 (53,60,'001699','Prostate Specific Antigen ','PSA',1,'2010-11-02 00:00:00','0001','Y','320'),
 (54,61,'001697','CA -125','CA-125',1,'2010-11-02 00:00:00','0001','Y','341'),
 (55,62,'002948','Hepatitis B Surface Antigen','HBSAG',1,'2010-11-02 00:00:00','0001','Y','400'),
 (56,63,'002951','Anti-HCV (Antibodies)','A-HCV',1,'2010-11-02 00:00:00','0001','Y','420'),
 (57,64,'002952','Anti-HIV I & II (Antibodies)','A-HIV',1,'2010-11-02 00:00:00','0001','Y','490'),
 (58,65,'001720','T3 Total','T3',1,'2010-11-02 00:00:00','0001','Y','50'),
 (59,66,'001750','Vit B12','B12',1,'2010-11-02 00:00:00','0001','Y','600'),
 (60,67,'001987','S. Folate','FOL',1,'2010-11-02 00:00:00','0001','Y','612'),
 (61,68,'003265','Immunoglobulin E (IgE)','IGE',1,'2010-11-02 00:00:00','0001','Y','630'),
 (62,69,'003424','Progesterone','PROG',1,'2010-11-02 00:00:00','0001','Y','191'),
 (63,70,'002950','Hepatitis Be Antigen','HBeAg',1,'2010-11-02 00:00:00','0001','Y','301'),
 (64,71,'002947','Hepatitis B Surface Antibody','Anti-HBs',1,'2010-11-02 00:00:00','0001','Y','131'),
 (65,72,'001674','Serum Ferritin','Ferritin',1,'2010-11-02 00:00:00','0001','Y','61'),
 (66,73,'003412','Testosterone (ARC)','Testost',1,'2010-11-02 00:00:00','0001','Y','231'),
 (67,74,'003523','Anti-TP antibodies','Syphilis',1,'2010-11-02 00:00:00','0001','Y','561'),
 (68,75,'003125','Alpha -fetoprotiens (AFP)','AFP_2',1,'2010-11-02 00:00:00','0001','Y','2'),
 (69,76,'002948','Hepatitis B Surface Antigen','HBsAg',1,'2010-11-02 00:00:00','0001','Y','149'),
 (70,77,'003422','LH','_LH',1,'2010-11-02 00:00:00','0001','Y','641'),
 (71,77,'003422','LH','_LH',1,'2010-11-02 00:00:00','0001','Y','641'),
 (72,79,'003423','FSH','FSH',1,'2010-11-02 00:00:00','0001','Y','81'),
 (73,80,'002949','Hepatitis Be Antibody','Anti-HBe',1,'2010-11-02 00:00:00','0001','Y','291'),
 (74,81,'003123','ß-hCG','BETAhCG',1,'2010-11-02 00:00:00','0001','Y','651'),
 (75,82,'003483','Plasma Cortisol (evening)','CortisolE',1,'2010-11-02 00:00:00','0001','Y','601'),
 (76,82,'003484','Plasma Cortisol (morning)','CortisolM',1,'2010-11-02 00:00:00','0001','Y','601'),
 (77,82,'003484','Plasma Cortisol (morning)','CortisolM',1,'2010-11-02 00:00:00','0001','Y','601'),
 (78,83,'002952','Anti-HIV I & II (Antibodies)','HIV AG/AB',1,'2010-11-02 00:00:00','0001','Y','721'),
 (79,84,'001699','Prostate Specific Antigen ','Total PSA',1,'2010-11-02 00:00:00','0001','Y','211'),
 (80,85,'003448','Hepatitis B core Total (Antibodies)','Anti-HBcII',1,'2010-11-02 00:00:00','0001','Y','580'),
 (81,86,'001727','Prolactin','Prolactin',1,'2010-11-02 00:00:00','0001','Y','201'),
 (82,87,'002951','Anti-HCV (Antibodies)','Anti-HCV',1,'2010-11-02 00:00:00','0001','Y','161'),
 (83,88,'001920','BNP','_BNP',1,'2010-11-02 00:00:00','0001','Y','739'),
 (84,89,'002953','Hepatitis A IgM antibodies','HAVAB IgM',1,'2010-11-02 00:00:00','0001','Y','321'),
 (85,90,'002952','Anti-HIV I & II (Antibodies)','HIV1_2_g0',1,'2010-11-02 00:00:00','0001','Y','829'),
 (86,91,'003349','Cytomegalovirus (CMV) IgG','CMV-G',1,'2010-11-02 00:00:00','0001','Y','743'),
 (87,92,'003351','Cytomegalovirus (CMV) IgM','CMV-M',1,'2010-11-02 00:00:00','0001','Y','744'),
 (88,93,'001721','TSH','TSH_3GEN',1,'2010-11-02 00:00:00','0001','Y','213'),
 (89,94,'001720','T3 Total','TT3-Mab',1,'2010-11-02 00:00:00','0001','Y','276'),
 (90,95,'002951','Anti-HCV (Antibodies)','HCV-3',1,'2010-11-02 00:00:00','0001','Y','841'),
 (91,96,'003423','FSH','FSH',1,'2010-11-02 00:00:00','0001','Y','37'),
 (92,97,'003422','LH','LH',1,'2010-11-02 00:00:00','0001','Y','25'),
 (93,98,'001727','Prolactin','PRL-3IS',1,'2010-11-02 00:00:00','0001','Y','55'),
 (94,99,'003424','Progesterone','PROG',1,'2010-11-02 00:00:00','0001','Y','92'),
 (95,100,'001892','D-dimer','D-dimer',1,'2010-11-02 00:00:00','0001','Y','868'),
 (96,101,'002947','Hepatitis B Surface Antibody','AUSAB',1,'2010-11-02 00:00:00','0001','Y','118'),
 (97,102,'001699','Prostate Specific Antigen ','PSA-Total',1,'2010-11-02 00:00:00','0001','Y','443'),
 (98,103,'003123','ß-hCG','B-hCG',1,'2010-11-02 00:00:00','0001','Y','16'),
 (99,104,'003412','Testosterone (ARC)','Testostrn',1,'2010-11-02 00:00:00','0001','Y','90'),
 (100,105,'002949','Hepatitis Be Antibody','Anti-HBe',1,'2010-11-02 00:00:00','0001','Y','192'),
 (101,106,'001674','Serum Ferritin','Ferritin',1,'2010-11-02 00:00:00','0001','Y','321'),
 (102,107,'003448','Hepatitis B core Total (Antibodies)','CORE',1,'2010-11-02 00:00:00','0001','Y','126'),
 (103,108,'002950','Hepatitis Be Antigen','HBe_2',1,'2010-11-02 00:00:00','0001','Y','193'),
 (104,109,'002948','Hepatitis B Surface Antigen','HBsAg',1,'2010-11-02 00:00:00','0001','Y','106'),
 (105,110,'003126','Plasma Cyclosporin A (CsA) level','Cyclo',1,'2010-11-02 00:00:00','0001','Y','693'),
 (106,111,'001722','fT4','Free-T4',1,'2010-11-02 00:00:00','0001','Y','219'),
 (107,112,'003125','Alpha -fetoprotiens (AFP)','AFP',1,'2010-11-02 00:00:00','0001','Y','728'),
 (108,113,'001695','Plasma Digoxin Level','Digoxin',1,'2010-11-02 00:00:00','0001','Y','601'),
 (109,114,'003421','Estradiol','Estradiol',1,'2010-11-02 00:00:00','0001','Y','71'),
 (110,115,'001920','BNP','BNP',1,'2010-11-02 00:00:00','0001','Y','377'),
 (111,116,'001859','Rubella IgG','RubellaG',1,'2010-11-02 00:00:00','0001','Y','723'),
 (112,117,'001860','Rubella IgM','RubellaM',1,'2010-11-02 00:00:00','0001','Y','754'),
 (113,118,'001799','Toxoplasma IgG Antibodies','TOXO-G',1,'2010-11-02 00:00:00','0001','Y','712'),
 (114,119,'001800','Toxplasma IgM Antibodies','TOXO-M',1,'2010-11-02 00:00:00','0001','Y','734'),
 (115,120,'003357','Troponin-I','TnI-ADV',1,'2010-11-02 00:00:00','0001','Y','313'),
 (116,121,'003483','Plasma Cortisol (evening)','CortisolE',1,'2010-11-02 00:00:00','0001','Y','848'),
 (117,121,'003483','Plasma Cortisol (evening)','CortisolE',1,'2010-11-02 00:00:00','0001','Y','848'),
 (118,121,'003484','Plasma Cortisol (morning)','CortisolM',1,'2010-11-02 00:00:00','0001','Y','848'),
 (119,122,'002953','Hepatitis A IgM antibodies','HAVABM_2',1,'2010-11-02 00:00:00','0001','Y','140'),
 (120,123,'002945','Hepatitis B Core IgM','COREM',1,'2010-11-02 00:00:00','0001','Y','165'),
 (121,124,'001717','Myoglobin','Myoglobin',1,'2010-11-02 00:00:00','0001','Y','350'),
 (122,125,'002872','P Vancomycin Level (Peak)','Vanco_II',1,'2010-11-02 00:00:00','0001','Y','668'),
 (123,125,'002872','P Vancomycin Level (Peak)','Vanco_II',1,'2010-11-02 00:00:00','0001','Y','668'),
 (124,125,'002873','P Vancomycin Level (Trough)','Vanco_II (Trough)',1,'2010-11-02 00:00:00','0001','Y','668'),
 (125,125,'002872','P Vancomycin Level (Peak)','Vanco_II (Peak)',1,'2010-11-02 00:00:00','0001','Y','668'),
 (126,125,'002873','P Vancomycin Level (Trough)','Vanco_II (Trough)',1,'2010-11-02 00:00:00','0001','Y','668'),
 (127,126,'001921','P Gentamicin Level (Peak)','Gent (Peak)',1,'2010-11-02 00:00:00','0001','Y','645'),
 (128,126,'001921','P Gentamicin Level (Peak)','Gent (Peak)',1,'2010-11-02 00:00:00','0001','Y','645'),
 (129,126,'002877','P Gentamicin Level (Random)','Gent (Random)',1,'2010-11-02 00:00:00','0001','Y','645'),
 (130,126,'001921','P Gentamicin Level (Peak)','Gent (Peak)',1,'2010-11-02 00:00:00','0001','Y','645'),
 (131,126,'002877','P Gentamicin Level (Random)','Gent (Random)',1,'2010-11-02 00:00:00','0001','Y','645'),
 (132,126,'002876','P Gentamicin Level (Trough)','Gent (Trough)',1,'2010-11-02 00:00:00','0001','Y','645'),
 (133,10,'001692','Alkaline Phosphatase','Alkaline Phosphatase',1,'2010-11-02 00:00:00','0001','Y','ALP'),
 (134,127,'001690','Alanine Transaminase (ALT)','ALT',1,'2010-11-02 00:00:00','0001','Y','ALT'),
 (135,128,'002951','Anti-HCV (Antibodies)','aHCV',1,'2010-12-05 00:00:00','0001','Y','aHCV'),
 (136,129,'003357','Troponin-I','TropI',1,'2010-12-05 00:00:00','0001','Y','0544'),
 (137,130,'001721','TSH','TSH',1,'2010-12-05 00:00:00','0001','Y','001'),
 (138,131,'001720','T3 Total','TT3',1,'2010-12-05 00:00:00','0001','Y','003'),
 (139,132,'001722','fT4','FT4',1,'2010-12-05 00:00:00','0001','Y','004'),
 (140,133,'003421','Estradiol','E2',1,'2010-12-05 00:00:00','0001','Y','008'),
 (141,134,'003422','LH','LH',1,'2010-12-05 00:00:00','0001','Y','009'),
 (142,135,'003423','FSH','FSH',1,'2010-12-05 00:00:00','0001','Y','010'),
 (143,136,'001727','Prolactin','PROL',1,'2010-12-05 00:00:00','0001','Y','011'),
 (144,137,'003424','Progesterone','PROG',1,'2010-12-05 00:00:00','0001','Y','012'),
 (145,138,'003123','ß-hCG','B-hCG',1,'2010-12-05 00:00:00','0001','Y','013'),
 (146,139,'003412','Testosterone (ARC)','TESTO',1,'2010-12-05 00:00:00','0001','Y','014'),
 (147,140,'003125','Alpha -fetoprotiens (AFP)','AFP',1,'2010-12-05 00:00:00','0001','Y','015'),
 (148,141,'001698','CEA (Carcinoemberyonic Antigen)','CEA',1,'2010-12-05 00:00:00','0001','Y','016'),
 (149,142,'002948','Hepatitis B Surface Antigen','HBsAg',1,'2010-12-05 00:00:00','0001','Y','HBsAg'),
 (150,143,'002947','Hepatitis B Surface Antibody','aHBS',1,'2010-12-05 00:00:00','0001','Y','018'),
 (151,144,'003448','Hepatitis B core Total (Antibodies)','aHBC',1,'2010-12-05 00:00:00','0001','Y','019'),
 (152,145,'002945','Hepatitis B Core IgM','aHBcM',1,'2010-12-05 00:00:00','0001','Y','020'),
 (153,146,'002950','Hepatitis Be Antigen','HBeAg',1,'2010-12-05 00:00:00','0001','Y','021'),
 (154,147,'002952','Anti-HIV I & II (Antibodies)','aHIV',1,'2010-12-05 00:00:00','0001','Y','aHIV'),
 (155,148,'001859','Rubella IgG','Rub G',1,'2010-12-05 00:00:00','0001','Y','025'),
 (156,149,'001860','Rubella IgM','Rub M',1,'2010-12-05 00:00:00','0001','Y','026'),
 (157,150,'001799','Toxoplasma IgG Antibodies','TOX G',1,'2010-12-05 00:00:00','0001','Y','027'),
 (158,151,'001800','Toxplasma IgM Antibodies','TOX M',1,'2010-12-05 00:00:00','0001','Y','028'),
 (159,152,'001674','Serum Ferritin','FERR',1,'2010-12-05 00:00:00','0001','Y','031'),
 (160,153,'001750','Vit B12','B12',1,'2010-12-05 00:00:00','0001','Y','032'),
 (161,154,'001987','S. Folate','FOLAT',1,'2010-12-05 00:00:00','0001','Y','033'),
 (162,155,'003483','Plasma Cortisol (evening)','CORT E',1,'2010-12-05 00:00:00','0001','Y','034'),
 (163,155,'003483','Plasma Cortisol (evening)','CORT E',1,'2010-12-05 00:00:00','0001','Y','034'),
 (164,155,'003484','Plasma Cortisol (morning)','CORT M',1,'2010-12-05 00:00:00','0001','Y','034'),
 (165,156,'001699','Prostate Specific Antigen ','PSA',1,'2010-12-05 00:00:00','0001','Y','036'),
 (166,157,'001697','CA -125','CA125',1,'2010-12-05 00:00:00','0001','Y','038'),
 (167,158,'002970','CA 15-3','CA153',1,'2010-12-05 00:00:00','0001','Y','039'),
 (168,158,'002970','CA 15-3','CA153',1,'2010-12-05 00:00:00','0001','Y','039');
/*!40000 ALTER TABLE `mi_ttestattribute` ENABLE KEYS */;


--
-- Definition of table `mi_ttests`
--

DROP TABLE IF EXISTS `mi_ttests`;
CREATE TABLE `mi_ttests` (
  `Machine_testid` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Lims_testid` char(6) NOT NULL,
  `Lims_test_name` varchar(200) NOT NULL,
  `Machine_Test_name` varchar(200) NOT NULL,
  `LOINC_code` varchar(45) DEFAULT NULL,
  `Instrumentid` int(10) unsigned NOT NULL,
  `EnteredBy` int(10) unsigned NOT NULL,
  `EnteredOn` datetime NOT NULL,
  `ClientID` char(4) NOT NULL,
  `Active` char(1) NOT NULL,
  `DeptID` char(3) DEFAULT NULL,
  `MachineTestCode` varchar(20) NOT NULL,
  PRIMARY KEY (`Machine_testid`)
) ENGINE=InnoDB AUTO_INCREMENT=159 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mi_ttests`
--

/*!40000 ALTER TABLE `mi_ttests` DISABLE KEYS */;
INSERT INTO `mi_ttests` (`Machine_testid`,`Lims_testid`,`Lims_test_name`,`Machine_Test_name`,`LOINC_code`,`Instrumentid`,`EnteredBy`,`EnteredOn`,`ClientID`,`Active`,`DeptID`,`MachineTestCode`) VALUES 
 (9,'000805','Albumin','Albumin','',10,1,'2010-10-13 00:00:00','0001','Y','006','ALB'),
 (10,'000804','Alkaline Phosphatase','Alkaline Phosphatase','',10,1,'2010-10-13 00:00:00','0001','Y','006','ALP'),
 (11,'001081','Plasma Ammonia','Plasma Ammonia','',10,1,'2010-10-13 00:00:00','0001','Y','006','AMON'),
 (12,'000919','Serum Amylase','Serum Amylase','',10,1,'2010-10-13 00:00:00','0001','Y','006','AMY'),
 (13,'000859','Aspartate transaminase (AST)','Aspartate transaminase (AST)','',10,1,'2010-10-13 00:00:00','0001','Y','006','AST'),
 (14,'000813','Blood Urea','Blood Urea','',10,1,'2010-10-13 00:00:00','0001','Y','006','BUN'),
 (15,'000798','Calcium Total','Calcium Total','',10,1,'2010-10-13 00:00:00','0001','Y','006','CA'),
 (16,'000817','Total Cholesterol','Total Cholesterol','',10,1,'2010-10-13 00:00:00','0001','Y','006','CHOL'),
 (17,'000809','CPK','CPK','',10,1,'2010-10-13 00:00:00','0001','Y','006','CK'),
 (18,'000814','Serum Creatinine','Serum Creatinine','',10,1,'2010-10-13 00:00:00','0001','Y','006','Crea'),
 (19,'000915','Bilirubin Direct','Bilirubin Direct','',10,1,'2010-10-13 00:00:00','0001','Y','006','DBIL'),
 (20,'000898','Glucose (R)','Glucose (R)','',10,1,'2010-10-13 00:00:00','0001','Y','006','GLU'),
 (21,'000812','LDH','LDH','',10,1,'2010-10-13 00:00:00','0001','Y','006','LDH'),
 (22,'000801','Magnesium','Magnesium','',10,1,'2010-10-13 00:00:00','0001','Y','006','MG'),
 (23,'000800','Phosphorous (PO4```)','Phosphorous (PO4```)','',10,1,'2010-10-13 00:00:00','0001','Y','006','PHOS'),
 (24,'000802','Bilirubin Total','Bilirubin Total','',10,1,'2010-10-13 00:00:00','0001','Y','006','TBIL'),
 (25,'000818','Triglyceride','Triglyceride','',10,1,'2010-10-13 00:00:00','0001','Y','006','TGL'),
 (26,'000815','Uric Acid','Uric Acid','',10,1,'2010-10-13 00:00:00','0001','Y','006','URCA'),
 (27,'000822','CEA (Carcinoemberyonic Antigen)','CEA (Carcinoemberyonic Antigen)','',9,1,'2010-10-13 00:00:00','0001','Y','006','CEA'),
 (28,'001136','Cytomegalovirus  (CMV) IgG','Cytomegalovirus (CMV) IgG','',9,1,'2010-10-13 00:00:00','0001','Y','002','CVG'),
 (29,'001137','Cytomegalovirus  (CMV) IgM','Cytomegalovirus (CMV) IgM','',9,1,'2010-10-13 00:00:00','0001','Y','002','CMM A'),
 (30,'001166','Plasma Cortisol','Plasma Cortisol','',9,1,'2010-10-13 00:00:00','0001','Y','010','COR'),
 (31,'001142','Estradiol ARC','Estradiol','',9,1,'2010-10-13 00:00:00','0001','Y','010','E2'),
 (32,'000868','fT4','fT4','',9,1,'2010-10-13 00:00:00','0001','Y','010','F4'),
 (33,'000848','Serum Ferritin','Serum Ferritin','',9,1,'2010-10-13 00:00:00','0001','Y','006','FER'),
 (34,'001144','FSH ARC','FSH','',9,1,'2010-10-13 00:00:00','0001','Y','010','FSH'),
 (35,'001067','ß-hCG (Roche)','ß-hCG','',9,1,'2010-10-13 00:00:00','0001','Y','010','HCG'),
 (36,'001183','H.pylori lgG antibodies','H.pylori lgG antibodies','',9,1,'2010-10-13 00:00:00','0001','Y','002','HPG'),
 (37,'001147','Plasma Parathyroid Hormone (PTH) intact','Plasma Parathyroid Hormone (PTH) intact','',9,1,'2010-10-13 00:00:00','0001','Y','010','iPT'),
 (38,'001143','LH ARC','LH','',9,1,'2010-10-13 00:00:00','0001','Y','010','LH'),
 (39,'000821','CA -125','CA-125','',9,1,'2010-10-13 00:00:00','0001','Y','006','OV'),
 (40,'000823','Prostate Specific Antigen (PSA)','Prostate Specific Antigen (PSA)','',9,1,'2010-10-13 00:00:00','0001','Y','006','PSA'),
 (41,'000863','TSH','TSH','',9,1,'2010-10-13 00:00:00','0001','Y','010','RTH'),
 (42,'000865','T3 Total','T3 Total','',9,1,'2010-10-13 00:00:00','0001','Y','010','T3'),
 (43,'000871','Testosterone','Testosterone','',9,1,'2010-10-13 00:00:00','0001','Y','010','TES'),
 (44,'001182','Thyroglobulin','Thyroglobulin','',9,1,'2010-10-13 00:00:00','0001','Y','002','TG'),
 (45,'001140','Troponin I','Troponin I','',9,1,'2010-10-13 00:00:00','0001','Y','006','TPI'),
 (46,'000845','Toxoplasma IgG Antibodies','Toxoplasma IgG Antibodies','',9,1,'2010-10-13 00:00:00','0001','Y','002','TXP'),
 (47,'000846','Toxoplasma IgM Antibodies','Toxoplasma IgM Antibodies','',9,1,'2010-10-13 00:00:00','0001','Y','002','TXU'),
 (48,'001181','Plasma Valproic Acid','Plasma Valproic Acid','',9,1,'2010-10-13 00:00:00','0001','Y','006','VAL'),
 (49,'000803','Alanine Transaminase (ALT)','ALT','',8,1,'2010-10-29 00:00:00','0001','Y','006','8'),
 (50,'000863','TSH','TSH','',5,1,'2010-11-02 00:00:00','0001','Y','010','10'),
 (51,'000871','Testosterone','Testo','',5,1,'2010-11-02 00:00:00','0001','Y','010','110'),
 (52,'001145','Progesterone ARC','Prog','',5,1,'2010-11-02 00:00:00','0001','Y','010','120'),
 (53,'000864','Prolactin','PRL','',5,1,'2010-11-02 00:00:00','0001','Y','010','130'),
 (54,'001143','LH ARC','LH','',5,1,'2010-11-02 00:00:00','0001','Y','010','140'),
 (55,'001144','FSH ARC','FSH','',5,1,'2010-11-02 00:00:00','0001','Y','010','150'),
 (56,'001067','ß-hCG (Roche)','HCG-BETA','',5,1,'2010-11-02 00:00:00','0001','Y','010','761'),
 (57,'000868','fT4','FT4','',5,1,'2010-11-02 00:00:00','0001','Y','010','30'),
 (58,'000822','CEA (Carcinoemberyonic Antigen)','CEA','',5,1,'2010-11-02 00:00:00','0001','Y','006','301'),
 (59,'001069','Alpha-fetoproteins (AFP)','AFP','',5,1,'2010-11-02 00:00:00','0001','Y','006','311'),
 (60,'000823','Prostate Specific Antigen (PSA)','PSA','',5,1,'2010-11-02 00:00:00','0001','Y','006','320'),
 (61,'000821','CA -125','CA-125','',5,1,'2010-11-02 00:00:00','0001','Y','006','341'),
 (62,'001032','Hepatitis B Surface Antigen','HBSAG','',5,1,'2010-11-02 00:00:00','0001','Y','002','400'),
 (63,'001039','Anti-Hepatitis C (HCV) Antibodies','A-HCV','',5,1,'2010-11-02 00:00:00','0001','Y','002','420'),
 (64,'001040','Anti-HIV Antibodies','A-HIV','',5,1,'2010-11-02 00:00:00','0001','Y','002','490'),
 (65,'000865','T3 Total','T3','',5,1,'2010-11-02 00:00:00','0001','Y','010','50'),
 (66,'000891','Vitamin B12','B12','',5,1,'2010-11-02 00:00:00','0001','Y','006','600'),
 (67,'000849','Serum Folate','FOL','',5,1,'2010-11-02 00:00:00','0001','Y','006','612'),
 (68,'001113','Immunoglobulin E (IgE)','IGE','',5,1,'2010-11-02 00:00:00','0001','Y','006','630'),
 (69,'001145','Progesterone ARC','PROG','',4,1,'2010-11-02 00:00:00','0001','Y','010','191'),
 (70,'001034','Hepatitis Be Antigen','HBeAg','',4,1,'2010-11-02 00:00:00','0001','Y','002','301'),
 (71,'001033','Anti-Hepatitis B Suface Antibodies','Anti-HBs','',4,1,'2010-11-02 00:00:00','0001','Y','002','131'),
 (72,'000848','Serum Ferritin','Ferritin','',4,1,'2010-11-02 00:00:00','0001','Y','006','61'),
 (73,'000871','Testosterone','Testost','',4,1,'2010-11-02 00:00:00','0001','Y','010','231'),
 (74,'001175','Anti-TP antibodies','Syphilis','',4,1,'2010-11-02 00:00:00','0001','Y','002','561'),
 (75,'001069','Alpha-fetoproteins (AFP)','AFP_2','',4,1,'2010-11-02 00:00:00','0001','Y','006','2'),
 (76,'001032','Hepatitis B Surface Antigen','HBsAg','',4,1,'2010-11-02 00:00:00','0001','Y','002','149'),
 (77,'001143','LH ARC','_LH','',4,1,'2010-11-02 00:00:00','0001','Y','010','641'),
 (78,'001037','Anti-Hepatitis B core IgM Antibodies','HBcAb-IgM','',4,1,'2010-11-02 00:00:00','0001','Y','002','281'),
 (79,'001144','FSH ARC','FSH','',4,1,'2010-11-02 00:00:00','0001','Y','010','81'),
 (80,'001035','Anti-Hepatitis Be Antibodies','Anti-HBe','',4,1,'2010-11-02 00:00:00','0001','Y','002','291'),
 (81,'001067','ß-hCG (Roche)','BETAhCG','',4,1,'2010-11-02 00:00:00','0001','Y','010','651'),
 (82,'001166','Plasma Cortisol','Cortisol','',4,1,'2010-11-02 00:00:00','0001','Y','010','601'),
 (83,'001040','Anti-HIV Antibodies','HIV AG/AB','',4,1,'2010-11-02 00:00:00','0001','Y','002','721'),
 (84,'000823','Prostate Specific Antigen (PSA)','Total PSA','',4,1,'2010-11-02 00:00:00','0001','Y','006','211'),
 (85,'001153','Anti-Hepatitis B core Total Antibodies ARC','Anti-HBcII','',4,1,'2010-11-02 00:00:00','0001','Y','002','580'),
 (86,'000864','Prolactin','Prolactin','',4,1,'2010-11-02 00:00:00','0001','Y','010','201'),
 (87,'001039','Anti-Hepatitis C (HCV) Antibodies','Anti-HCV','',4,1,'2010-11-02 00:00:00','0001','Y','002','161'),
 (88,'000970','BNP','_BNP','',4,1,'2010-11-02 00:00:00','0001','Y','006','739'),
 (89,'001038','Anti-Hepatitis A IgM Antibodies','HAVAB IgM','',4,1,'2010-11-02 00:00:00','0001','Y','002','321'),
 (90,'001040','Anti-HIV Antibodies','HIV1_2_g0','',3,1,'2010-11-02 00:00:00','0001','Y','002','829'),
 (91,'001136','Cytomegalovirus  (CMV) IgG','CMV-G','',3,1,'2010-11-02 00:00:00','0001','Y','002','743'),
 (92,'001137','Cytomegalovirus  (CMV) IgM','CMV-M','',3,1,'2010-11-02 00:00:00','0001','Y','002','744'),
 (93,'000863','TSH','TSH_3GEN','',3,1,'2010-11-02 00:00:00','0001','Y','010','213'),
 (94,'000865','T3 Total','TT3-Mab','',3,1,'2010-11-02 00:00:00','0001','Y','010','276'),
 (95,'001039','Anti-Hepatitis C (HCV) Antibodies','HCV-3','',3,1,'2010-11-02 00:00:00','0001','Y','002','841'),
 (96,'001144','FSH ARC','FSH','',3,1,'2010-11-02 00:00:00','0001','Y','010','37'),
 (97,'001143','LH ARC','LH','',3,1,'2010-11-02 00:00:00','0001','Y','010','25'),
 (98,'000864','Prolactin','PRL-3IS','',3,1,'2010-11-02 00:00:00','0001','Y','010','55'),
 (99,'001145','Progesterone ARC','PROG','',3,1,'2010-11-02 00:00:00','0001','Y','010','92'),
 (100,'000892','D-dimer','D-dimer','',3,1,'2010-11-02 00:00:00','0001','Y','007','868'),
 (101,'001033','Anti-Hepatitis B Suface Antibodies','AUSAB','',3,1,'2010-11-02 00:00:00','0001','Y','002','118'),
 (102,'000823','Prostate Specific Antigen (PSA)','PSA-Total','',3,1,'2010-11-02 00:00:00','0001','Y','006','443'),
 (103,'001067','ß-hCG (Roche)','B-hCG','',3,1,'2010-11-02 00:00:00','0001','Y','010','16'),
 (104,'000871','Testosterone','Testostrn','',3,1,'2010-11-02 00:00:00','0001','Y','010','90'),
 (105,'001035','Anti-Hepatitis Be Antibodies','Anti-HBe','',3,1,'2010-11-02 00:00:00','0001','Y','002','192'),
 (106,'000848','Serum Ferritin','Ferritin','',3,1,'2010-11-02 00:00:00','0001','Y','006','321'),
 (107,'001153','Anti-Hepatitis B core Total Antibodies ARC','CORE','',3,1,'2010-11-02 00:00:00','0001','Y','002','126'),
 (108,'001034','Hepatitis Be Antigen','HBe_2','',3,1,'2010-11-02 00:00:00','0001','Y','002','193'),
 (109,'001032','Hepatitis B Surface Antigen','HBsAg','',3,1,'2010-11-02 00:00:00','0001','Y','002','106'),
 (110,'001070','Plasma Cyclosporin (CsA) level','Cyclo','',3,1,'2010-11-02 00:00:00','0001','Y','006','693'),
 (111,'000868','fT4','Free-T4','',3,1,'2010-11-02 00:00:00','0001','Y','010','219'),
 (112,'001069','Alpha-fetoproteins (AFP)','AFP','',3,1,'2010-11-02 00:00:00','0001','Y','006','428'),
 (113,'000807','Plasma Digoxin Level','Digoxin','',3,1,'2010-11-02 00:00:00','0001','Y','006','601'),
 (114,'001142','Estradiol ARC','Estradiol','',3,1,'2010-11-02 00:00:00','0001','Y','010','71'),
 (115,'000970','BNP','BNP','',3,1,'2010-11-02 00:00:00','0001','Y','006','377'),
 (116,'000923','Rubella IgG','RubellaG','',3,1,'2010-11-02 00:00:00','0001','Y','002','723'),
 (117,'000924','Rubella IgM','RubellaM','',3,1,'2010-11-02 00:00:00','0001','Y','002','754'),
 (118,'000845','Toxoplasma IgG Antibodies','TOXO-G','',3,1,'2010-11-02 00:00:00','0001','Y','002','712'),
 (119,'000846','Toxoplasma IgM Antibodies','TOXO-M','',3,1,'2010-11-02 00:00:00','0001','Y','002','734'),
 (120,'001140','Troponin I','TnI-ADV','',3,1,'2010-11-02 00:00:00','0001','Y','006','313'),
 (121,'001166','Plasma Cortisol','Cortiso','',3,1,'2010-11-02 00:00:00','0001','Y','010','848'),
 (122,'001038','Anti-Hepatitis A IgM Antibodies','HAVABM_2','',3,1,'2010-11-02 00:00:00','0001','Y','002','140'),
 (123,'001037','Anti-Hepatitis B core IgM Antibodies','COREM','',3,1,'2010-11-02 00:00:00','0001','Y','002','165'),
 (124,'000860','Myoglobin','Myoglobin','',3,1,'2010-11-02 00:00:00','0001','Y','006','350'),
 (125,'000969','Plasma Vancomycin Level','Vanco_II','',3,1,'2010-11-02 00:00:00','0001','Y','006','668'),
 (126,'000968','Plasma Gentamicin Level','Gent','',3,1,'2010-11-02 00:00:00','0001','Y','006','645'),
 (127,'000803','Alanine Transaminase (ALT)','ALT','',10,1,'2010-11-02 00:00:00','0001','Y','006','ALT'),
 (128,'001039','Anti-Hepatitis C (HCV) Antibodies','aHCV','',17,1,'2010-12-05 00:00:00','0001','Y','002','023'),
 (129,'001140','Troponin I','TropI','',17,1,'2010-12-05 00:00:00','0001','Y','006','030'),
 (130,'000863','TSH','TSH','',17,1,'2010-12-05 00:00:00','0001','Y','010','001'),
 (131,'000865','T3 Total','TT3','',17,1,'2010-12-05 00:00:00','0001','Y','010','003'),
 (132,'000868','fT4','FT4','',17,1,'2010-12-05 00:00:00','0001','Y','010','004'),
 (133,'001142','Estradiol ARC','E2','',17,1,'2010-12-05 00:00:00','0001','Y','010','008'),
 (134,'001143','LH ARC','LH','',17,1,'2010-12-05 00:00:00','0001','Y','010','009'),
 (135,'001144','FSH ARC','FSH','',17,1,'2010-12-05 00:00:00','0001','Y','010','010'),
 (136,'000864','Prolactin','PROL','',17,1,'2010-12-05 00:00:00','0001','Y','010','011'),
 (137,'001145','Progesterone ARC','PROG','',17,1,'2010-12-05 00:00:00','0001','Y','010','012'),
 (138,'001067','ß-hCG (Roche)','B-hCG','',17,1,'2010-12-05 00:00:00','0001','Y','010','013'),
 (139,'000871','Testosterone','TESTO','',17,1,'2010-12-05 00:00:00','0001','Y','010','014'),
 (140,'001069','Alpha-fetoproteins (AFP)','AFP','',17,1,'2010-12-05 00:00:00','0001','Y','006','015'),
 (141,'000822','CEA (Carcinoemberyonic Antigen)','CEA','',17,1,'2010-12-05 00:00:00','0001','Y','006','016'),
 (142,'001032','Hepatitis B Surface Antigen','HBsAg','',17,1,'2010-12-05 00:00:00','0001','Y','002','017'),
 (143,'001033','Anti-Hepatitis B Suface Antibodies','aHBS','',17,1,'2010-12-05 00:00:00','0001','Y','002','018'),
 (144,'001153','Anti-Hepatitis B core Total Antibodies ARC','aHBC','',17,1,'2010-12-05 00:00:00','0001','Y','002','019'),
 (145,'001037','Anti-Hepatitis B core IgM Antibodies','aHBcM','',17,1,'2010-12-05 00:00:00','0001','Y','002','020'),
 (146,'001034','Hepatitis Be Antigen','HBeAg','',17,1,'2010-12-05 00:00:00','0001','Y','002','021'),
 (147,'001040','Anti-HIV Antibodies','aHIV','',17,1,'2010-12-05 00:00:00','0001','Y','002','024'),
 (148,'000923','Rubella IgG','Rub G','',17,1,'2010-12-05 00:00:00','0001','Y','002','025'),
 (149,'000924','Rubella IgM','Rub M','',17,1,'2010-12-05 00:00:00','0001','Y','002','026'),
 (150,'000845','Toxoplasma IgG Antibodies','TOX G','',17,1,'2010-12-05 00:00:00','0001','Y','002','027'),
 (151,'000846','Toxoplasma IgM Antibodies','TOX M','',17,1,'2010-12-05 00:00:00','0001','Y','002','028'),
 (152,'000848','Serum Ferritin','FERR','',17,1,'2010-12-05 00:00:00','0001','Y','006','031'),
 (153,'000891','Vitamin B12','B12','',17,1,'2010-12-05 00:00:00','0001','Y','006','032'),
 (154,'000849','Serum Folate','FOLAT','',17,1,'2010-12-05 00:00:00','0001','Y','006','033'),
 (155,'001166','Plasma Cortisol','CORT','',17,1,'2010-12-05 00:00:00','0001','Y','010','034'),
 (156,'000823','Prostate Specific Antigen (PSA)','PSA','',17,1,'2010-12-05 00:00:00','0001','Y','006','036'),
 (157,'000821','CA -125','CA125','',17,1,'2010-12-05 00:00:00','0001','Y','006','038'),
 (158,'001047','CA 15-3','CA153','',17,1,'2010-12-05 00:00:00','0001','Y','006','039');
/*!40000 ALTER TABLE `mi_ttests` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
