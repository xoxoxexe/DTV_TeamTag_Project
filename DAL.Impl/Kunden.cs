//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Impl
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kunden
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kunden()
        {
            this.Angebote = new HashSet<Angebote>();
        }
    
        public string Name { get; set; }
        public string Plz { get; set; }
        public string Strasse { get; set; }
        public string HNr { get; set; }
        public string Ort { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public System.Guid ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Angebote> Angebote { get; set; }
    }
}
