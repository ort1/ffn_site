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
    
    public partial class Epreuve
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Epreuve()
        {
            this.Ballet = new HashSet<Ballet>();
            this.Equipe = new HashSet<Equipe>();
            this.Juge = new HashSet<Juge>();
        }
    
        public int id { get; set; }
        public int id_Tour { get; set; }
        public int id_CategorieEpreuve { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ballet> Ballet { get; set; }
        public virtual CategorieEpreuve CategorieEpreuve { get; set; }
        public virtual Tour Tour { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipe> Equipe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Juge> Juge { get; set; }
    }
}
