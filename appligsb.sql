-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : Dim 03 avr. 2022 à 19:49
-- Version du serveur :  5.7.31
-- Version de PHP : 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gsbap2`
--

-- --------------------------------------------------------

--
-- Structure de la table `directeurregional`
--

DROP TABLE IF EXISTS `directeurregional`;
CREATE TABLE IF NOT EXISTS `directeurregional` (
  `idForceDeVente` int(11) NOT NULL,
  PRIMARY KEY (`idForceDeVente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `directeurregional`
--

INSERT INTO `directeurregional` (`idForceDeVente`) VALUES
(1),
(2),
(3),
(4),
(5),
(6);

-- --------------------------------------------------------

--
-- Structure de la table `evaluation`
--

DROP TABLE IF EXISTS `evaluation`;
CREATE TABLE IF NOT EXISTS `evaluation` (
  `idEval` int(11) NOT NULL AUTO_INCREMENT,
  `idForceDeVente` int(11) NOT NULL,
  `valeur` varchar(255) NOT NULL,
  `Annee` year(4) NOT NULL,
  PRIMARY KEY (`idEval`),
  KEY `fkFdv2Evaluation` (`idForceDeVente`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `evaluation`
--

INSERT INTO `evaluation` (`idEval`, `idForceDeVente`, `valeur`, `Annee`) VALUES
(1, 8, 'Travail bien', 2021),
(2, 20, 'Mauvais', 2021),
(3, 8, 'Toujours au top', 2020),
(4, 20, 'En amélioration', 2022);

-- --------------------------------------------------------

--
-- Structure de la table `forcedevente`
--

DROP TABLE IF EXISTS `forcedevente`;
CREATE TABLE IF NOT EXISTS `forcedevente` (
  `numero` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) NOT NULL,
  `nbEnfantsACharge` int(11) DEFAULT NULL,
  `laSituationFamiliale` varchar(255) DEFAULT NULL,
  `dateNaissance` datetime DEFAULT NULL,
  `dateEmbauche` datetime DEFAULT NULL,
  `idGrade` int(11) DEFAULT NULL,
  `login` varchar(60) NOT NULL,
  `pwd` varchar(60) NOT NULL,
  PRIMARY KEY (`numero`),
  KEY `fkfdv2grade` (`idGrade`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `forcedevente`
--

INSERT INTO `forcedevente` (`numero`, `nom`, `nbEnfantsACharge`, `laSituationFamiliale`, `dateNaissance`, `dateEmbauche`, `idGrade`, `login`, `pwd`) VALUES
(1, 'Directeur1', 1, 'Divorcé', '1965-03-01 00:00:00', '2022-03-02 00:00:00', 2, 'k2000', '6789'),
(2, 'Directeur2', 1, 'Divorcé', '2022-03-01 00:00:00', '2022-03-02 00:00:00', 2, '', ''),
(3, 'Directeur3', 1, 'Divorcé', '1965-06-23 00:00:00', '2022-03-02 00:00:00', 2, '', ''),
(4, 'Directeur4', 2, 'Pacsé', '2002-03-01 00:00:00', '2020-03-02 00:00:00', 2, '', ''),
(5, 'Directeur1', 1, 'Divorcé', '2022-03-01 00:00:00', '2022-03-02 00:00:00', 2, '', ''),
(6, 'Directeur1', 1, 'Divorcé', '2022-03-01 00:00:00', '2022-03-02 00:00:00', 2, '', ''),
(7, 'Titouan', 0, 'Célibataire', '2022-04-01 12:52:29', '2022-04-02 12:52:29', 1, 'tfornite', '1234'),
(8, 'Marc', 1, 'Veuf', '1999-03-01 00:00:00', '2022-03-02 00:00:00', 3, '', ''),
(20, 'Jean-Paul', 8, 'Célibataire', '1956-02-22 00:00:00', '2005-04-01 00:00:00', 3, '', '');

-- --------------------------------------------------------

--
-- Structure de la table `grade`
--

DROP TABLE IF EXISTS `grade`;
CREATE TABLE IF NOT EXISTS `grade` (
  `idGrade` int(11) NOT NULL AUTO_INCREMENT,
  `libelleGrade` varchar(255) NOT NULL,
  PRIMARY KEY (`idGrade`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `grade`
--

INSERT INTO `grade` (`idGrade`, `libelleGrade`) VALUES
(1, 'Ressource humaine'),
(2, 'Directeur regional'),
(3, 'Visiteur');

-- --------------------------------------------------------

--
-- Structure de la table `region`
--

DROP TABLE IF EXISTS `region`;
CREATE TABLE IF NOT EXISTS `region` (
  `idRegion` int(11) NOT NULL AUTO_INCREMENT,
  `nomRegion` varchar(255) NOT NULL,
  `leDirecteurDeRegion` int(11) DEFAULT NULL,
  PRIMARY KEY (`idRegion`),
  KEY `fkFdv2Region` (`leDirecteurDeRegion`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `region`
--

INSERT INTO `region` (`idRegion`, `nomRegion`, `leDirecteurDeRegion`) VALUES
(1, 'Paris-Centre', 1),
(2, 'Sud', 2),
(3, 'Nord', 3),
(4, 'Ouest', 4),
(5, 'Est', 5),
(6, 'Caraïbes-Amériques', 6),
(7, 'DTOM Asie-Afrique', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

DROP TABLE IF EXISTS `secteur`;
CREATE TABLE IF NOT EXISTS `secteur` (
  `idSecteur` int(11) NOT NULL AUTO_INCREMENT,
  `labelleSecteur` varchar(255) NOT NULL,
  `laRegion` int(11) NOT NULL,
  PRIMARY KEY (`idSecteur`),
  KEY `fkSecteur2Region` (`laRegion`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `secteur`
--

INSERT INTO `secteur` (`idSecteur`, `labelleSecteur`, `laRegion`) VALUES
(1, 'A56', 1),
(2, 'A53', 1),
(3, 'A49', 1),
(4, 'B12', 2),
(5, 'B23', 2),
(6, 'L532', 1),
(7, 'L4561', 1);

-- --------------------------------------------------------

--
-- Structure de la table `visiteur`
--

DROP TABLE IF EXISTS `visiteur`;
CREATE TABLE IF NOT EXISTS `visiteur` (
  `idForceDeVente` int(11) NOT NULL,
  `leSecteur` int(11) DEFAULT NULL,
  `leDirecteurRegional` int(11) NOT NULL,
  PRIMARY KEY (`idForceDeVente`),
  KEY `fkDirecteur2Visiteur` (`leDirecteurRegional`),
  KEY `fkSecteur2Visiteur` (`leSecteur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `visiteur`
--

INSERT INTO `visiteur` (`idForceDeVente`, `leSecteur`, `leDirecteurRegional`) VALUES
(8, 3, 1),
(20, 6, 1);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `directeurregional`
--
ALTER TABLE `directeurregional`
  ADD CONSTRAINT `fkFdv2Dr` FOREIGN KEY (`idForceDeVente`) REFERENCES `forcedevente` (`numero`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `evaluation`
--
ALTER TABLE `evaluation`
  ADD CONSTRAINT `fkFdv2Evaluation` FOREIGN KEY (`idForceDeVente`) REFERENCES `forcedevente` (`numero`);

--
-- Contraintes pour la table `forcedevente`
--
ALTER TABLE `forcedevente`
  ADD CONSTRAINT `fkfdv2grade` FOREIGN KEY (`idGrade`) REFERENCES `grade` (`idGrade`);

--
-- Contraintes pour la table `region`
--
ALTER TABLE `region`
  ADD CONSTRAINT `fkFdv2Region` FOREIGN KEY (`leDirecteurDeRegion`) REFERENCES `forcedevente` (`numero`);

--
-- Contraintes pour la table `secteur`
--
ALTER TABLE `secteur`
  ADD CONSTRAINT `fkSecteur2Region` FOREIGN KEY (`laRegion`) REFERENCES `region` (`idRegion`);

--
-- Contraintes pour la table `visiteur`
--
ALTER TABLE `visiteur`
  ADD CONSTRAINT `fkDirecteur2Visiteur` FOREIGN KEY (`leDirecteurRegional`) REFERENCES `directeurregional` (`idForceDeVente`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fkFdv2Visiteur` FOREIGN KEY (`idForceDeVente`) REFERENCES `forcedevente` (`numero`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fkSecteur2Visiteur` FOREIGN KEY (`leSecteur`) REFERENCES `secteur` (`idSecteur`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
