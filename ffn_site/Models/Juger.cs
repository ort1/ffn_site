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
    
    public partial class Juger
    {
        public Nullable<bool> actif { get; set; }
        public int id_Epreuve { get; set; }
        public int id_Juge { get; set; }
    
        public virtual Epreuve Epreuve { get; set; }
        public virtual Juge Juge { get; set; }
    }
}