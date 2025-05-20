-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 20, 2025 at 07:47 PM
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
-- Database: `laundry_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `completed_table`
--

CREATE TABLE `completed_table` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `contact_info` varchar(255) NOT NULL,
  `total_cost` int(11) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `completed_table`
--

INSERT INTO `completed_table` (`id`, `name`, `contact_info`, `total_cost`, `date`) VALUES
(1, 'jed', '102904', 0, '2025-05-20'),
(3, 'waw', '123', 150, '2025-05-20'),
(4, 'jed', '102904', 0, '2025-05-20'),
(5, 'Jeda', '0912', 300, '2025-05-20'),
(6, 'gdgd', '2222', 400, '2025-05-21'),
(7, 'jed ', '102904', 400, '2025-05-21'),
(8, 'hdftfh', '2222', 300, '2025-05-21'),
(9, 'jed', '102904', 400, '2025-05-21'),
(10, 'poda', '102904', 300, '2025-05-21'),
(11, 'sasa', '102904', 400, '2025-05-21'),
(12, 'kala', '102904', 300, '2025-05-21'),
(13, 'lopa', '102904', 400, '2025-05-21'),
(14, 'fada', '102904', 300, '2025-05-21'),
(16, 'arlei', '08214792444', 500, '2025-05-21'),
(17, 'adi', '102904', 0, '2025-05-21');

-- --------------------------------------------------------

--
-- Table structure for table `services_table`
--

CREATE TABLE `services_table` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `contact_info` varchar(20) NOT NULL,
  `service_type` varchar(255) NOT NULL,
  `total_cost` int(11) NOT NULL,
  `special_instruction` text NOT NULL,
  `date_time` datetime NOT NULL,
  `status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `services_table`
--

INSERT INTO `services_table` (`id`, `name`, `contact_info`, `service_type`, `total_cost`, `special_instruction`, `date_time`, `status`) VALUES
(11, 'arlei', '101', 'Curtains', 500, 'zaaaazzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz', '2025-05-21 01:20:38', 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` int(50) NOT NULL,
  `name` varchar(255) NOT NULL,
  `contact_info` varchar(255) NOT NULL,
  `age` int(255) NOT NULL,
  `birthday` date NOT NULL,
  `gender` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `name`, `contact_info`, `age`, `birthday`, `gender`) VALUES
(1, 'jed', '2222', 23, '0000-00-00', '22'),
(2, 'adi', '234', 44, '2025-03-21', 'male'),
(3, 'dj', '22', 22, '2025-05-09', 'Female'),
(4, 'fgdfg', '11', 11, '2025-04-30', 'Male'),
(5, 'fed', '123', 22, '2025-05-09', 'Female'),
(6, 'wow', '192', 33, '2025-05-01', 'Male'),
(7, 'jfjsdf', '222', 22, '2025-05-03', 'Male'),
(8, 'dgdgddg', '35345', 11, '2025-05-09', 'Male'),
(9, 'deo', '2222', 12, '2025-05-08', 'Female');

-- --------------------------------------------------------

--
-- Table structure for table `voucher_table`
--

CREATE TABLE `voucher_table` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `value` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `completed_table`
--
ALTER TABLE `completed_table`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `services_table`
--
ALTER TABLE `services_table`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `voucher_table`
--
ALTER TABLE `voucher_table`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `completed_table`
--
ALTER TABLE `completed_table`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `services_table`
--
ALTER TABLE `services_table`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `voucher_table`
--
ALTER TABLE `voucher_table`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
