﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ffn_site.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ffn_siteEntities : DbContext
    {
        public ffn_siteEntities()
            : base("name=ffn_siteEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appartenir> Appartenir { get; set; }
        public virtual DbSet<Ballet> Ballet { get; set; }
        public virtual DbSet<CategorieBallet> CategorieBallet { get; set; }
        public virtual DbSet<CategorieCompetition> CategorieCompetition { get; set; }
        public virtual DbSet<CategorieEpreuve> CategorieEpreuve { get; set; }
        public virtual DbSet<CategorieEvaluation> CategorieEvaluation { get; set; }
        public virtual DbSet<CategorieTour> CategorieTour { get; set; }
        public virtual DbSet<Club> Club { get; set; }
        public virtual DbSet<Coefficient> Coefficient { get; set; }
        public virtual DbSet<Competition> Competition { get; set; }
        public virtual DbSet<Epreuve> Epreuve { get; set; }
        public virtual DbSet<Equipe> Equipe { get; set; }
        public virtual DbSet<Evaluation> Evaluation { get; set; }
        public virtual DbSet<EvaluationCompilee> EvaluationCompilee { get; set; }
        public virtual DbSet<Juge> Juge { get; set; }
        public virtual DbSet<Juger> Juger { get; set; }
        public virtual DbSet<Nageur> Nageur { get; set; }
        public virtual DbSet<Personne> Personne { get; set; }
        public virtual DbSet<Profil> Profil { get; set; }
        public virtual DbSet<Tour> Tour { get; set; }
    }
}
