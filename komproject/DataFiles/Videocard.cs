//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace komproject.DataFiles
{
    using System;
    using System.Collections.Generic;
    
    public partial class Videocard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Videocard()
        {
            this.PC = new HashSet<PC>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Price { get; set; }
        public string VRAM { get; set; }
        public string VRAMType { get; set; }
        public Nullable<int> BusWidth { get; set; }
        public string Recommendedpowersupply { get; set; }
        public string GPUBaseClock { get; set; }
        public string GPUBoostClock { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PC> PC { get; set; }
    }
}
