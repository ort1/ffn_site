drop table if exists Evaluation;
drop table if exists EvaluationCompilee;
drop table if exists Ballet;
drop table if exists Equipe;
drop table if exists JugeDEpreuve;
drop table if exists Epreuve;
drop table if exists Tour;
drop table if exists Coefficient;
drop table if exists Juge;
drop table if exists Nageur;
drop table if exists Competition;
drop table if exists Club;
drop table if exists CategorieBallet;
drop table if exists CategorieEvaluation;
drop table if exists CategorieEpreuve;
drop table if exists CategorieTour;
drop table if exists CategorieCompetition;
drop table if exists Profil;


CREATE TABLE Club(
        id              int IDENTITY(1,1) NOT NULL ,
        nomClub         varchar(max) ,
		villeSiege		varchar(max) ,
		CPSiege			varchar(max) ,
		rueSiege		varchar(max) ,
        nomDirigeant    varchar(max) ,
        prenomDirigeant varchar(max) ,
        telDirigeant    varchar(max) ,
        mailDirigeant   varchar(max) ,
        PRIMARY KEY (id )
);

CREATE TABLE CategorieCompetition(
        id  int IDENTITY(1,1) NOT NULL ,
        lbl varchar(max) ,
        PRIMARY KEY (id )
);

CREATE TABLE Competition(
        id                      int IDENTITY(1,1) NOT NULL ,
        titre                   varchar(max) ,
        dateDebut               Date ,
        lieuVille               varchar(max) ,
        lieuCP                  varchar(max) ,
        id_CategorieCompetition Int NOT NULL ,
        PRIMARY KEY (id )
);

CREATE TABLE Nageur(
        id             int IDENTITY(1,1) NOT NULL ,
        nom            varchar(max) ,
        prenom         varchar(max) ,
        anneeNaissance Int ,
        statut         varchar(max) ,
        forfait        varchar(max) ,
        id_Club        Int NOT NULL ,
        PRIMARY KEY (id )
);

CREATE TABLE Tour(
        id               int IDENTITY(1,1) NOT NULL ,
        nbEquipe         Int ,
        id_Competition   Int NOT NULL ,
        id_CategorieTour Int NOT NULL ,
        PRIMARY KEY (id )
);

CREATE TABLE Juge(
        id         int IDENTITY(1,1) NOT NULL ,
        nom        varchar(max) ,
        prenom     varchar(max) ,
        rang       Int ,
        estArbitre BIT ,
        id_Profil    Int NOT NULL ,
        PRIMARY KEY (id )
);

CREATE TABLE CategorieBallet(
        id  int IDENTITY(1,1) NOT NULL ,
        lbl varchar(max) ,
        PRIMARY KEY (id )
);

CREATE TABLE CategorieEpreuve(
        id  int IDENTITY(1,1) NOT NULL ,
        lbl varchar(max) ,
        PRIMARY KEY (id )
);

CREATE TABLE CategorieEvaluation(
        id  int IDENTITY(1,1) NOT NULL ,
        lbl varchar(max) ,
        PRIMARY KEY (id )
);

CREATE TABLE Profil(
        id            int IDENTITY(1,1) NOT NULL ,
        login         varchar(max) ,
        password      varchar(max) ,
        mail          varchar(max) ,
        dateCreation  Date ,
        dateConnexion Date ,
		estAdmin	  BIT ,
        PRIMARY KEY (id )
);

CREATE TABLE Epreuve(
        id                  int IDENTITY(1,1) NOT NULL ,
        id_Tour             Int NOT NULL ,
        id_CategorieEpreuve Int NOT NULL ,
        PRIMARY KEY (id )
);

CREATE TABLE JugeDEpreuve(
        id_Juge    Int NOT NULL ,
        id_Epreuve Int NOT NULL ,
        PRIMARY KEY (id_Juge, id_Epreuve )
);

CREATE TABLE Ballet(
        id                 int IDENTITY(1,1) NOT NULL ,
        id_CategorieBallet Int NOT NULL ,
        id_Epreuve         Int NOT NULL ,
        PRIMARY KEY (id )
);

CREATE TABLE CategorieTour(
        id  int IDENTITY(1,1) NOT NULL ,
        lbl varchar(max) ,
        PRIMARY KEY (id )
);

CREATE TABLE Coefficient(
        coef                   Float ,
        id_CategorieEvaluation Int NOT NULL ,
        id_CategorieEpreuve    Int NOT NULL ,
        id_CategorieBallet     Int NOT NULL ,
        PRIMARY KEY (id_CategorieEvaluation ,id_CategorieEpreuve ,id_CategorieBallet )
);

CREATE TABLE Equipe(
        id         Int NOT NULL ,
        id_Epreuve Int NOT NULL ,
        id_Nageur  Int NOT NULL ,
        PRIMARY KEY (id ,id_Nageur )
);

CREATE TABLE EvaluationCompilee(
        noteCompilee Float ,
        penalite     Float ,
        id_Ballet    Int NOT NULL ,
        id_Juge      Int NOT NULL ,
        PRIMARY KEY (id_Ballet ,id_Juge )
);

CREATE TABLE Evaluation(
        note                   Float ,
        id_CategorieEvaluation Int NOT NULL ,
        id_Ballet              Int NOT NULL ,
        id_Juge                Int NOT NULL ,
        PRIMARY KEY (id_CategorieEvaluation ,id_Ballet ,id_Juge )
);
