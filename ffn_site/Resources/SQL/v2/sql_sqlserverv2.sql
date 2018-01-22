--------------------------------------------------------------
--        Script SQLServer.
--------------------------------------------------------------

--------------------------------------------------------------
-- Table: Club
--------------------------------------------------------------

CREATE TABLE Club(
        id           int IDENTITY(1,1)  NOT NULL ,
        nomClub      Varchar (max) ,
        adresseSiege Varchar (max) ,
        cpSiege      Varchar (max) ,
        villeSiege   Varchar (max) ,
        siteWeb      Varchar (max) ,
        idFederal    Varchar (max) ,
        id_Dirigeant Int ,
        PRIMARY KEY (id )
);


--------------------------------------------------------------
-- Table: CategorieCompetition
--------------------------------------------------------------

CREATE TABLE CategorieCompetition(
        id  int IDENTITY(1,1)  NOT NULL ,
        lbl Varchar (max) ,
        PRIMARY KEY (id )
);


--------------------------------------------------------------
-- Table: Competition
--------------------------------------------------------------

CREATE TABLE Competition(
        id                      int IDENTITY(1,1)  NOT NULL ,
        titre                   Varchar (max) ,
        dateDebut               Date ,
        dateFin                 Date ,
        lieuVille               Varchar (max) ,
        lieuCP                  Varchar (max) ,
        id_CategorieCompetition Int ,
        PRIMARY KEY (id )
);


--------------------------------------------------------------
-- Table: Nageur
--------------------------------------------------------------

CREATE TABLE Nageur(
        id          int IDENTITY(1,1)  NOT NULL ,
        id_Club     Int ,
        id_Personne Int ,
        PRIMARY KEY (id )
);


--------------------------------------------------------------
-- Table: Tour
--------------------------------------------------------------

CREATE TABLE Tour(
        id               int IDENTITY(1,1)  NOT NULL ,
        nbEquipe         Int ,
        id_Competition   Int ,
        id_CategorieTour Int ,
        PRIMARY KEY (id )
);


--------------------------------------------------------------
-- Table: Juge
--------------------------------------------------------------

CREATE TABLE Juge(
        id          int IDENTITY(1,1)  NOT NULL ,
        id_Profil   Int ,
        id_Personne Int ,
        PRIMARY KEY (id )
);


--------------------------------------------------------------
-- Table: CategorieBallet
--------------------------------------------------------------

CREATE TABLE CategorieBallet(
        id  int IDENTITY(1,1)  NOT NULL ,
        lbl Varchar (max) ,
        PRIMARY KEY (id )
);


--------------------------------------------------------------
-- Table: CategorieEpreuve
--------------------------------------------------------------

CREATE TABLE CategorieEpreuve(
        id  int IDENTITY(1,1)  NOT NULL ,
        lbl Varchar (max) ,
        PRIMARY KEY (id )
);


--------------------------------------------------------------
-- Table: CategorieEvaluation
--------------------------------------------------------------

CREATE TABLE CategorieEvaluation(
        id  int IDENTITY(1,1)  NOT NULL ,
        lbl Varchar (max) ,
        PRIMARY KEY (id )
);


--------------------------------------------------------------
-- Table: Profil
--------------------------------------------------------------

CREATE TABLE Profil(
        id            int IDENTITY(1,1)  NOT NULL ,
        login         Varchar (max) ,
        password      Varchar (max) ,
        mail          Varchar (max) ,
        dateCreation  DateTime ,
        dateConnexion DateTime ,
        role		  nchar(2) ,
		commentaire   Varchar (250) ,
        PRIMARY KEY (id )
);


--------------------------------------------------------------
-- Table: Epreuve
--------------------------------------------------------------

CREATE TABLE Epreuve(
        id                  int IDENTITY(1,1)  NOT NULL ,
        id_Tour             Int ,
        id_CategorieEpreuve Int ,
        PRIMARY KEY (id )
);


--------------------------------------------------------------
-- Table: Ballet
--------------------------------------------------------------

CREATE TABLE Ballet(
        id                 int IDENTITY(1,1)  NOT NULL ,
        id_CategorieBallet Int ,
        id_Epreuve         Int ,
        PRIMARY KEY (id )
);


--------------------------------------------------------------
-- Table: CategorieTour
--------------------------------------------------------------

CREATE TABLE CategorieTour(
        id  int IDENTITY(1,1)  NOT NULL ,
        lbl Varchar (max) ,
        PRIMARY KEY (id )
);


--------------------------------------------------------------
-- Table: Equipe
--------------------------------------------------------------

CREATE TABLE Equipe(
        id         int IDENTITY(1,1)  NOT NULL ,
        id_Club    Int ,
        PRIMARY KEY (id )
);


--------------------------------------------------------------
-- Table: Personne
--------------------------------------------------------------

CREATE TABLE Personne(
        id            int IDENTITY(1,1)  NOT NULL ,
        nom           Varchar (max) ,
        prenom        Varchar (max) ,
        dateNaissance Date ,
        telFixe       Varchar (max) ,
        telPortable   Varchar (max) ,
        mail          Varchar (max) ,
        PRIMARY KEY (id )
);


--------------------------------------------------------------
-- Table: Coefficient
--------------------------------------------------------------

CREATE TABLE Coefficient(
        coef                   Float ,
        id_CategorieEvaluation Int NOT NULL ,
        id_CategorieEpreuve    Int NOT NULL ,
        id_CategorieBallet     Int NOT NULL ,
        PRIMARY KEY (id_CategorieEvaluation ,id_CategorieEpreuve ,id_CategorieBallet )
);


--------------------------------------------------------------
-- Table: EvaluationCompilee
--------------------------------------------------------------

CREATE TABLE EvaluationCompilee(
        noteCompilee Float ,
        penalite     Float ,
        id_Ballet    Int NOT NULL ,
        id_Juge      Int NOT NULL ,
        id_Equipe    Int NOT NULL ,
        PRIMARY KEY (id_Ballet ,id_Juge ,id_Equipe )
);


--------------------------------------------------------------
-- Table: Evaluation
--------------------------------------------------------------

CREATE TABLE Evaluation(
        note                   Float ,
        id_CategorieEvaluation Int NOT NULL ,
        id_Ballet              Int NOT NULL ,
        id_Juge                Int NOT NULL ,
        id_Equipe              Int NOT NULL ,
        PRIMARY KEY (id_CategorieEvaluation ,id_Ballet ,id_Juge ,id_Equipe )
);


--------------------------------------------------------------
-- Table: Juger
--------------------------------------------------------------

CREATE TABLE Juger(
        actif      BIT ,
        id_Epreuve Int NOT NULL ,
        id_Juge    Int NOT NULL ,
        PRIMARY KEY (id_Epreuve ,id_Juge )
);


--------------------------------------------------------------
-- Table: Appartenir
--------------------------------------------------------------

CREATE TABLE Appartenir(
        statut    Varchar (max) ,
        id_Nageur Int NOT NULL ,
        id_Equipe Int NOT NULL ,
        PRIMARY KEY (id_Nageur ,id_Equipe )
);


--------------------------------------------------------------
-- Table: Participer
--------------------------------------------------------------

CREATE TABLE Participer(
        id_Equipe  Int NOT NULL ,
        id_Epreuve Int NOT NULL ,
		forfait    BIT,
        PRIMARY KEY (id_Equipe ,id_Epreuve )
);
