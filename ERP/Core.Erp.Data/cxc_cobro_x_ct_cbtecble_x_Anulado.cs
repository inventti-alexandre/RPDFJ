//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class cxc_cobro_x_ct_cbtecble_x_Anulado
    {
        public int cbr_IdEmpresa { get; set; }
        public int cbr_IdSucursal { get; set; }
        public decimal cbr_IdCobro { get; set; }
        public int ct_IdEmpresa { get; set; }
        public int ct_IdTipoCbte { get; set; }
        public decimal ct_IdCbteCble { get; set; }
        public string observacion { get; set; }
    
        public virtual cxc_cobro cxc_cobro { get; set; }
    }
}