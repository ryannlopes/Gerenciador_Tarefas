CREATE DATABASE TASKMANAGERKIDS;

USE TASKMANAGERKIDS;

CREATE TABLE KID(
	ID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	NAME VARCHAR(70) NOT NULL,
	USER VARCHAR(100) NOT NULL,
	PASSWORD VARCHAR(50) NOT NULL,
	SCORE INT NOT NULL,
	PROFILE BLOB
);

INSERT INTO KID(NAME, USER, PASSWORD, SCORE)
VALUES ("Gustavo Eduardo", "gustavo123", "Gust4v0$", 0),
       ("Ana Silva", "ana13", "Ana$123", 0),
       ("Pedro Almeida", "pedro12", "P3dr0$", 0),
       ("Lara Santos", "lara3", "Lara456", 0),
       ("Luan Ferreira", "luan45", "lu4n@", 0),
       ("Sophia Lima", "sophia14", "Soph14!", 0),
       ("Lucas Oliveira", "lucas10", "L123456", 0),
       ("Isabella Costa", "isabella1", "Is@789", 0),
       ("Matheus Ribeiro", "matheus125", "M@theus12", 0),
       ("Laura Gomes", "laura24", "Laura$567", 0),
       ("Rafaela Costa", "rafaela3", "R4f@el4$", 0),
       ("Guilherme Lopes", "guilherme24", "G@123!", 0),
       ("Manuela Oliveira", "manuela56", "Manu567$", 0),
       ("Enzo Fernandes", "enzo35", "3nz0R!", 0),
       ("Beatriz Souza", "beatriz14", "B3@tr1z12", 0);



CREATE TABLE PARENT(
	ID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	NAME VARCHAR(70) NOT NULL,
	USER VARCHAR(100) NOT NULL,
	PASSWORD VARCHAR(50) NOT NULL,
	PROFILE BLOB
);

INSERT INTO PARENT(NAME, USER, PASSWORD)
VALUES ("José Eduardo", "jose123", "J0s3$"),
       ("Maria Silva", "maria12", "Maria$123"),
       ("Carlos Almeida", "carlos23", "C@rl0s$"),
       ("Patrícia Santos", "patricia1", "Patr1c14!"),
       ("Fernando Ferreira", "fernando123", "F3rn@nd0"),
       ("Amanda Lima", "amanda13", "Am4nd@"),
       ("Ricardo Oliveira", "ricardo22", "R1c@rd0!"),
       ("Juliana Costa", "juliana123", "Juli@n4"),
       ("Roberto Ribeiro", "roberto45", "R0bert0$"),
       ("Camila Gomes", "camila31", "C@m1l@"),
       ("Mariana Costa", "mariana113", "M@r1@n4"),
       ("Paulo Lopes", "paulo45", "P@ul0123"),
       ("Carolina Oliveira", "carolina7", "C@rol1n@"),
       ("Fábio Fernandes", "fabio8", "F@b10R!"),
       ("Juliana Souza", "juliana10", "Juli@n4$");

CREATE TABLE PARENT_KID(
	ID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	IDKID INT NOT NULL,
	IDPARENT INT NOT NULL,
	FOREIGN KEY (IDKID) REFERENCES KID(ID),
	FOREIGN KEY (IDPARENT) REFERENCES PARENT(ID)
);

INSERT INTO PARENT_KID(KIDSID, PARENTSID) VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10),
(11, 11),
(12, 12),
(13, 13),
(14, 14),
(15, 15);


CREATE TABLE TODO(
  ID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  CATEGORY VARCHAR(50) NOT NULL,
  TOPIC VARCHAR(30) NOT NULL,
  TITLE VARCHAR(50) NOT NULL,
  DESCRIPTION VARCHAR(100) NOT NULL,
  STATUS VARCHAR(30) NOT NULL,
  IMPORTANCE VARCHAR(10) NOT NULL,
  RESPONSIBLEID INT NOT NULL,
  GAINSCORE INT NOT NULL,
  FOREIGN KEY (RESPONSIBLEID) REFERENCES KID(ID)
);
INSERT INTO TODO(CATEGORY, TOPIC, TITLE, DESCRIPTION, STATUS, IMPORTANCE, GAINSCORE, KIDID)
VALUES ("Tarefa Doméstica", "Limpeza", "Retirar o lixo", "Favor recolher o lixo antes das 10 horas", "Aguardando", "Alta", 20, 1),
       ("Tarefa Escolar", "Matemática", "Resolver exercícios de álgebra", "Resolver as questões 1 a 10 do capítulo de álgebra", "Em andamento", "Média", 2, 15), ("Tarefa Doméstica", "Organização", "Arrumar o quarto", "Organizar os brinquedos e arrumar a cama", "Aguardando", "Média", 10, 3),
       ("Tarefa Escolar", "Ciências", "Fazer experimento de química", "Realizar o experimento do efeito da temperatura na dissolução de um soluto", "Concluída", "Alta", 25, 4),
       ("Tarefa Escolar", "História", "Ler capítulo sobre Revolução Francesa", "Ler o capítulo 7 sobre a Revolução Francesa no livro de História", "Aguardando", "Baixa", 5, 5),
       ("Tarefa Doméstica", "Culinária", "Preparar o jantar", "Preparar o jantar para a família", "Em andamento", "Alta", 20, 6),
       ("Tarefa Escolar", "Português", "Escrever redação argumentativa", "Escrever uma redação de 500 palavras sobre o tema 'Importância da leitura'", "Aguardando", "Média", 15, 7),
       ("Tarefa Doméstica", "Compras", "Fazer lista de compras", "Fazer lista de compras para o supermercado", "Concluída", "Baixa", 5, 8),
       ("Tarefa Escolar", "Geografia", "Estudar países da América do Sul", "Estudar os países da América do Sul e suas capitais", "Aguardando", "Média", 10, 9),
       ("Tarefa Doméstica", "Organização", "Arrumar armário de roupas", "Arrumar as roupas do armário por tipo e cor", "Em andamento", "Alta", 20, 10),
       ("Tarefa Escolar", "Inglês", "Practice vocabulary", "Review and practice vocabulary words for the upcoming test", "Em andamento", "Média", 15, 11),
       ("Tarefa Doméstica", "Organização", "Arrumar a despensa", "Organizar os alimentos e limpar a despensa", "Aguardando", "Média", 10, 12),
       ("Tarefa Escolar", "Ciências", "Pesquisar sobre a energia solar", "Realizar pesquisa sobre a energia solar e seus benefícios", "Em andamento", "Alta", 20, 13),
       ("Tarefa Escolar", "Artes", "Criar uma pintura", "Criar uma pintura usando técnica de aquarela", "Em progresso", "Alta", 25, 14),
       ("Tarefa Doméstica", "Cozinha", "Ajudar a preparar o almoço", "Auxiliar na preparação do almoço para a família", "Concluída", "Baixa", 5, 15),
       ("Tarefa Escolar", "História", "Fazer um resumo sobre a Segunda Guerra Mundial", "Elaborar um resumo sobre as principais causas, eventos e consequências da Segunda Guerra Mundial", "Aguardando", "Alta", 30, 1);
