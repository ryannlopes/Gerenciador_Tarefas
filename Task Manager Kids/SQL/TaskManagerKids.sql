create database taskmanagerkids;
Use taskmanagerkids;

create table Kid(
  id int NOT NULL auto_increment primary key,
  name varchar(70) NOT NULL,
  user varchar(100) NOT NULL,
  password varchar(50) NOT NULL,
  Score int NOT NULL,
  profile BLOB
);

Insert into Kid(name, user, password, Score)
values ("Gustavo Eduardo", "gustavo123", "Gust4v0$", 0);

Insert into Kid(name, user, password, Score)
values ("Administrator", "admin", "admin", 0);

select user, password from Kid;

create table Parent(
  id int NOT NULL auto_increment primary key,
  name varchar(70) NOT NULL,
  user varchar(100) NOT NULL,
  password varchar(50) NOT NULL,
  profile BLOB
);

Insert into Parent(name, user, password)
values ("José Eduardo", "jose123", "J0s3$");

create table Parent_Kid(
id int NOT NULL auto_increment primary key,
idKid int NOT NULL,
idParent int NOT NULL,
FOREIGN KEY (idKid) REFERENCES Kid(id),
FOREIGN KEY (idParent) REFERENCES Parent(id)
);

Insert into Parent_Kid(idKid, idParent)
values (1, 1);

create table ToDo(
  id int NOT NULL auto_increment primary key,
  Category varchar(50) NOT NULL,
  Topic varchar(30) NOT NULL,
  Title varchar(50) NOT NULL,
  Description varchar(100) NOT NULL,
  Status varchar(30) NOT NULL,
  Importance varchar(10) NOT NULL,
  ResponsibleId int NOT NULL,
  GainScore int NOT NULL,
  FOREIGN KEY (ResponsibleId) REFERENCES Kid(id)
);

Insert into ToDo(Category, Topic, Title, Description, Status, Importance, ResponsibleId, GainScore)
values ("Tarefa Doméstica", "Limpeza", "Retirar o lixo", "Favor recolher o lixo antes das 10 horas", "Aguardando", "Alta", 1, 20);
