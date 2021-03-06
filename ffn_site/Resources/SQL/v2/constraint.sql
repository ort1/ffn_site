--------------------------------------------------------------
-- Constraint
--------------------------------------------------------------

ALTER TABLE Club ADD CONSTRAINT FK_Club_id_Personne FOREIGN KEY (id_Dirigeant) REFERENCES Personne(id);
ALTER TABLE Competition ADD CONSTRAINT FK_Competition_id_CategorieCompetition FOREIGN KEY (id_CategorieCompetition) REFERENCES CategorieCompetition(id);
ALTER TABLE Nageur ADD CONSTRAINT FK_Nageur_id_Club FOREIGN KEY (id_Club) REFERENCES Club(id);
ALTER TABLE Nageur ADD CONSTRAINT FK_Nageur_id_Personne FOREIGN KEY (id_Personne) REFERENCES Personne(id);
ALTER TABLE Tour ADD CONSTRAINT FK_Tour_id_Competition FOREIGN KEY (id_Competition) REFERENCES Competition(id);
ALTER TABLE Tour ADD CONSTRAINT FK_Tour_id_CategorieTour FOREIGN KEY (id_CategorieTour) REFERENCES CategorieTour(id);
ALTER TABLE Juge ADD CONSTRAINT FK_Juge_id_Profil FOREIGN KEY (id_Profil) REFERENCES Profil(id);
ALTER TABLE Juge ADD CONSTRAINT FK_Juge_id_Personne FOREIGN KEY (id_Personne) REFERENCES Personne(id);
ALTER TABLE Epreuve ADD CONSTRAINT FK_Epreuve_id_Tour FOREIGN KEY (id_Tour) REFERENCES Tour(id);
ALTER TABLE Epreuve ADD CONSTRAINT FK_Epreuve_id_CategorieEpreuve FOREIGN KEY (id_CategorieEpreuve) REFERENCES CategorieEpreuve(id);
ALTER TABLE Ballet ADD CONSTRAINT FK_Ballet_id_CategorieBallet FOREIGN KEY (id_CategorieBallet) REFERENCES CategorieBallet(id);
ALTER TABLE Ballet ADD CONSTRAINT FK_Ballet_id_Epreuve FOREIGN KEY (id_Epreuve) REFERENCES Epreuve(id);
ALTER TABLE Equipe ADD CONSTRAINT FK_Equipe_id_Club FOREIGN KEY (id_Club) REFERENCES Club(id);
ALTER TABLE Coefficient ADD CONSTRAINT FK_Coefficient_id_CategorieEvaluation FOREIGN KEY (id_CategorieEvaluation) REFERENCES CategorieEvaluation(id);
ALTER TABLE Coefficient ADD CONSTRAINT FK_Coefficient_id_CategorieEpreuve FOREIGN KEY (id_CategorieEpreuve) REFERENCES CategorieEpreuve(id);
ALTER TABLE Coefficient ADD CONSTRAINT FK_Coefficient_id_CategorieBallet FOREIGN KEY (id_CategorieBallet) REFERENCES CategorieBallet(id);
ALTER TABLE EvaluationCompilee ADD CONSTRAINT FK_EvaluationCompilee_id_Ballet FOREIGN KEY (id_Ballet) REFERENCES Ballet(id);
ALTER TABLE EvaluationCompilee ADD CONSTRAINT FK_EvaluationCompilee_id_Juge FOREIGN KEY (id_Juge) REFERENCES Juge(id);
ALTER TABLE EvaluationCompilee ADD CONSTRAINT FK_EvaluationCompilee_id_Equipe FOREIGN KEY (id_Equipe) REFERENCES Equipe(id);
ALTER TABLE Evaluation ADD CONSTRAINT FK_Evaluation_id_CategorieEvaluation FOREIGN KEY (id_CategorieEvaluation) REFERENCES CategorieEvaluation(id);
ALTER TABLE Evaluation ADD CONSTRAINT FK_Evaluation_id_Ballet FOREIGN KEY (id_Ballet) REFERENCES Ballet(id);
ALTER TABLE Evaluation ADD CONSTRAINT FK_Evaluation_id_Juge FOREIGN KEY (id_Juge) REFERENCES Juge(id);
ALTER TABLE Evaluation ADD CONSTRAINT FK_Evaluation_id_Equipe FOREIGN KEY (id_Equipe) REFERENCES Equipe(id);
ALTER TABLE Juger ADD CONSTRAINT FK_Juger_id_Epreuve FOREIGN KEY (id_Epreuve) REFERENCES Epreuve(id);
ALTER TABLE Juger ADD CONSTRAINT FK_Juger_id_Juge FOREIGN KEY (id_Juge) REFERENCES Juge(id);
ALTER TABLE Appartenir ADD CONSTRAINT FK_Appartenir_id_Nageur FOREIGN KEY (id_Nageur) REFERENCES Nageur(id);
ALTER TABLE Appartenir ADD CONSTRAINT FK_Appartenir_id_Equipe FOREIGN KEY (id_Equipe) REFERENCES Equipe(id);
ALTER TABLE Participer ADD CONSTRAINT FK_Participer_id_Equipe FOREIGN KEY (id_Equipe) REFERENCES Equipe(id);
ALTER TABLE Participer ADD CONSTRAINT FK_Participer_id_Epreuve FOREIGN KEY (id_Epreuve) REFERENCES Epreuve(id);