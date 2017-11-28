-- Profil
insert into Profil (login, password, mail, dateCreation, estAdmin) values (
  'admin',
  'c7ad44cbad762a5da0a452f9e854fdc1e0e7a52a38015f23f3eab1d80b931dd472634dfac71cd34ebc35d16ab7fb8a90c81f975113d6c7538dc69dd8de9077ec',
  't.moiroud@hotmail.fr',
  GETDATE(),
  1
);

-- CategorieCompetition
insert into CategorieCompetition (lbl) values
	('Avenirs (9-12 ans)'),
	('Jeunes (12-15 ans)'),
	('Juniors (15-18 ans)'),
	('Seniors (19 ans et plus)'),
	('Toutes catégories (15 ans et plus)'),
	('Challenge'),
	('Maitres');

-- CategorieTour
insert into CategorieTour (lbl) values
	('Préliminaires'),
	('Eliminatoires'),
	('1/8 de finale'),
	('1/4 de finale'),
	('1/2 de finale'),
	('Finale');

-- CategorieEpreuve
insert into CategorieEpreuve (lbl) values
	('Solo'),
	('Duo'),
	('Equipe');

-- CategorieEvaluation
insert into CategorieEvaluation (lbl) values
	('Exécution'),
	('Artistique'),
	('Difficulté'),
	('Elément 1'),
	('Elément 2'),
	('Elément 3'),
	('Elément 4'),
	('Elément 5');

-- CategorieBallet
insert into CategorieBallet (lbl) values
	('Technique'),
	('Libre');

-- Club
insert into Club (nomClub, villeSiege, CPSiege, rueSiege, nomDirigeant, prenomDirigeant, telDirigeant, mailDirigeant) values
	('Aix-en-Provence PAN', 'Aix-en-Provence', '13100', '26, av. des Ecoles-Militaires', 'Armingol', 'Jean-Luc', '0603558965', 'jl.armingol@aixprovencepan.fr'),
	('Angers Nat.Synchro', 'Angers', '49000', '31 Boulevard Pierre de Coubertin', 'Biteau', 'Antoine', '0667327208', 'antoine-biteau.bbox.fr'),
	('Dauphins section Paloise', 'Pau', '64000', '96 Avenue Montardon', 'Romero', 'Andre', '0615212889', 'contact@dauphinsectionpaloise.fr'),
	('A A S S section natation Agde', 'Agde', '34300', '4 rue des Ortolans', 'Cantagrill', 'Jean-Louis', '0467000532', 'aass34@orange.fr');

-- Competition
-- insert into Competition () values ();

-- Nageur
-- insert into Nageur () values ();

-- Juge
-- insert into Juge () values ();

-- Coefficient
-- insert into Coefficient () values ();

-- Tour
-- insert into Tour () values ();

-- Epreuve
-- insert into Epreuve () values ();

-- Equipe
-- insert into Equipe () values ();

-- Ballet
-- insert into Ballet () values ();

-- EvaluationCompilee
-- insert into EvaluationCompilee () values ();

-- Evaluation
-- insert into Evaluation () values ();