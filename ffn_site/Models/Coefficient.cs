//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Coefficient
    {
        public Nullable<double> coef { get; set; }
        public int id_CategorieEvaluation { get; set; }
        public int id_CategorieEpreuve { get; set; }
        public int id_CategorieBallet { get; set; }
    
        public virtual CategorieBallet CategorieBallet { get; set; }
        public virtual CategorieEpreuve CategorieEpreuve { get; set; }
        public virtual CategorieEvaluation CategorieEvaluation { get; set; }
    }
}