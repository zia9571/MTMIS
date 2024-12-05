-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 27, 2024 at 06:56 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mtmis`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `ID` int(11) NOT NULL,
  `username` varchar(60) NOT NULL,
  `password` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`ID`, `username`, `password`) VALUES
(1, 'admin', 'root'),
(2, 'Mason', 'root');

-- --------------------------------------------------------

--
-- Table structure for table `bookings`
--

CREATE TABLE `bookings` (
  `booking_id` int(11) NOT NULL,
  `show_id` int(11) DEFAULT NULL,
  `seat_number` varchar(10) DEFAULT NULL,
  `customer_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bookings`
--

INSERT INTO `bookings` (`booking_id`, `show_id`, `seat_number`, `customer_id`) VALUES
(1, 1, 'A5', NULL),
(2, 2, 'B2', NULL),
(3, 1, 'A3', NULL),
(4, 1, 'B2', NULL),
(5, 1, 'B3', NULL),
(6, 1, 'C2', NULL),
(7, 1, 'C3', NULL),
(8, 2, 'C3', NULL),
(9, 1, 'B4', NULL),
(10, 1, 'C4', NULL),
(11, 2, 'B4', NULL),
(12, 2, 'B5', NULL),
(13, 2, 'C4', NULL),
(14, 3, 'C3', NULL),
(15, 3, 'C4', NULL),
(16, 1, 'B4', NULL),
(17, 1, 'B5', NULL),
(18, 1, 'C4', NULL),
(19, 1, 'C5', NULL),
(20, 1, 'C2', NULL),
(21, 1, 'C3', NULL),
(22, 1, 'B2', NULL),
(23, 1, 'B3', NULL),
(24, 3, 'B3', NULL),
(25, 3, 'B4', NULL),
(26, 3, 'B5', NULL),
(27, 3, 'C2', NULL),
(28, 3, 'C3', NULL),
(29, 3, 'C4', NULL),
(30, 3, 'C5', NULL),
(31, 3, 'C3', NULL),
(32, 3, 'C4', NULL),
(33, 3, 'C5', NULL),
(34, 3, 'C2', NULL),
(35, 4, 'C3', NULL),
(36, 4, 'C4', NULL),
(37, 5, 'C3', NULL),
(38, 5, 'C4', NULL),
(39, 1, 'B3', NULL),
(40, 1, 'B4', NULL),
(41, 3, 'B3', NULL),
(42, 3, 'B4', NULL),
(43, 1, 'C3', NULL),
(44, 1, 'C4', NULL),
(45, NULL, NULL, NULL),
(46, 4, 'B3', NULL),
(47, 4, 'B4', NULL),
(48, 5, 'B3', NULL),
(49, 5, 'B4', NULL),
(50, 1, 'A3', NULL),
(51, 1, 'A4', NULL),
(52, 6, 'C3', NULL),
(53, 6, 'C4', NULL),
(54, 2, 'C3', NULL),
(55, 2, 'C4', NULL),
(56, 1, '1', 23),
(57, 3, 'B1', NULL),
(58, 3, 'B2', NULL),
(59, 1, 'C2', NULL),
(60, 1, 'C5', NULL),
(61, 1, '1', 25),
(62, 2, 'B2', NULL),
(63, 2, 'B3', NULL),
(64, 2, 'B4', NULL),
(65, 1, '1', 26),
(66, 4, 'C1', NULL),
(67, 4, 'C2', NULL),
(68, 1, '1', 27),
(69, 4, 'B2', NULL),
(70, 4, 'B5', NULL),
(71, 4, 'C5', NULL),
(72, 1, 'B5', 28),
(73, 1, 'C5', 28),
(74, 4, 'C2', NULL),
(75, 4, 'C3', NULL),
(76, 4, 'C4', NULL),
(77, 1, 'C3', 29),
(78, 1, 'C4', 29),
(79, 1, 'C5', 29),
(80, 4, 'B3', NULL),
(81, 4, 'B4', NULL),
(82, 1, 'B3', 30),
(83, 1, 'B4', 30),
(84, 4, 'B1', NULL),
(85, 4, 'B2', NULL),
(86, 4, 'B1', 31),
(87, 4, 'B2', 31),
(88, 6, 'C1', NULL),
(89, 6, 'C2', NULL),
(90, 6, 'C1', 32),
(91, 6, 'C2', 32),
(92, 6, 'B3', NULL),
(93, 6, 'B4', NULL),
(94, 6, 'B3', 33),
(95, 6, 'B4', 33),
(96, 5, 'C1', NULL),
(97, 5, 'C2', NULL),
(98, 5, 'C5', NULL),
(99, 5, 'C1', 34),
(100, 5, 'C2', 34),
(101, 5, 'C5', 34),
(102, 1, 'B1', NULL),
(103, 1, 'B2', NULL),
(104, 3, 'B1', 35),
(105, 3, 'B2', 35),
(106, 3, 'B5', NULL),
(107, 3, 'B5', 36),
(108, 3, 'C1', NULL),
(109, 3, 'C1', 37),
(110, 5, 'B1', NULL),
(111, 5, 'B2', NULL),
(112, 5, 'B1', 38),
(113, 5, 'B2', 38),
(114, 6, 'B1', NULL),
(115, 6, 'B2', NULL),
(116, 6, 'B5', NULL),
(117, 6, 'B1', 39),
(118, 6, 'B2', 39),
(119, 6, 'B5', 39),
(120, 1, 'A5', NULL),
(121, 1, 'B5', NULL),
(122, 1, 'A5', 40),
(123, 1, 'B5', 40),
(124, 3, 'C3', NULL),
(125, 3, 'C4', NULL),
(126, 3, 'C3', 41),
(127, 3, 'C4', 41),
(128, 1, 'A1', NULL),
(129, 1, 'A2', NULL),
(130, 1, 'A1', 42),
(131, 1, 'A2', 42),
(132, 3, 'C1', NULL),
(133, 3, 'C2', NULL),
(134, 3, 'C1', 43),
(135, 3, 'C2', 43),
(136, 1, 'C2', NULL),
(137, 1, 'C3', NULL),
(138, 1, 'C4', NULL),
(139, 1, 'C2', 44),
(140, 1, 'C3', 44),
(141, 1, 'C4', 44),
(142, 6, 'C4', NULL),
(143, 6, 'C5', NULL),
(144, 6, 'C4', 45),
(145, 6, 'C5', 45),
(146, 1, 'B3', NULL),
(147, 1, 'B4', NULL),
(148, 1, 'B3', 46),
(149, 1, 'B4', 46),
(152, 1, 'A3', NULL),
(153, 1, 'A4', NULL),
(154, 1, 'A3', 48),
(155, 1, 'A4', 48),
(156, 2, 'C1', NULL),
(157, 2, 'C2', NULL),
(158, 2, 'C1', 49),
(159, 2, 'C2', 49),
(160, 1, 'B1', NULL),
(161, 1, 'B2', NULL),
(162, 1, 'B1', 50),
(163, 1, 'B2', 50),
(164, 1, 'A1', NULL),
(165, 1, 'A2', NULL),
(166, 1, 'A1', 51),
(167, 1, 'A2', 51),
(168, 1, 'C1', NULL),
(169, 1, 'C5', NULL),
(170, 1, 'C1', 52),
(171, 1, 'C5', 52),
(172, 5, 'B5', NULL),
(173, 5, 'B5', 53),
(174, 2, 'C5', NULL),
(175, 2, 'C5', 54),
(176, 5, 'C3', NULL),
(177, 5, 'C4', NULL),
(178, 5, 'C3', 55),
(179, 5, 'C4', 55),
(180, 6, 'C2', NULL),
(181, 6, 'C3', NULL),
(182, 6, 'C2', 56),
(183, 6, 'C3', 56),
(184, 1, 'A5', NULL),
(185, 1, 'B5', NULL),
(186, 1, 'A5', 57),
(187, 1, 'B5', 57),
(188, 1, 'C3', NULL),
(189, 1, 'C4', NULL),
(190, 1, 'C3', NULL),
(191, 1, 'C4', NULL),
(192, 1, 'C3', 58),
(193, 1, 'C4', 58),
(194, 1, 'B3', NULL),
(195, 1, 'B4', NULL),
(196, 1, 'B3', 59),
(197, 1, 'B4', 59),
(198, 1, 'A3', NULL),
(199, 1, 'A4', NULL),
(200, 1, 'A3', 60),
(201, 1, 'A4', 60),
(202, 1, 'A3', NULL),
(203, 1, 'A4', NULL),
(204, 1, 'A3', 61),
(205, 1, 'A4', 61),
(206, 1, 'A3', 62),
(207, 1, 'A4', 62),
(208, 1, 'C2', NULL),
(209, 1, 'C2', 63),
(210, 7, 'C3', NULL),
(211, 7, 'C4', NULL),
(212, 7, 'C3', 64),
(213, 7, 'C4', 64),
(218, 1, 'B1', NULL),
(219, 1, 'B2', NULL),
(220, 1, 'B1', 66),
(221, 1, 'B2', 66),
(222, 1, 'C1', NULL),
(223, 1, 'C2', NULL),
(224, 1, 'C3', NULL),
(225, 1, 'C4', NULL),
(226, 1, 'C5', NULL),
(227, 1, 'C1', 67),
(228, 1, 'C2', 67),
(229, 1, 'C3', 67),
(230, 1, 'C4', 67),
(231, 1, 'C5', 67),
(232, 3, 'B3', NULL),
(233, 3, 'B4', NULL),
(234, 2, 'B3', 68),
(235, 2, 'B4', 68),
(236, 7, 'C2', NULL),
(237, 7, 'C2', 69),
(238, 7, 'B1', NULL),
(239, 7, 'B2', NULL),
(240, 3, 'C5', NULL),
(241, 4, 'C5', 70);

-- --------------------------------------------------------

--
-- Table structure for table `clerk`
--

CREATE TABLE `clerk` (
  `cID` int(11) NOT NULL,
  `cusername` varchar(255) NOT NULL,
  `cpassword` varchar(255) NOT NULL,
  `position` varchar(50) DEFAULT NULL,
  `phone_number` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `clerk`
--

INSERT INTO `clerk` (`cID`, `cusername`, `cpassword`, `position`, `phone_number`) VALUES
(1, 'John Doe', 'root', 'Counter Clerk', '9586767864'),
(11, 'Carter', 'root', 'Cleaners/Janitorial Staff', '9867886795'),
(12, 'Mason', 'root', 'Admin (Manager)', '9868697567'),
(13, 'Sasha', 'root', 'Concessions Staff', '9586768689'),
(14, 'Butch', 'root', 'Security Personnel', '8757689569');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `phone_number` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`customer_id`, `name`, `phone_number`) VALUES
(1, 'Z', '8746573845'),
(2, 'Jane Austen', '5364576456'),
(3, 'Janice', '6456774658'),
(4, 'Zia', '8767854678'),
(5, 'MJ Roberts', '7676864567'),
(6, 'Jake', '5756757868'),
(11, 'Katherine', '7657574857'),
(13, 'Ziaa', '7687898989'),
(14, 'Fahad', '6578578934'),
(18, 'Gautam', '8737484757'),
(19, 'Farida', '8274847578'),
(20, 'Andy', '8789893456'),
(21, 'Jules', '8984567348'),
(22, 'Kim', '8968923498'),
(23, 'Tqeen', '9834678945'),
(24, 'Fah', '9823457896'),
(25, 'Gai', '9274473947'),
(26, 'Rid', '2839459458'),
(27, 'Jimmy', '4757593746'),
(28, 'Tammy', '9847595758'),
(29, 'Hina', '9824682749'),
(30, 'Tis', '7474973474'),
(31, 'Had', '9867734567'),
(32, 'An', '9836478956'),
(33, 'Jud', '9836468475'),
(34, 'Jan', '8747498465'),
(35, 'Hon', '837475874'),
(36, 'Jil', '7365738475'),
(37, 'Ama', '746565837'),
(38, 'Fal', '4656583748'),
(39, 'Asha', '7465774657'),
(40, 'Zia Rashid', '7465655754'),
(41, 'Ari', '8264647474'),
(42, 'Jan', '7646464756'),
(43, 'Geet', '9857628474'),
(44, 'Kika', '2535483747'),
(45, 'Sana', '8374759445'),
(46, 'Teb', '6466583774'),
(47, 'Dal', '756657555'),
(48, 'Dal', '6364694757'),
(49, 'Kik', '7565657574'),
(50, 'Anabh', '7465565474'),
(51, 'Upta', '7755755855'),
(52, 'Sash', '6465657657'),
(53, 'Aryan', '6565736467'),
(54, 'Jordan', '6565757539'),
(55, 'Shreyas', '6552765567'),
(56, 'Dhanush', '6575739474'),
(57, 'Zara', '7565637473'),
(58, 'June', '6565658475'),
(59, 'August', '6644855768'),
(60, 'Katha', '7474492837'),
(61, 'Katha', '6465658345'),
(62, 'Kathak', '6575967495'),
(63, 'Anthony', '6464658374'),
(64, 'Om', '6445583748'),
(65, 'Zri', '6376464837'),
(66, 'Nadia', '9374746576'),
(67, 'Abir', '758679659'),
(68, 'Biku', '6475657567'),
(69, 'Biki', '99310 90555'),
(70, 'Sasha', '9686868573');

-- --------------------------------------------------------

--
-- Table structure for table `moviedetails`
--

CREATE TABLE `moviedetails` (
  `mID` int(11) NOT NULL,
  `mtitle` varchar(255) NOT NULL,
  `mposter` varchar(255) NOT NULL,
  `mdes` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `moviedetails`
--

INSERT INTO `moviedetails` (`mID`, `mtitle`, `mposter`, `mdes`) VALUES
(5, 'Little Woman', 'C:\\Users\\Downloads\\mtmis assets\\Posters\\Little Woman.png', 'With their father fighting in the American Civil War, sisters Jo, Meg, Amy and Beth are at home with their mother, a very outspoken woman for her time. The story tells of how the sisters grow up, find love, and find their place in the world.'),
(6, 'Pride and Prejudice', 'C:\\Users\\Downloads\\mtmis assets\\Posters\\Pride and Prejudice.png', 'Pride and Prejudice follows the turbulent relationship between Elizabeth Bennet, the daughter of a country gentleman, and Fitzwilliam Darcy, a rich aristocratic landowner. They must overcome the titular sins of pride and prejudice in order to fall in love and marry.'),
(7, 'Om Shanti Om', 'C:\\Users\\Downloads\\mtmis assets\\Posters\\Om Shanti Om.png', 'Om Prakash Makhija is a Junior Artist in the 1970s Hindi film industry and in love with actress Shantipriya. Om rescues Shanti from an out-of-control fire scene and they become friends. His hopes seem to be coming true--until he finds out that she\'s married to film producer Mukesh Mehra and expecting his child. He then watches in horror as Mukesh, after luring her into an abandoned studio, sets it afire to prevent a financial loss and protect his career. Om attempts--unsuccessfully--to rescue her and eventually dies himself. 30 years later, Om has been reincarnated as the only son of Bollywood actor Rajesh Kapoor, and is himself an actor. His memories start to return when he meets his widowed mother Bela, from his previous life. He also meets Mukesh and they decide to make a movie, \'Om Shanti Om\'. Om hires a look-alike of Shantipriya and hopes to force a confession from Mukesh, but things go awry and Om finds his life endangered once again.'),
(8, 'Cars', 'C:\\Users\\Downloads\\mtmis assets\\Posters\\Cars.png', 'In a world where the towns are peopled with cars, and even the bugs are mini motors, a young ambitious racing car called Lightning McQueen is a star. On his way to an important event he has to stop in the little town of Radiator Springs after he accidentally damages the road and is forced to repair it. He finds living in a community oddly endearing, making true friends and beginning to realise there\'s more in life than winning. A Pixar animation.'),
(9, 'Princess Diaries', 'C:\\Users\\Downloads\\mtmis assets\\Posters\\Princess Diaries.png', 'Shy San Francisco teenager Mia Thermopolis (Anne Hathaway) is thrown for a loop when, from out of the blue, she learns the astonishing news that she\'s a real-life princess! As the heir apparent to the crown of the small European principality of Genovia, Mia begins a comical journey toward the throne when her strict and formidable grandmother, Queen Clarisse Renaldi (Julie Andrews), shows up to give her \"princess lessons.\"'),
(17, 'October', 'C:\\Users\\Downloads\\mtmis assets\\Posters\\October.png', 'Dan and Shiuli are brought closer in an unexpected turn of events. Eventually, they develop feelings for each other and establish a bond unlike any other which leads to an internal awakening.');

-- --------------------------------------------------------

--
-- Table structure for table `seats`
--

CREATE TABLE `seats` (
  `seat_id` int(11) NOT NULL,
  `show_id` int(11) DEFAULT NULL,
  `seat_number` varchar(10) DEFAULT NULL,
  `status` enum('available','booked') DEFAULT 'available'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `seats`
--

INSERT INTO `seats` (`seat_id`, `show_id`, `seat_number`, `status`) VALUES
(1, 1, 'A1', 'available'),
(2, 1, 'A2', 'available'),
(3, 1, 'A3', 'available'),
(4, 1, 'A4', 'available'),
(5, 1, 'A5', 'available'),
(6, 2, 'B1', 'available'),
(7, 2, 'B2', 'booked'),
(8, 2, 'B3', 'booked'),
(9, 2, 'B4', 'booked'),
(10, 2, 'B5', 'available'),
(11, 1, 'B1', 'available'),
(12, 3, 'B1', 'available'),
(13, 4, 'B1', 'booked'),
(14, 5, 'B1', 'available'),
(15, 6, 'B1', 'available'),
(16, 1, 'B2', 'available'),
(17, 3, 'B2', 'available'),
(18, 4, 'B2', 'booked'),
(19, 5, 'B2', 'available'),
(20, 6, 'B2', 'available'),
(21, 1, 'B3', 'available'),
(22, 3, 'B3', 'booked'),
(23, 4, 'B3', 'booked'),
(24, 5, 'B3', 'available'),
(25, 6, 'B3', 'available'),
(26, 1, 'B4', 'available'),
(27, 3, 'B4', 'booked'),
(28, 4, 'B4', 'booked'),
(29, 5, 'B4', 'available'),
(30, 6, 'B4', 'available'),
(31, 1, 'B5', 'available'),
(32, 3, 'B5', 'available'),
(33, 4, 'B5', 'available'),
(34, 5, 'B5', 'available'),
(35, 6, 'B5', 'available'),
(36, 1, 'C1', 'booked'),
(37, 2, 'C1', 'booked'),
(38, 3, 'C1', 'booked'),
(39, 4, 'C1', 'available'),
(40, 5, 'C1', 'available'),
(41, 6, 'C1', 'available'),
(42, 1, 'C2', 'booked'),
(43, 2, 'C2', 'booked'),
(44, 3, 'C2', 'booked'),
(45, 4, 'C2', 'booked'),
(46, 5, 'C2', 'available'),
(47, 6, 'C2', 'booked'),
(48, 1, 'C3', 'booked'),
(49, 2, 'C3', 'booked'),
(50, 3, 'C3', 'booked'),
(51, 4, 'C3', 'booked'),
(52, 5, 'C3', 'booked'),
(53, 6, 'C3', 'booked'),
(54, 1, 'C4', 'booked'),
(55, 2, 'C4', 'booked'),
(56, 3, 'C4', 'booked'),
(57, 4, 'C4', 'booked'),
(58, 5, 'C4', 'booked'),
(59, 6, 'C4', 'booked'),
(60, 1, 'C5', 'booked'),
(61, 2, 'C5', 'booked'),
(62, 3, 'C5', 'booked'),
(63, 4, 'C5', 'available'),
(64, 5, 'C5', 'available'),
(65, 6, 'C5', 'booked'),
(66, 7, 'A1', 'available'),
(67, 7, 'A2', 'available'),
(68, 7, 'A3', 'available'),
(69, 7, 'A4', 'available'),
(70, 7, 'A5', 'available'),
(71, 7, 'B1', 'booked'),
(72, 7, 'B2', 'booked'),
(73, 7, 'B3', 'available'),
(74, 7, 'B4', 'available'),
(75, 7, 'B5', 'available'),
(76, 7, 'C1', 'available'),
(77, 7, 'C2', 'booked'),
(78, 7, 'C3', 'booked'),
(79, 7, 'C4', 'booked'),
(80, 7, 'C5', 'available'),
(141, 12, 'A1', 'available'),
(142, 12, 'A2', 'available'),
(143, 12, 'A3', 'available'),
(144, 12, 'A4', 'available'),
(145, 12, 'A5', 'available'),
(146, 12, 'B6', 'available'),
(147, 12, 'B7', 'available'),
(148, 12, 'B8', 'available'),
(149, 12, 'B9', 'available'),
(150, 12, 'B10', 'available'),
(151, 12, 'C11', 'available'),
(152, 12, 'C12', 'available'),
(153, 12, 'C13', 'available'),
(154, 12, 'C14', 'available'),
(155, 12, 'C15', 'available');

-- --------------------------------------------------------

--
-- Table structure for table `shows`
--

CREATE TABLE `shows` (
  `show_id` int(11) NOT NULL,
  `mID` int(11) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `time` time DEFAULT NULL,
  `auditorium` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `shows`
--

INSERT INTO `shows` (`show_id`, `mID`, `date`, `time`, `auditorium`) VALUES
(1, 5, '2024-11-20', '14:00:00', 'Auditorium 1'),
(2, 5, '2024-11-20', '16:00:00', 'Auditorium 2'),
(3, 6, '2024-11-21', '12:00:00', 'Auditorium 1'),
(4, 6, '2024-11-21', '15:00:00', 'Auditorium 2'),
(5, 8, '2024-11-22', '10:00:00', 'Auditorium 1'),
(6, 9, '2024-11-22', '14:00:00', 'Auditorium 2'),
(7, 7, '2024-12-02', '14:00:00', 'Auditorium 1'),
(12, 17, '2024-12-10', '13:00:00', 'Auditorium 2');

-- --------------------------------------------------------

--
-- Table structure for table `ticket`
--

CREATE TABLE `ticket` (
  `ticket_id` int(11) NOT NULL,
  `ticket_price` int(11) NOT NULL,
  `customer_name` varchar(100) NOT NULL,
  `customer_phone_number` varchar(15) NOT NULL,
  `auditorium` varchar(50) NOT NULL,
  `day` date NOT NULL,
  `time` time NOT NULL,
  `show_id` int(11) DEFAULT NULL,
  `seat_numbers` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ticket`
