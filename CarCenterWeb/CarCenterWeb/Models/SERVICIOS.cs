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
    
    public partial class SERVICIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICIOS()
        {
            this.SERVICIO_REPUESTO = new HashSet<SERVICIO_REPUESTO>();
        }
    
        public decimal ID_SERVICIO { get; set; }
        public string DESC_SERVICIO { get; set; }
        public string TIPO_SERVICIO { get; set; }
        public decimal TIEMPO_ESTIMADO { get; set; }
        public string ESTADO_SERVICIO { get; set; }
        public decimal VALOR_SERVICIO { get; set; }
        public System.DateTime FECHA_SERVICIO { get; set; }
        public decimal NUM_FACTURA { get; set; }
        public decimal ID_CITA { get; set; }
    
        public virtual CITAS CITAS { get; set; }
        public virtual FACTURAS FACTURAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIO_REPUESTO> SERVICIO_REPUESTO { get; set; }
    }
}
