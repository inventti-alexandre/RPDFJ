//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwfa_pre_facturacion
    {
        public int IdEmpresa { get; set; }
        public decimal IdPreFacturacion { get; set; }
        public int IdPeriodo { get; set; }
        public string Observacion { get; set; }
        public System.DateTime fecha { get; set; }
        public string estado { get; set; }
        public int pe_mes { get; set; }
        public System.DateTime pe_FechaIni { get; set; }
        public System.DateTime pe_FechaFin { get; set; }
        public string IdCentroCosto { get; set; }
        public string nom_Centro_costo { get; set; }
        public bool estado_cierre { get; set; }
        public int TotalEquipos { get; set; }
        public double ValorFacturar { get; set; }
    }
}