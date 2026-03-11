-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2026. Már 04. 10:51
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `clasfund`
--
CREATE DATABASE IF NOT EXISTS `classfund` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `classfund`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `classfund`
--

CREATE TABLE `classfund` (
  `id` int(2) NOT NULL,
  `studentName` varchar(12) DEFAULT NULL,
  `month` varchar(10) DEFAULT NULL,
  `amount` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- A tábla adatainak kiíratása `classfund`
--

INSERT INTO `classfund` (`id`, `studentName`, `month`, `amount`) VALUES
(1, 'Kiss Gábor', 'Szeptember', 5000),
(2, 'Nagy Anna', 'Szeptember', 4000),
(3, 'Szabó László', 'Szeptember', 0),
(4, 'Tóth Eszter', 'Szeptember', 3000),
(5, 'Kiss Gábor', 'Október', 0),
(6, 'Nagy Anna', 'Október', 4000),
(7, 'Szabó László', 'Október', 12000),
(8, 'Tóth Eszter', 'Október', 3000),
(9, 'Varga Péter', 'Szeptember', 3000),
(10, 'Varga Péter', 'Október', 3000),
(11, 'Kiss Gábor', 'November', 10000),
(12, 'Nagy Anna', 'November', 4000),
(13, 'Szabó László', 'November', 6000),
(14, 'Kiss Gábor', 'December', 5000),
(15, 'Tóth Eszter', 'November', 3000),
(16, 'Varga Péter', 'November', 3000),
(17, 'Nagy Anna', 'December', 4000),
(18, 'Kiss Gábor', 'Január', 5000),
(19, 'Nagy Anna', 'Január', 4000),
(20, 'Szabó László', 'December', 6000),
(21, 'Tóth Eszter', 'December', 0),
(22, 'Varga Péter', 'December', 3000),
(23, 'Szabó László', 'Január', 6000),
(24, 'Tóth Eszter', 'Január', 6000),
(25, 'Varga Péter', 'Január', 3000);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `classfund`
--
ALTER TABLE `classfund`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
