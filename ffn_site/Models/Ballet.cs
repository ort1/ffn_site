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
    
    public partial class Ballet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ballet()
        {
            this.Evaluation = new HashSet<Evaluation>();
            this.EvaluationCompilee = new HashSet<EvaluationCompilee>();
        }
    
        public int id { get; set; }
        public int id_CategorieBallet { get; set; }
        public int id_Epreuve { get; set; }
    
        public virtual CategorieBallet CategorieBallet { get; set; }
        public virtual Epreuve Epreuve { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluation> Evaluation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvaluationCompilee> EvaluationCompilee { get; set; }
    }
}