-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 28-01-2021 a las 23:27:00
-- Versión del servidor: 10.1.30-MariaDB
-- Versión de PHP: 7.2.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `db_salajuntas`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `liberar_salas` ()  MODIFIES SQL DATA
    COMMENT 'Liberar Salas'
delete r from rentas r inner join salas s on (r.ID_Sala=s.ID_Sala) where s.Hora_Fin < DATE_FORMAT(NOW( ), "%H:%i:%S" )$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `rentas`
--

CREATE TABLE `rentas` (
  `ID_Renta` int(11) NOT NULL,
  `ID_Sala` int(11) NOT NULL,
  `Usuario` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salas`
--

CREATE TABLE `salas` (
  `ID_Sala` int(11) NOT NULL,
  `Nombre` varchar(35) NOT NULL,
  `Hora_Inicio` time NOT NULL,
  `Hora_Fin` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `salas`
--

INSERT INTO `salas` (`ID_Sala`, `Nombre`, `Hora_Inicio`, `Hora_Fin`) VALUES
(1, 'Sala 1', '07:00:00', '08:00:00'),
(2, 'Sala 2', '08:00:00', '09:00:00'),
(3, 'Sala 3', '09:00:00', '10:00:00'),
(4, 'Sala 4', '10:00:00', '11:00:00'),
(5, 'Sala 5', '11:00:00', '12:00:00'),
(6, 'Sala 6', '12:00:00', '13:00:00'),
(7, 'Sala 7', '13:00:00', '14:00:00'),
(8, 'Sala 8', '14:00:00', '15:00:00');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `rentas`
--
ALTER TABLE `rentas`
  ADD PRIMARY KEY (`ID_Renta`,`ID_Sala`),
  ADD KEY `ID_Sala` (`ID_Sala`);

--
-- Indices de la tabla `salas`
--
ALTER TABLE `salas`
  ADD PRIMARY KEY (`ID_Sala`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `rentas`
--
ALTER TABLE `rentas`
  MODIFY `ID_Renta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT de la tabla `salas`
--
ALTER TABLE `salas`
  MODIFY `ID_Sala` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `rentas`
--
ALTER TABLE `rentas`
  ADD CONSTRAINT `rentas_ibfk_1` FOREIGN KEY (`ID_Sala`) REFERENCES `salas` (`ID_Sala`) ON DELETE CASCADE;

DELIMITER $$
--
-- Eventos
--
CREATE DEFINER=`root`@`localhost` EVENT `liberacionSalas` ON SCHEDULE EVERY 1 HOUR STARTS '2021-01-28 16:19:00' ON COMPLETION PRESERVE ENABLE COMMENT 'Ayuda' DO CALL liberar_salas()$$

DELIMITER ;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
