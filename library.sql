-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 18 Maj 2023, 23:45
-- Wersja serwera: 10.4.27-MariaDB
-- Wersja PHP: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `library`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `bookauthors`
--

CREATE TABLE `bookauthors` (
  `authorID` int(11) NOT NULL,
  `firstName` varchar(60) NOT NULL,
  `lastName` varchar(60) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Zrzut danych tabeli `bookauthors`
--

INSERT INTO `bookauthors` (`authorID`, `firstName`, `lastName`, `name`) VALUES
(1, 'Marcin', 'Moskała', ''),
(2, 'Paul', 'McFedries', ''),
(4, 'Aleksander', 'Majkowski', ''),
(9, 'Marcin', 'Karbowski', ''),
(18, 'Charles', 'Dickens', ''),
(21, 'Ignacy', 'Mościcki', '');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `bookcategories`
--

CREATE TABLE `bookcategories` (
  `id` int(11) NOT NULL,
  `name` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Zrzut danych tabeli `bookcategories`
--

INSERT INTO `bookcategories` (`id`, `name`) VALUES
(0, 'inne'),
(1, 'fantasy'),
(2, 'science fiction'),
(3, 'horror'),
(4, 'kryminał'),
(5, 'klasyka'),
(6, 'sensacja'),
(8, 'romans'),
(9, 'nauka'),
(10, 'dla dzieci'),
(11, 'faktu'),
(13, 'powieść');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `books`
--

CREATE TABLE `books` (
  `bookID` int(11) NOT NULL,
  `bookName` varchar(225) DEFAULT NULL,
  `bookAuthorID` int(11) NOT NULL,
  `publisherID` int(11) NOT NULL,
  `releaseDate` date DEFAULT NULL,
  `bookCategoryID` int(11) NOT NULL,
  `bookDescription` varchar(255) DEFAULT NULL,
  `quantityInStock` int(11) NOT NULL,
  `totalQuantityInStock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Zrzut danych tabeli `books`
--

INSERT INTO `books` (`bookID`, `bookName`, `bookAuthorID`, `publisherID`, `releaseDate`, `bookCategoryID`, `bookDescription`, `quantityInStock`, `totalQuantityInStock`) VALUES
(1, 'Hobbit', 9, 2, '2023-05-10', 9, 'Wspaniała przygoda', 2, 2),
(2, 'Zielony Dom', 1, 1, '2003-02-17', 4, NULL, 2, 2),
(4, 'Puchatek', 4, 4, '1945-01-01', 4, 'الجامعة البحرية في غدينيا', 3, 3),
(9, 'Magiczne drzewo', 18, 1, '2003-01-01', 1, NULL, 4, 5),
(10, 'Życie i przygody Remusa', 4, 2, '2021-01-01', 3, 'Epopeja', 3, 3);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `customers`
--

CREATE TABLE `customers` (
  `customerID` int(11) NOT NULL,
  `firstName` varchar(50) NOT NULL,
  `lastName` varchar(50) NOT NULL,
  `phoneNr` varchar(50) NOT NULL,
  `postalCode` varchar(6) NOT NULL,
  `city` varchar(50) NOT NULL,
  `street` varchar(60) NOT NULL,
  `houseNumber` varchar(5) NOT NULL,
  `apartmentNumber` varchar(5) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Zrzut danych tabeli `customers`
--

INSERT INTO `customers` (`customerID`, `firstName`, `lastName`, `phoneNr`, `postalCode`, `city`, `street`, `houseNumber`, `apartmentNumber`, `email`) VALUES
(1, 'Jerzy', 'Waszyngton', '533690219', '43-234', 'Gdansk', 'Listopadowa', '32', '4', 'barbara2@gmail.com'),
(3, 'Maria', 'Zielińska', '432345665', '89-987', 'Kraków', 'Targowa', '12', '', 'maria005@gmail.com'),
(4, 'Andrzej', 'Kmicic', '458789985', '32-897', 'Gdynia', 'Łęgowa', '2', '', 'piotr422@gmail.com'),
(5, 'Jeremi', 'Wiśniowiecki', '433765890', '84-222', 'Gdańsk', 'Listopadowa', '34', '4', 'tomasza522@gmail.com'),
(6, 'Dawid', 'Tylka', '668223456', '84-230', 'Rumia', 'Kosynierów', '3', '21', 'dtylka@polki.pl'),
(8, 'Adam', 'Wąż', '222333444', '87-895', 'Mąciwody', 'Rzeźnicka', '22', '', 'awaz@gamil.com'),
(9, 'Karol', 'Rathenow', '123456789', '32-897', 'Mrzezino', 'Poselska', '22', '4', 'karol@op.pl');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `employees`
--

CREATE TABLE `employees` (
  `employeeID` int(11) NOT NULL,
  `login` varchar(50) NOT NULL,
  `firstName` varchar(50) NOT NULL,
  `lastName` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `jobTitle` int(11) NOT NULL,
  `password` varchar(150) NOT NULL,
  `privilege` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Zrzut danych tabeli `employees`
--

INSERT INTO `employees` (`employeeID`, `login`, `firstName`, `lastName`, `email`, `jobTitle`, `password`, `privilege`) VALUES
(1, 'amares8', 'Amadeusz', 'Reszke', '49344@student.umg.edu.pl', 1, '9EF836C161A1A9F5BCC5746795A058CE976190680E51EEA128558EBE4D66BE36', 3),
(11, 'muhzai8', 'Muhammad', 'Zaindin', 'muhammadzaindin@gmail.com', 8, '5E884898DA28047151D0E56F8DC6292773603D0D6AABBDD62A11EF721D1542D8', 2),
(12, 'patwie8', 'Patrycja', 'Wierkin', 'patwie@gmail.com', 7, '5E884898DA28047151D0E56F8DC6292773603D0D6AABBDD62A11EF721D1542D8', 2);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `jobtitles`
--

CREATE TABLE `jobtitles` (
  `jobTitleID` int(11) NOT NULL,
  `jobTitle` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Zrzut danych tabeli `jobtitles`
--

INSERT INTO `jobtitles` (`jobTitleID`, `jobTitle`) VALUES
(0, 'Intern'),
(1, 'IT'),
(2, 'Accountant'),
(3, 'HR Analyst'),
(4, 'Manager'),
(5, 'Assistant'),
(6, 'Supervisor'),
(7, 'CEO'),
(8, 'Librarian');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `lendings`
--

CREATE TABLE `lendings` (
  `lendingID` int(11) NOT NULL,
  `bookID` int(11) NOT NULL,
  `customerID` int(11) NOT NULL,
  `employeeID` int(11) NOT NULL,
  `lendingDate` date NOT NULL,
  `returnDate` date DEFAULT NULL,
  `finalReturnedDate` date DEFAULT NULL,
  `statusID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Zrzut danych tabeli `lendings`
--

INSERT INTO `lendings` (`lendingID`, `bookID`, `customerID`, `employeeID`, `lendingDate`, `returnDate`, `finalReturnedDate`, `statusID`) VALUES
(54, 2, 4, 1, '2023-05-16', '2023-05-16', '2023-05-16', 2),
(55, 2, 1, 1, '2023-05-16', '2023-05-16', '2023-05-17', 3),
(56, 1, 6, 1, '2023-05-01', '2023-05-03', '2023-05-16', 3),
(57, 1, 5, 1, '2023-05-16', '2023-05-26', '2023-05-17', 2),
(58, 2, 5, 1, '2023-05-17', '2023-05-17', '2023-05-17', 2),
(59, 4, 5, 1, '2023-05-17', '2023-05-21', '2023-05-17', 2),
(60, 2, 4, 1, '2023-05-17', '2023-05-21', '2023-05-17', 2),
(63, 9, 9, 1, '2023-05-18', '2023-05-21', '2023-05-18', 2),
(65, 10, 8, 1, '2023-05-18', '2023-05-18', '2023-05-18', 2),
(66, 9, 8, 1, '2023-05-18', '2023-05-18', '2023-05-18', 2),
(67, 1, 1, 1, '2023-05-18', '2023-05-18', '2023-05-18', 2),
(68, 1, 1, 1, '2023-05-18', '2023-05-18', '2023-05-18', 2),
(71, 9, 5, 1, '2023-05-18', '2023-05-18', '2023-05-18', 2),
(72, 4, 6, 1, '2023-05-18', '2023-05-18', '2023-05-18', 2),
(73, 4, 6, 1, '2023-05-02', '2023-05-10', '2023-05-18', 3),
(74, 1, 8, 1, '2023-05-17', '2023-05-24', '2023-05-18', 2),
(75, 1, 1, 1, '2023-05-18', '2023-05-18', '2023-05-18', 2),
(76, 2, 1, 1, '2023-05-18', '2023-05-18', '2023-05-18', 2),
(77, 9, 6, 1, '2023-05-18', '2023-05-18', NULL, 1);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `lendingstatus`
--

CREATE TABLE `lendingstatus` (
  `statusID` int(11) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Zrzut danych tabeli `lendingstatus`
--

INSERT INTO `lendingstatus` (`statusID`, `name`) VALUES
(0, 'other'),
(1, 'lended'),
(2, 'returned'),
(3, 'returned late');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `publishers`
--

CREATE TABLE `publishers` (
  `publisherID` int(11) NOT NULL,
  `name` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Zrzut danych tabeli `publishers`
--

INSERT INTO `publishers` (`publisherID`, `name`) VALUES
(1, 'Nowa Era'),
(2, 'Skra'),
(3, 'Pallottinum'),
(4, 'Dom');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `bookauthors`
--
ALTER TABLE `bookauthors`
  ADD PRIMARY KEY (`authorID`);

--
-- Indeksy dla tabeli `bookcategories`
--
ALTER TABLE `bookcategories`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`bookID`),
  ADD KEY `bookAuthorID` (`bookAuthorID`,`publisherID`,`bookCategoryID`),
  ADD KEY `publisherID` (`publisherID`),
  ADD KEY `bookCategoryID` (`bookCategoryID`);

--
-- Indeksy dla tabeli `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customerID`);

--
-- Indeksy dla tabeli `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`employeeID`),
  ADD UNIQUE KEY `employeeID_3` (`employeeID`),
  ADD KEY `jobTitle` (`jobTitle`),
  ADD KEY `employeeID` (`employeeID`),
  ADD KEY `employeeID_2` (`employeeID`);

--
-- Indeksy dla tabeli `jobtitles`
--
ALTER TABLE `jobtitles`
  ADD PRIMARY KEY (`jobTitleID`),
  ADD KEY `jobTitleID` (`jobTitleID`);

--
-- Indeksy dla tabeli `lendings`
--
ALTER TABLE `lendings`
  ADD PRIMARY KEY (`lendingID`),
  ADD KEY `productID` (`bookID`,`customerID`,`employeeID`,`statusID`),
  ADD KEY `bookID` (`bookID`),
  ADD KEY `customerID` (`customerID`),
  ADD KEY `statusID` (`statusID`),
  ADD KEY `employeeID` (`employeeID`);

--
-- Indeksy dla tabeli `lendingstatus`
--
ALTER TABLE `lendingstatus`
  ADD PRIMARY KEY (`statusID`);

--
-- Indeksy dla tabeli `publishers`
--
ALTER TABLE `publishers`
  ADD PRIMARY KEY (`publisherID`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `bookauthors`
--
ALTER TABLE `bookauthors`
  MODIFY `authorID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT dla tabeli `bookcategories`
--
ALTER TABLE `bookcategories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT dla tabeli `books`
--
ALTER TABLE `books`
  MODIFY `bookID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT dla tabeli `customers`
--
ALTER TABLE `customers`
  MODIFY `customerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT dla tabeli `employees`
--
ALTER TABLE `employees`
  MODIFY `employeeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT dla tabeli `jobtitles`
--
ALTER TABLE `jobtitles`
  MODIFY `jobTitleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT dla tabeli `lendings`
--
ALTER TABLE `lendings`
  MODIFY `lendingID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=78;

--
-- AUTO_INCREMENT dla tabeli `publishers`
--
ALTER TABLE `publishers`
  MODIFY `publisherID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `books_ibfk_1` FOREIGN KEY (`bookAuthorID`) REFERENCES `bookauthors` (`authorID`),
  ADD CONSTRAINT `books_ibfk_3` FOREIGN KEY (`bookCategoryID`) REFERENCES `bookcategories` (`id`),
  ADD CONSTRAINT `books_ibfk_4` FOREIGN KEY (`publisherID`) REFERENCES `publishers` (`publisherID`);

--
-- Ograniczenia dla tabeli `employees`
--
ALTER TABLE `employees`
  ADD CONSTRAINT `employees_ibfk_1` FOREIGN KEY (`jobTitle`) REFERENCES `jobtitles` (`jobTitleID`);

--
-- Ograniczenia dla tabeli `lendings`
--
ALTER TABLE `lendings`
  ADD CONSTRAINT `lendings_ibfk_3` FOREIGN KEY (`statusID`) REFERENCES `lendingstatus` (`statusID`),
  ADD CONSTRAINT `lendings_ibfk_5` FOREIGN KEY (`customerID`) REFERENCES `customers` (`customerID`),
  ADD CONSTRAINT `lendings_ibfk_6` FOREIGN KEY (`employeeID`) REFERENCES `employees` (`employeeID`),
  ADD CONSTRAINT `lendings_ibfk_7` FOREIGN KEY (`bookID`) REFERENCES `books` (`bookID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
