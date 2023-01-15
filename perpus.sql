-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 15, 2023 at 03:55 PM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 7.4.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `perpus`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `admin_id` int(15) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_id`, `username`, `password`) VALUES
(1, 'fathur12', '123'),
(2, 'Bimo08', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `buku`
--

CREATE TABLE `buku` (
  `isbn` int(15) NOT NULL,
  `judul` varchar(20) NOT NULL,
  `pengarang` varchar(15) NOT NULL,
  `penerbit` varchar(15) NOT NULL,
  `tgl_terbit` year(4) NOT NULL,
  `tgl_masuk` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `buku`
--

INSERT INTO `buku` (`isbn`, `judul`, `pengarang`, `penerbit`, `tgl_terbit`, `tgl_masuk`) VALUES
(12345678, '11 11', 'Fiersa Besari ', 'Gramedia', 2018, '2022-05-12');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` varchar(9) NOT NULL,
  `nim` varchar(9) NOT NULL,
  `isbn` varchar(20) NOT NULL,
  `tgl_peminjaman` date NOT NULL,
  `tgl_kembali` date NOT NULL,
  `tgl_dikembalikan` date NOT NULL,
  `denda` varchar(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`id_transaksi`, `nim`, `isbn`, `tgl_peminjaman`, `tgl_kembali`, `tgl_dikembalikan`, `denda`) VALUES
('1', 'A1', '11', '0000-00-00', '0000-00-00', '0000-00-00', ''),
('2', 'A2', '22', '0000-00-00', '0000-00-00', '0000-00-00', ''),
('3', 'E1E2', '123456', '0000-00-00', '0000-00-00', '0000-00-00', ''),
('4', 'W1', '25', '0000-00-00', '0000-00-00', '0000-00-00', ''),
('5', 'A4', '44', '0000-00-00', '0000-00-00', '0000-00-00', '');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `nim` varchar(9) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `no_hp` int(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`nim`, `nama`, `no_hp`) VALUES
('1202020', 'Bitu', 123456789);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`admin_id`);

--
-- Indexes for table `buku`
--
ALTER TABLE `buku`
  ADD PRIMARY KEY (`isbn`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD KEY `nim` (`nim`),
  ADD KEY `isbn` (`isbn`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`nim`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `admin_id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
