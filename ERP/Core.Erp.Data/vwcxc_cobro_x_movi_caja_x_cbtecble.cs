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
    
    public partial class vwcxc_cobro_x_movi_caja_x_cbtecble
    {
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<decimal> IdCobro { get; set; }
        public string IdCobro_tipo { get; set; }
        public Nullable<double> cr_TotalCobro { get; set; }
        public Nullable<System.DateTime> cr_fecha { get; set; }
        public string cr_Banco { get; set; }
        public string cr_cuenta { get; set; }
        public string cr_NumDocumento { get; set; }
        public string tc_TipoCbte { get; set; }
        public decimal Num_CbteCble { get; set; }
        public Nullable<int> IdCaja { get; set; }
        public string ca_Descripcion { get; set; }
        public Nullable<decimal> Movi_Caja { get; set; }
        public string tm_descripcion { get; set; }
    }
}