//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Reportes
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwINV_Rpt006
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public decimal IdNumMovi { get; set; }
        public string signo { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public string CodMoviInven { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public string pr_codigo { get; set; }
        public double dm_cantidad { get; set; }
        public Nullable<double> dm_peso { get; set; }
        public double dm_stock_actu { get; set; }
        public double dm_stock_ante { get; set; }
        public string IdUsuario { get; set; }
    }
}
