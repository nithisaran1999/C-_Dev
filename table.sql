-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.1.72-community - MySQL Community Server (GPL)
-- Server OS:                    Win32
-- HeidiSQL Version:             11.0.0.6104
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for reru2
CREATE DATABASE IF NOT EXISTS `reru2` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `reru2`;

-- Dumping structure for table reru2.act
CREATE TABLE IF NOT EXISTS `act` (
  `act_ID` int(5) NOT NULL AUTO_INCREMENT,
  `act_Name` varchar(50) NOT NULL DEFAULT '',
  `act_Date` date NOT NULL,
  `act_Exp` date NOT NULL,
  `act_Type` varchar(32) NOT NULL DEFAULT '',
  `act_Term` varchar(50) NOT NULL DEFAULT '',
  `act_Year` int(1) NOT NULL,
  PRIMARY KEY (`act_ID`)
) ENGINE=MyISAM AUTO_INCREMENT=37 DEFAULT CHARSET=utf8;

-- Dumping data for table reru2.act: 13 rows
/*!40000 ALTER TABLE `act` DISABLE KEYS */;
REPLACE INTO `act` (`act_ID`, `act_Name`, `act_Date`, `act_Exp`, `act_Type`, `act_Term`, `act_Year`) VALUES
	(29, 'Test2', '2020-11-15', '2020-11-15', 'กิจกรรมเลือก', '2/2999', 2),
	(28, 'Test2', '2020-11-15', '2020-11-15', 'กิจกรรมเลือก', '2/2999', 1),
	(27, 'Test', '2020-11-15', '2020-11-15', 'กิจกรรมหลัก', '2/2567', 4),
	(26, 'Test', '2020-11-15', '2020-11-15', 'กิจกรรมหลัก', '2/2567', 3),
	(25, 'Test', '2020-11-15', '2020-11-15', 'กิจกรรมหลัก', '2/2567', 2),
	(24, 'Test', '2020-11-15', '2020-11-15', 'กิจกรรมหลัก', '2/2567', 1),
	(30, 'Test2', '2020-11-15', '2020-11-15', 'กิจกรรมเลือก', '2/2999', 3),
	(31, 'Test2', '2020-11-15', '2020-11-15', 'กิจกรรมเลือก', '2/2999', 4),
	(32, 'Test2', '2020-11-15', '2020-11-15', 'กิจกรรมเลือก', '2/2999', 5),
	(33, 'Test 3', '2020-11-15', '2020-11-15', 'กิจกรรมหลัก', '1/2900', 5),
	(34, 'zzzz', '2020-11-15', '2020-11-15', 'กิจกรรมเลือก', '2/2342', 2),
	(35, 'xxxxxx', '2020-11-15', '2020-11-15', 'กิจกรรมหลัก', '1/7800', 3),
	(36, 'xxxxxx', '2020-11-15', '2020-11-15', 'กิจกรรมหลัก', '1/7800', 4);
/*!40000 ALTER TABLE `act` ENABLE KEYS */;

-- Dumping structure for table reru2.admin
CREATE TABLE IF NOT EXISTS `admin` (
  `admin_ID` int(3) NOT NULL AUTO_INCREMENT,
  `admin_Username` varchar(50) DEFAULT NULL,
  `admin_Password` char(32) DEFAULT NULL,
  PRIMARY KEY (`admin_ID`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Dumping data for table reru2.admin: 1 rows
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
REPLACE INTO `admin` (`admin_ID`, `admin_Username`, `admin_Password`) VALUES
	(2, 'moto', 'moto');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;

-- Dumping structure for table reru2.coupon
CREATE TABLE IF NOT EXISTS `coupon` (
  `coupon_ID` int(9) NOT NULL AUTO_INCREMENT,
  `coupon_Code` char(5) NOT NULL DEFAULT '0',
  `act_ID` int(9) NOT NULL DEFAULT '0',
  `coupon_Exp` date NOT NULL DEFAULT '0000-00-00',
  PRIMARY KEY (`coupon_ID`),
  KEY `FK__act` (`act_ID`)
) ENGINE=MyISAM AUTO_INCREMENT=201 DEFAULT CHARSET=utf8;

-- Dumping data for table reru2.coupon: 0 rows
/*!40000 ALTER TABLE `coupon` DISABLE KEYS */;
/*!40000 ALTER TABLE `coupon` ENABLE KEYS */;

-- Dumping structure for table reru2.member
CREATE TABLE IF NOT EXISTS `member` (
  `member_ID` int(9) NOT NULL AUTO_INCREMENT,
  `member_RERU_ID` char(11) NOT NULL DEFAULT '0',
  `member_Name` varchar(64) NOT NULL DEFAULT '0',
  `member_Password` varchar(32) NOT NULL DEFAULT '0',
  `member_Year` int(1) DEFAULT NULL,
  PRIMARY KEY (`member_ID`,`member_RERU_ID`) USING BTREE
) ENGINE=MyISAM AUTO_INCREMENT=203 DEFAULT CHARSET=utf8;

-- Dumping data for table reru2.member: 2 rows
/*!40000 ALTER TABLE `member` DISABLE KEYS */;
REPLACE INTO `member` (`member_ID`, `member_RERU_ID`, `member_Name`, `member_Password`, `member_Year`) VALUES
	(1, '61424201008', 'Nithisaran  Suksom', '123', 1),
	(202, '63424201001', 'นางสาวริน รินไง', '123', 3);
/*!40000 ALTER TABLE `member` ENABLE KEYS */;

-- Dumping structure for table reru2.regis
CREATE TABLE IF NOT EXISTS `regis` (
  `regis_ID` int(8) NOT NULL AUTO_INCREMENT,
  `regis_Time` datetime DEFAULT NULL,
  `act_ID` int(9) NOT NULL,
  `coupon_Code` char(5) NOT NULL,
  `member_ID` char(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`regis_ID`),
  KEY `FK_regis_act` (`act_ID`),
  KEY `FK_regis_member` (`member_ID`),
  KEY `FK_regis_coupon` (`coupon_Code`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- Dumping data for table reru2.regis: 0 rows
/*!40000 ALTER TABLE `regis` DISABLE KEYS */;
/*!40000 ALTER TABLE `regis` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
