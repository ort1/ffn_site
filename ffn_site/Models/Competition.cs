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
    
    public partial class Competition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Competition()
        {
            this.Tour = new HashSet<Tour>();
        }
    
        public int id { get; set; }
        public string titre { get; set; }
        public Nullable<System.DateTime> dateDebut { get; set; }
        public string lieuVille { get; set; }
        public string lieuCP { get; set; }
        public int id_CategorieCompetition { get; set; }
    
        public virtual CategorieCompetition CategorieCompetition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tour> Tour { get; set; }
    }
}