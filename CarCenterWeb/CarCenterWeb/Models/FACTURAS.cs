//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarCenterWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FACTURAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACTURAS()
        {
            this.SERVICIOS = new HashSet<SERVICIOS>();
        }
    
        public decimal NUM_FACTURA { get; set; }
        public System.DateTime FECHA_FACTURA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIOS> SERVICIOS { get; set; }
    }
}
