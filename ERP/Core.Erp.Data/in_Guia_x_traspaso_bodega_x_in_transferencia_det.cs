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
    
    public partial class in_Guia_x_traspaso_bodega_x_in_transferencia_det
    {
        public int IdEmpresa { get; set; }
        public decimal IdGuia { get; set; }
        public int IdEmpresa_tras { get; set; }
        public int IdSucursalOrigen { get; set; }
        public int IdBodegaOrigen { get; set; }
        public decimal IdTransferencia { get; set; }
        public int dt_secuencia { get; set; }
        public decimal cantidad { get; set; }
        public string observacion { get; set; }
    
        public virtual in_transferencia_det in_transferencia_det { get; set; }
        public virtual in_Guia_x_traspaso_bodega in_Guia_x_traspaso_bodega { get; set; }
    }
}