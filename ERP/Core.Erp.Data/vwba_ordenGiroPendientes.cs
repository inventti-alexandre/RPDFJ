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
    
    public partial class vwba_ordenGiroPendientes
    {
        public decimal IdProveedor { get; set; }
        public System.DateTime co_fechaOg { get; set; }
        public string co_observacion { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public Nullable<double> valorAPagar { get; set; }
        public double TotalPagado { get; set; }
        public Nullable<double> saldo { get; set; }
        public string Proveedor { get; set; }
        public string NFactura { get; set; }
        public string GiraCheque { get; set; }
        public string CtaProveedor { get; set; }
    }
}