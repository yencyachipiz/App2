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
    
    public partial class SERVICIO_REPUESTO
    {
        public decimal ID_SERVICIO_REPUESTO { get; set; }
        public decimal CANTIDAD { get; set; }
        public decimal VALOR_REPUESTO { get; set; }
        public decimal ID_SERVICIO { get; set; }
        public decimal ID_REPUESTO { get; set; }
    
        public virtual REPUESTOS REPUESTOS { get; set; }
        public virtual SERVICIOS SERVICIOS { get; set; }
    }
}
