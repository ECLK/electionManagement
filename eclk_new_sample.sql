-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 17, 2021 at 09:01 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 7.4.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `eclk_new`
--

-- --------------------------------------------------------

--
-- Table structure for table `admindistrict`
--

CREATE TABLE `admindistrict` (
  `admin_dis_id` int(11) NOT NULL,
  `admin_dis_name_en` varchar(50) DEFAULT NULL,
  `admin_dis_name_si` varchar(50) DEFAULT NULL,
  `admin_dis_name_ta` varchar(50) DEFAULT NULL,
  `itteration_id` int(11) DEFAULT NULL,
  `province_id` int(11) DEFAULT NULL,
  `ed_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admindistrict`
--

INSERT INTO `admindistrict` (`admin_dis_id`, `admin_dis_name_en`, `admin_dis_name_si`, `admin_dis_name_ta`, `itteration_id`, `province_id`, `ed_id`) VALUES
(1, 'Colombo', 'කොළඹ', NULL, 3, 1, 1),
(2, 'Gampaha', 'ගම්පහ', NULL, 3, 1, 2),
(3, 'Kalutara', 'කළුතර', NULL, 3, 1, 3),
(4, 'Mahanuwara', 'මහනුවර', NULL, 3, 2, 4),
(5, 'Matale', 'මාතලේ', NULL, 3, 2, 5),
(6, 'Nuwaraeliya', 'නුවරඑළිය', NULL, 3, 2, 6),
(7, 'Galle', 'ගාල්ල', NULL, 3, 3, 7),
(8, 'Matara', 'මාතර', NULL, 3, 3, 8),
(9, 'Hambantota', 'හම්බන්තොට', NULL, 3, 3, 9),
(10, 'Jaffna', 'යාපනය', NULL, 3, 4, 10),
(11, 'Kilinochchi', 'කිලිනොචිචිය', NULL, 3, 4, 10),
(12, 'Mullativu', 'මුලතිව්', NULL, 3, 4, 11),
(13, 'Mannar', 'මන්නාරම', NULL, 3, 4, 11),
(14, 'Vavuniya', 'වව්නියාව', NULL, 3, 4, 11),
(15, 'Batticaloa', 'මඩකලපුව', NULL, 3, 5, 12),
(16, 'Ampara', 'අම්පාර', NULL, 3, 5, 13),
(17, 'Trincomalee', 'ත්‍රිකුණාමලය', NULL, 3, 5, 14),
(18, 'Kurunegala', 'කුරුණෑගල', NULL, 3, 6, 15),
(19, 'Puttalam', 'පුත්තලම', NULL, 3, 6, 16),
(20, 'Anuradhapura', 'අනුරාධපුර', NULL, 3, 7, 17),
(21, 'Polonnaruwa', 'පොලොන්නරුව', NULL, 3, 7, 18),
(22, 'Badulla', 'බදුල්ල', NULL, 3, 8, 19),
(23, 'Moneragala', 'මොණරාගල', NULL, 3, 8, 20),
(24, 'Ratnapura', 'රත්නපුර', NULL, 3, 9, 21),
(25, 'Kegalle', 'කෑගල්ල', NULL, 3, 9, 22);

-- --------------------------------------------------------

--
-- Table structure for table `countingcentre`
--

CREATE TABLE `countingcentre` (
  `cc_id` int(11) NOT NULL,
  `cc_name` varchar(25) DEFAULT NULL,
  `vote_type` varchar(50) DEFAULT NULL,
  `pdiv_id` int(11) DEFAULT NULL,
  `dc_id` int(11) DEFAULT NULL,
  `election_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `countingcentre`
--

INSERT INTO `countingcentre` (`cc_id`, `cc_name`, `vote_type`, `pdiv_id`, `dc_id`, `election_id`) VALUES
(1, '1', 'Normal', 1, 1, 3),
(2, '2', 'Normal', 1, 1, 3),
(3, '3', 'Normal', 1, 1, 3),
(4, '4', 'Normal', 1, 1, 3),
(5, '5', 'Normal', 1, 1, 3),
(6, '6', 'Normal', 1, 1, 3),
(7, '7', 'Normal', 1, 1, 3),
(8, '8', 'Normal', 1, 1, 3),
(9, '9', 'Normal', 1, 1, 3),
(10, '10', 'Normal', 1, 1, 3),
(11, '11', 'Normal', 1, 1, 3),
(12, '12', 'Normal', 1, 1, 3),
(13, '13', 'Normal', 1, 1, 3),
(14, '14', 'Normal', 1, 1, 3),
(15, '15', 'Normal', 1, 1, 3),
(16, '16', 'Normal', 1, 1, 3),
(17, '17', 'Normal', 2, 1, 3),
(18, '18', 'Normal', 2, 1, 3);

-- --------------------------------------------------------

--
-- Table structure for table `current_election`
--

CREATE TABLE `current_election` (
  `current_ele_id` int(11) NOT NULL,
  `election_name_en` varchar(100) DEFAULT NULL,
  `election_name_si` varchar(100) DEFAULT NULL,
  `election_name_ta` varchar(100) DEFAULT NULL,
  `itteration_id` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `current_election`
--

INSERT INTO `current_election` (`current_ele_id`, `election_name_en`, `election_name_si`, `election_name_ta`, `itteration_id`) VALUES
(1, 'parliamentary Election', NULL, NULL, 3),
(2, 'Provincial Council Election', NULL, NULL, 4);

-- --------------------------------------------------------

--
-- Table structure for table `districtcentre`
--

CREATE TABLE `districtcentre` (
  `dc_id` int(11) NOT NULL,
  `dc_name_en` varchar(150) DEFAULT NULL,
  `dc_name_si` varchar(150) DEFAULT NULL,
  `dc_name_ta` varchar(150) DEFAULT NULL,
  `current_elec_id` int(11) DEFAULT NULL,
  `ed_id` int(11) DEFAULT NULL,
  `longitude` point DEFAULT NULL,
  `latitude` point DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `districtcentre`
--

INSERT INTO `districtcentre` (`dc_id`, `dc_name_en`, `dc_name_si`, `dc_name_ta`, `current_elec_id`, `ed_id`, `longitude`, `latitude`) VALUES
(1, 'Royal College Colombo 07', NULL, NULL, 3, 1, NULL, NULL),
(2, 'D.S.Senanayake College', NULL, NULL, 3, 1, NULL, NULL),
(3, 'Isipathana College', NULL, NULL, 3, 1, NULL, NULL),
(4, 'Bandaranayaka College Gampaha', NULL, NULL, 3, 2, NULL, NULL),
(5, 'Gampaha Medical Faculty Main Hall', NULL, NULL, 3, 2, NULL, NULL),
(6, 'Gampaha District Secretary complex', NULL, NULL, 3, 2, NULL, NULL),
(7, 'Kalutara Vidyalaya', NULL, NULL, 3, 3, NULL, NULL),
(8, 'Panadura Municipal Council', NULL, NULL, 3, 3, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `election`
--

CREATE TABLE `election` (
  `election_id` int(11) NOT NULL,
  `election_name_en` varchar(240) DEFAULT NULL,
  `election_name_si` varchar(240) DEFAULT NULL,
  `election_name_ta` varchar(240) DEFAULT NULL,
  `election_template_name` varchar(200) DEFAULT NULL,
  `active_status` varchar(10) DEFAULT NULL,
  `itteration_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `election`
--

INSERT INTO `election` (`election_id`, `election_name_en`, `election_name_si`, `election_name_ta`, `election_template_name`, `active_status`, `itteration_id`) VALUES
(1, 'Presidential Election', 'ජනාධිපතිවරණය', NULL, 'PRESIDENTIAL_ELECTION_2019', 'No', 3),
(2, 'Parliamentary Election', 'පාර්ලිමේන්තු මැතිවරණය', NULL, 'PARLIAMENT_ELECTION_2020', 'No', 3),
(3, 'Provincial Council Election', 'පළාත් සභා මැතිවරණය', NULL, 'PROVINCIAL_COUNCIL_ELECTION_2021', 'Yes', 3),
(4, 'Local Authorities Election', 'පළාත් පාලන ආයතන මැතිවරණය', NULL, 'Local Authorities Election - 2021', 'No', 3);

-- --------------------------------------------------------

--
-- Table structure for table `electoraldistrict`
--

CREATE TABLE `electoraldistrict` (
  `ed_id` int(11) NOT NULL,
  `ed_name_en` varchar(50) DEFAULT NULL,
  `ed_name_si` varchar(50) DEFAULT NULL,
  `ed_name_ta` varchar(50) DEFAULT NULL,
  `number_of_seats` int(11) DEFAULT NULL,
  `itteration_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `electoraldistrict`
--

INSERT INTO `electoraldistrict` (`ed_id`, `ed_name_en`, `ed_name_si`, `ed_name_ta`, `number_of_seats`, `itteration_id`) VALUES
(1, 'Colombo', 'කොළඹ', NULL, 19, 3),
(2, 'Gampaha', 'ගම්පහ', NULL, 18, 3),
(3, 'Kalutara', 'කළුතර', NULL, 10, 3),
(4, 'Mahanuwara', 'මහනුවර', NULL, 12, 3),
(5, 'Matale', 'මාතලේ', NULL, 5, 3),
(6, 'Nuwaraeliya', 'නුවරඑළිය', NULL, 8, 3),
(7, 'Galle', 'ගාල්ල', NULL, 9, 3),
(8, 'Matara', 'මාතර', NULL, 7, 3),
(9, 'Hambantota', 'හම්බන්තොට', NULL, 7, 3),
(10, 'Jaffna', 'යාපනය', NULL, 7, 3),
(11, 'Vanni', 'වන්නි', NULL, 6, 3),
(12, 'Batticaloa', 'මඩකලපුව', NULL, 5, 3),
(13, 'Digamadulla', 'දිගාමඩුල්ල', NULL, 7, 3),
(14, 'Trincomalee', 'ත්‍රිකුණාමලය', NULL, 4, 3),
(15, 'Kurunegala', 'කුරුණෑගල', NULL, 15, 3),
(16, 'Puttalam', 'පුත්තලම', NULL, 8, 3),
(17, 'Anuradhapura', 'අනුරාධපුර', NULL, 9, 3),
(18, 'Polonnaruwa', 'පොලොන්නරුව', NULL, 5, 3),
(19, 'Badulla', 'බදුල්ල', NULL, 9, 3),
(20, 'Moneragala', 'මොණරාගල', NULL, 6, 3),
(21, 'Ratnapura', 'රත්නපුර', NULL, 11, 3),
(22, 'Kegalle', 'කෑගල්ල', NULL, 9, 3);

-- --------------------------------------------------------

--
-- Table structure for table `itteration`
--

CREATE TABLE `itteration` (
  `itteration_id` int(11) NOT NULL,
  `itteration_name` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `itteration`
--

INSERT INTO `itteration` (`itteration_id`, `itteration_name`) VALUES
(1, '2018'),
(2, '2019'),
(3, '2020'),
(4, '2021');

-- --------------------------------------------------------

--
-- Table structure for table `localauthority`
--

CREATE TABLE `localauthority` (
  `la_id` int(11) NOT NULL,
  `la_name_en` varchar(150) DEFAULT NULL,
  `la_name_si` varchar(150) DEFAULT NULL,
  `la_name_ta` varchar(150) DEFAULT NULL,
  `itteration_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `party`
--

CREATE TABLE `party` (
  `party_id` int(11) NOT NULL,
  `party_name` varchar(200) DEFAULT NULL,
  `party_abbreviation` varchar(50) DEFAULT NULL,
  `party_symbol` varchar(100) DEFAULT NULL,
  `color` varchar(50) DEFAULT NULL,
  `admin_dis_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `party`
--

INSERT INTO `party` (`party_id`, `party_name`, `party_abbreviation`, `party_symbol`, `color`, `admin_dis_id`) VALUES
(1, 'Party A', 'PA', 'Symbol 1', 'Color 1', 1),
(2, 'Party B', 'PB', 'Symbol 2', 'Color 2', 1),
(3, 'Party C', 'PC', 'Symbol 3', 'Color 3', 1),
(4, 'Colombo - Independent Group 1', 'IND01_D01', 'Symbol 4', 'Color 4', 1),
(5, 'Colombo - Independent Group 2', 'IND02_D01', 'Symbol 5', 'Color 5', 1),
(6, 'Party A', 'PA', 'Symbol 1', 'Color 1', 2),
(7, 'Party D', 'PD', 'Symbol 6', 'Color 6', 2),
(8, 'Gampaha - Independent Group 1', 'IND01_D02', 'Symbol 7', 'Color 7', 2),
(9, 'Party E', 'PE', 'Symbol 8', 'Color 8', 3),
(10, 'Kalutara - Independent Group 1', 'IND01_D03', 'Symbol 9', 'Color 9', 3);

-- --------------------------------------------------------

--
-- Table structure for table `pollingdistrict`
--

CREATE TABLE `pollingdistrict` (
  `pd_id` int(11) NOT NULL,
  `pd_num` tinytext DEFAULT NULL,
  `pdiv_id` int(11) DEFAULT NULL,
  `wd_id` int(11) DEFAULT NULL,
  `cc_id` int(11) DEFAULT NULL,
  `itteration_id` int(11) DEFAULT NULL,
  `longitude` point DEFAULT NULL,
  `latitude` point DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pollingdistrict`
--

INSERT INTO `pollingdistrict` (`pd_id`, `pd_num`, `pdiv_id`, `wd_id`, `cc_id`, `itteration_id`, `longitude`, `latitude`) VALUES
(1, '1', 1, NULL, 1, 3, NULL, NULL),
(2, '28', 1, NULL, 1, 3, NULL, NULL),
(3, '31', 1, NULL, 1, 3, NULL, NULL),
(4, '42', 1, NULL, 1, 3, NULL, NULL),
(5, '32', 1, NULL, 2, 3, NULL, NULL),
(6, '44', 1, NULL, 2, 3, NULL, NULL),
(7, '48F', 1, NULL, 2, 3, NULL, NULL),
(8, '48M', 1, NULL, 2, 3, NULL, NULL),
(9, '3', 1, NULL, 3, 3, NULL, NULL),
(10, '10', 1, NULL, 3, 3, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `pollingdivision`
--

CREATE TABLE `pollingdivision` (
  `pdiv_id` int(11) NOT NULL,
  `pdiv_name_en` varchar(50) DEFAULT NULL,
  `pdiv_name_si` varchar(50) DEFAULT NULL,
  `pdiv_name_ta` varchar(50) DEFAULT NULL,
  `dc_id` int(11) DEFAULT NULL,
  `ed_id` int(11) DEFAULT NULL,
  `itteration_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pollingdivision`
--

INSERT INTO `pollingdivision` (`pdiv_id`, `pdiv_name_en`, `pdiv_name_si`, `pdiv_name_ta`, `dc_id`, `ed_id`, `itteration_id`) VALUES
(1, 'Colombo North', NULL, NULL, 1, 1, 3),
(2, 'Colombo Central', NULL, NULL, 1, 1, 3),
(3, 'Borella', NULL, NULL, 1, 1, 3),
(4, 'Colombo East', NULL, NULL, 1, 1, 3),
(5, 'Colombo West', NULL, NULL, 1, 1, 3),
(6, 'Dehiwala', NULL, NULL, 2, 1, 3),
(7, 'Ratmalana', NULL, NULL, 2, 1, 3),
(8, 'Kolonnawa', NULL, NULL, 2, 1, 3),
(9, 'Kotte', NULL, NULL, 2, 1, 3),
(10, 'Kaduwela', NULL, NULL, 2, 1, 3),
(11, 'Avissawella', NULL, NULL, 3, 1, 3),
(12, 'Homagama', NULL, NULL, 3, 1, 3),
(13, 'Maharagama', NULL, NULL, 3, 1, 3),
(14, 'Kesbewa', NULL, NULL, 3, 1, 3),
(15, 'Moratuwa', NULL, NULL, 3, 1, 3),
(16, 'Wattala', NULL, NULL, 4, 2, 3),
(17, 'Negambo', NULL, NULL, 4, 2, 3),
(18, 'Katana', NULL, NULL, 4, 2, 3),
(19, 'Diulapitiya', NULL, NULL, 5, 2, 3),
(20, 'Mirigama', NULL, NULL, 5, 2, 3),
(21, 'Minuwangoda', NULL, NULL, 5, 2, 3),
(22, 'Attanagalla', NULL, NULL, 6, 2, 3),
(23, 'Gampaha', NULL, NULL, 6, 2, 3),
(24, 'Ja-Ela', NULL, NULL, 6, 2, 3),
(25, 'Mahara', NULL, NULL, 6, 2, 3),
(26, 'Dompe', NULL, NULL, NULL, 2, 3),
(27, 'Biyagama', NULL, NULL, NULL, 2, 2),
(28, 'Kelaniya', NULL, NULL, NULL, 2, 3),
(29, 'Panadura', NULL, NULL, NULL, 3, 3),
(30, 'Bandaragama', NULL, NULL, NULL, 3, 3),
(31, 'Horana', NULL, NULL, NULL, 3, 3),
(32, 'Bulathsinhala', NULL, NULL, NULL, 3, 3),
(33, 'Matugama', NULL, NULL, NULL, 3, 3),
(34, 'Kalutara', NULL, NULL, NULL, 3, 3),
(35, 'Beruwala', NULL, NULL, NULL, 3, 3),
(36, 'H-Agalawatta', NULL, NULL, NULL, 3, 3);

-- --------------------------------------------------------

--
-- Table structure for table `pollingstation`
--

CREATE TABLE `pollingstation` (
  `ps_id` int(11) NOT NULL,
  `ps_name_en` text DEFAULT NULL,
  `ps_name_si` text DEFAULT NULL,
  `ps_name_ta` text DEFAULT NULL,
  `pd_id` int(11) DEFAULT NULL,
  `longitude` point DEFAULT NULL,
  `latitude` point DEFAULT NULL,
  `cc_id` int(11) DEFAULT NULL,
  `registered_normal_voters` int(11) DEFAULT NULL,
  `registered_postal_voters` int(11) DEFAULT NULL,
  `registered_displaced_voters` int(11) DEFAULT NULL,
  `registered_quarantine_voters` int(11) DEFAULT NULL,
  `status` tinyint(4) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pollingstation`
--

INSERT INTO `pollingstation` (`ps_id`, `ps_name_en`, `ps_name_si`, `ps_name_ta`, `pd_id`, `longitude`, `latitude`, `cc_id`, `registered_normal_voters`, `registered_postal_voters`, `registered_displaced_voters`, `registered_quarantine_voters`, `status`) VALUES
(1, 'Mattakkuliya Sir Rasik Fareed Muslim Vidyalaya St.Maria Road Colombo 15. Hall No. 01', NULL, NULL, 1, NULL, NULL, 1, NULL, NULL, NULL, NULL, 1),
(2, 'Ananda Vidyalaya Modara Colombo 15. - Hall No. 03', NULL, NULL, 2, NULL, NULL, 1, NULL, NULL, NULL, NULL, 1),
(3, 'Mahawatta St. Anthony\'s Tamil Vidyalaya Colombo 14 - Hall No. 02', NULL, NULL, 3, NULL, NULL, 1, NULL, NULL, NULL, NULL, 1),
(4, 'St. Andrew\'s Maha Vidyalaya Maubrey Lane Colombo 15 - Hall No.01', NULL, NULL, 4, NULL, NULL, 1, NULL, NULL, NULL, NULL, 1),
(5, 'Muwadora Uyana Community Hall Colombo 15', NULL, NULL, 5, NULL, NULL, 2, NULL, NULL, NULL, NULL, 1),
(6, 'President Maha Vidyalaya Alwis Place Colombo 13 - Hall No.01', NULL, NULL, 6, NULL, NULL, 2, NULL, NULL, NULL, NULL, 1);

-- --------------------------------------------------------

--
-- Table structure for table `province`
--

CREATE TABLE `province` (
  `province_id` int(11) NOT NULL,
  `province_name_en` varchar(240) DEFAULT NULL,
  `province_name_si` varchar(240) DEFAULT NULL,
  `province_name_ta` varchar(240) DEFAULT NULL,
  `itteration_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `province`
--

INSERT INTO `province` (`province_id`, `province_name_en`, `province_name_si`, `province_name_ta`, `itteration_id`) VALUES
(1, 'Western', 'බස්නාහිර', NULL, 3),
(2, 'Central', 'මධ්‍යම', NULL, 3),
(3, 'Southern', 'දකුණු', NULL, 3),
(4, 'Northern', 'උතුරු', NULL, 3),
(5, 'Eastern', 'නැගෙනහිර', NULL, 3),
(6, 'North Western', 'වයඹ', NULL, 3),
(7, 'North Central', 'උතුරුමැද', NULL, 3),
(8, 'Uva', 'ඌව', NULL, 3),
(9, 'Sabaragamuwa ', 'සබරගමුව', NULL, 3);

-- --------------------------------------------------------

--
-- Table structure for table `ward`
--

CREATE TABLE `ward` (
  `wd_id` int(11) NOT NULL,
  `wd_name_en` varchar(150) DEFAULT NULL,
  `wd_name_si` varchar(150) DEFAULT NULL,
  `wd_name_ta` varchar(150) DEFAULT NULL,
  `la_id` int(11) DEFAULT NULL,
  `itteration_id` int(11) DEFAULT NULL,
  `geo_location` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admindistrict`
--
ALTER TABLE `admindistrict`
  ADD PRIMARY KEY (`admin_dis_id`);

--
-- Indexes for table `countingcentre`
--
ALTER TABLE `countingcentre`
  ADD PRIMARY KEY (`cc_id`);

--
-- Indexes for table `current_election`
--
ALTER TABLE `current_election`
  ADD PRIMARY KEY (`current_ele_id`);

--
-- Indexes for table `districtcentre`
--
ALTER TABLE `districtcentre`
  ADD PRIMARY KEY (`dc_id`);

--
-- Indexes for table `election`
--
ALTER TABLE `election`
  ADD PRIMARY KEY (`election_id`);

--
-- Indexes for table `electoraldistrict`
--
ALTER TABLE `electoraldistrict`
  ADD PRIMARY KEY (`ed_id`);

--
-- Indexes for table `itteration`
--
ALTER TABLE `itteration`
  ADD PRIMARY KEY (`itteration_id`);

--
-- Indexes for table `localauthority`
--
ALTER TABLE `localauthority`
  ADD PRIMARY KEY (`la_id`);

--
-- Indexes for table `party`
--
ALTER TABLE `party`
  ADD PRIMARY KEY (`party_id`);

--
-- Indexes for table `pollingdistrict`
--
ALTER TABLE `pollingdistrict`
  ADD PRIMARY KEY (`pd_id`);

--
-- Indexes for table `pollingdivision`
--
ALTER TABLE `pollingdivision`
  ADD PRIMARY KEY (`pdiv_id`);

--
-- Indexes for table `pollingstation`
--
ALTER TABLE `pollingstation`
  ADD PRIMARY KEY (`ps_id`);

--
-- Indexes for table `province`
--
ALTER TABLE `province`
  ADD PRIMARY KEY (`province_id`);

--
-- Indexes for table `ward`
--
ALTER TABLE `ward`
  ADD PRIMARY KEY (`wd_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admindistrict`
--
ALTER TABLE `admindistrict`
  MODIFY `admin_dis_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `countingcentre`
--
ALTER TABLE `countingcentre`
  MODIFY `cc_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `current_election`
--
ALTER TABLE `current_election`
  MODIFY `current_ele_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `districtcentre`
--
ALTER TABLE `districtcentre`
  MODIFY `dc_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `election`
--
ALTER TABLE `election`
  MODIFY `election_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `electoraldistrict`
--
ALTER TABLE `electoraldistrict`
  MODIFY `ed_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `itteration`
--
ALTER TABLE `itteration`
  MODIFY `itteration_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `localauthority`
--
ALTER TABLE `localauthority`
  MODIFY `la_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `party`
--
ALTER TABLE `party`
  MODIFY `party_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `pollingdistrict`
--
ALTER TABLE `pollingdistrict`
  MODIFY `pd_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `pollingdivision`
--
ALTER TABLE `pollingdivision`
  MODIFY `pdiv_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `pollingstation`
--
ALTER TABLE `pollingstation`
  MODIFY `ps_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `province`
--
ALTER TABLE `province`
  MODIFY `province_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `ward`
--
ALTER TABLE `ward`
  MODIFY `wd_id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
