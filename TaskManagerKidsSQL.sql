CREATE DATABASE  IF NOT EXISTS `taskmanagerkids` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `taskmanagerkids`;
-- MariaDB dump 10.19  Distrib 10.4.28-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: taskmanagerkids
-- ------------------------------------------------------
-- Server version	10.4.28-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20230606005253_initMigration','6.0.3'),('20230613023448_updatingDatabaseTables','6.0.3'),('20230619005456_createTableRewards','6.0.16'),('20230619010104_createTableRewards','6.0.16');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kidparent`
--

DROP TABLE IF EXISTS `kidparent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kidparent` (
  `KidsId` int(11) NOT NULL,
  `ParentsId` int(11) NOT NULL,
  PRIMARY KEY (`KidsId`,`ParentsId`),
  KEY `IX_KidParent_ParentsId` (`ParentsId`),
  CONSTRAINT `FK_KidParent_Kids_KidsId` FOREIGN KEY (`KidsId`) REFERENCES `kids` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_KidParent_Parents_ParentsId` FOREIGN KEY (`ParentsId`) REFERENCES `parents` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kidparent`
--

LOCK TABLES `kidparent` WRITE;
/*!40000 ALTER TABLE `kidparent` DISABLE KEYS */;
INSERT INTO `kidparent` VALUES (1,1),(2,2),(3,3),(4,4),(5,5),(6,6),(7,7),(8,8),(9,9),(10,10),(11,11),(12,12),(13,13),(14,14),(15,15);
/*!40000 ALTER TABLE `kidparent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kids`
--

DROP TABLE IF EXISTS `kids`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kids` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `User` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL,
  `Score` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kids`
--

LOCK TABLES `kids` WRITE;
/*!40000 ALTER TABLE `kids` DISABLE KEYS */;
INSERT INTO `kids` VALUES (1,'Gustavo Eduardo','gustavo123','Gust4v0$',0),(2,'Ana Silva','ana13','Ana$123',0),(3,'Pedro Almeida','pedro12','P3dr0$',0),(4,'Lara Santos','lara3','Lara456',0),(5,'Luan Ferreira','luan45','lu4n@',0),(6,'Sophia Lima','sophia14','Soph14!',0),(7,'Lucas Oliveira','lucas10','L123456',0),(8,'Isabella Costa','isabella1','Is@789',0),(9,'Matheus Ribeiro','matheus125','M@theus12',0),(10,'Laura Gomes','laura24','Laura$567',0),(11,'Rafaela Costa','rafaela3','R4f@el4$',0),(12,'Guilherme Lopes','guilherme24','G@123!',0),(13,'Manuela Oliveira','manuela56','Manu567$',0),(14,'Enzo Fernandes','enzo35','3nz0R!',0),(15,'Beatriz Souza','beatriz14','B3@tr1z12',0);
/*!40000 ALTER TABLE `kids` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parents`
--

DROP TABLE IF EXISTS `parents`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `parents` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `User` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parents`
--

LOCK TABLES `parents` WRITE;
/*!40000 ALTER TABLE `parents` DISABLE KEYS */;
INSERT INTO `parents` VALUES (1,'José Eduardo','jose123','J0s3$'),(2,'Maria Silva','maria12','Maria$123'),(3,'Carlos Almeida','carlos23','C@rl0s$'),(4,'Patrícia Santos','patricia1','Patr1c14!'),(5,'Fernando Ferreira','fernando123','F3rn@nd0'),(6,'Amanda Lima','amanda13','Am4nd@'),(7,'Ricardo Oliveira','ricardo22','R1c@rd0!'),(8,'Juliana Costa','juliana123','Juli@n4'),(9,'Roberto Ribeiro','roberto45','R0bert0$'),(10,'Camila Gomes','camila31','C@m1l@'),(11,'Mariana Costa','mariana113','M@r1@n4'),(12,'Paulo Lopes','paulo45','P@ul0123'),(13,'Carolina Oliveira','carolina7','C@rol1n@'),(14,'Fábio Fernandes','fabio8','F@b10R!'),(15,'Juliana Souza','juliana10','Juli@n4$');
/*!40000 ALTER TABLE `parents` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rewards`
--

DROP TABLE IF EXISTS `rewards`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rewards` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(50) NOT NULL,
  `Description` varchar(100) NOT NULL,
  `TaskId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Rewards_TaskId` (`TaskId`),
  CONSTRAINT `FK_Rewards_Tasks_TaskId` FOREIGN KEY (`TaskId`) REFERENCES `tasks` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rewards`
--

LOCK TABLES `rewards` WRITE;
/*!40000 ALTER TABLE `rewards` DISABLE KEYS */;
INSERT INTO `rewards` VALUES (1,'Bônus de Jogos','Ganhe 30 minutos extras de tempo de jogo após concluir sua tarefa.',1),(2,'Passeio ao Parque','Desfrute de um passeio divertido no parque após realizar sua tarefa com sucesso.',2),(3,'Sobremesa Especial','Saboreie sua sobremesa favorita após completar sua tarefa.',3),(4,'Noite de Cinema','Desfrute de uma noite de cinema em família após cumprir sua tarefa.',4),(5,'Brinquedo Novo','Escolha um brinquedo novo como recompensa por concluir sua tarefa.',5),(6,'Picnic no Jardim','Divirta-se com um picnic delicioso no jardim após realizar sua tarefa.',6),(7,'Dia da Piscina','Aproveite um dia refrescante na piscina depois de terminar sua tarefa.',7),(8,'Livro Surpresa','Receba um livro surpresa como recompensa por completar sua tarefa.',8),(9,'Convidar um Amigo','Convide um amigo para brincar em casa depois de realizar sua tarefa.',9),(10,'Dia do Sorvete','Desfrute de um dia especial com sorvete após cumprir sua tarefa.',10),(11,'Aula de Culinária','Aprenda a fazer uma receita divertida em uma aula de culinária após concluir sua tarefa.',11),(12,'Passeio de Bicicleta','Faça um passeio de bicicleta emocionante depois de realizar sua tarefa.',12),(13,'Artesanato Criativo','Crie um artesanato criativo como recompensa por terminar sua tarefa.',13),(14,'Dia do Parque de Diversões','Divirta-se em um parque de diversões após cumprir sua tarefa.',14),(15,'Escolha do Jantar','Escolha o jantar da noite como recompensa por completar sua tarefa.',15);
/*!40000 ALTER TABLE `rewards` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tasks`
--

DROP TABLE IF EXISTS `tasks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tasks` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Category` varchar(50) NOT NULL,
  `Topic` varchar(50) NOT NULL,
  `Title` varchar(50) NOT NULL,
  `Description` varchar(100) NOT NULL,
  `Status` varchar(50) NOT NULL,
  `Importance` varchar(50) NOT NULL,
  `GainScore` int(11) NOT NULL,
  `KidId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Tasks_KidId` (`KidId`),
  CONSTRAINT `FK_Tasks_Kids_KidId` FOREIGN KEY (`KidId`) REFERENCES `kids` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tasks`
--

LOCK TABLES `tasks` WRITE;
/*!40000 ALTER TABLE `tasks` DISABLE KEYS */;
INSERT INTO `tasks` VALUES (1,'Tarefa Doméstica','Limpeza','Retirar o lixo','Favor recolher o lixo antes das 10 horas','Aguardando','Alta',20,1),(2,'Tarefa Escolar','Matemática','Resolver exercícios de álgebra','Resolver as questões 1 a 10 do capítulo de álgebra','Em andamento','Média',2,15),(3,'Tarefa Doméstica','Organização','Arrumar o quarto','Organizar os brinquedos e arrumar a cama','Aguardando','Média',10,3),(4,'Tarefa Escolar','Ciências','Fazer experimento de química','Realizar o experimento do efeito da temperatura na dissolução de um soluto','Concluída','Alta',25,4),(5,'Tarefa Escolar','História','Ler capítulo sobre Revolução Francesa','Ler o capítulo 7 sobre a Revolução Francesa no livro de História','Aguardando','Baixa',5,5),(6,'Tarefa Doméstica','Culinária','Preparar o jantar','Preparar o jantar para a família','Em andamento','Alta',20,6),(7,'Tarefa Escolar','Português','Escrever redação argumentativa','Escrever uma redação de 500 palavras sobre o tema \'Importância da leitura\'','Aguardando','Média',15,7),(8,'Tarefa Doméstica','Compras','Fazer lista de compras','Fazer lista de compras para o supermercado','Concluída','Baixa',5,8),(9,'Tarefa Escolar','Geografia','Estudar países da América do Sul','Estudar os países da América do Sul e suas capitais','Aguardando','Média',10,9),(10,'Tarefa Doméstica','Organização','Arrumar armário de roupas','Arrumar as roupas do armário por tipo e cor','Em andamento','Alta',20,10),(11,'Tarefa Escolar','Inglês','Practice vocabulary','Review and practice vocabulary words for the upcoming test','Em andamento','Média',15,11),(12,'Tarefa Doméstica','Organização','Arrumar a despensa','Organizar os alimentos e limpar a despensa','Aguardando','Média',10,12),(13,'Tarefa Escolar','Ciências','Pesquisar sobre a energia solar','Realizar pesquisa sobre a energia solar e seus benefícios','Em andamento','Alta',20,13),(14,'Tarefa Escolar','Artes','Criar uma pintura','Criar uma pintura usando técnica de aquarela','Em progresso','Alta',25,14),(15,'Tarefa Doméstica','Cozinha','Ajudar a preparar o almoço','Auxiliar na preparação do almoço para a família','Concluída','Baixa',5,15),(16,'Tarefa Escolar','História','Fazer um resumo sobre a Segunda Guerra Mundial','Elaborar um resumo sobre as principais causas, eventos e consequências da Segunda Guerra Mundial','Aguardando','Alta',30,1);
/*!40000 ALTER TABLE `tasks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'taskmanagerkids'
--

--
-- Dumping routines for database 'taskmanagerkids'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-18 22:12:55