--

INSERT INTO `ticket` (`ticket_id`, `ticket_price`, `customer_name`, `customer_phone_number`, `auditorium`, `day`, `time`, `show_id`, `seat_numbers`) VALUES
(3, 200, 'Gauri', '9274473947', 'Auditorium 1', '2024-11-20', '14:00:00', NULL, NULL),
(4, 200, 'Rida', '2839459458', 'Auditorium 1', '2024-11-20', '14:00:00', NULL, NULL),
(5, 200, 'Jimmy', '4757593746', 'Auditorium 1', '2024-11-20', '14:00:00', NULL, NULL),
(6, 400, 'Tammy', '9847595758', 'Auditorium 1', '2024-11-20', '14:00:00', 1, NULL),
(7, 600, 'Hana', '9824682749', 'Auditorium 1', '2024-11-20', '14:00:00', 1, NULL),
(8, 400, 'Ton', '7474973474', 'Auditorium 1', '2024-11-20', '14:00:00', 1, NULL),
(9, 400, 'Had', '9867734567', 'Auditorium 2', '2024-11-21', '15:00:00', 4, NULL),
(10, 400, 'Am', '9836478956', 'Auditorium 2', '2024-11-22', '14:00:00', 6, NULL),
(11, 400, 'Jy', '9836468475', 'Auditorium 2', '2024-11-22', '14:00:00', 6, NULL),
(12, 600, 'Jan', '8747498465', 'Auditorium 1', '2024-11-22', '10:00:00', 5, NULL),
(13, 400, 'Hon', '837475874', 'Auditorium 1', '2024-11-21', '12:00:00', 3, NULL),
(14, 200, 'Jil', '7365738475', 'Auditorium 1', '2024-11-21', '12:00:00', 3, NULL),
(15, 200, 'Aera', '746565837', 'Auditorium 1', '2024-11-21', '12:00:00', 3, NULL),
(16, 400, 'Fal', '4656583748', 'Auditorium 1', '2024-11-22', '10:00:00', 5, NULL),
(17, 600, 'Asha', '7465774657', 'Auditorium 2', '2024-11-22', '14:00:00', 6, 'B1,B2,B5'),
(18, 400, 'Zia Rashid', '7465655754', 'Auditorium 1', '2024-11-20', '14:00:00', 1, 'A5,B5'),
(19, 400, 'Ari', '8264647474', 'Auditorium 1', '2024-11-21', '12:00:00', 3, 'C3,C4'),
(20, 400, 'Jan', '7646464756', 'Auditorium 1', '2024-11-20', '14:00:00', 1, 'A1,A2'),
(21, 400, 'Geet', '9857628474', 'Auditorium 1', '2024-11-21', '12:00:00', 3, 'C1,C2'),
(22, 600, 'Kika', '2535483747', 'Auditorium 1', '2024-11-20', '14:00:00', 1, 'C2,C3,C4'),
(40, 200, 'Anthony', '6464658374', 'Auditorium 1', '2024-11-20', '14:00:00', 1, 'C2'),
(41, 400, 'Om', '6445583748', 'Auditorium 1', '2024-12-02', '14:00:00', 7, 'C3,C4'),
(42, 400, 'Zara', '6376464837', 'Auditorium 2', '2024-12-05', '17:00:00', 10, 'B8,B9'),
(43, 400, 'Nadia', '9374746576', 'Auditorium 1', '2024-11-20', '14:00:00', 1, 'B1,B2'),
(44, 1000, 'Abir', '758679659', 'Auditorium 1', '2024-11-20', '14:00:00', 1, 'C1,C2,C3,C4,C5'),
(45, 400, 'Biku', '6475657567', 'Auditorium 2', '2024-11-20', '16:00:00', 2, 'B3,B4'),
(46, 200, 'Bikhi', '99310 90555', 'Auditorium 1', '2024-12-02', '14:00:00', 7, 'C2'),
(47, 200, 'Sasha', '9686868573', 'Auditorium 2', '2024-11-21', '15:00:00', 4, 'C5');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `bookings`
--
ALTER TABLE `bookings`
  ADD PRIMARY KEY (`booking_id`),
  ADD KEY `show_id` (`show_id`);

