-- Profil
insert into Profil (login, password, mail, dateCreation, role) values
  ('admin',
  'c7ad44cbad762a5da0a452f9e854fdc1e0e7a52a38015f23f3eab1d80b931dd472634dfac71cd34ebc35d16ab7fb8a90c81f975113d6c7538dc69dd8de9077ec',
  't.moiroud@hotmail.fr', GETDATE(), 'AD'),
  ('jugeArbitre',
  '680e937007b5332405006f2557a86fb0a0a8a3d76c06562a8dc6c5513ac92545cc78c8e025ed8e4ec2786396349f69fe24bdb931aca7d84168c8baea6b4c985a',
  't.moiroud@hotmail.fr', GETDATE(), 'AR'),
  ('juge1',
  'c378ee4afba40e39cc54a01cb857cc1b46921d4ed39a0d41f5ba21d338cf8c6235bbb66857c692390a9ddcc9fd872a091af4f79f08c1dadb385ac92dd6f6eab6',
  't.moiroud@hotmail.fr', GETDATE(), 'JU');

-- Personne
insert into Personne (nom, prenom, dateNaissance, telFixe, telPortable, mail) values 
	('Armingol', 'Jean-Luc', '', '', '0603558965', 'jl.armingol@aixprovencepan.fr'),
	('Biteau', 'Antoine', '', '', '0667327208', 'antoine-biteau.bbox.fr'),
	('Romero', 'Andre', '', '', '0615212889', 'contact@dauphinsectionpaloise.fr'),
	('Cantagrill', 'Jean-Louis', '', '0467000532', '', 'aass34@orange.fr'),
	('D''Arc', 'Jeanne', '03/10/1986', '', '', ''),
	('Moreau', 'Michelle', '12/01/1998', '', '', ''),
	('Moiroud', 'Thibaut', '03/06/1994', '', '0601020304', 't.moiroud@hotmail.fr');

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
insert into Club (nomClub, villeSiege, CPSiege, adresseSiege, id_Dirigeant) values
	('Aix-en-Provence PAN', 'Aix-en-Provence', '13100', '26, av. des Ecoles-Militaires', 1),
	('Angers Nat.Synchro', 'Angers', '49000', '31 Boulevard Pierre de Coubertin', 2),
	('Dauphins section Paloise', 'Pau', '64000', '96 Avenue Montardon', 3),
	('A A S S section natation Agde', 'Agde', '34300', '4 rue des Ortolans', 4);

-- Competition
-- insert into Competition () values ();

-- Nageur
-- insert into Nageur () values ();

-- Juge
insert into Juge (id_Personne, id_Profil) values
	(7, 3),
	(7, 2);

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