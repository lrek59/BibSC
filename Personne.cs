//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsBiblio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personne
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personne()
        {
            this.Historique = new HashSet<Historique>();
        }
    
        public long IdPersonne { get; set; }
        public string NomClasse { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public bool Personnel { get; set; }
    
        public virtual Classe Classe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historique> Historique { get; set; }
    }
}
