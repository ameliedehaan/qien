//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fonqentity.fonq_database
{
    using System;
    using System.Collections.Generic;
    
    public partial class distributie_product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public distributie_product()
        {
            this.prod_vest_voorraad = new HashSet<prod_vest_voorraad>();
        }
    
        public int product_id { get; set; }
        public string merk { get; set; }
        public string type { get; set; }
        public string aftmetingen { get; set; }
        public int voorraad { get; set; }
        public Nullable<decimal> gewicht { get; set; }
        public string naam { get; set; }
        public string afbeelding { get; set; }
        public Nullable<int> totalLocal { get; set; }
        public Nullable<bool> Show { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prod_vest_voorraad> prod_vest_voorraad { get; set; }
    }
}
