-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.21-community-nt


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
  `Parameter2` varchar(45) default NULL,
  `Parameter3` varchar(45) default NULL,
  `Parameter4` varchar(45) default NULL,
  PRIMARY KEY  (`ID`)
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
  `BookingID` int(10) unsigned NOT NULL auto_increment,
  `LabID` varchar(20) default NULL,
  `PatientID` int(10) unsigned default NULL,
  `Patient_name` varchar(150) default NULL,
  `Test_Code` varchar(50) NOT NULL,
  `Machine_TestID` varchar(50) NOT NULL,
  `Test_Name` varchar(100) NOT NULL,
  `InstrumentID` int(10) unsigned NOT NULL,
  `Machine_Time` datetime default NULL,
  `SeqID` varchar(50) default NULL,
  `BatchNo` varchar(50) default NULL,
  `Sample_Type` varchar(50) default NULL,
  `EnteredBy` int(10) unsigned NOT NULL,
  `EnteredOn` datetime NOT NULL,
  `ClientID` char(4) NOT NULL,
  `Active` char(1) NOT NULL,
  `SendOn` datetime default NULL,
  `ReceivedOn` datetime default NULL,
  PRIMARY KEY  (`BookingID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mi_tbooking`
--

/*!40000 ALTER TABLE `mi_tbooking` DISABLE KEYS */;
INSERT INTO `mi_tbooking` (`BookingID`,`LabID`,`PatientID`,`Patient_name`,`Test_Code`,`Machine_TestID`,`Test_Name`,`InstrumentID`,`Machine_Time`,`SeqID`,`BatchNo`,`Sample_Type`,`EnteredBy`,`EnteredOn`,`ClientID`,`Active`,`SendOn`,`ReceivedOn`) VALUES 
 (1,'136028',NULL,NULL,'1','36','TSH',17,NULL,NULL,NULL,NULL,1,'2017-09-23 13:34:00','0001','Y','2017-09-23 01:34:00','2017-09-23 13:34:00'),
 (2,'135850',NULL,NULL,'1','36','TSH',17,NULL,NULL,NULL,NULL,1,'2017-09-23 14:19:00','0001','Y','2017-09-23 02:19:00','2017-09-23 14:19:00'),
 (3,'135850',NULL,NULL,'201','21','FT4 II',17,NULL,NULL,NULL,NULL,1,'2017-09-23 14:19:00','0001','Y','2017-09-23 02:19:00','2017-09-23 14:19:00'),
 (4,'136015',NULL,NULL,'731','29','LIPC',17,NULL,NULL,NULL,NULL,1,'2017-09-23 14:19:00','0001','Y','2017-09-23 02:19:00','2017-09-23 14:19:00'),
 (5,'136045',NULL,NULL,'690','19','CREJ2',17,NULL,NULL,NULL,NULL,1,'2017-09-23 14:19:00','0001','Y','2017-09-23 02:19:00','2017-09-23 14:19:00'),
 (6,'136045',NULL,NULL,'418','37','UREAL',17,NULL,NULL,NULL,NULL,1,'2017-09-23 14:19:00','0001','Y','2017-09-23 02:19:00','2017-09-23 14:19:00'),
 (7,'136043',NULL,NULL,'661','43','IRON2',17,NULL,NULL,NULL,NULL,1,'2017-09-23 14:19:00','0001','Y','2017-09-23 02:19:00','2017-09-23 14:19:00'),
 (8,'136043',NULL,NULL,'962','46','TIBC',17,NULL,NULL,NULL,NULL,1,'2017-09-23 14:19:00','0001','Y','2017-09-23 02:19:00','2017-09-23 14:19:00'),
 (9,'120598',NULL,NULL,'690','19','CREJ2',17,NULL,NULL,NULL,NULL,1,'2017-09-23 14:20:00','0001','Y','2017-09-23 02:20:00','2017-09-23 14:20:00'),
 (10,'120598',NULL,NULL,'418','37','UREAL',17,NULL,NULL,NULL,NULL,1,'2017-09-23 14:20:00','0001','Y','2017-09-23 02:20:00','2017-09-23 14:20:00'),
 (11,'120125',NULL,NULL,'465','42','IGM-2',17,NULL,NULL,NULL,NULL,1,'2017-09-23 14:20:00','0001','Y','2017-09-23 02:20:00','2017-09-23 14:20:00'),
 (12,'120125',NULL,NULL,'458','39','IGA-2',17,NULL,NULL,NULL,NULL,1,'2017-09-23 14:20:00','0001','Y','2017-09-23 02:20:00','2017-09-23 14:20:00'),
 (13,'120125',NULL,NULL,'674','41','IGG-2',17,NULL,NULL,NULL,NULL,1,'2017-09-23 14:20:00','0001','Y','2017-09-23 02:20:00','2017-09-23 14:20:00'),
 (14,'120573',NULL,NULL,'465','42','IGM-2',17,NULL,NULL,NULL,NULL,1,'2017-09-23 14:20:00','0001','Y','2017-09-23 02:20:00','2017-09-23 14:20:00'),
 (15,'120573',NULL,NULL,'458','39','IGA-2',17,NULL,NULL,NULL,NULL,1,'2017-09-23 14:20:00','0001','Y','2017-09-23 02:20:00','2017-09-23 14:20:00'),
 (16,'120573',NULL,NULL,'674','41','IGG-2',17,NULL,NULL,NULL,NULL,1,'2017-09-23 14:20:00','0001','Y','2017-09-23 02:20:00','2017-09-23 14:20:00');
/*!40000 ALTER TABLE `mi_tbooking` ENABLE KEYS */;


--
-- Definition of table `mi_tinstruments`
--

DROP TABLE IF EXISTS `mi_tinstruments`;
CREATE TABLE `mi_tinstruments` (
  `InstrumentID` int(10) unsigned NOT NULL auto_increment,
  `Supplierid` int(10) unsigned NOT NULL,
  `Instrument_Name` varchar(150) NOT NULL,
  `Model` varchar(50) NOT NULL,
  `I_Release` varchar(50) default NULL,
  `Description` varchar(1000) default NULL,
  `Manual` varchar(150) default NULL,
  `Patient_no_format` varchar(50) default NULL,
  `BarCode_Standard` varchar(100) default NULL,
  `Bidirectional` char(1) NOT NULL,
  `Communication_Stnadard` varchar(50) NOT NULL,
  `Communication_method` varchar(50) NOT NULL,
  `PORT` varchar(10) NOT NULL,
  `BaudRate` int(10) unsigned NOT NULL,
  `Parity` varchar(10) NOT NULL,
  `Stopbit` varchar(10) NOT NULL,
  `DataBit` varchar(10) NOT NULL,
  `FlowControl` varchar(10) NOT NULL,
  `Acknowledgement_code` int(10) unsigned default NULL,
  `EnteredBy` int(10) unsigned NOT NULL,
  `EnteredOn` datetime NOT NULL,
  `ClientID` varchar(45) NOT NULL,
  `Active` char(1) NOT NULL,
  PRIMARY KEY  (`InstrumentID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mi_tinstruments`
--

/*!40000 ALTER TABLE `mi_tinstruments` DISABLE KEYS */;
INSERT INTO `mi_tinstruments` (`InstrumentID`,`Supplierid`,`Instrument_Name`,`Model`,`I_Release`,`Description`,`Manual`,`Patient_no_format`,`BarCode_Standard`,`Bidirectional`,`Communication_Stnadard`,`Communication_method`,`PORT`,`BaudRate`,`Parity`,`Stopbit`,`DataBit`,`FlowControl`,`Acknowledgement_code`,`EnteredBy`,`EnteredOn`,`ClientID`,`Active`) VALUES 
 (3,5,'AxSYM Plus','AxSYM Plus','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2010-10-13 00:00:00','0001','Y'),
 (4,5,'Architect i 1000 SR System','i1000 SR','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2012-04-18 00:00:00','0001','Y'),
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
 (17,6,'cobas6000','cobas6000','','','','','','Y','','PORT','COM1',9600,'None','One','8','None',NULL,1,'2017-09-23 00:00:00','0001','Y');
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
  `ServiceNo` varchar(20) default NULL,
  `Salutation` varchar(6) NOT NULL,
  `FName` varchar(30) NOT NULL,
  `MName` varchar(30) default NULL,
  `LName` varchar(30) default NULL,
  `Acronym` varchar(10) NOT NULL,
  `FHName` varchar(30) default NULL,
  `Sex` char(1) NOT NULL,
  `DOB` datetime default NULL,
  `BloodGroup` varchar(3) default NULL,
  `MS` char(1) default NULL,
  `NIC` varchar(15) default NULL,
  `NICValidUpto` datetime default NULL,
  `Passport` varchar(20) default NULL,
  `PassportValidUpto` datetime default NULL,
  `HPhoneNo1` varchar(15) default NULL,
  `HPhoneNo2` varchar(15) default NULL,
  `OPhoneNo1` varchar(15) default NULL,
  `OPhoneNo2` varchar(15) default NULL,
  `CPhoneNo` varchar(15) default NULL,
  `Email` varchar(50) default NULL,
  `CurrentAddress` varchar(250) default NULL,
  `PermanentAddress` varchar(250) default NULL,
  `PictureRef` varchar(255) default NULL,
  `LoginId` varchar(15) default NULL,
  `Pasword` varchar(15) default NULL,
  `JoiningDate` datetime default NULL,
  `LeavingDate` datetime default NULL,
  `Education` varchar(255) default NULL,
  `Nature` char(1) default NULL,
  `ContractExpiry` datetime default NULL,
  `ReferenceCode` varchar(15) default NULL,
  `Salary` int(10) unsigned default NULL,
  `FaxNo` varchar(15) default NULL,
  `Enteredby` int(10) unsigned NOT NULL,
  `Enteredon` datetime NOT NULL,
  `clientid` char(3) NOT NULL,
  `crossdept` char(1) NOT NULL,
  PRIMARY KEY  (`PersonId`)
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
  `ResultID` int(10) unsigned NOT NULL auto_increment,
  `BookingID` int(10) unsigned NOT NULL,
  `AttributeID` int(10) unsigned NOT NULL,
  `Result` varchar(100) NOT NULL,
  `EnteredBy` int(10) unsigned NOT NULL,
  `EnteredOn` datetime NOT NULL,
  `ClientID` char(4) NOT NULL,
  `Status` char(1) NOT NULL default '0',
  PRIMARY KEY  (`ResultID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mi_tresult`
--

/*!40000 ALTER TABLE `mi_tresult` DISABLE KEYS */;
INSERT INTO `mi_tresult` (`ResultID`,`BookingID`,`AttributeID`,`Result`,`EnteredBy`,`EnteredOn`,`ClientID`,`Status`) VALUES 
 (1,1,37,'4.78',1,'2017-09-23 13:34:00','0001','1'),
 (2,2,37,'0.114',1,'2017-09-23 14:19:00','0001','1'),
 (3,3,21,'23.30',1,'2017-09-23 14:19:00','0001','1'),
 (4,4,29,'211',1,'2017-09-23 14:19:00','0001','1'),
 (5,5,19,'10.8',1,'2017-09-23 14:19:00','0001','1'),
 (6,6,38,'89',1,'2017-09-23 14:19:00','0001','1'),
 (7,7,40,'73.9',1,'2017-09-23 14:19:00','0001','1'),
 (8,8,41,'290',1,'2017-09-23 14:19:00','0001','1'),
 (9,9,19,'22.9',1,'2017-09-23 14:20:00','0001','1'),
 (10,10,38,'115',1,'2017-09-23 14:20:00','0001','1'),
 (11,11,49,'0.5',1,'2017-09-23 14:20:00','0001','1'),
 (12,12,52,'1.0',1,'2017-09-23 14:20:00','0001','1'),
 (13,13,50,'10.0',1,'2017-09-23 14:20:00','0001','1'),
 (14,14,49,'1.0',1,'2017-09-23 14:20:00','0001','1'),
 (15,15,52,'2.4',1,'2017-09-23 14:20:00','0001','1'),
 (16,16,50,'10.0',1,'2017-09-23 14:20:00','0001','1');
/*!40000 ALTER TABLE `mi_tresult` ENABLE KEYS */;


--
-- Definition of table `mi_tsuppliers`
--

DROP TABLE IF EXISTS `mi_tsuppliers`;
CREATE TABLE `mi_tsuppliers` (
  `SupplierID` int(10) unsigned NOT NULL auto_increment,
  `Supplier_Name` varchar(150) NOT NULL,
  `Address` varchar(500) default NULL,
  `Phone_1` varchar(20) default NULL,
  `Phone_2` varchar(20) default NULL,
  `Fax_1` varchar(20) default NULL,
  `Fax_2` varchar(20) default NULL,
  `Email` varchar(50) default NULL,
  `CellNo` varchar(20) default NULL,
  `WebAddress` varchar(50) default NULL,
  `Linkedin_ID` varchar(50) default NULL,
  `CP_Name` varchar(50) NOT NULL,
  `CP_Designation` varchar(50) default NULL,
  `CP_Office_Phone` varchar(20) default NULL,
  `CP_Cell_no` varchar(20) default NULL,
  `CP_Email` varchar(50) default NULL,
  `City` varchar(50) default NULL,
  `Country` varchar(45) default NULL,
  `EnteredBy` int(10) unsigned NOT NULL,
  `EnteredOn` datetime NOT NULL,
  `Clientid` char(4) NOT NULL,
  `Active` char(1) NOT NULL,
  `Ref_SupplierID` int(10) unsigned default NULL,
  PRIMARY KEY  (`SupplierID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mi_tsuppliers`
--

/*!40000 ALTER TABLE `mi_tsuppliers` DISABLE KEYS */;
INSERT INTO `mi_tsuppliers` (`SupplierID`,`Supplier_Name`,`Address`,`Phone_1`,`Phone_2`,`Fax_1`,`Fax_2`,`Email`,`CellNo`,`WebAddress`,`Linkedin_ID`,`CP_Name`,`CP_Designation`,`CP_Office_Phone`,`CP_Cell_no`,`CP_Email`,`City`,`Country`,`EnteredBy`,`EnteredOn`,`Clientid`,`Active`,`Ref_SupplierID`) VALUES 
 (5,'Abbott Diagnostic Division','House no. 663/9, old bara road, University Town, Peshawar','0915840252','','0915840252','','muhammad.jan@abbott.com','03005983709','http://www.abbott.com','Abbott','Muhammad Akif Jan','Field Manager','0915840252','03005983709','muhammad.jan@abbott.com','Peshawar','Pakistan',1,'2015-01-10 00:00:00','0001','Y',NULL),
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
  `AttributeID` int(10) unsigned NOT NULL auto_increment,
  `Machine_testid` int(10) unsigned NOT NULL,
  `LIMSAttributeID` char(6) NOT NULL,
  `LIMSAttributeName` varchar(150) NOT NULL,
  `MachineAttributeName` varchar(150) NOT NULL,
  `EnteredBy` int(10) unsigned NOT NULL,
  `EnteredOn` datetime NOT NULL,
  `ClientId` char(4) NOT NULL,
  `Active` char(1) NOT NULL,
  `MachineAttributeCode` varchar(20) NOT NULL,
  `channel` int(10) unsigned default NULL,
  PRIMARY KEY  (`AttributeID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mi_ttestattribute`
--

/*!40000 ALTER TABLE `mi_ttestattribute` DISABLE KEYS */;
INSERT INTO `mi_ttestattribute` (`AttributeID`,`Machine_testid`,`LIMSAttributeID`,`LIMSAttributeName`,`MachineAttributeName`,`EnteredBy`,`EnteredOn`,`ClientId`,`Active`,`MachineAttributeCode`,`channel`) VALUES 
 (1,1,'004327','Anti-CCP','202',1,'2017-09-23 00:00:00','0001','Y','202',NULL),
 (2,2,'002951','Anti-HCV (Antibodies)','A-HCV II',1,'2017-09-23 00:00:00','0001','Y','286',NULL),
 (3,3,'001691','Albumin','ALB2',1,'2017-09-23 00:00:00','0001','Y','413',NULL),
 (4,4,'001692','Alkaline Phosphatase','ALP2L',1,'2017-09-23 00:00:00','0001','Y','683',NULL),
 (5,5,'001690','Alanine Transaminase (ALT)','ALTL',1,'2017-09-23 00:00:00','0001','Y','785',NULL),
 (6,6,'004253','Anti Mullerian hormone (AMH)','AMH',1,'2017-09-23 00:00:00','0001','Y','782',NULL),
 (7,7,'001855','Serum Amylase','AMYL2',1,'2017-09-23 00:00:00','0001','Y','570',NULL),
 (8,8,'001791','ASO Titre','ASLO',1,'2017-09-23 00:00:00','0001','Y','37',NULL),
 (9,9,'001714','AST (GOT)','ASLT',1,'2017-09-23 00:00:00','0001','Y','687',NULL),
 (10,10,'001750','Vit B12','B12 II',1,'2017-09-23 00:00:00','0001','Y','224',NULL),
 (11,11,'001842','Bilirubin Direct','BILD2',1,'2017-09-23 00:00:00','0001','Y','734',NULL),
 (12,12,'001693','Bilrubin Total','BILT3',1,'2017-09-23 00:00:00','0001','Y','712',NULL),
 (13,13,'003219','Serum C3','C3C-2',1,'2017-09-23 00:00:00','0001','Y','36',NULL),
 (14,14,'003218','Serum C4','C4-2',1,'2017-09-23 00:00:00','0001','Y','32',NULL),
 (15,15,'001679','Calcium Total','CA2',1,'2017-09-23 00:00:00','0001','Y','698',NULL),
 (16,16,'001688','Total Cholesterol','CHO2I',1,'2017-09-23 00:00:00','0001','Y','798',NULL),
 (17,17,'001667','CPK','CKL',1,'2017-09-23 00:00:00','0001','Y','57',NULL),
 (18,18,'001666','CKMB','CKMBL',1,'2017-09-23 00:00:00','0001','Y','60',NULL),
 (19,19,'001684','Serum Creatinine','CREJ2',1,'2017-09-23 00:00:00','0001','Y','690',NULL),
 (20,20,'001793','C Reactive Protein ','CRPLX',1,'2017-09-23 00:00:00','0001','Y','19',NULL),
 (21,21,'001722','fT4','FT4 II',1,'2017-09-23 00:00:00','0001','Y','201',NULL),
 (22,22,'001694','Gamm glutamyle transferase (GGT)','GGTS2',1,'2017-09-23 00:00:00','0001','Y','480',NULL),
 (23,23,'001770','Plasma Glucose (R)','GLUC3',1,'2017-09-23 00:00:00','0001','Y','717',NULL),
 (24,24,'001769','Plasma Glucose (F)','GLUC3',1,'2017-09-23 00:00:00','0001','Y','717',NULL),
 (25,25,'002948','Hepatitis B Surface Antigen','HBSAGII',1,'2017-09-23 00:00:00','0001','Y','250',NULL),
 (26,26,'003123','ß-hCG','HCG-BETA',1,'2017-09-23 00:00:00','0001','Y','148',NULL),
 (27,27,'003347','HDL+LDL','HDLC3',1,'2017-09-23 00:00:00','0001','Y','435',NULL),
 (28,28,'003956','Growth Hormone','HGH',1,'2017-09-23 00:00:00','0001','Y','263',NULL),
 (29,29,'003417','Serum Lipase','LIPC',1,'2017-09-23 00:00:00','0001','Y','731',NULL),
 (30,30,'001680','Magnesium','MG-2',1,'2017-09-23 00:00:00','0001','Y','701',NULL),
 (31,31,'001681','Phosphorous','PHOS2',1,'2017-09-23 00:00:00','0001','Y','714',NULL),
 (32,31,'001681','Phosphorous','PHOS2',1,'2017-09-23 00:00:00','0001','Y','714',NULL),
 (33,32,'001727','Prolactin','PRL',1,'2017-09-23 00:00:00','0001','Y','14',NULL),
 (34,33,'001797','Rheumatoid Factor','RF-II',1,'2017-09-23 00:00:00','0001','Y','17',NULL),
 (35,34,'003523','Anti-TP antibodies','Syphilis',1,'2017-09-23 00:00:00','0001','Y','160',NULL),
 (36,35,'001720','T3 Total','T3',1,'2017-09-23 00:00:00','0001','Y','7',NULL),
 (37,36,'001721','TSH','TSH',1,'2017-09-23 00:00:00','0001','Y','1',NULL),
 (38,37,'001682','Blood Urea','UREAL',1,'2017-09-23 00:00:00','0001','Y','418',NULL),
 (39,38,'003624','Vitamin D (25-OH)','VITD-T',1,'2017-09-23 00:00:00','0001','Y','459',NULL),
 (40,43,'004151','Serum Iron','IRON2',1,'2017-09-23 00:00:00','0001','Y','661',NULL),
 (41,46,'004173','Serum T.I.B.C','TIBC',1,'2017-09-23 00:00:00','0001','Y','962',NULL),
 (42,51,'002952','Anti-HIV I & II (Antibodies)','HIVCOMPT',1,'2017-09-23 00:00:00','0001','Y','111',NULL),
 (43,50,'003126','Plasma Cyclosporin A (CsA) level','CYSC2',1,'2017-09-23 00:00:00','0001','Y','109',NULL),
 (44,50,'003126','Plasma Cyclosporin A (CsA) level','CYSC2',1,'2017-09-23 00:00:00','0001','Y','109',NULL),
 (45,49,'001685','Uric Acid','UA2',1,'2017-09-23 00:00:00','0001','Y','700',NULL),
 (46,48,'001689','Triglyceride','TRIGL',1,'2017-09-23 00:00:00','0001','Y','781',NULL),
 (47,47,'001885','Total protein','TP2',1,'2017-09-23 00:00:00','0001','Y','678',NULL),
 (48,44,'003625','LDH.','LDHI2',1,'2017-09-23 00:00:00','0001','Y','80',NULL),
 (49,42,'003222','Immunoglobulin M (IgM)','IGM-2',1,'2017-09-23 00:00:00','0001','Y','465',NULL),
 (50,41,'003221','Immunoglobulin G (IgG)','IGG-2',1,'2017-09-23 00:00:00','0001','Y','674',NULL),
 (51,40,'003265','Immunoglobulin E (IgE)','IGE',1,'2017-09-23 00:00:00','0001','Y','116',NULL),
 (52,39,'003220','Immunoglobulin A (IgA)','IGA-2',1,'2017-09-23 00:00:00','0001','Y','458',NULL);
/*!40000 ALTER TABLE `mi_ttestattribute` ENABLE KEYS */;


--
-- Definition of table `mi_ttests`
--

DROP TABLE IF EXISTS `mi_ttests`;
CREATE TABLE `mi_ttests` (
  `Machine_testid` int(10) unsigned NOT NULL auto_increment,
  `Lims_testid` char(6) NOT NULL,
  `Lims_test_name` varchar(200) NOT NULL,
  `Machine_Test_name` varchar(200) NOT NULL,
  `LOINC_code` varchar(45) default NULL,
  `Instrumentid` int(10) unsigned NOT NULL,
  `EnteredBy` int(10) unsigned NOT NULL,
  `EnteredOn` datetime NOT NULL,
  `ClientID` char(4) NOT NULL,
  `Active` char(1) NOT NULL,
  `DeptID` char(3) default NULL,
  `MachineTestCode` varchar(20) NOT NULL,
  PRIMARY KEY  (`Machine_testid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mi_ttests`
--

/*!40000 ALTER TABLE `mi_ttests` DISABLE KEYS */;
INSERT INTO `mi_ttests` (`Machine_testid`,`Lims_testid`,`Lims_test_name`,`Machine_Test_name`,`LOINC_code`,`Instrumentid`,`EnteredBy`,`EnteredOn`,`ClientID`,`Active`,`DeptID`,`MachineTestCode`) VALUES 
 (1,'001184','Anti-CCP','A-CCP','',17,1,'2017-09-23 00:00:00','0001','Y','002','202'),
 (2,'001039','Anti-Hepatitis C (HCV) Antibodies','A-HCV II','',17,1,'2017-09-23 00:00:00','0001','Y','002','286'),
 (3,'000805','Albumin','ALB2','',17,1,'2017-09-23 00:00:00','0001','Y','006','413'),
 (4,'000804','Alkaline Phosphatase','ALP2L','',17,1,'2017-09-23 00:00:00','0001','Y','006','683'),
 (5,'000803','Alanine Transaminase (ALT)','ALTL','',17,1,'2017-09-23 00:00:00','0001','Y','006','785'),
 (6,'001350','Anti Mullerian hormone (AMH)','AMH','',17,1,'2017-09-23 00:00:00','0001','Y','010','782'),
 (7,'000919','Serum Amylase','AMYL2','',17,1,'2017-09-23 00:00:00','0001','Y','006','570'),
 (8,'000835','ASO Titre','ASLO','',17,1,'2017-09-23 00:00:00','0001','Y','002','37'),
 (9,'000859','Aspartate transaminase (AST)','ASLT','',17,1,'2017-09-23 00:00:00','0001','Y','006','687'),
 (10,'000891','Vitamin B12','B12 II','',17,1,'2017-09-23 00:00:00','0001','Y','006','224'),
 (11,'000915','Bilirubin Direct','BILD2','',17,1,'2017-09-23 00:00:00','0001','Y','006','734'),
 (12,'000802','Bilirubin Total','BILT3','',17,1,'2017-09-23 00:00:00','0001','Y','006','712'),
 (13,'001098','C3','C3C-2','',17,1,'2017-09-23 00:00:00','0001','Y','006','36'),
 (14,'001097','C4','C4-2','',17,1,'2017-09-23 00:00:00','0001','Y','006','32'),
 (15,'000798','Calcium Total','CA2','',17,1,'2017-09-23 00:00:00','0001','Y','006','698'),
 (16,'000817','Total Cholesterol','CHO2I','',17,1,'2017-09-23 00:00:00','0001','Y','006','798'),
 (17,'000809','CPK','CKL','',17,1,'2017-09-23 00:00:00','0001','Y','006','57'),
 (18,'000810','CK-MB','CKMBL','',17,1,'2017-09-23 00:00:00','0001','Y','006','60'),
 (19,'000814','Serum Creatinine','CREJ2','',17,1,'2017-09-23 00:00:00','0001','Y','006','690'),
 (20,'000837','C Reactive Protien','CRPLX','',17,1,'2017-09-23 00:00:00','0001','Y','002','19'),
 (21,'000868','fT4','FT4 II','',17,1,'2017-09-23 00:00:00','0001','Y','010','201'),
 (22,'000806','Gamm glutamyle transferase (GGT)','GGTS2','',17,1,'2017-09-23 00:00:00','0001','Y','006','480'),
 (23,'000898','Glucose (R)','GLUC3','',17,1,'2017-09-23 00:00:00','0001','Y','006','717'),
 (24,'000897','Glucose (F)','GLUC3','',17,1,'2017-09-23 00:00:00','0001','Y','006','717'),
 (25,'001032','Hepatitis B Surface Antigen','HBSAGII','',17,1,'2017-09-23 00:00:00','0001','Y','002','250'),
 (26,'001067','B-hCG','HCG-BETA','',17,1,'2017-09-23 00:00:00','0001','Y','010','148'),
 (27,'001134','HDL/LDL-Cholesterol','HDLC3','',17,1,'2017-09-23 00:00:00','0001','Y','006','435'),
 (28,'001270','Growth Hormone','HGH','',17,1,'2017-09-23 00:00:00','0001','Y','010','263'),
 (29,'001141','Serum Lipase','LIPC','',17,1,'2017-09-23 00:00:00','0001','Y','006','731'),
 (30,'000801','Magnesium','MG-2','',17,1,'2017-09-23 00:00:00','0001','Y','006','701'),
 (31,'000800','Phosphorous (PO4```)','PHOS2','',17,1,'2017-09-23 00:00:00','0001','Y','006','714'),
 (32,'000864','Prolactin','PRL','',17,1,'2017-09-23 00:00:00','0001','Y','010','14'),
 (33,'000844','Rheumatoid Factor','RF-II','',17,1,'2017-09-23 00:00:00','0001','Y','002','17'),
 (34,'001175','Anti-TP antibodies','Syphilis','',17,1,'2017-09-23 00:00:00','0001','Y','002','160'),
 (35,'000865','T3 Total','T3','',17,1,'2017-09-23 00:00:00','0001','Y','010','7'),
 (36,'000863','TSH','TSH','',17,1,'2017-09-23 00:00:00','0001','Y','010','1'),
 (37,'000813','Blood Urea','UREAL','',17,1,'2017-09-23 00:00:00','0001','Y','006','418'),
 (38,'001151','Vitamin D','VITD-T','',17,1,'2017-09-23 00:00:00','0001','Y','006','459'),
 (39,'001101','Immunoglobulin A (IgA)','IGA-2','',17,1,'2017-09-23 00:00:00','0001','Y','006','458'),
 (40,'001113','Immunoglobulin E (IgE)','IGE','',17,1,'2017-09-23 00:00:00','0001','Y','006','116'),
 (41,'001099','Immunoglobulin G (IgG)','IGG-2','',17,1,'2017-09-23 00:00:00','0001','Y','006','674'),
 (42,'001100','Immunoglobulin M (IgM)','IGM-2','',17,1,'2017-09-23 00:00:00','0001','Y','006','465'),
 (43,'001330','Serum Iron/TIBC','IRON2','',17,1,'2017-09-23 00:00:00','0001','Y','006','661'),
 (44,'000812','LDH','LDHI2','',17,1,'2017-09-23 00:00:00','0001','Y','006','80'),
 (45,'001141','Serum Lipase','LIPC','',17,1,'2017-09-23 00:00:00','0001','Y','006','731'),
 (46,'001330','Serum Iron/TIBC','TIBC','',17,1,'2017-09-23 00:00:00','0001','Y','006','962'),
 (47,'000935','Total Protien','TP2','',17,1,'2017-09-23 00:00:00','0001','Y','006','678'),
 (48,'000818','Triglyceride','TRIGL','',17,1,'2017-09-23 00:00:00','0001','Y','006','781'),
 (49,'000815','Uric Acid','UA2','',17,1,'2017-09-23 00:00:00','0001','Y','006','700'),
 (50,'001070','Plasma Cyclosporin (CsA) level','CYSC2','',17,1,'2017-09-23 00:00:00','0001','Y','006','109'),
 (51,'001040','Anti-HIV Antibodies','HIVCOMPT','',17,1,'2017-09-23 00:00:00','0001','Y','002','111');
/*!40000 ALTER TABLE `mi_ttests` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
