-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 04, 2018 at 10:34 PM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 5.6.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bps`
--

-- --------------------------------------------------------

--
-- Table structure for table `karyawan`
--

CREATE TABLE `karyawan` (
  `nik` varchar(15) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `divisi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `karyawan`
--

INSERT INTO `karyawan` (`nik`, `nama`, `email`, `divisi`) VALUES
('123', 'ulfatun syariyah', 'ulfataqwa@gmail.com', 'Hubungan Masyarakat'),
('2014312', 'Fahmi Roihanul F', 'frayhands@gmail.com', 'Hubungan Masyarakat'),
('201431294', 'Firman Giri', 'firman@bps.com', 'Hubungan Masyarakat');

-- --------------------------------------------------------

--
-- Table structure for table `pemesanan`
--

CREATE TABLE `pemesanan` (
  `no` int(11) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `divisi` varchar(50) NOT NULL,
  `kategori` varchar(20) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `kss` int(11) NOT NULL,
  `ksl` int(11) NOT NULL,
  `kms` int(11) NOT NULL,
  `kml` int(11) NOT NULL,
  `kls` int(11) NOT NULL,
  `kll` int(11) NOT NULL,
  `kxls` int(11) NOT NULL,
  `kxll` int(11) NOT NULL,
  `ass` int(11) NOT NULL,
  `asl` int(11) NOT NULL,
  `ams` int(11) NOT NULL,
  `aml` int(11) NOT NULL,
  `als` int(11) NOT NULL,
  `adll` int(11) NOT NULL,
  `axls` int(11) NOT NULL,
  `axll` int(11) NOT NULL,
  `axxls` int(11) NOT NULL,
  `axxll` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pemesanan`
--

INSERT INTO `pemesanan` (`no`, `nama`, `divisi`, `kategori`, `jumlah`, `kss`, `ksl`, `kms`, `kml`, `kls`, `kll`, `kxls`, `kxll`, `ass`, `asl`, `ams`, `aml`, `als`, `adll`, `axls`, `axll`, `axxls`, `axxll`) VALUES
(1, 'ulfatun syariyah', 'Hubungan Masyarakat', 'Regu Keluarga', 3, 0, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(2, 'ulfatun syariyah', 'Hubungan Masyarakat', 'Regu Keluarga', 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `karyawan`
--
ALTER TABLE `karyawan`
  ADD PRIMARY KEY (`nik`);

--
-- Indexes for table `pemesanan`
--
ALTER TABLE `pemesanan`
  ADD PRIMARY KEY (`no`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pemesanan`
--
ALTER TABLE `pemesanan`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