--
-- Indexes for table `clerk`
--
ALTER TABLE `clerk`
  ADD PRIMARY KEY (`cID`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customer_id`),
  ADD UNIQUE KEY `phone_number` (`phone_number`);

--
-- Indexes for table `moviedetails`
--
ALTER TABLE `moviedetails`
  ADD PRIMARY KEY (`mID`);

--
-- Indexes for table `seats`
--
ALTER TABLE `seats`
  ADD PRIMARY KEY (`seat_id`),
  ADD KEY `show_id` (`show_id`);

--
-- Indexes for table `shows`
--
ALTER TABLE `shows`
  ADD PRIMARY KEY (`show_id`),
  ADD KEY `mID` (`mID`);

--
-- Indexes for table `ticket`
--
ALTER TABLE `ticket`
  ADD PRIMARY KEY (`ticket_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `bookings`
--
ALTER TABLE `bookings`
  MODIFY `booking_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=242;

--
-- AUTO_INCREMENT for table `clerk`
--
ALTER TABLE `clerk`
  MODIFY `cID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=71;

--
-- AUTO_INCREMENT for table `moviedetails`
--
ALTER TABLE `moviedetails`
  MODIFY `mID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `seats`
--
ALTER TABLE `seats`
  MODIFY `seat_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=156;

--
-- AUTO_INCREMENT for table `shows`
--
ALTER TABLE `shows`
  MODIFY `show_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `ticket`
--
ALTER TABLE `ticket`
  MODIFY `ticket_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `bookings`
--
ALTER TABLE `bookings`
  ADD CONSTRAINT `bookings_ibfk_1` FOREIGN KEY (`show_id`) REFERENCES `shows` (`show_id`);

--
-- Constraints for table `seats`
--
ALTER TABLE `seats`
  ADD CONSTRAINT `seats_ibfk_1` FOREIGN KEY (`show_id`) REFERENCES `shows` (`show_id`);

--
-- Constraints for table `shows`
--
ALTER TABLE `shows`
  ADD CONSTRAINT `shows_ibfk_1` FOREIGN KEY (`mID`) REFERENCES `moviedetails` (`mID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
