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
    
    public partial class Profil
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profil()
        {
            this.Juge = new HashSet<Juge>();
        }
    
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string mail { get; set; }
        public Nullable<System.DateTime> dateCreation { get; set; }
        public Nullable<System.DateTime> dateConnexion { get; set; }
        public Nullable<bool> estAdmin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Juge> Juge { get; set; }
    }
}
