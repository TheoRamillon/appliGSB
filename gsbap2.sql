-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 28 mars 2022 à 13:34
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
  `idDirecteurRegional` int(11) NOT NULL AUTO_INCREMENT,
  `idForceDeVente` int(11) NOT NULL,
  PRIMARY KEY (`idDirecteurRegional`),
  KEY `fkFdv2Dr` (`idForceDeVente`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `directeurregional`
--

INSERT INTO `directeurregional` (`idDirecteurRegional`, `idForceDeVente`) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7);

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
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `forcedevente`
--

DROP TABLE IF EXISTS `forcedevente`;
CREATE TABLE IF NOT EXISTS `forcedevente` (
  `numero` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) NOT NULL,
  `nbEnfantsACharge` int(11) DEFAULT NULL,
  `laSitutationFamilliale` varchar(255) DEFAULT NULL,
  `dateNaissance` datetime DEFAULT NULL,
  `dateEmbauche` datetime DEFAULT NULL,
  `idGrade` int(11) DEFAULT NULL,
  PRIMARY KEY (`numero`),
  KEY `fkfdv2grade` (`idGrade`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `forcedevente`
--

INSERT INTO `forcedevente` (`numero`, `nom`, `nbEnfantsACharge`, `laSitutationFamilliale`, `dateNaissance`, `dateEmbauche`, `idGrade`) VALUES
(1, 'Directeur1', 1, 'Marie', '2022-03-01 09:28:40', '2022-03-02 09:29:27', 2),
(2, 'Directeur2', 1, 'Marie', '2022-03-01 09:28:40', '2022-03-02 09:29:27', 2),
(3, 'Directeur3', 1, 'Marie', '2022-03-01 09:28:40', '2022-03-02 09:29:27', 2),
(4, 'Directeur4', 1, 'Marie', '2022-03-01 09:28:40', '2022-03-02 09:29:27', 2),
(5, 'Directeur5', 1, 'Marie', '2022-03-01 09:28:40', '2022-03-02 09:29:27', 2),
(6, 'Directeur6', 1, 'Marie', '2022-03-01 09:28:40', '2022-03-02 09:29:27', 2),
(7, 'Directeur7', 1, 'Marie', '2022-03-01 09:28:40', '2022-03-02 09:29:27', 2);

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
(7, 'DTOM Asie-Afrique', 7);

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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `secteur`
--

INSERT INTO `secteur` (`idSecteur`, `labelleSecteur`, `laRegion`) VALUES
(1, 'A56', 1),
(2, 'A53', 1),
(3, 'A49', 1),
(4, 'B12', 2),
(5, 'B23', 2);

-- --------------------------------------------------------

--
-- Structure de la table `visiteur`
--

DROP TABLE IF EXISTS `visiteur`;
CREATE TABLE IF NOT EXISTS `visiteur` (
  `idVisiteur` int(11) NOT NULL AUTO_INCREMENT,
  `idForceDeVente` int(11) NOT NULL,
  `leSecteur` int(11) NOT NULL,
  `leDirecteurRegional` int(11) NOT NULL,
  PRIMARY KEY (`idVisiteur`),
  KEY `fkDr2Visiteur` (`leDirecteurRegional`),
  KEY `fkSecteur2Visiteur` (`leSecteur`),
  KEY `fkFdv2Visiteur` (`idForceDeVente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `directeurregional`
--
ALTER TABLE `directeurregional`
  ADD CONSTRAINT `fkFdv2Dr` FOREIGN KEY (`idForceDeVente`) REFERENCES `forcedevente` (`numero`);

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
  ADD CONSTRAINT `fkDr2Visiteur` FOREIGN KEY (`leDirecteurRegional`) REFERENCES `directeurregional` (`idDirecteurRegional`),
  ADD CONSTRAINT `fkFdv2Visiteur` FOREIGN KEY (`idForceDeVente`) REFERENCES `forcedevente` (`numero`),
  ADD CONSTRAINT `fkSecteur2Visiteur` FOREIGN KEY (`leSecteur`) REFERENCES `secteur` (`idSecteur`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
