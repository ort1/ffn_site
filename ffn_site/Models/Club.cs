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
    
    public partial class Club
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Club()
        {
            this.Nageur = new HashSet<Nageur>();
        }
    
        public int id { get; set; }
        public string nomClub { get; set; }
        public string villeSiege { get; set; }
        public string CPSiege { get; set; }
        public string rueSiege { get; set; }
        public string nomDirigeant { get; set; }
        public string prenomDirigeant { get; set; }
        public string telDirigeant { get; set; }
        public string mailDirigeant { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nageur> Nageur { get; set; }
    }
}
